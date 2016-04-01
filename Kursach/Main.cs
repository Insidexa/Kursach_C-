using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using MetroFramework.Forms;
using System.Drawing;

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

            dataGridView.DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.Font = new Font("Tahoma", 12);
          
            this.FormClosing += CloseProcess.FormClose;

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
            if ((data == null) || (data == ""))
            {
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
#if DEBUG
                MessageBox.Show(e.Message);
#endif
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

        private void btnSelectByBalAndSchool_Click(object sender, EventArgs e)
        {
            this.typeForm = 0;
            panelSelectBySchoolAndBal.Show();
            panelSelectByBal.Hide();
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            this.searchUserData.Clear();
            this.setDataInDataGridView(this.userData);

            tbBal1.Clear();
            tbBal2.Clear();
            tbNumberSchool.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.searchUserData.Clear();

            int i = 0;
            bool search = true;

            while ((i < this.userData.Count) && search)
            {
                switch (this.typeForm)
                {
                    case BY_BAL:
                        if (this.IsNullOrWhiteSpace(tbBal2.Text))
                        {
                            search = false;
                            MessageBox.Show("Введіть значення умови");
                        }
                        else if (userData[i].bal >= Convert.ToInt32(tbBal2.Text))
                            this.searchUserData.Add(userData[i]);
                        break;
                    case BY_BAL_AND_SCHOOL:
                        if ((this.IsNullOrWhiteSpace(tbBal1.Text)) || (this.IsNullOrWhiteSpace(tbNumberSchool.Text)))
                        {
                            search = false;
                            MessageBox.Show("Введіть значення умови");
                        }
                        else
                        {
                            if ((userData[i].bal >= Convert.ToInt32(tbBal1.Text))
                                && (userData[i].numberSchool == Convert.ToInt32(tbNumberSchool.Text)))
                                this.searchUserData.Add(userData[i]);

                        }
                        break;
                }
                i++;
            }

            if (search)
            {
                if (this.searchUserData.Count == 0)
                    MessageBox.Show("Записів за таким запитом не знайдено");
                else
                    this.setDataInDataGridView(this.searchUserData, this.searchUserData.Count);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.searchUserData.Count >= 1)
            {
                string FileName = "результати.docx";

                SaveFileDialog sf = new SaveFileDialog();
                sf.FileName = FileName;

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    Message msg = this.wordApp.saveToFile(sf.FileName, this.searchUserData);

                    if (msg.code)
                    {
                        MessageBox.Show(msg.userMessage);
                    }
                    else
                    {
                        MessageBox.Show(msg.userMessage);
                        Logger.log(msg.logMessage, Logger.ERROR);

                        CloseProcess.FormClose(sender);
                    }

                }
                else
                {
                    MessageBox.Show("Ви відмінили збереження файлу");
                }
            }
            else
            {
                MessageBox.Show("Даних немає");
            }
        }

    }

}