namespace library.UI
{
    partial class FormAddCategory
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
            this.panelManageCategory = new System.Windows.Forms.Panel();
            this.labelManageCategory = new System.Windows.Forms.Label();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.panelManageCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManageCategory
            // 
            this.panelManageCategory.BackColor = System.Drawing.Color.Blue;
            this.panelManageCategory.Controls.Add(this.labelManageCategory);
            this.panelManageCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManageCategory.Location = new System.Drawing.Point(0, 0);
            this.panelManageCategory.Name = "panelManageCategory";
            this.panelManageCategory.Size = new System.Drawing.Size(800, 95);
            this.panelManageCategory.TabIndex = 2;
            // 
            // labelManageCategory
            // 
            this.labelManageCategory.AutoSize = true;
            this.labelManageCategory.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelManageCategory.Location = new System.Drawing.Point(229, 9);
            this.labelManageCategory.Name = "labelManageCategory";
            this.labelManageCategory.Size = new System.Drawing.Size(418, 65);
            this.labelManageCategory.TabIndex = 1;
            this.labelManageCategory.Text = "ManageCategory";
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonAddCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddCategory.Location = new System.Drawing.Point(363, 264);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(118, 37);
            this.buttonAddCategory.TabIndex = 7;
            this.buttonAddCategory.Text = "ADD";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryName.Location = new System.Drawing.Point(358, 158);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(166, 30);
            this.labelCategoryName.TabIndex = 6;
            this.labelCategoryName.Text = "Category Name";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategoryName.Location = new System.Drawing.Point(300, 210);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(259, 29);
            this.textBoxCategoryName.TabIndex = 5;
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.labelCategoryName);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.panelManageCategory);
            this.Name = "FormAddCategory";
            this.Text = "FormAddCategory";
            this.panelManageCategory.ResumeLayout(false);
            this.panelManageCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelManageCategory;
        private System.Windows.Forms.Label labelManageCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryName;
    }
}