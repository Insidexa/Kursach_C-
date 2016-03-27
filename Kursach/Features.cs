using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;

namespace Kursach
{
    public partial class Features : MetroForm
    {
        public Features()
        {
            InitializeComponent();

        }

        private void btnOpenWord_Click_1(object sender, EventArgs e)
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
