using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kursach
{
    public partial class Features : Form
    {
        public Features()
        {
            InitializeComponent();
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
