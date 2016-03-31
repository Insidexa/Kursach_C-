using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Kursach
{
    public partial class Features : MetroForm
    {
        public Features()
        {
            InitializeComponent();
            this.FormClosing += CloseProcess.FormClose;
        }

        private void btnOpenWord_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogExcel = new OpenFileDialog();

            openFileDialogExcel.InitialDirectory = "c:\\";
            openFileDialogExcel.FileName = "*.xlsx";
            openFileDialogExcel.Filter = "Excel file (*.xls;*.xlsx)|";
            openFileDialogExcel.Multiselect = false;
            openFileDialogExcel.FilterIndex = 1;
            openFileDialogExcel.RestoreDirectory = true;
            openFileDialogExcel.Title = "Select Excel file";

            if (openFileDialogExcel.ShowDialog() == DialogResult.OK)
            {
                this.Hide();

                Main mainForm = new Main();

                mainForm.Show();
                mainForm.runApplication(openFileDialogExcel.FileName);
            }
        }
    }
}
