using DGVPrinterHelper;
using library.BLL;
using library.DAL;
using library.UI;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class FormHome : Form
    {
        public FormHome(String username)
        {
            InitializeComponent();
            labelStaffUsername.Text = username;
        }
        System.Data.DataTable bookLoan = new System.Data.DataTable();
       

       

        private void searchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageUser users = new FormManageUser();
            users.Show();
        }

        private void manageBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBook books = new FormBook();
            books.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBookLoan bookLoan = new FormBookLoan();
            bookLoan.Show();
        }

        private void buttonEditBookLoan_Click(object sender, EventArgs e)
        {
            FormManageBookLoan manageBookLoan = new FormManageBookLoan();
            manageBookLoan.Show();
        }

        private void buttonManageBooks_Click(object sender, EventArgs e)
        {
            FormBook books = new FormBook();
            books.Show();
        }

        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            FormManageUser users = new FormManageUser();
            users.Show();
        }

        private void buttonExportToWord_Click(object sender, EventArgs e)
        {
            BookLoanModel bloanM = new BookLoanModel();
            bookloanDAL bloanD = new bookloanDAL();
            
            
            bookLoan  = bloanD.Select();

            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            Document doc = word.Documents.Add();
            Microsoft.Office.Interop.Word.Range rng = doc.Range(0, 0);
            doc.Content.Text = "hello";
            doc.Content.Text = "dude";
            Table wdTable = doc.Tables.Add(rng,bookLoan.Rows.Count+1, bookLoan.Columns.Count);
            wdTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDouble;
            wdTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
            try
            {
                doc = word.ActiveDocument;
                //i is the row index
                for (int i = 0; i < bookLoan.Rows.Count ; i++)
                {
                    for (int j = 0; j < bookLoan.Columns.Count; j++)
                    {
                        if (i == 0)
                        {
                            wdTable.Cell(i + 1, j + 1).Range.InsertAfter(bookLoan.Columns[j].ToString());
                        }
                        
                        {
                            wdTable.Cell(i + 2, j + 1).Range.InsertAfter(bookLoan.Rows[i][j].ToString());

                        }
                    }
                }
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    doc.SaveAs2(saveFileDialog1.FileName);
                    Process.Start("winword.exe", saveFileDialog1.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                word.Quit();
                word = null;
                doc = null;

            }
        }

        private void buttonDVG_Click(object sender, EventArgs e)
        {

           /* DGVPrinter printer = new DGVPrinter();
            printer.Title = "BOOk LOAN RECORD";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Online Library Management";
            printer.FooterSpacing = 15;*/
        }
    }
}
