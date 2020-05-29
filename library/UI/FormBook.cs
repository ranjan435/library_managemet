using library.BLL;
using library.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.UI
{
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        BookModel b = new BookModel();
        bookDAL d = new bookDAL();
        CategoryModel catM = new CategoryModel();
        categoryDAL catD = new categoryDAL();

/*        string[] categoryName;
*/
        //global image string variable
        string imageName = "no-image.jpg";

        public void loadDefaultImage()
        {
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);
            string imagepath = path + "\\images\\no-image.jpg";

            pictureBoxBookImage.Image = new Bitmap(imagepath);
        }

        public void refreshData()
        {
            DataTable dt = d.Select();
            dataGridViewBooks.DataSource = dt;
        }

        public void getCategoryName()
        {
            comboBoxCategoryTest.Items.Clear();
            DataTable dt = catD.Select();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //check if mycombobox has already the category name
            
                comboBoxCategoryTest.Items.Add(dt.Rows[i]["Name"]);
               
           
            }

        }

 

        public void Clear()
        {
            textBoxBookName.Text = "";
            textBoxBookID.Text = "";
            textBoxBookAuthor.Text = "";
            textBoxBookEdition.Text = "";
            textBoxBookPrice.Text = "";
            textBoxBookRackNum.Text = "";

            loadDefaultImage();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //step 1
            bool isSuccess = false;
                b.book_name = textBoxBookName.Text;
                b.author = textBoxBookAuthor.Text;
                switch (comboBoxBookAvailability.Text.Trim())
                {
                    case "Yes":
                        b.availability = 1;
                        break;
                    case "No":
                        b.availability = 0;
                        break;
                }
                b.book_image = imageName;
                b.edition = textBoxBookEdition.Text;
               
                
                b.rack_number = textBoxBookRackNum.Text;
                b.category_name = comboBoxCategoryTest.Text;
                try
                {
                    b.price = float.Parse(textBoxBookPrice.Text);
                    isSuccess = d.Insert(b);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} Hint: Price must be in number");
                }
            /*                b.category_id = int.Parse(comboBoxCategoryTest.SelectedValue.ToString().Trim());
            */            //step 2 
            

            //check 
            if (isSuccess)
            {
                MessageBox.Show("New book added successfully");

                //refres the datagridbox 
                refreshData();
                Clear();
            }
            else
            {
                MessageBox.Show("Cant add the new book");
            }
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void dataGridViewBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            textBoxBookID.Text = dataGridViewBooks.Rows[RowIndex].Cells[0].Value.ToString();
            textBoxBookName.Text = dataGridViewBooks.Rows[RowIndex].Cells[1].Value.ToString();
            string tempImage = dataGridViewBooks.Rows[RowIndex].Cells[2].Value.ToString();
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);
            string imagePath = paths + "\\images\\" + tempImage;
            pictureBoxBookImage.Image = new Bitmap(imagePath);
/*            MessageBox.Show(dataGridViewBooks.Rows[RowIndex].Cells[3].Value.GetType().ToString());
*/            switch (dataGridViewBooks.Rows[RowIndex].Cells[3].Value)
            {
                case true:
                    comboBoxBookAvailability.SelectedIndex = 0;
                    break;
                case false:
                    comboBoxBookAvailability.SelectedIndex = 1;
                    break;
            }
            textBoxBookAuthor.Text = dataGridViewBooks.Rows[RowIndex].Cells[4].Value.ToString();
            textBoxBookEdition.Text = dataGridViewBooks.Rows[RowIndex].Cells[5].Value.ToString();
            textBoxBookPrice.Text = dataGridViewBooks.Rows[RowIndex].Cells[6].Value.ToString();
            textBoxBookRackNum.Text = dataGridViewBooks.Rows[RowIndex].Cells[7].Value.ToString();
            comboBoxCategoryTest.Text = dataGridViewBooks.Rows[RowIndex].Cells[8].Value.ToString();
           /* string tempCategory = dataGridViewBooks.Rows[RowIndex].Cells[9].Value.ToString();
            DataTable dt = catD.Search(tempCategory);*/
            //error so  here try adding all the category name in constructor and making a list and adding to combo box list
            /*comboBoxCategoryTest.DisplayMember = dt.Rows[0][1].ToString();
            comboBoxCategoryTest.ValueMember = dt.Rows[0][0].ToString();*/
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            b.book_id = int.Parse(textBoxBookID.Text);
            b.book_name = textBoxBookName.Text;
            b.author = textBoxBookAuthor.Text;
            b.book_image = imageName;
            b.edition = textBoxBookEdition.Text;
            b.price = float.Parse(textBoxBookPrice.Text);
            b.rack_number = textBoxBookRackNum.Text;
            switch (comboBoxBookAvailability.Text.Trim())
            {
                case "Yes":
                    b.availability = 1;
                    break;
                case "No":
                    b.availability = 0;
                    break;
                default:
                    MessageBox.Show("Invalid format");
                    break;
            }

            b.category_name = comboBoxCategoryTest.Text;

            bool isSuccess = d.Update(b);

            if (isSuccess)
            {
                MessageBox.Show("Update Successfull");
                Clear();
                refreshData();
            }
            else
            {
                MessageBox.Show("Couldn\'t update");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //get the userid from text box
            b.book_id = int.Parse(textBoxBookID.Text);

            //boolean for succession of delete
            bool DeleteSuccess = d.Delete(b);

            if (DeleteSuccess)
            {
                MessageBox.Show($"Book deleted successfully");
                Clear();
                //refresh datagrid view
                refreshData();
            }
            else
            {
                MessageBox.Show("Cant delete the book");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonUploadBookImage_Click(object sender, EventArgs e)
        {
            //open the dialog box to select image
            OpenFileDialog open = new OpenFileDialog();

            //filter the file type to allow only image file
            open.Filter = "Image Files Only (*.jpg; *.jpeg; *.png; *.gif| *.jpg; *.jpeg; *.png; *.gif)";

            //check if dialog is shown properly
            if(open.ShowDialog() == DialogResult.OK)
            {
                //check if the file exists or not
                if (open.CheckFileExists)
                {
                    //display the picture in picturebox
                    pictureBoxBookImage.Image = new Bitmap(open.FileName);

                    //get extension of image
                    string ext = Path.GetExtension(open.FileName);

                    string name = Path.GetFileNameWithoutExtension(open.FileName);

                    //generate random but globally uniquer identifier
                    Guid g = new Guid();
                    g = Guid.NewGuid();

                    //rename the global identifier
                    imageName = "Book_" + name + "_" + g + ext;

                    //get the source path (path of image)
                    string sourcePath = open.FileName;

                    //get the destination path
                    string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

                    //path to destination
                    string destinationPath = path + "\\images\\" + imageName;

                    //upload the image to destination folder
                    File.Copy(sourcePath, destinationPath);

                    //display message after the image is uploaded successfully
                    MessageBox.Show("Image uploaded successfully");

                }
            }
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory addCat = new FormAddCategory();
            addCat.Show();
        }

        private void FormBook_Activated(object sender, EventArgs e)
        {
            getCategoryName();
        }

        

        private void buttonPrintBooks_Click(object sender, EventArgs e)
        {
            printDVG.print(dataGridViewBooks,"BOOK RECORD");
            
        }
    }
}
