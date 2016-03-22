using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace Kursach
{
    public partial class Main : Form
    {
        const int BY_BAL = 1;
        const int BY_BAL_AND_SCHOOL = 0;

        private int typeForm = 0;

        private Excel.Application excelApp;
        private Excel.Workbook excelWorkbook;

        private Excel.Sheets excelSheets;
        private Excel.Worksheet excelWorksheet;
        private Excel.Range xlRange;

        private List<Results> userData;
        private List<Results> searchUserData;

        object[,] valueCell;

        public Main()
        {
            InitializeComponent();

            this.excelApp = new Excel.Application();
            this.excelApp.Visible = false;

            this.userData = new List<Results>();
            this.searchUserData = new List<Results>();

            panelSelectByBal.Hide();

        }

        public void runApplication(string pathToExcel)
        {
            try
            {
                this.excelWorkbook = this.excelApp.Workbooks.Open(pathToExcel,
                       0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "",
                       true, false, 0, true, false, false);

                this.initializeWorkSheet();
                List<Results> localUserData = this.readDataFromExcel();
                this.closeExcelApplication();

                this.setDataInDataGridView(localUserData);

            }
            catch (Exception e)
            {
                Logger.log(e.Message, Logger.ERROR);
                MessageBox.Show("Внутрішня помилка програми. Зверніться до системного адміністратора!");

                Application.Exit();
            }
        }

        private void setDataInDataGridView(List<Results> localUserData, int row = 10)
        {
            dataGridView.Rows.Clear();
            int counter = 1;

            for (int i = 0; i < row; i++)
            {
                dataGridView.Rows.Add(counter, localUserData[i].name, localUserData[i].bal, localUserData[i].numberSchool);
                counter++;
            }
        }

        private void closeExcelApplication()
        {
            this.excelWorkbook.Close(0);

            this.excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(this.excelApp);
        }

        private List<Results> readDataFromExcel()
        {
            for (int row = 1; row < this.excelWorksheet.UsedRange.Rows.Count; row++)
            {
                Results results;
                results.bal = 0;
                results.numberSchool = 0;
                results.name = "";

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

        private void initializeWorkSheet()
        {
            this.excelSheets = this.excelWorkbook.Worksheets;
            this.excelWorksheet = this.excelWorkbook.Sheets[1];
            this.xlRange = this.excelWorksheet.UsedRange;
            this.valueCell = (object[,])this.xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);
        }

        private void btnSelectByBal_Click(object sender, EventArgs e)
        {
            this.typeForm = 1;
            panelSelectBySchoolAndBal.Hide();
            panelSelectByBal.Show();

        }

        private void buttonSelectByBalAndSchool_Click(object sender, EventArgs e)
        {
            this.typeForm = 0;
            panelSelectBySchoolAndBal.Show();
            panelSelectByBal.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: save results (this.searchUserData) to word file
            // add check if zero records in list
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.searchUserData.Clear();

            for (int i = 1; i < 10; i++)
            {
                if (this.typeForm == BY_BAL)
                {
                    int bal = Convert.ToInt32(tbBal2.Text.ToString());
                    if (userData[i].bal >= bal)
                    {
                        this.searchUserData.Add(userData[i]);
                    }
                }
                if (this.typeForm == BY_BAL_AND_SCHOOL)
                {
                    int bal = Convert.ToInt32(tbBal1.Text.ToString());
                    int numberSchool = Convert.ToInt32(tbNumberSchool.Text.ToString());

                    if ((userData[i].bal >= bal) && (userData[i].numberSchool == numberSchool))
                    {
                        this.searchUserData.Add(userData[i]);
                    }
                }
            }

            if (this.searchUserData.Count == 0)
            {
                MessageBox.Show("Записів за таким запитом не знайдено");
            }
            else
            {
                this.setDataInDataGridView(this.searchUserData, this.searchUserData.Count);
            }

        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            this.searchUserData.Clear();
            this.setDataInDataGridView(this.userData);
        }
    }

    struct Results
    {
        public string name;
        public int bal;
        public int numberSchool;
    };

}
