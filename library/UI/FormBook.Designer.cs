namespace library.UI
{
    partial class FormBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelManageBook = new System.Windows.Forms.Panel();
            this.labelManageBook = new System.Windows.Forms.Label();
            this.labelBookID = new System.Windows.Forms.Label();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.textBoxSearchBook = new System.Windows.Forms.TextBox();
            this.labelSearchBook = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxBookAvailability = new System.Windows.Forms.ComboBox();
            this.labelBookAvailability = new System.Windows.Forms.Label();
            this.textBoxBookRackNum = new System.Windows.Forms.TextBox();
            this.labelBookRackNum = new System.Windows.Forms.Label();
            this.textBoxBookPrice = new System.Windows.Forms.TextBox();
            this.labelBookPrice = new System.Windows.Forms.Label();
            this.textBoxBookEdition = new System.Windows.Forms.TextBox();
            this.labelBookEdition = new System.Windows.Forms.Label();
            this.textBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.labelBookAuthor = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelBookImage = new System.Windows.Forms.Label();
            this.pictureBoxBookImage = new System.Windows.Forms.PictureBox();
            this.buttonUploadBookImage = new System.Windows.Forms.Button();
            this.labelCategoryTest = new System.Windows.Forms.Label();
            this.comboBoxCategoryTest = new System.Windows.Forms.ComboBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrintBooks = new System.Windows.Forms.Button();
            this.panelManageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelManageBook
            // 
            this.panelManageBook.BackColor = System.Drawing.Color.Blue;
            this.panelManageBook.Controls.Add(this.labelManageBook);
            this.panelManageBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManageBook.Location = new System.Drawing.Point(0, 0);
            this.panelManageBook.Name = "panelManageBook";
            this.panelManageBook.Size = new System.Drawing.Size(1119, 52);
            this.panelManageBook.TabIndex = 1;
            // 
            // labelManageBook
            // 
            this.labelManageBook.AutoSize = true;
            this.labelManageBook.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelManageBook.Location = new System.Drawing.Point(441, 9);
            this.labelManageBook.Name = "labelManageBook";
            this.labelManageBook.Size = new System.Drawing.Size(143, 30);
            this.labelManageBook.TabIndex = 1;
            this.labelManageBook.Text = "ManageBook";
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookID.Location = new System.Drawing.Point(12, 61);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(60, 21);
            this.labelBookID.TabIndex = 61;
            this.labelBookID.Text = "BookID";
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Location = new System.Drawing.Point(170, 61);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.ReadOnly = true;
            this.textBoxBookID.Size = new System.Drawing.Size(263, 20);
            this.textBoxBookID.TabIndex = 60;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(467, 94);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(640, 410);
            this.dataGridViewBooks.TabIndex = 59;
            this.dataGridViewBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBooks_RowHeaderMouseClick);
            // 
            // textBoxSearchBook
            // 
            this.textBoxSearchBook.Location = new System.Drawing.Point(788, 59);
            this.textBoxSearchBook.Name = "textBoxSearchBook";
            this.textBoxSearchBook.Size = new System.Drawing.Size(239, 20);
            this.textBoxSearchBook.TabIndex = 58;
            // 
            // labelSearchBook
            // 
            this.labelSearchBook.AutoSize = true;
            this.labelSearchBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchBook.Location = new System.Drawing.Point(679, 58);
            this.labelSearchBook.Name = "labelSearchBook";
            this.labelSearchBook.Size = new System.Drawing.Size(103, 21);
            this.labelSearchBook.TabIndex = 57;
            this.labelSearchBook.Text = "Search Books";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(829, 517);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(84, 42);
            this.buttonClear.TabIndex = 56;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(718, 517);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(84, 42);
            this.buttonDelete.TabIndex = 55;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Blue;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.Location = new System.Drawing.Point(608, 517);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 42);
            this.buttonUpdate.TabIndex = 54;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(497, 517);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 42);
            this.buttonAdd.TabIndex = 53;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxBookAvailability
            // 
            this.comboBoxBookAvailability.FormattingEnabled = true;
            this.comboBoxBookAvailability.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxBookAvailability.Location = new System.Drawing.Point(170, 363);
            this.comboBoxBookAvailability.Name = "comboBoxBookAvailability";
            this.comboBoxBookAvailability.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBookAvailability.TabIndex = 46;
            // 
            // labelBookAvailability
            // 
            this.labelBookAvailability.AutoSize = true;
            this.labelBookAvailability.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookAvailability.Location = new System.Drawing.Point(12, 363);
            this.labelBookAvailability.Name = "labelBookAvailability";
            this.labelBookAvailability.Size = new System.Drawing.Size(82, 21);
            this.labelBookAvailability.TabIndex = 45;
            this.labelBookAvailability.Text = "Availabitly";
            // 
            // textBoxBookRackNum
            // 
            this.textBoxBookRackNum.Location = new System.Drawing.Point(170, 399);
            this.textBoxBookRackNum.Name = "textBoxBookRackNum";
            this.textBoxBookRackNum.Size = new System.Drawing.Size(263, 20);
            this.textBoxBookRackNum.TabIndex = 44;
            // 
            // labelBookRackNum
            // 
            this.labelBookRackNum.AutoSize = true;
            this.labelBookRackNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookRackNum.Location = new System.Drawing.Point(13, 397);
            this.labelBookRackNum.Name = "labelBookRackNum";
            this.labelBookRackNum.Size = new System.Drawing.Size(105, 21);
            this.labelBookRackNum.TabIndex = 43;
            this.labelBookRackNum.Text = "Rack Number";
            // 
            // textBoxBookPrice
            // 
            this.textBoxBookPrice.Location = new System.Drawing.Point(170, 328);
            this.textBoxBookPrice.Name = "textBoxBookPrice";
            this.textBoxBookPrice.Size = new System.Drawing.Size(263, 20);
            this.textBoxBookPrice.TabIndex = 40;
            // 
            // labelBookPrice
            // 
            this.labelBookPrice.AutoSize = true;
            this.labelBookPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookPrice.Location = new System.Drawing.Point(13, 326);
            this.labelBookPrice.Name = "labelBookPrice";
            this.labelBookPrice.Size = new System.Drawing.Size(44, 21);
            this.labelBookPrice.TabIndex = 39;
            this.labelBookPrice.Text = "Price";
            // 
            // textBoxBookEdition
            // 
            this.textBoxBookEdition.Location = new System.Drawing.Point(170, 290);
            this.textBoxBookEdition.Name = "textBoxBookEdition";
            this.textBoxBookEdition.Size = new System.Drawing.Size(263, 20);
            this.textBoxBookEdition.TabIndex = 38;
            // 
            // labelBookEdition
            // 
            this.labelBookEdition.AutoSize = true;
            this.labelBookEdition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookEdition.Location = new System.Drawing.Point(13, 288);
            this.labelBookEdition.Name = "labelBookEdition";
            this.labelBookEdition.Size = new System.Drawing.Size(58, 21);
            this.labelBookEdition.TabIndex = 37;
            this.labelBookEdition.Text = "Edition";
            // 
            // textBoxBookAuthor
            // 
            this.textBoxBookAuthor.Location = new System.Drawing.Point(170, 253);
            this.textBoxBookAuthor.Name = "textBoxBookAuthor";
            this.textBoxBookAuthor.Size = new System.Drawing.Size(263, 20);
            this.textBoxBookAuthor.TabIndex = 36;
            // 
            // labelBookAuthor
            // 
            this.labelBookAuthor.AutoSize = true;
            this.labelBookAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookAuthor.Location = new System.Drawing.Point(13, 251);
            this.labelBookAuthor.Name = "labelBookAuthor";
            this.labelBookAuthor.Size = new System.Drawing.Size(58, 21);
            this.labelBookAuthor.TabIndex = 35;
            this.labelBookAuthor.Text = "Author";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(170, 216);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(263, 20);
            this.textBoxBookName.TabIndex = 34;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookName.Location = new System.Drawing.Point(13, 214);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(91, 21);
            this.labelBookName.TabIndex = 33;
            this.labelBookName.Text = "Book Name";
            // 
            // labelBookImage
            // 
            this.labelBookImage.AutoSize = true;
            this.labelBookImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookImage.Location = new System.Drawing.Point(13, 94);
            this.labelBookImage.Name = "labelBookImage";
            this.labelBookImage.Size = new System.Drawing.Size(92, 21);
            this.labelBookImage.TabIndex = 62;
            this.labelBookImage.Text = "Book Image";
            // 
            // pictureBoxBookImage
            // 
            this.pictureBoxBookImage.Location = new System.Drawing.Point(170, 87);
            this.pictureBoxBookImage.Name = "pictureBoxBookImage";
            this.pictureBoxBookImage.Size = new System.Drawing.Size(166, 116);
            this.pictureBoxBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBookImage.TabIndex = 63;
            this.pictureBoxBookImage.TabStop = false;
            // 
            // buttonUploadBookImage
            // 
            this.buttonUploadBookImage.BackColor = System.Drawing.Color.Green;
            this.buttonUploadBookImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUploadBookImage.Location = new System.Drawing.Point(349, 130);
            this.buttonUploadBookImage.Name = "buttonUploadBookImage";
            this.buttonUploadBookImage.Size = new System.Drawing.Size(84, 38);
            this.buttonUploadBookImage.TabIndex = 64;
            this.buttonUploadBookImage.Text = "UPLOAD";
            this.buttonUploadBookImage.UseVisualStyleBackColor = false;
            this.buttonUploadBookImage.Click += new System.EventHandler(this.buttonUploadBookImage_Click);
            // 
            // labelCategoryTest
            // 
            this.labelCategoryTest.AutoSize = true;
            this.labelCategoryTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryTest.Location = new System.Drawing.Point(12, 439);
            this.labelCategoryTest.Name = "labelCategoryTest";
            this.labelCategoryTest.Size = new System.Drawing.Size(122, 21);
            this.labelCategoryTest.TabIndex = 66;
            this.labelCategoryTest.Text = "Category_Name";
            // 
            // comboBoxCategoryTest
            // 
            this.comboBoxCategoryTest.FormattingEnabled = true;
            this.comboBoxCategoryTest.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxCategoryTest.Location = new System.Drawing.Point(170, 439);
            this.comboBoxCategoryTest.Name = "comboBoxCategoryTest";
            this.comboBoxCategoryTest.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoryTest.TabIndex = 65;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCategory.Location = new System.Drawing.Point(327, 475);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(97, 48);
            this.buttonAddCategory.TabIndex = 68;
            this.buttonAddCategory.Text = "Add Catgory";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 69;
            this.label1.Text = "Category Not Listed?";
            // 
            // buttonPrintBooks
            // 
            this.buttonPrintBooks.BackColor = System.Drawing.Color.Tomato;
            this.buttonPrintBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPrintBooks.Location = new System.Drawing.Point(943, 517);
            this.buttonPrintBooks.Name = "buttonPrintBooks";
            this.buttonPrintBooks.Size = new System.Drawing.Size(84, 42);
            this.buttonPrintBooks.TabIndex = 70;
            this.buttonPrintBooks.Text = "PRINT";
            this.buttonPrintBooks.UseVisualStyleBackColor = false;
            this.buttonPrintBooks.Click += new System.EventHandler(this.buttonPrintBooks_Click);
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 571);
            this.Controls.Add(this.buttonPrintBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.labelCategoryTest);
            this.Controls.Add(this.comboBoxCategoryTest);
            this.Controls.Add(this.buttonUploadBookImage);
            this.Controls.Add(this.pictureBoxBookImage);
            this.Controls.Add(this.labelBookImage);
            this.Controls.Add(this.labelBookID);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.textBoxSearchBook);
            this.Controls.Add(this.labelSearchBook);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxBookAvailability);
            this.Controls.Add(this.labelBookAvailability);
            this.Controls.Add(this.textBoxBookRackNum);
            this.Controls.Add(this.labelBookRackNum);
            this.Controls.Add(this.textBoxBookPrice);
            this.Controls.Add(this.labelBookPrice);
            this.Controls.Add(this.textBoxBookEdition);
            this.Controls.Add(this.labelBookEdition);
            this.Controls.Add(this.textBoxBookAuthor);
            this.Controls.Add(this.labelBookAuthor);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.panelManageBook);
            this.Name = "FormBook";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FormBook_Activated);
            this.Load += new System.EventHandler(this.FormBook_Load);
            this.panelManageBook.ResumeLayout(false);
            this.panelManageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelManageBook;
        private System.Windows.Forms.Label labelManageBook;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.TextBox textBoxSearchBook;
        private System.Windows.Forms.Label labelSearchBook;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxBookAvailability;
        private System.Windows.Forms.Label labelBookAvailability;
        private System.Windows.Forms.TextBox textBoxBookRackNum;
        private System.Windows.Forms.Label labelBookRackNum;
        private System.Windows.Forms.TextBox textBoxBookPrice;
        private System.Windows.Forms.Label labelBookPrice;
        private System.Windows.Forms.TextBox textBoxBookEdition;
        private System.Windows.Forms.Label labelBookEdition;
        private System.Windows.Forms.TextBox textBoxBookAuthor;
        private System.Windows.Forms.Label labelBookAuthor;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelBookImage;
        private System.Windows.Forms.PictureBox pictureBoxBookImage;
        private System.Windows.Forms.Button buttonUploadBookImage;
        private System.Windows.Forms.Label labelCategoryTest;
        private System.Windows.Forms.ComboBox comboBoxCategoryTest;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrintBooks;
    }
}