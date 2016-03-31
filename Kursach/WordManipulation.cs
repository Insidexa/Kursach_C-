using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Word = Microsoft.Office.Interop.Word;

namespace Kursach
{
    class WordManipulation
    {
        protected Word.ApplicationClass WordApp = null;
        protected Word.Document doc = null;
        protected Word.Table newTable;

        protected int minRows = 1;
        protected int minColumns = 3;

        /// <summary>
        /// Default value
        /// </summary>
        protected object oMissing;

        protected object oEndOfDoc = "\\endofdoc";

        protected void createWordApplication()
        {
            this.oMissing = System.Reflection.Missing.Value;

            try
            {
                this.WordApp = new Word.ApplicationClass();
                this.WordApp.Visible = false;
                this.doc = WordApp.Documents.Add(ref this.oMissing, ref this.oMissing, ref this.oMissing, ref this.oMissing);

                this.initializeTable();

            }
            catch (Exception e)
            {
                Logger.log(e.Message, Logger.ERROR);
            }
        }

        protected void initializeTable()
        {
            Word.Range wrdRng = doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            wrdRng.Font.Size = 16;
            newTable = doc.Tables.Add(wrdRng, this.minRows, this.minColumns, ref oMissing, ref oMissing);
            newTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            newTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            newTable.AllowAutoFit = true;

            newTable.Cell(0, 1).Range.Text = "І.П.Б";
            newTable.Cell(0, 2).Range.Text = "Бал";
            newTable.Cell(0, 3).Range.Text = "№ Школи";
            newTable.Rows.Add();
        }

        public Message saveToFile(string pathToSave, List<UserStruct> data)
        {
            this.createWordApplication();

            Message msg = new Message();
            if (WordApp != null && doc != null)
            {
                UserStruct last = data[data.Count - 1];

                foreach (UserStruct user in data)
                {
                    newTable.Cell(newTable.Rows.Count, 1).Range.Text = user.name;
                    newTable.Cell(newTable.Rows.Count, 2).Range.Text = user.bal.ToString();
                    newTable.Cell(newTable.Rows.Count, 3).Range.Text = user.numberSchool.ToString();

                    if (last != user)
                    {
                        newTable.Rows.Add();
                    }
                }

                doc.SaveAs(@pathToSave, ref oMissing, ref oMissing, ref oMissing,
                                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                msg.userMessage = "Файл збережено!";
                msg.code = true;

                this.closeWordApp();

                return msg;

            }
            else
            {
                msg.userMessage = "Неможливо записати у документ.\nПрограму буде завершено!";
                msg.logMessage = "Cannot write to word file";
                msg.code = false;

                return msg;
            }

        }

        public void closeWordApp()
        {
            doc.Close(0);

            WordApp.Quit();

            if (doc != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(doc);
            if (WordApp != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(WordApp);

            doc = null;
            WordApp = null;
        }
    }
}