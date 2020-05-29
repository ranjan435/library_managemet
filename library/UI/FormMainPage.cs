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
    public partial class FormMainPage : Form
    {
        public FormMainPage()
        {
            InitializeComponent();
        }

        BookModel b = new BookModel();
        bookDAL d = new bookDAL();

        private void buttonAdminSection_Click(object sender, EventArgs e)
        {
            FormStaffLogin staff = new FormStaffLogin();
            staff.Show();
        }

        private void textBoxSearchBooks_TextChanged(object sender, EventArgs e)
        {
            string value = textBoxSearchBooks.Text;
            DataTable dt = d.Search(value);
            dataGridViewSearchBookResult.DataSource = dt;
        }

        private void FormMainPage_Activated(object sender, EventArgs e)
        {
            DataTable dt = d.Select();
            dataGridViewSearchBookResult.DataSource = dt;
        }


        private void dataGridViewSearchBookResult_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;

        }

        private void showDetailPage(int RowIndex)
        {
            BookModel tempModel = new BookModel();
            tempModel.book_id = int.Parse(dataGridViewSearchBookResult.Rows[RowIndex].Cells[0].Value.ToString().Trim());
            tempModel.book_name = dataGridViewSearchBookResult.Rows[RowIndex].Cells[1].Value.ToString();
            tempModel.book_image = dataGridViewSearchBookResult.Rows[RowIndex].Cells[2].Value.ToString();
            switch (dataGridViewSearchBookResult.Rows[RowIndex].Cells[3].Value)
            {
                case true:
                    tempModel.availability = 1;
                    break;
                case false:
                    tempModel.availability = 0;
                    break;
            }
            tempModel.author = dataGridViewSearchBookResult.Rows[RowIndex].Cells[4].Value.ToString();
            tempModel.edition = dataGridViewSearchBookResult.Rows[RowIndex].Cells[5].Value.ToString();
            tempModel.price = float.Parse(dataGridViewSearchBookResult.Rows[RowIndex].Cells[6].Value.ToString());
            tempModel.rack_number = dataGridViewSearchBookResult.Rows[RowIndex].Cells[7].Value.ToString();
            tempModel.category_name = dataGridViewSearchBookResult.Rows[RowIndex].Cells[8].Value.ToString();

            FormBookDetail bookdet = new FormBookDetail(tempModel);
            bookdet.Show();
        }

        private void dataGridViewSearchBookResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            showDetailPage(RowIndex);
        }
    }
}
