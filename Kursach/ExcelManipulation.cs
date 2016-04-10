using System;
using System.Collections.Generic;

using System.Data.OleDb;
using System.Data;
using System.Text;

namespace Kursach
{
    class ExcelManipulation
    {

        private string path;

        private List<UserStruct> userData;

        public ExcelManipulation(string pathToExcel)
        {
            this.path = pathToExcel;
            this.GetConnectionString();
            this.userData = new List<UserStruct>();
        }

        private string GetConnectionString()
        {
            Dictionary<string, string> props = new Dictionary<string, string>();

            if (this.path.EndsWith(".xls"))
            {
                // XLS - Excel 2003 and Older
                props["Provider"] = "Microsoft.Jet.OLEDB.4.0";
                props["Extended Properties"] = "Excel 8.0";
            }
            else if ((this.path.EndsWith(".xlsx")))
            {
                // XLSX - Excel 2007, 2010, 2012, 2013
                props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
                props["Extended Properties"] = "Excel 12.0 XML";
            }

            props["Data Source"] = this.path;

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> prop in props)
            {
                sb.Append(prop.Key);
                sb.Append('=');
                sb.Append(prop.Value);
                sb.Append(';');
            }

            return sb.ToString();
        }

        public DataSet ReadTables()
        {
            DataSet ds = new DataSet();

            string connectionString = GetConnectionString();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                // Get all Sheets in Excel File
                DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                // Loop through all Sheets to get data
                foreach (DataRow dr in dtSheet.Rows)
                {
                    string sheetName = dr["TABLE_NAME"].ToString();

                    if (!sheetName.EndsWith("$"))
                        continue;

                    // Get all rows from the Sheet
                    cmd.CommandText = "SELECT * FROM [" + sheetName + "]";

                    DataTable dt = new DataTable();
                    dt.TableName = sheetName;

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);

                    ds.Tables.Add(dt);
                }

                cmd = null;
                conn.Close();
            }

            return ds;
        }

        public List<UserStruct> readDataFromTable()
        {
            DataSet ds = this.ReadTables();

            foreach (DataRow myRow in ds.Tables[0].Rows)
            {
                UserStruct user = new UserStruct();
                int columnNumber = 1;

                foreach (DataColumn myCol in ds.Tables[0].Columns)
                {

                    if (myRow[myCol] != System.DBNull.Value)
                    {
                        if (columnNumber == 1)
                        {
                            user.name = myRow[myCol].ToString();

                        }
                        if (columnNumber == 2)
                        {
                            user.bal = Convert.ToInt32(myRow[myCol]);
                        }
                        if (columnNumber == 3)
                        {
                            user.numberSchool = Convert.ToInt32(myRow[myCol]);
                        }
                    }

                    columnNumber++;
                }

                this.userData.Add(user);

            }


            return this.userData;
        }

    }
}
