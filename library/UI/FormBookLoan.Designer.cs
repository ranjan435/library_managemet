namespace library.UI
{
    partial class FormBookLoan
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
            this.panelBookLoanHeader = new System.Windows.Forms.Panel();
            this.labelBookLoanHeader = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBookLoanID = new System.Windows.Forms.Label();
            this.textBoxBookLoanID = new System.Windows.Forms.TextBox();
            this.labelBookLoanName = new System.Windows.Forms.Label();
            this.textBoxBookLoanName = new System.Windows.Forms.TextBox();
            this.textBoxBookLoanToUsername = new System.Windows.Forms.TextBox();
            this.labelBookLoanToUsername = new System.Windows.Forms.Label();
            this.labelIssuedDate = new System.Windows.Forms.Label();
            this.dateTimePickerIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxBookLoanBookID = new System.Windows.Forms.TextBox();
            this.labelBookLoanBookID = new System.Windows.Forms.Label();
            this.textBoxBookLoanUserID = new System.Windows.Forms.TextBox();
            this.labelBookLoanUserID = new System.Windows.Forms.Label();
            this.labelReturnStatus = new System.Windows.Forms.Label();
            this.comboBoxBookUserSearch = new System.Windows.Forms.ComboBox();
            this.dataGridViewBookUserSearchResult = new System.Windows.Forms.DataGridView();
            this.textBoxBookUserSearch = new System.Windows.Forms.TextBox();
            this.labelBookUserSearch = new System.Windows.Forms.Label();
            this.labelSearchResults = new System.Windows.Forms.Label();
            this.labelDefaultReturnStatus = new System.Windows.Forms.Label();
            this.panelBookLoanHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookUserSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBookLoanHeader
            // 
            this.panelBookLoanHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelBookLoanHeader.Controls.Add(this.labelBookLoanHeader);
            this.panelBookLoanHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookLoanHeader.Location = new System.Drawing.Point(0, 0);
            this.panelBookLoanHeader.Name = "panelBookLoanHeader";
            this.panelBookLoanHeader.Size = new System.Drawing.Size(1119, 88);
            this.panelBookLoanHeader.TabIndex = 0;
            // 
            // labelBookLoanHeader
            // 
            this.labelBookLoanHeader.AutoSize = true;
            this.labelBookLoanHeader.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookLoanHeader.Location = new System.Drawing.Point(351, 9);
            this.labelBookLoanHeader.Name = "labelBookLoanHeader";
            this.labelBookLoanHeader.Size = new System.Drawing.Size(504, 65);
            this.labelBookLoanHeader.TabIndex = 0;
            this.labelBookLoanHeader.Text = "Add Book Loan/Lend";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(624, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelBookLoanID
            // 
            this.labelBookLoanID.AutoSize = true;
            this.labelBookLoanID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookLoanID.Location = new System.Drawing.Point(360, 110);
            this.labelBookLoanID.Name = "labelBookLoanID";
            this.labelBookLoanID.Size = new System.Drawing.Size(94, 21);
            this.labelBookLoanID.TabIndex = 63;
            this.labelBookLoanID.Text = "BookLoanID";
            // 
            // textBoxBookLoanID
            // 
            this.textBoxBookLoanID.Location = new System.Drawing.Point(516, 111);
            this.textBoxBookLoanID.Name = "textBoxBookLoanID";
            this.textBoxBookLoanID.ReadOnly = true;
            this.textBoxBookLoanID.Size = new System.Drawing.Size(263, 22);
            this.textBoxBookLoanID.TabIndex = 64;
            // 
            // labelBookLoanName
            // 
            this.labelBookLoanName.AutoSize = true;
            this.labelBookLoanName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookLoanName.Location = new System.Drawing.Point(360, 167);
            this.labelBookLoanName.Name = "labelBookLoanName";
            this.labelBookLoanName.Size = new System.Drawing.Size(91, 21);
            this.labelBookLoanName.TabIndex = 65;
            this.labelBookLoanName.Text = "Book Name";
            // 
            // textBoxBookLoanName
            // 
            this.textBoxBookLoanName.Location = new System.Drawing.Point(516, 167);
            this.textBoxBookLoanName.Name = "textBoxBookLoanName";
            this.textBoxBookLoanName.Size = new System.Drawing.Size(263, 22);
            this.textBoxBookLoanName.TabIndex = 66;
            // 
            // textBoxBookLoanToUsername
            // 
            this.textBoxBookLoanToUsername.Location = new System.Drawing.Point(516, 227);
            this.textBoxBookLoanToUsername.Name = "textBoxBookLoanToUsername";
            this.textBoxBookLoanToUsername.Size = new System.Drawing.Size(263, 22);
            this.textBoxBookLoanToUsername.TabIndex = 68;
            // 
            // labelBookLoanToUsername
            // 
            this.labelBookLoanToUsername.AutoSize = true;
            this.labelBookLoanToUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookLoanToUsername.Location = new System.Drawing.Point(360, 227);
            this.labelBookLoanToUsername.Name = "labelBookLoanToUsername";
            this.labelBookLoanToUsername.Size = new System.Drawing.Size(81, 21);
            this.labelBookLoanToUsername.TabIndex = 67;
            this.labelBookLoanToUsername.Text = "Username";
            // 
            // labelIssuedDate
            // 
            this.labelIssuedDate.AutoSize = true;
            this.labelIssuedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssuedDate.Location = new System.Drawing.Point(360, 261);
            this.labelIssuedDate.Name = "labelIssuedDate";
            this.labelIssuedDate.Size = new System.Drawing.Size(81, 21);
            this.labelIssuedDate.TabIndex = 69;
            this.labelIssuedDate.Text = "Issue Date";
            // 
            // dateTimePickerIssuedDate
            // 
            this.dateTimePickerIssuedDate.Location = new System.Drawing.Point(516, 261);
            this.dateTimePickerIssuedDate.Name = "dateTimePickerIssuedDate";
            this.dateTimePickerIssuedDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerIssuedDate.TabIndex = 70;
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(516, 301);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerReturnDate.TabIndex = 72;
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnDate.Location = new System.Drawing.Point(360, 301);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(93, 21);
            this.labelReturnDate.TabIndex = 71;
            this.labelReturnDate.Text = "Return Date";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(101, 216);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 53);
            this.buttonClear.TabIndex = 80;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(895, 216);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 53);
            this.buttonAdd.TabIndex = 77;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxBookLoanBookID
            // 
            this.textBoxBookLoanBookID.Location = new System.Drawing.Point(516, 137);
            this.textBoxBookLoanBookID.Name = "textBoxBookLoanBookID";
            this.textBoxBookLoanBookID.ReadOnly = true;
            this.textBoxBookLoanBookID.Size = new System.Drawing.Size(263, 22);
            this.textBoxBookLoanBookID.TabIndex = 85;
            // 
            // labelBookLoanBookID
            // 
            this.labelBookLoanBookID.AutoSize = true;
            this.labelBookLoanBookID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookLoanBookID.Location = new System.Drawing.Point(360, 138);
            this.labelBookLoanBookID.Name = "labelBookLoanBookID";
            this.labelBookLoanBookID.Size = new System.Drawing.Size(64, 21);
            this.labelBookLoanBookID.TabIndex = 84;
            this.labelBookLoanBookID.Text = "Book ID";
            // 
            // textBoxBookLoanUserID
            // 
            this.textBoxBookLoanUserID.Location = new System.Drawing.Point(516, 195);
            this.textBoxBookLoanUserID.Name = "textBoxBookLoanUserID";
            this.textBoxBookLoanUserID.ReadOnly = true;
            this.textBoxBookLoanUserID.Size = new System.Drawing.Size(263, 22);
            this.textBoxBookLoanUserID.TabIndex = 87;
            // 
            // labelBookLoanUserID
            // 
            this.labelBookLoanUserID.AutoSize = true;
            this.labelBookLoanUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookLoanUserID.Location = new System.Drawing.Point(360, 196);
            this.labelBookLoanUserID.Name = "labelBookLoanUserID";
            this.labelBookLoanUserID.Size = new System.Drawing.Size(61, 21);
            this.labelBookLoanUserID.TabIndex = 86;
            this.labelBookLoanUserID.Text = "User ID";
            // 
            // labelReturnStatus
            // 
            this.labelReturnStatus.AutoSize = true;
            this.labelReturnStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnStatus.Location = new System.Drawing.Point(360, 337);
            this.labelReturnStatus.Name = "labelReturnStatus";
            this.labelReturnStatus.Size = new System.Drawing.Size(103, 21);
            this.labelReturnStatus.TabIndex = 91;
            this.labelReturnStatus.Text = "Return Status";
            // 
            // comboBoxBookUserSearch
            // 
            this.comboBoxBookUserSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBookUserSearch.FormattingEnabled = true;
            this.comboBoxBookUserSearch.Items.AddRange(new object[] {
            "Book ",
            "User\t"});
            this.comboBoxBookUserSearch.Location = new System.Drawing.Point(85, 459);
            this.comboBoxBookUserSearch.Name = "comboBoxBookUserSearch";
            this.comboBoxBookUserSearch.Size = new System.Drawing.Size(221, 45);
            this.comboBoxBookUserSearch.TabIndex = 95;
            this.comboBoxBookUserSearch.Text = "Book/User";
            this.comboBoxBookUserSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookUserSearch_SelectedIndexChanged);
            // 
            // dataGridViewBookUserSearchResult
            // 
            this.dataGridViewBookUserSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookUserSearchResult.Location = new System.Drawing.Point(450, 383);
            this.dataGridViewBookUserSearchResult.Name = "dataGridViewBookUserSearchResult";
            this.dataGridViewBookUserSearchResult.Size = new System.Drawing.Size(648, 233);
            this.dataGridViewBookUserSearchResult.TabIndex = 96;
            this.dataGridViewBookUserSearchResult.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBookUserSearchResult_RowHeaderMouseClick);
            // 
            // textBoxBookUserSearch
            // 
            this.textBoxBookUserSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookUserSearch.Location = new System.Drawing.Point(85, 526);
            this.textBoxBookUserSearch.Name = "textBoxBookUserSearch";
            this.textBoxBookUserSearch.Size = new System.Drawing.Size(221, 43);
            this.textBoxBookUserSearch.TabIndex = 97;
            this.textBoxBookUserSearch.TextChanged += new System.EventHandler(this.textBoxBookUserSearch_TextChanged);
            // 
            // labelBookUserSearch
            // 
            this.labelBookUserSearch.AutoSize = true;
            this.labelBookUserSearch.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookUserSearch.Location = new System.Drawing.Point(78, 403);
            this.labelBookUserSearch.Name = "labelBookUserSearch";
            this.labelBookUserSearch.Size = new System.Drawing.Size(245, 37);
            this.labelBookUserSearch.TabIndex = 98;
            this.labelBookUserSearch.Text = "Search Book/User";
            // 
            // labelSearchResults
            // 
            this.labelSearchResults.AutoSize = true;
            this.labelSearchResults.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchResults.Location = new System.Drawing.Point(714, 337);
            this.labelSearchResults.Name = "labelSearchResults";
            this.labelSearchResults.Size = new System.Drawing.Size(200, 37);
            this.labelSearchResults.TabIndex = 99;
            this.labelSearchResults.Text = "Search Results";
            // 
            // labelDefaultReturnStatus
            // 
            this.labelDefaultReturnStatus.AutoSize = true;
            this.labelDefaultReturnStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefaultReturnStatus.Location = new System.Drawing.Point(512, 337);
            this.labelDefaultReturnStatus.Name = "labelDefaultReturnStatus";
            this.labelDefaultReturnStatus.Size = new System.Drawing.Size(31, 21);
            this.labelDefaultReturnStatus.TabIndex = 100;
            this.labelDefaultReturnStatus.Text = "No";
            // 
            // FormBookLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 628);
            this.Controls.Add(this.labelDefaultReturnStatus);
            this.Controls.Add(this.labelSearchResults);
            this.Controls.Add(this.labelBookUserSearch);
            this.Controls.Add(this.textBoxBookUserSearch);
            this.Controls.Add(this.dataGridViewBookUserSearchResult);
            this.Controls.Add(this.comboBoxBookUserSearch);
            this.Controls.Add(this.labelReturnStatus);
            this.Controls.Add(this.textBoxBookLoanUserID);
            this.Controls.Add(this.labelBookLoanUserID);
            this.Controls.Add(this.textBoxBookLoanBookID);
            this.Controls.Add(this.labelBookLoanBookID);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.labelReturnDate);
            this.Controls.Add(this.dateTimePickerIssuedDate);
            this.Controls.Add(this.labelIssuedDate);
            this.Controls.Add(this.textBoxBookLoanToUsername);
            this.Controls.Add(this.labelBookLoanToUsername);
            this.Controls.Add(this.textBoxBookLoanName);
            this.Controls.Add(this.labelBookLoanName);
            this.Controls.Add(this.textBoxBookLoanID);
            this.Controls.Add(this.labelBookLoanID);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelBookLoanHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormBookLoan";
            this.Text = "BookLoan";
            this.panelBookLoanHeader.ResumeLayout(false);
            this.panelBookLoanHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookUserSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBookLoanHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelBookLoanHeader;
        private System.Windows.Forms.Label labelBookLoanID;
        private System.Windows.Forms.TextBox textBoxBookLoanID;
        private System.Windows.Forms.Label labelBookLoanName;
        private System.Windows.Forms.TextBox textBoxBookLoanName;
        private System.Windows.Forms.TextBox textBoxBookLoanToUsername;
        private System.Windows.Forms.Label labelBookLoanToUsername;
        private System.Windows.Forms.Label labelIssuedDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssuedDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxBookLoanBookID;
        private System.Windows.Forms.Label labelBookLoanBookID;
        private System.Windows.Forms.TextBox textBoxBookLoanUserID;
        private System.Windows.Forms.Label labelBookLoanUserID;
        private System.Windows.Forms.Label labelReturnStatus;
        private System.Windows.Forms.ComboBox comboBoxBookUserSearch;
        private System.Windows.Forms.DataGridView dataGridViewBookUserSearchResult;
        private System.Windows.Forms.TextBox textBoxBookUserSearch;
        private System.Windows.Forms.Label labelBookUserSearch;
        private System.Windows.Forms.Label labelSearchResults;
        private System.Windows.Forms.Label labelDefaultReturnStatus;
    }
}