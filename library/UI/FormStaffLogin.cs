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
    public partial class FormStaffLogin : Form
    {
        public FormStaffLogin()
        {
            InitializeComponent();
        }

        LoginModel m = new LoginModel();
        LoginDAL d = new LoginDAL();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m.username = textBoxUsername.Text;
            m.password = textBoxPassword.Text;

            bool isSuccess = d.loginCheck(m);

            if(isSuccess)
            {
                MessageBox.Show("Login Successful");
                FormHome h = new FormHome(m.username);
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login Credentials");
            }
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            FormAddStaff addStaff = new FormAddStaff();
            addStaff.Show();
        }
    }
}
