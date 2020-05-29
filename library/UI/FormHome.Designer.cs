namespace library
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDvlp = new System.Windows.Forms.Label();
            this.labelFooter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEditBookLoan = new System.Windows.Forms.Button();
            this.buttonManageUsers = new System.Windows.Forms.Button();
            this.buttonManageBooks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelStaffUsername = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.labelDvlp);
            this.panel1.Controls.Add(this.labelFooter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 0;
            // 
            // labelDvlp
            // 
            this.labelDvlp.AutoSize = true;
            this.labelDvlp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDvlp.Location = new System.Drawing.Point(263, 37);
            this.labelDvlp.Name = "labelDvlp";
            this.labelDvlp.Size = new System.Drawing.Size(239, 32);
            this.labelDvlp.TabIndex = 1;
            this.labelDvlp.Text = "Software Assessment";
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter.ForeColor = System.Drawing.Color.DarkRed;
            this.labelFooter.Location = new System.Drawing.Point(228, 5);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(319, 32);
            this.labelFooter.TabIndex = 0;
            this.labelFooter.Text = "Library Management System";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.manageBooksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchUserToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchUserToolStripMenuItem
            // 
            this.searchUserToolStripMenuItem.Name = "searchUserToolStripMenuItem";
            this.searchUserToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.searchUserToolStripMenuItem.Text = "Search User";
            this.searchUserToolStripMenuItem.Click += new System.EventHandler(this.searchUserToolStripMenuItem_Click);
            // 
            // manageBooksToolStripMenuItem
            // 
            this.manageBooksToolStripMenuItem.Name = "manageBooksToolStripMenuItem";
            this.manageBooksToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.manageBooksToolStripMenuItem.Text = "Manage Books";
            this.manageBooksToolStripMenuItem.Click += new System.EventHandler(this.manageBooksToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(71, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 126);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Book Loan/Issue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEditBookLoan
            // 
            this.buttonEditBookLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditBookLoan.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditBookLoan.Location = new System.Drawing.Point(320, 220);
            this.buttonEditBookLoan.Name = "buttonEditBookLoan";
            this.buttonEditBookLoan.Size = new System.Drawing.Size(197, 126);
            this.buttonEditBookLoan.TabIndex = 3;
            this.buttonEditBookLoan.Text = "Edit Book Loan/Return/Renew";
            this.buttonEditBookLoan.UseVisualStyleBackColor = true;
            this.buttonEditBookLoan.Click += new System.EventHandler(this.buttonEditBookLoan_Click);
            // 
            // buttonManageUsers
            // 
            this.buttonManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManageUsers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageUsers.Location = new System.Drawing.Point(320, 77);
            this.buttonManageUsers.Name = "buttonManageUsers";
            this.buttonManageUsers.Size = new System.Drawing.Size(197, 126);
            this.buttonManageUsers.TabIndex = 4;
            this.buttonManageUsers.Text = "Add/Manage Users";
            this.buttonManageUsers.UseVisualStyleBackColor = true;
            this.buttonManageUsers.Click += new System.EventHandler(this.buttonManageUsers_Click);
            // 
            // buttonManageBooks
            // 
            this.buttonManageBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManageBooks.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageBooks.Location = new System.Drawing.Point(71, 77);
            this.buttonManageBooks.Name = "buttonManageBooks";
            this.buttonManageBooks.Size = new System.Drawing.Size(197, 126);
            this.buttonManageBooks.TabIndex = 5;
            this.buttonManageBooks.Text = "Add/Manage Books";
            this.buttonManageBooks.UseVisualStyleBackColor = true;
            this.buttonManageBooks.Click += new System.EventHandler(this.buttonManageBooks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(682, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelStaffUsername
            // 
            this.labelStaffUsername.AutoSize = true;
            this.labelStaffUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffUsername.Location = new System.Drawing.Point(695, 112);
            this.labelStaffUsername.Name = "labelStaffUsername";
            this.labelStaffUsername.Size = new System.Drawing.Size(57, 21);
            this.labelStaffUsername.TabIndex = 9;
            this.labelStaffUsername.Text = "label1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "WordFiles (*.docx)|*.docx";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStaffUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonManageBooks);
            this.Controls.Add(this.buttonManageUsers);
            this.Controls.Add(this.buttonEditBookLoan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHome";
            this.Text = "Online Library";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDvlp;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBooksToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEditBookLoan;
        private System.Windows.Forms.Button buttonManageUsers;
        private System.Windows.Forms.Button buttonManageBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStaffUsername;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

