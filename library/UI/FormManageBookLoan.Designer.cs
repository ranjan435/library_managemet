namespace library.UI
{
    partial class FormManageBookLoan
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
            this.panelManageBookLoanHeader = new System.Windows.Forms.Panel();
            this.labelManageBookLoanHeader = new System.Windows.Forms.Label();
            this.comboBoxManageReturnStatus = new System.Windows.Forms.ComboBox();
            this.labelReturnStatus = new System.Windows.Forms.Label();
            this.textBoxManageBookLoanUserID = new System.Windows.Forms.TextBox();
            this.labelBookLoanUserID = new System.Windows.Forms.Label();
            this.textBoxManageBookLoanBookID = new System.Windows.Forms.TextBox();
            this.labelBookLoanBookID = new System.Windows.Forms.Label();
            this.dateTimePickerManageReturnDate = new System.Windows.Forms.DateTimePicker();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.dateTimePickerManageIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.labelIssuedDate = new System.Windows.Forms.Label();
            this.textBoxManageBookLoanToUsername = new System.Windows.Forms.TextBox();
            this.labelBookLoanToUsername = new System.Windows.Forms.Label();
            this.textBoxManageBookLoanName = new System.Windows.Forms.TextBox();
            this.labelBookLoanName = new System.Windows.Forms.Label();
            this.textBoxManageBookLoanID = new System.Windows.Forms.TextBox();
            this.labelManageBookLoanID = new System.Windows.Forms.Label();
            this.dataGridViewManageBookLoanDatabase = new System.Windows.Forms.DataGridView();
            this.labelManageBookLoanDatabase = new System.Windows.Forms.Label();
            this.buttonManageClear = new System.Windows.Forms.Button();
            this.buttonManageDelete = new System.Windows.Forms.Button();
            this.buttonManageUpdate = new System.Windows.Forms.Button();
            this.textBoxManageSearch = new System.Windows.Forms.TextBox();
            this.labelSearchDatabase = new System.Windows.Forms.Label();
            this.buttonPrintBooks = new System.Windows.Forms.Button();
            this.panelManageBookLoanHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageBookLoanDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // panelManageBookLoanHeader
            // 
            this.panelManageBookLoanHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelManageBookLoanHeader.Controls.Add(this.labelManageBookLoanHeader);
            this.panelManageBookLoanHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManageBookLoanHeader.Location = new System.Drawing.Point(0, 0);
            this.panelManageBookLoanHeader.Name = "panelManageBookLoanHeader";
            this.panelManageBookLoanHeader.Size = new System.Drawing.Size(1119, 88);
            this.panelManageBookLoanHeader.TabIndex = 1;
            // 
            // labelManageBookLoanHeader
            // 
            this.labelManageBookLoanHeader.AutoSize = true;
            this.labelManageBookLoanHeader.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageBookLoanHeader.Location = new System.Drawing.Point(351, 9);
            this.labelManageBookLoanHeader.Name = "labelManageBookLoanHeader";
            this.labelManageBookLoanHeader.Size = new System.Drawing.Size(462, 65);
            this.labelManageBookLoanHeader.TabIndex = 0;
            this.labelManageBookLoanHeader.Text = "Manage Book Loan";
            // 
            // comboBoxManageReturnStatus
            // 
            this.comboBoxManageReturnStatus.FormattingEnabled = true;
            this.comboBoxManageReturnStatus.Items.AddRange(new object[] {
            "Yes\t",
            "No"});
            this.comboBoxManageReturnStatus.Location = new System.Drawing.Point(145, 377);
            this.comboBoxManageReturnStatus.Name = "comboBoxManageReturnStatus";
            this.comboBoxManageReturnStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxManageReturnStatus.TabIndex = 108;
            // 
            // labelReturnStatus
            // 
            this.labelReturnStatus.AutoSize = true;
            this.labelReturnStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnStatus.Location = new System.Drawing.Point(45, 374);
            this.labelReturnStatus.Name = "labelReturnStatus";
            this.labelReturnStatus.Size = new System.Drawing.Size(103, 21);
            this.labelReturnStatus.TabIndex = 107;
            this.labelReturnStatus.Text = "Return Status";
            // 
            // textBoxManageBookLoanUserID
            // 
            this.textBoxManageBookLoanUserID.Location = new System.Drawing.Point(145, 232);
            this.textBoxManageBookLoanUserID.Name = "textBoxManageBookLoanUserID";
            this.textBoxManageBookLoanUserID.ReadOnly = true;
            this.textBoxManageBookLoanUserID.Size = new System.Drawing.Size(263, 20);
            this.textBoxManageBookLoanUserID.TabIndex = 106;
            // 
            // labelBookLoanUserID
            // 
            this.labelBookLoanUserID.AutoSize = true;
            this.labelBookLoanUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookLoanUserID.Location = new System.Drawing.Point(45, 233);
            this.labelBookLoanUserID.Name = "labelBookLoanUserID";
            this.labelBookLoanUserID.Size = new System.Drawing.Size(61, 21);
            this.labelBookLoanUserID.TabIndex = 105;
            this.labelBookLoanUserID.Text = "User ID";
            // 
            // textBoxManageBookLoanBookID
            // 
            this.textBoxManageBookLoanBookID.Location = new System.Drawing.Point(145, 174);
            this.textBoxManageBookLoanBookID.Name = "textBoxManageBookLoanBookID";
            this.textBoxManageBookLoanBookID.ReadOnly = true;
            this.textBoxManageBookLoanBookID.Size = new System.Drawing.Size(263, 20);
            this.textBoxManageBookLoanBookID.TabIndex = 104;
            // 
            // labelBookLoanBookID
            // 
            this.labelBookLoanBookID.AutoSize = true;
            this.labelBookLoanBookID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookLoanBookID.Location = new System.Drawing.Point(45, 175);
            this.labelBookLoanBookID.Name = "labelBookLoanBookID";
            this.labelBookLoanBookID.Size = new System.Drawing.Size(64, 21);
            this.labelBookLoanBookID.TabIndex = 103;
            this.labelBookLoanBookID.Text = "Book ID";
            // 
            // dateTimePickerManageReturnDate
            // 
            this.dateTimePickerManageReturnDate.Location = new System.Drawing.Point(145, 338);
            this.dateTimePickerManageReturnDate.Name = "dateTimePickerManageReturnDate";
            this.dateTimePickerManageReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerManageReturnDate.TabIndex = 102;
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnDate.Location = new System.Drawing.Point(45, 338);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(93, 21);
            this.labelReturnDate.TabIndex = 101;
            this.labelReturnDate.Text = "Return Date";
            // 
            // dateTimePickerManageIssuedDate
            // 
            this.dateTimePickerManageIssuedDate.Location = new System.Drawing.Point(145, 298);
            this.dateTimePickerManageIssuedDate.Name = "dateTimePickerManageIssuedDate";
            this.dateTimePickerManageIssuedDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerManageIssuedDate.TabIndex = 100;
            // 
            // labelIssuedDate
            // 
            this.labelIssuedDate.AutoSize = true;
            this.labelIssuedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssuedDate.Location = new System.Drawing.Point(45, 298);
            this.labelIssuedDate.Name = "labelIssuedDate";
            this.labelIssuedDate.Size = new System.Drawing.Size(81, 21);
            this.labelIssuedDate.TabIndex = 99;
            this.labelIssuedDate.Text = "Issue Date";
            // 
            // textBoxManageBookLoanToUsername
            // 
            this.textBoxManageBookLoanToUsername.Location = new System.Drawing.Point(145, 264);
            this.textBoxManageBookLoanToUsername.Name = "textBoxManageBookLoanToUsername";
            this.textBoxManageBookLoanToUsername.Size = new System.Drawing.Size(263, 20);
            this.textBoxManageBookLoanToUsername.TabIndex = 98;
            // 
            // labelBookLoanToUsername
            // 
            this.labelBookLoanToUsername.AutoSize = true;
            this.labelBookLoanToUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookLoanToUsername.Location = new System.Drawing.Point(45, 264);
            this.labelBookLoanToUsername.Name = "labelBookLoanToUsername";
            this.labelBookLoanToUsername.Size = new System.Drawing.Size(81, 21);
            this.labelBookLoanToUsername.TabIndex = 97;
            this.labelBookLoanToUsername.Text = "Username";
            // 
            // textBoxManageBookLoanName
            // 
            this.textBoxManageBookLoanName.Location = new System.Drawing.Point(145, 204);
            this.textBoxManageBookLoanName.Name = "textBoxManageBookLoanName";
            this.textBoxManageBookLoanName.Size = new System.Drawing.Size(263, 20);
            this.textBoxManageBookLoanName.TabIndex = 96;
            // 
            // labelBookLoanName
            // 
            this.labelBookLoanName.AutoSize = true;
            this.labelBookLoanName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookLoanName.Location = new System.Drawing.Point(45, 204);
            this.labelBookLoanName.Name = "labelBookLoanName";
            this.labelBookLoanName.Size = new System.Drawing.Size(91, 21);
            this.labelBookLoanName.TabIndex = 95;
            this.labelBookLoanName.Text = "Book Name";
            // 
            // textBoxManageBookLoanID
            // 
            this.textBoxManageBookLoanID.Location = new System.Drawing.Point(145, 148);
            this.textBoxManageBookLoanID.Name = "textBoxManageBookLoanID";
            this.textBoxManageBookLoanID.ReadOnly = true;
            this.textBoxManageBookLoanID.Size = new System.Drawing.Size(263, 20);
            this.textBoxManageBookLoanID.TabIndex = 94;
            // 
            // labelManageBookLoanID
            // 
            this.labelManageBookLoanID.AutoSize = true;
            this.labelManageBookLoanID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageBookLoanID.Location = new System.Drawing.Point(45, 147);
            this.labelManageBookLoanID.Name = "labelManageBookLoanID";
            this.labelManageBookLoanID.Size = new System.Drawing.Size(94, 21);
            this.labelManageBookLoanID.TabIndex = 93;
            this.labelManageBookLoanID.Text = "BookLoanID";
            // 
            // dataGridViewManageBookLoanDatabase
            // 
            this.dataGridViewManageBookLoanDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewManageBookLoanDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageBookLoanDatabase.Location = new System.Drawing.Point(446, 187);
            this.dataGridViewManageBookLoanDatabase.Name = "dataGridViewManageBookLoanDatabase";
            this.dataGridViewManageBookLoanDatabase.Size = new System.Drawing.Size(661, 372);
            this.dataGridViewManageBookLoanDatabase.TabIndex = 110;
            this.dataGridViewManageBookLoanDatabase.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewManageBookLoanDatabase_RowHeaderMouseClick);
            // 
            // labelManageBookLoanDatabase
            // 
            this.labelManageBookLoanDatabase.AutoSize = true;
            this.labelManageBookLoanDatabase.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageBookLoanDatabase.Location = new System.Drawing.Point(643, 106);
            this.labelManageBookLoanDatabase.Name = "labelManageBookLoanDatabase";
            this.labelManageBookLoanDatabase.Size = new System.Drawing.Size(279, 37);
            this.labelManageBookLoanDatabase.TabIndex = 109;
            this.labelManageBookLoanDatabase.Text = "Book Loan Database";
            // 
            // buttonManageClear
            // 
            this.buttonManageClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonManageClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonManageClear.Location = new System.Drawing.Point(304, 424);
            this.buttonManageClear.Name = "buttonManageClear";
            this.buttonManageClear.Size = new System.Drawing.Size(84, 42);
            this.buttonManageClear.TabIndex = 114;
            this.buttonManageClear.Text = "CLEAR";
            this.buttonManageClear.UseVisualStyleBackColor = false;
            this.buttonManageClear.Click += new System.EventHandler(this.buttonManageClear_Click);
            // 
            // buttonManageDelete
            // 
            this.buttonManageDelete.BackColor = System.Drawing.Color.Red;
            this.buttonManageDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonManageDelete.Location = new System.Drawing.Point(182, 424);
            this.buttonManageDelete.Name = "buttonManageDelete";
            this.buttonManageDelete.Size = new System.Drawing.Size(84, 42);
            this.buttonManageDelete.TabIndex = 113;
            this.buttonManageDelete.Text = "DELETE";
            this.buttonManageDelete.UseVisualStyleBackColor = false;
            this.buttonManageDelete.Click += new System.EventHandler(this.buttonManageDelete_Click);
            // 
            // buttonManageUpdate
            // 
            this.buttonManageUpdate.BackColor = System.Drawing.Color.Blue;
            this.buttonManageUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonManageUpdate.Location = new System.Drawing.Point(64, 424);
            this.buttonManageUpdate.Name = "buttonManageUpdate";
            this.buttonManageUpdate.Size = new System.Drawing.Size(84, 42);
            this.buttonManageUpdate.TabIndex = 112;
            this.buttonManageUpdate.Text = "UPDATE";
            this.buttonManageUpdate.UseVisualStyleBackColor = false;
            this.buttonManageUpdate.Click += new System.EventHandler(this.buttonManageUpdate_Click);
            // 
            // textBoxManageSearch
            // 
            this.textBoxManageSearch.Location = new System.Drawing.Point(700, 156);
            this.textBoxManageSearch.Name = "textBoxManageSearch";
            this.textBoxManageSearch.Size = new System.Drawing.Size(263, 20);
            this.textBoxManageSearch.TabIndex = 116;
            this.textBoxManageSearch.TextChanged += new System.EventHandler(this.textBoxManageSearch_TextChanged);
            // 
            // labelSearchDatabase
            // 
            this.labelSearchDatabase.AutoSize = true;
            this.labelSearchDatabase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchDatabase.Location = new System.Drawing.Point(548, 156);
            this.labelSearchDatabase.Name = "labelSearchDatabase";
            this.labelSearchDatabase.Size = new System.Drawing.Size(125, 21);
            this.labelSearchDatabase.TabIndex = 115;
            this.labelSearchDatabase.Text = "Search Database";
            this.labelSearchDatabase.Click += new System.EventHandler(this.labelSearchDatabase_Click);
            // 
            // buttonPrintBooks
            // 
            this.buttonPrintBooks.BackColor = System.Drawing.Color.Tomato;
            this.buttonPrintBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPrintBooks.Location = new System.Drawing.Point(1023, 136);
            this.buttonPrintBooks.Name = "buttonPrintBooks";
            this.buttonPrintBooks.Size = new System.Drawing.Size(84, 42);
            this.buttonPrintBooks.TabIndex = 117;
            this.buttonPrintBooks.Text = "PRINT";
            this.buttonPrintBooks.UseVisualStyleBackColor = false;
            this.buttonPrintBooks.Click += new System.EventHandler(this.buttonPrintBooks_Click);
            // 
            // FormManageBookLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 571);
            this.Controls.Add(this.buttonPrintBooks);
            this.Controls.Add(this.textBoxManageSearch);
            this.Controls.Add(this.labelSearchDatabase);
            this.Controls.Add(this.buttonManageClear);
            this.Controls.Add(this.buttonManageDelete);
            this.Controls.Add(this.buttonManageUpdate);
            this.Controls.Add(this.dataGridViewManageBookLoanDatabase);
            this.Controls.Add(this.labelManageBookLoanDatabase);
            this.Controls.Add(this.comboBoxManageReturnStatus);
            this.Controls.Add(this.labelReturnStatus);
            this.Controls.Add(this.textBoxManageBookLoanUserID);
            this.Controls.Add(this.labelBookLoanUserID);
            this.Controls.Add(this.textBoxManageBookLoanBookID);
            this.Controls.Add(this.labelBookLoanBookID);
            this.Controls.Add(this.dateTimePickerManageReturnDate);
            this.Controls.Add(this.labelReturnDate);
            this.Controls.Add(this.dateTimePickerManageIssuedDate);
            this.Controls.Add(this.labelIssuedDate);
            this.Controls.Add(this.textBoxManageBookLoanToUsername);
            this.Controls.Add(this.labelBookLoanToUsername);
            this.Controls.Add(this.textBoxManageBookLoanName);
            this.Controls.Add(this.labelBookLoanName);
            this.Controls.Add(this.textBoxManageBookLoanID);
            this.Controls.Add(this.labelManageBookLoanID);
            this.Controls.Add(this.panelManageBookLoanHeader);
            this.Name = "FormManageBookLoan";
            this.Text = "FormManageBookLoan";
            this.Load += new System.EventHandler(this.FormManageBookLoan_Load);
            this.panelManageBookLoanHeader.ResumeLayout(false);
            this.panelManageBookLoanHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageBookLoanDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelManageBookLoanHeader;
        private System.Windows.Forms.Label labelManageBookLoanHeader;
        private System.Windows.Forms.ComboBox comboBoxManageReturnStatus;
        private System.Windows.Forms.Label labelReturnStatus;
        private System.Windows.Forms.TextBox textBoxManageBookLoanUserID;
        private System.Windows.Forms.Label labelBookLoanUserID;
        private System.Windows.Forms.TextBox textBoxManageBookLoanBookID;
        private System.Windows.Forms.Label labelBookLoanBookID;
        private System.Windows.Forms.DateTimePicker dateTimePickerManageReturnDate;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerManageIssuedDate;
        private System.Windows.Forms.Label labelIssuedDate;
        private System.Windows.Forms.TextBox textBoxManageBookLoanToUsername;
        private System.Windows.Forms.Label labelBookLoanToUsername;
        private System.Windows.Forms.TextBox textBoxManageBookLoanName;
        private System.Windows.Forms.Label labelBookLoanName;
        private System.Windows.Forms.TextBox textBoxManageBookLoanID;
        private System.Windows.Forms.Label labelManageBookLoanID;
        private System.Windows.Forms.DataGridView dataGridViewManageBookLoanDatabase;
        private System.Windows.Forms.Label labelManageBookLoanDatabase;
        private System.Windows.Forms.Button buttonManageClear;
        private System.Windows.Forms.Button buttonManageDelete;
        private System.Windows.Forms.Button buttonManageUpdate;
        private System.Windows.Forms.TextBox textBoxManageSearch;
        private System.Windows.Forms.Label labelSearchDatabase;
        private System.Windows.Forms.Button buttonPrintBooks;
    }
}