namespace library.UI
{
    partial class FormStaffLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaffLogin));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelStaffLogin = new System.Windows.Forms.Panel();
            this.labelStaffLoginHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLibraryPhoto = new System.Windows.Forms.PictureBox();
            this.buttonAddStaff = new System.Windows.Forms.Button();
            this.panelStaffLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibraryPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(492, 199);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(259, 29);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(492, 279);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(259, 29);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(576, 166);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(110, 30);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(576, 246);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(105, 30);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogin.Location = new System.Drawing.Point(568, 336);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(118, 37);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelStaffLogin
            // 
            this.panelStaffLogin.BackColor = System.Drawing.Color.Blue;
            this.panelStaffLogin.Controls.Add(this.labelStaffLoginHeader);
            this.panelStaffLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStaffLogin.Location = new System.Drawing.Point(0, 0);
            this.panelStaffLogin.Name = "panelStaffLogin";
            this.panelStaffLogin.Size = new System.Drawing.Size(800, 100);
            this.panelStaffLogin.TabIndex = 5;
            // 
            // labelStaffLoginHeader
            // 
            this.labelStaffLoginHeader.AutoSize = true;
            this.labelStaffLoginHeader.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffLoginHeader.ForeColor = System.Drawing.Color.Red;
            this.labelStaffLoginHeader.Location = new System.Drawing.Point(294, 19);
            this.labelStaffLoginHeader.Name = "labelStaffLoginHeader";
            this.labelStaffLoginHeader.Size = new System.Drawing.Size(275, 65);
            this.labelStaffLoginHeader.TabIndex = 6;
            this.labelStaffLoginHeader.Text = "Staff Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Library Management System";
            // 
            // pictureBoxLibraryPhoto
            // 
            this.pictureBoxLibraryPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLibraryPhoto.Image")));
            this.pictureBoxLibraryPhoto.Location = new System.Drawing.Point(61, 117);
            this.pictureBoxLibraryPhoto.Name = "pictureBoxLibraryPhoto";
            this.pictureBoxLibraryPhoto.Size = new System.Drawing.Size(344, 238);
            this.pictureBoxLibraryPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLibraryPhoto.TabIndex = 7;
            this.pictureBoxLibraryPhoto.TabStop = false;
            // 
            // buttonAddStaff
            // 
            this.buttonAddStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddStaff.Location = new System.Drawing.Point(676, 404);
            this.buttonAddStaff.Name = "buttonAddStaff";
            this.buttonAddStaff.Size = new System.Drawing.Size(75, 23);
            this.buttonAddStaff.TabIndex = 9;
            this.buttonAddStaff.Text = "Add Staff";
            this.buttonAddStaff.UseVisualStyleBackColor = false;
            this.buttonAddStaff.Click += new System.EventHandler(this.buttonAddStaff_Click);
            // 
            // FormStaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddStaff);
            this.Controls.Add(this.pictureBoxLibraryPhoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelStaffLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "FormStaffLogin";
            this.Text = "FormStaffLogin";
            this.panelStaffLogin.ResumeLayout(false);
            this.panelStaffLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibraryPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelStaffLogin;
        private System.Windows.Forms.Label labelStaffLoginHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLibraryPhoto;
        private System.Windows.Forms.Button buttonAddStaff;
    }
}