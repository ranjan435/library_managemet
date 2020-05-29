using library.BLL;
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
    public partial class FormBookDetail : Form
    {
        public FormBookDetail(BookModel m)
        {
            InitializeComponent();
            loadData (m);
        }

        private void loadData(BookModel m)
        {
            string tempImage = m.book_image;
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);
            string imagePath = paths + "\\images\\" + tempImage;
            pictureBoxBookImage.Image = new Bitmap(imagePath);

            labelBookDetailHeader.Text = m.book_name;
            labelBookDetailID.Text = m.book_id.ToString();
            labelBookDetailBookName.Text = m.book_name;
            labelBookDetailCategory.Text = m.category_name;
            labelBookDetailEdition.Text = m.edition;
            labelBookDetailAuthor.Text = m.author;
            labelBookDetailPrice.Text = m.price.ToString();
            labelBookDetailRackNumber.Text = m.rack_number;
            switch (m.availability)
            {
                case 1:
                    labelBookDetailAvailability.Text = "Yes";
                    break;
                case 0:
                    labelBookDetailAvailability.Text = "No";
                    break;
            }
        }

       

    }
}
