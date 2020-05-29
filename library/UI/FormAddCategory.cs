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
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
        {
            InitializeComponent();
        }

        CategoryModel cat = new CategoryModel();
        categoryDAL catD = new categoryDAL();
        

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            cat.name = textBoxCategoryName.Text;
            bool isSuccess = catD.Insert(cat);

            if (isSuccess)
            {
                MessageBox.Show("Category Added Successfully");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Couldnt add category");
            }
        }
    }
}
