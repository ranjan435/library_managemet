namespace library.UI
{
    partial class FormAddStaff
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
            this.textBoxStaffUsername = new System.Windows.Forms.TextBox();
            this.labelStaffUsername = new System.Windows.Forms.Label();
            this.labelStaffPassword = new System.Windows.Forms.Label();
            this.textBoxStaffPassword = new System.Windows.Forms.TextBox();
            this.buttonStaffAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxStaffUsername
            // 
            this.textBoxStaffUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStaffUsername.Location = new System.Drawing.Point(305, 153);
            this.textBoxStaffUsername.Name = "textBoxStaffUsername";
            this.textBoxStaffUsername.Size = new System.Drawing.Size(186, 35);
            this.textBoxStaffUsername.TabIndex = 0;
            // 
            // labelStaffUsername
            // 
            this.labelStaffUsername.AutoSize = true;
            this.labelStaffUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffUsername.Location = new System.Drawing.Point(182, 156);
            this.labelStaffUsername.Name = "labelStaffUsername";
            this.labelStaffUsername.Size = new System.Drawing.Size(106, 30);
            this.labelStaffUsername.TabIndex = 1;
            this.labelStaffUsername.Text = "Username";
            // 
            // labelStaffPassword
            // 
            this.labelStaffPassword.AutoSize = true;
            this.labelStaffPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffPassword.Location = new System.Drawing.Point(182, 218);
            this.labelStaffPassword.Name = "labelStaffPassword";
            this.labelStaffPassword.Size = new System.Drawing.Size(99, 30);
            this.labelStaffPassword.TabIndex = 3;
            this.labelStaffPassword.Text = "Password";
            // 
            // textBoxStaffPassword
            // 
            this.textBoxStaffPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStaffPassword.Location = new System.Drawing.Point(305, 215);
            this.textBoxStaffPassword.Name = "textBoxStaffPassword";
            this.textBoxStaffPassword.PasswordChar = '*';
            this.textBoxStaffPassword.Size = new System.Drawing.Size(186, 35);
            this.textBoxStaffPassword.TabIndex = 2;
            // 
            // buttonStaffAdd
            // 
            this.buttonStaffAdd.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaffAdd.Location = new System.Drawing.Point(317, 285);
            this.buttonStaffAdd.Name = "buttonStaffAdd";
            this.buttonStaffAdd.Size = new System.Drawing.Size(138, 47);
            this.buttonStaffAdd.TabIndex = 4;
            this.buttonStaffAdd.Text = "Add Staff";
            this.buttonStaffAdd.UseVisualStyleBackColor = true;
            this.buttonStaffAdd.Click += new System.EventHandler(this.buttonStaffAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Staff ";
            // 
            // FormAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStaffAdd);
            this.Controls.Add(this.labelStaffPassword);
            this.Controls.Add(this.textBoxStaffPassword);
            this.Controls.Add(this.labelStaffUsername);
            this.Controls.Add(this.textBoxStaffUsername);
            this.Name = "FormAddStaff";
            this.Text = "FormAddStaff";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStaffUsername;
        private System.Windows.Forms.Label labelStaffUsername;
        private System.Windows.Forms.Label labelStaffPassword;
        private System.Windows.Forms.TextBox textBoxStaffPassword;
        private System.Windows.Forms.Button buttonStaffAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}