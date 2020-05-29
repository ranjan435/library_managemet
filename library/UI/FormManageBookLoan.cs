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
    public partial class FormManageBookLoan : Form
    {
        public FormManageBookLoan()
        {
            InitializeComponent();
        }

        BookModel bookM = new BookModel();
        bookDAL bookD = new bookDAL();
        UserModel userM = new UserModel();
        userDAL userD = new userDAL();
        BookLoanModel bookLoanM = new BookLoanModel();
        bookloanDAL bookloanD = new bookloanDAL();

        public void refreshData()
        {
            DataTable dt = bookloanD.Select();
            dataGridViewManageBookLoanDatabase.DataSource = dt;            
        }

        public void Clear()
        {
            textBoxManageBookLoanID.Text = "";
            textBoxManageBookLoanBookID.Text = "";
            textBoxManageBookLoanUserID.Text = "";
            textBoxManageBookLoanName.Text = "";
            textBoxManageBookLoanToUsername.Text = "";

        }

        private void FormManageBookLoan_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void dataGridViewManageBookLoanDatabase_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            textBoxManageBookLoanID.Text = (dataGridViewManageBookLoanDatabase.Rows[RowIndex].Cells[0].Value.ToString());
            textBoxManageBookLoanBookID.Text = (dataGridViewManageBookLoanDatabase.Rows[RowIndex].Cells[1].Value.ToString());
            textBoxManageBookLoanUserID.Text = (dataGridViewManageBookLoanDatabase.Rows[RowIndex].Cells[2].Value.ToString());
            textBoxManageBookLoanName.Text = dataGridViewManageBookLoanDatabase.Rows[RowIndex].Cells[5].Value.ToString();
            textBoxManageBookLoanToUsername.Text = dataGridViewManageBookLoanDatabase.Rows[RowIndex].Cells[6].Value.ToString();
            dateTimePickerManageIssuedDate.Value = DateTime.Parse(dataGridViewManageBookLoanDatabase.Rows[RowIndex].Cells[3].Value.ToString());
            dateTimePickerManageReturnDate.Value = DateTime.Parse(dataGridViewManageBookLoanDatabase.Rows[RowIndex].Cells[4].Value.ToString());
            switch (dataGridViewManageBookLoanDatabase.Rows[RowIndex].Cells[7].Value)
            {
                case true:
                    comboBoxManageReturnStatus.SelectedIndex = 0;
                    break;
                case false:
                    comboBoxManageReturnStatus.SelectedIndex = 1;
                    break;
            }
        }

        private void buttonManageClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonManageDelete_Click(object sender, EventArgs e)
        {
            bookLoanM.id = int.Parse(textBoxManageBookLoanID.Text);
            bool DeleteSuccess = bookloanD.Delete(bookLoanM);

            if (DeleteSuccess)
            {
                MessageBox.Show($"Book Loan Record Deleted successfully");

                //refresh datagrid view
                refreshData();
            }
            else
            {
                MessageBox.Show("Cant delete the record");
            }

        }

        private void buttonManageUpdate_Click(object sender, EventArgs e)
        {
            bookLoanM.id = int.Parse(textBoxManageBookLoanID.Text);
            bookLoanM.issued_book_id = int.Parse(textBoxManageBookLoanBookID.Text);
            bookLoanM.issued_book_name = textBoxManageBookLoanName.Text;
            bookLoanM.issued_to_user_id = int.Parse(textBoxManageBookLoanUserID.Text);
            bookLoanM.issued_user_name = textBoxManageBookLoanToUsername.Text;
            bookLoanM.issued_date = dateTimePickerManageIssuedDate.Value;
            bookLoanM.return_date = dateTimePickerManageReturnDate.Value;
            switch (comboBoxManageReturnStatus.Text.Trim())
            {
                case "Yes":
                    bookLoanM.return_status = 1;
                    break;
                case "No":
                    bookLoanM.return_status = 0;
                    break;
            }
            bool isSuccess = bookloanD.Update(bookLoanM);
            if (isSuccess)
            {
                MessageBox.Show("Book Loan Record updated Successfully");
                refreshData();
            }
            else
            {
                MessageBox.Show("Coudnt update the book loan record");
            }
        }

        private void labelSearchDatabase_Click(object sender, EventArgs e)
        {

        }

        private void textBoxManageSearch_TextChanged(object sender, EventArgs e)
        {
            string value = textBoxManageSearch.Text;

            if (value != null)
            {
                DataTable dt = bookloanD.Search(value);
                dataGridViewManageBookLoanDatabase.DataSource = dt;

            }
            else
            {
                refreshData();
            }
        }

        private void buttonPrintBooks_Click(object sender, EventArgs e)
        {
            printDVG.print(dataGridViewManageBookLoanDatabase, "BOOK LOAN RECORD");
        }
    }
}
