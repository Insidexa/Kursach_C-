using System;
using System.Collections.Generic;
using System.Text;

using Excel = Microsoft.Office.Interop.Excel;

namespace Kursach
{
    class ExcelManipulation
    {
        private Excel.Application excelApp;
        private Excel.Workbook excelWorkbook;

        private Excel.Sheets excelSheets;
        private Excel.Worksheet excelWorksheet;
        private Excel.Range xlRange;

        object[,] valueCell;

        private List<UserStruct> userData;

        public ExcelManipulation(string pathToExcel)
        {
            this.excelApp = new Excel.Application();
            this.excelApp.Visible = false;

            this.excelWorkbook = this.excelApp.Workbooks.Open(pathToExcel,
                       0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "",
                       true, false, 0, true, false, false);

            this.excelSheets = this.excelWorkbook.Worksheets;
            this.excelWorksheet = (Excel.Worksheet)this.excelWorkbook.Sheets[1];
            this.xlRange = this.excelWorksheet.UsedRange;
            this.valueCell = (object[,])this.xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            this.userData = new List<UserStruct>();
        }

        public List<UserStruct> readDataFromExcel()
        {
            for (int row = 1; row < this.excelWorksheet.UsedRange.Rows.Count; row++)
            {
                UserStruct results = new UserStruct();

                for (int col = 1; col <= this.excelWorksheet.UsedRange.Columns.Count; col++)
                {
                    if (this.valueCell[row, col] != null)
                    {

                        if (col == 1)
                        {
                            results.name = this.valueCell[row, col].ToString();
                        }

                        if (col == 2)
                        {
                            results.bal = Convert.ToInt32(this.valueCell[row, col].ToString());
                        }

                        if (col == 3)
                        {
                            results.numberSchool = Convert.ToInt32(this.valueCell[row, col].ToString());
                        }

                    }
                }

                this.userData.Add(results);
            }

            return this.userData;
        }

        public void closeExcelApplication()
        {
            this.excelWorkbook.Close(0);

            this.excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(this.excelApp);
        }

    }
}
