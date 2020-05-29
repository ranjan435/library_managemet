namespace library.UI
{
    partial class FormMainPage
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
            this.buttonAdminSection = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelDvlp = new System.Windows.Forms.Label();
            this.labelFooterAppName = new System.Windows.Forms.Label();
            this.labelSearchBook = new System.Windows.Forms.Label();
            this.textBoxSearchBooks = new System.Windows.Forms.TextBox();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSearchBookResult = new System.Windows.Forms.DataGridView();
            this.panelFooter.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchBookResult)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdminSection
            // 
            this.buttonAdminSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdminSection.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminSection.Location = new System.Drawing.Point(933, 2);
            this.buttonAdminSection.Name = "buttonAdminSection";
            this.buttonAdminSection.Size = new System.Drawing.Size(183, 52);
            this.buttonAdminSection.TabIndex = 1;
            this.buttonAdminSection.Text = "Administration";
            this.buttonAdminSection.UseVisualStyleBackColor = true;
            this.buttonAdminSection.Click += new System.EventHandler(this.buttonAdminSection_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.Control;
            this.panelFooter.Controls.Add(this.labelDvlp);
            this.panelFooter.Controls.Add(this.labelFooterAppName);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 497);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1119, 74);
            this.panelFooter.TabIndex = 2;
            // 
            // labelDvlp
            // 
            this.labelDvlp.AutoSize = true;
            this.labelDvlp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDvlp.Location = new System.Drawing.Point(474, 37);
            this.labelDvlp.Name = "labelDvlp";
            this.labelDvlp.Size = new System.Drawing.Size(239, 32);
            this.labelDvlp.TabIndex = 1;
            this.labelDvlp.Text = "Software Assessment";
            // 
            // labelFooterAppName
            // 
            this.labelFooterAppName.AutoSize = true;
            this.labelFooterAppName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooterAppName.ForeColor = System.Drawing.Color.DarkRed;
            this.labelFooterAppName.Location = new System.Drawing.Point(439, 5);
            this.labelFooterAppName.Name = "labelFooterAppName";
            this.labelFooterAppName.Size = new System.Drawing.Size(319, 32);
            this.labelFooterAppName.TabIndex = 0;
            this.labelFooterAppName.Text = "Library Management System";
            // 
            // labelSearchBook
            // 
            this.labelSearchBook.AutoSize = true;
            this.labelSearchBook.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchBook.Location = new System.Drawing.Point(400, 77);
            this.labelSearchBook.Name = "labelSearchBook";
            this.labelSearchBook.Size = new System.Drawing.Size(175, 37);
            this.labelSearchBook.TabIndex = 3;
            this.labelSearchBook.Text = "Search Book";
            // 
            // textBoxSearchBooks
            // 
            this.textBoxSearchBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchBooks.Location = new System.Drawing.Point(596, 74);
            this.textBoxSearchBooks.Name = "textBoxSearchBooks";
            this.textBoxSearchBooks.Size = new System.Drawing.Size(200, 43);
            this.textBoxSearchBooks.TabIndex = 4;
            this.textBoxSearchBooks.TextChanged += new System.EventHandler(this.textBoxSearchBooks_TextChanged);
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelWelcome.Controls.Add(this.label2);
            this.panelWelcome.Controls.Add(this.buttonAdminSection);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1119, 55);
            this.panelWelcome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome";
            // 
            // dataGridViewSearchBookResult
            // 
            this.dataGridViewSearchBookResult.AllowUserToAddRows = false;
            this.dataGridViewSearchBookResult.AllowUserToDeleteRows = false;
            this.dataGridViewSearchBookResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchBookResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSearchBookResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchBookResult.Location = new System.Drawing.Point(13, 130);
            this.dataGridViewSearchBookResult.Name = "dataGridViewSearchBookResult";
            this.dataGridViewSearchBookResult.ReadOnly = true;
            this.dataGridViewSearchBookResult.Size = new System.Drawing.Size(1094, 361);
            this.dataGridViewSearchBookResult.TabIndex = 6;
            this.dataGridViewSearchBookResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchBookResult_CellDoubleClick);
            this.dataGridViewSearchBookResult.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSearchBookResult_RowHeaderMouseClick);
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 571);
            this.Controls.Add(this.dataGridViewSearchBookResult);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.textBoxSearchBooks);
            this.Controls.Add(this.labelSearchBook);
            this.Controls.Add(this.panelFooter);
            this.Name = "FormMainPage";
            this.Text = "Library Management System";
            this.Activated += new System.EventHandler(this.FormMainPage_Activated);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchBookResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdminSection;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelDvlp;
        private System.Windows.Forms.Label labelFooterAppName;
        private System.Windows.Forms.Label labelSearchBook;
        private System.Windows.Forms.TextBox textBoxSearchBooks;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewSearchBookResult;
    }
}