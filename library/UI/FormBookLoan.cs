using library.BLL;
using library.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.UI
{

    public partial class FormBookLoan : Form
    {
        public FormBookLoan()
        {
            InitializeComponent();
        }

        BookModel bookM = new BookModel();
        bookDAL bookD = new bookDAL();
        UserModel userM = new UserModel();
        userDAL userD = new userDAL();
        BookLoanModel bookLoanM = new BookLoanModel();
        bookloanDAL bookloanD = new bookloanDAL();

        int checkbookStatus = 1;
        

       

        public void Clear()
        {
            textBoxBookLoanID.Text = "";
            textBoxBookLoanBookID.Text = "";
            textBoxBookLoanUserID.Text = "";
            textBoxBookLoanName.Text = "";
            textBoxBookLoanToUsername.Text = "";
            dataGridViewBookUserSearchResult.DataSource = null;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            bookLoanM.issued_book_id = int.Parse(textBoxBookLoanBookID.Text);
            bookLoanM.issued_book_name = textBoxBookLoanName.Text;
            bookLoanM.issued_to_user_id = int.Parse(textBoxBookLoanUserID.Text);
            bookLoanM.issued_user_name = textBoxBookLoanToUsername.Text;
            bookLoanM.issued_date = dateTimePickerIssuedDate.Value;
            bookLoanM.return_date = dateTimePickerReturnDate.Value;
            bookLoanM.return_status = 0;
           /* switch (comboBoxReturnStatus.Text.Trim())
            {
                case "Yes":
                    bookLoanM.return_status = 1;
                    break;
                case "No":
                    bookLoanM.return_status = 0;
                    break;
            }*/

            //check if the book is available or not
            if (checkbookStatus == 1)
            {
                isSuccess = bookloanD.Insert(bookLoanM);
            }
            else
            {
                isSuccess = false;
                MessageBox.Show(" Sorry! Can\'t lend that book. It is currently unavailable.");
            }
            
            if (isSuccess)
            {
                MessageBox.Show("Book Issued Successfully");
                Clear();
                
            }
            else
            {
                MessageBox.Show("Coudnt issue the book");
            }
           
        }

        

       

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


       

        private void dataGridViewBookUserSearchResult_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            switch (comboBoxBookUserSearch.Text.Trim())
            {
                case "User":
                    
                    textBoxBookLoanUserID.Text = dataGridViewBookUserSearchResult.Rows[RowIndex].Cells[0].Value.ToString();
                    textBoxBookLoanToUsername.Text = dataGridViewBookUserSearchResult.Rows[RowIndex].Cells[1].Value.ToString();



                    break;
                case "Book":
                    textBoxBookLoanBookID.Text = dataGridViewBookUserSearchResult.Rows[RowIndex].Cells[0].Value.ToString();
                    textBoxBookLoanName.Text = dataGridViewBookUserSearchResult.Rows[RowIndex].Cells[1].Value.ToString();
                    /*            checkbookStatus = int.Parse(dataGridViewSearchResults.Rows[RowIndex].Cells["Availability"].Value.ToString().Trim());
                    */
                    switch (dataGridViewBookUserSearchResult.Rows[RowIndex].Cells["Availability"].Value.ToString())
                    {
                        case "True":
                            checkbookStatus = 1;
                            break;
                        case "False":
                            checkbookStatus = 0;
                            break;
                    }
                    MessageBox.Show(checkbookStatus.ToString());
                    break;
                default:
                    MessageBox.Show("Nothing");
                    break;

            }
        }

        private void textBoxBookUserSearch_TextChanged(object sender, EventArgs e)
        {
            string val = textBoxBookUserSearch.Text;
            switch (comboBoxBookUserSearch.Text.Trim())
            {
                case "User":
                    this.dataGridViewBookUserSearchResult.DataSource = null;
                    DataTable dt = userD.Search(val);
                    dataGridViewBookUserSearchResult.DataSource = dt;

                    break;
                case "Book":
                    this.dataGridViewBookUserSearchResult.DataSource = null;
                    DataTable bt = bookD.Search(val);
                    dataGridViewBookUserSearchResult.DataSource = bt;
                    break;
                default:
                    MessageBox.Show("Please select either book or user to search");
                    break;

            }
        }

        private void comboBoxBookUserSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewBookUserSearchResult.DataSource = null;
        }

        

        private void buttonPrintBooks_Click(object sender, EventArgs e)
        {
            printDVG.print(dataGridViewBookUserSearchResult, "BOOK LOAN RECORD");
        }
    }
}
