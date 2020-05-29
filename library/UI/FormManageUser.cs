using library.BLL;
using library.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.UI
{
    public partial class FormManageUser : Form
    {
        public FormManageUser()
        {
            InitializeComponent();
        }

        //create objects of userModel and userDAL
        UserModel u = new UserModel();
        userDAL dal = new userDAL();
        bookloanDAL bloanD = new bookloanDAL();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //on add get the text input
            u.username = textBoxUsername.Text;
            u.first_name = textBoxFirstName.Text;
            u.last_name = textBoxLastName.Text;
            u.email = textBoxEmail.Text;
            u.address = textBoxAddress.Text;
            u.mobile = textBoxMobile.Text;
            switch (comboBoxGender.SelectedIndex)
            {
                case 0:
                    u.gender = "Male";
                    break;
                case 1:
                    u.gender = "Female";
                    break;
                case 2:
                    u.gender = "Others";
                    break;
            }
            
            u.enrolled_date = dateTimePickerEnrolledDate.Value;
            u.membership_expiry_date = dateTimePickerExpiryDate.Value;
            u.num_books_borrowed = int.Parse(textBoxBooksBorrowed.Text);
            bool success = dal.Insert(u);

            if (success)
            {
                MessageBox.Show("New User Added Successfully");

                //display the user in DataGrid view
                DataTable dt = dal.Select();
                dataGridViewUsers.DataSource = dt;

                //clear the text inputs
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Add New User");
            }
        }

        public void Clear()
        {
            textBoxUserID.Text = "";
            textBoxUsername.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            textBoxMobile.Text = "";
            comboBoxGender.SelectedIndex = 0;
            textBoxBooksBorrowed.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void FormManageUser_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dataGridViewUsers.DataSource = dt;
        }

        private void dataGridViewUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //find the row index of the row clicked on user data grid view
            int RowIndex = e.RowIndex;
            textBoxUserID.Text = dataGridViewUsers.Rows[RowIndex].Cells[0].Value.ToString();
            textBoxUsername.Text = dataGridViewUsers.Rows[RowIndex].Cells[1].Value.ToString();
            textBoxFirstName.Text = dataGridViewUsers.Rows[RowIndex].Cells[2].Value.ToString();
            textBoxLastName.Text = dataGridViewUsers.Rows[RowIndex].Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewUsers.Rows[RowIndex].Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridViewUsers.Rows[RowIndex].Cells[5].Value.ToString();
            textBoxMobile.Text = dataGridViewUsers.Rows[RowIndex].Cells[6].Value.ToString();
            switch (dataGridViewUsers.Rows[RowIndex].Cells[7].Value.ToString().Trim())
            {
                case "Male":
                    comboBoxGender.SelectedIndex = 0;
                    break;
                case "Female":
                    comboBoxGender.SelectedIndex = 1;
                    break;
                case "Other":
                    comboBoxGender.SelectedIndex = 2;
                    break;
            }
            dateTimePickerEnrolledDate.Value = DateTime.Parse(dataGridViewUsers.Rows[RowIndex].Cells[8].Value.ToString());
            dateTimePickerExpiryDate.Value = DateTime.Parse(dataGridViewUsers.Rows[RowIndex].Cells[9].Value.ToString());
            textBoxBooksBorrowed.Text = dataGridViewUsers.Rows[RowIndex].Cells[10].Value.ToString();

            List<BookLoanModel> listBooks = bloanD.Search(int.Parse(textBoxUserID.Text));
            /*            dataGridViewBooksBorrowed.DataSource = dt;
             *            
            */
            /*            MessageBox.Show(listBooks[0].issued_book_name);  
            */
            var columns = from t in listBooks
                          orderby t.return_date
                          select new
                          {
                              BookName = t.issued_book_name,
                              Username = t.issued_user_name,
                              Issue_Date = t.issued_date,
                              Return_Date = t.return_date,
                              Days_left_DAY_HR_MIN_SEC = t.return_date - t.issued_date
                          };
            dataGridViewBooksBorrowed.DataSource = columns.ToList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(textBoxUserID.Text);
            u.username = textBoxUsername.Text;
            u.first_name = textBoxFirstName.Text;
            u.last_name = textBoxLastName.Text;
            u.email = textBoxMobile.Text;
            u.address = textBoxAddress.Text;
            u.mobile = textBoxMobile.Text;
            switch (comboBoxGender.SelectedIndex)
            {
                case 0:
                    u.gender = "Male";
                    break;
                case 1:
                    u.gender = "Female";
                    break;
                case 2:
                    u.gender = "Other";
                    break;
            }

            u.enrolled_date = dateTimePickerEnrolledDate.Value;
            u.membership_expiry_date = dateTimePickerExpiryDate.Value;
            u.num_books_borrowed = int.Parse(textBoxBooksBorrowed.Text);
            bool successUpdated = dal.Update(u);
            if (successUpdated)
            {
                MessageBox.Show($"User {u.username} Updated Successfully");

                //display the user in DataGrid view
                DataTable dt = dal.Select();
                dataGridViewUsers.DataSource = dt;

                //clear the text inputs
                Clear();
            }
            else
            {
                MessageBox.Show($"Failed to Update User {u.username}");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //get the userid from text box
            u.user_id = int.Parse(textBoxUserID.Text);

            //boolean for succession of delete
            bool DeleteSuccess = dal.Delete(u);

            if (DeleteSuccess)
            {
                MessageBox.Show($"User deleted successfully");

                //refresh datagrid view
                DataTable dt = dal.Select();
                dataGridViewUsers.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Cant delete the user");
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //get keyword from the textbox
            String keywords = textBoxSearch.Text;

            if(keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dataGridViewUsers.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dataGridViewUsers.DataSource = dt;
            }
        }









        private void buttonPrintBooks_Click(object sender, EventArgs e)
        {
            printDVG.print(dataGridViewUsers, "USER RECORD");
        }
    }
}
