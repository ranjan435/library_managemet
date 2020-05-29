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
    public partial class FormAddStaff : Form
    {
        public FormAddStaff()
        {
            InitializeComponent();
        }

        StaffModel staff = new StaffModel();
        staffDAL d = new staffDAL();

        private void buttonStaffAdd_Click(object sender, EventArgs e)
        {
            staff.username = textBoxStaffUsername.Text;
            staff.password = textBoxStaffPassword.Text;

            bool isSuccess = d.Insert(staff);

            if (isSuccess)
            {
                MessageBox.Show("Staff Added Successfully");
                this.Hide();
                /*FormStaffLogin st = new FormStaffLogin();
                st.Show();*/
            }
            else
            {
                MessageBox.Show("Unable to add Staff");
            }
        }
    }
}
