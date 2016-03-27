using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using MetroFramework.Forms;

namespace Kursach
{
    public partial class Main : MetroForm
    {
        const int BY_BAL = 1;
        const int BY_BAL_AND_SCHOOL = 0;

        private int typeForm;

        private List<UserStruct> userData;
        private List<UserStruct> searchUserData;

        private ExcelManipulation excelApp;
        private WordManipulation wordApp;

        public Main()
        {
            InitializeComponent();

            this.wordApp = new WordManipulation();

            this.userData = new List<UserStruct>();
            this.searchUserData = new List<UserStruct>();

            this.typeForm = 0;

            panelSelectByBal.Hide();
        }

        /// <summary>
        /// Replace string.IsNullOrWhiteSpace
        /// string.IsNullOrWhiteSpace does not exists in NET Framework < 4
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private bool IsNullOrWhiteSpace(string data)
        {
            if ((data == null) || (data == "")) {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void runApplication(string pathToExcel)
        {
            try
            {
                this.excelApp = new ExcelManipulation(pathToExcel);

                this.userData = this.excelApp.readDataFromExcel();
                this.setDataInDataGridView(this.userData);

                this.excelApp.closeExcelApplication();

            }
            catch (Exception e)
            {
                Logger.log(e.Message, Logger.ERROR);
                MessageBox.Show("Внутрішня помилка програми. Зверніться до системного адміністратора!");

                Application.Exit();
            }
        }

        private void setDataInDataGridView(List<UserStruct> localUserData, int row = 10)
        {
            dataGridView.Rows.Clear();
            int counter = 1;

            for (int i = 0; i < row; i++)
            {
                dataGridView.Rows.Add(counter, localUserData[i].name, localUserData[i].bal, localUserData[i].numberSchool);
                counter++;
            }
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
            this.wordApp.saveToFile("", "");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.searchUserData.Clear();

            for (int i = 0; i < this.userData.Count; i++)
            {
                switch (this.typeForm)
                {
                    case BY_BAL:
                        int bal = Convert.ToInt32(tbBal2.Text);
                        if (this.IsNullOrWhiteSpace(tbBal2.Text)) MessageBox.Show("Введіть значення умови");
                        else if (userData[i].bal >= bal) 
                            this.searchUserData.Add(userData[i]);
                        break;
                    case BY_BAL_AND_SCHOOL:
                        if ((this.IsNullOrWhiteSpace(tbBal1.Text)) || (this.IsNullOrWhiteSpace(tbNumberSchool.Text))) MessageBox.Show("Введіть значення умови");
                        else
                        {
                            int _bal = Convert.ToInt32(tbBal1.Text);
                            int numberSchool = Convert.ToInt32(tbNumberSchool.Text);

                            if ((userData[i].bal >= _bal) && (userData[i].numberSchool == numberSchool))
                                this.searchUserData.Add(userData[i]);
                            
                        }
                        break;
                }
            }

            if (this.searchUserData.Count == 0)            
                MessageBox.Show("Записів за таким запитом не знайдено");            
            else            
                this.setDataInDataGridView(this.searchUserData, this.searchUserData.Count);
            
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            this.searchUserData.Clear();
            this.setDataInDataGridView(this.userData);

            tbBal1.Clear();
            tbBal2.Clear();
            tbNumberSchool.Clear();
        }
    }

}