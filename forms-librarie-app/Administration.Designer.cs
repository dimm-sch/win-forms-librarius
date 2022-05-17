namespace forms_librarie_app
{
	partial class Administration
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNavAddBook = new System.Windows.Forms.Button();
            this.buttonNavRemoveBook = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContent.Location = new System.Drawing.Point(170, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(650, 605);
            this.panelContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNavRemoveBook);
            this.panel1.Controls.Add(this.buttonNavAddBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 605);
            this.panel1.TabIndex = 1;
            // 
            // buttonNavAddBook
            // 
            this.buttonNavAddBook.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNavAddBook.Location = new System.Drawing.Point(10, 10);
            this.buttonNavAddBook.Name = "buttonNavAddBook";
            this.buttonNavAddBook.Size = new System.Drawing.Size(148, 75);
            this.buttonNavAddBook.TabIndex = 0;
            this.buttonNavAddBook.Text = "Adaugă carte";
            this.buttonNavAddBook.UseVisualStyleBackColor = true;
            this.buttonNavAddBook.Click += new System.EventHandler(this.buttonNavAddBook_Click);
            // 
            // buttonNavRemoveBook
            // 
            this.buttonNavRemoveBook.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNavRemoveBook.Location = new System.Drawing.Point(10, 102);
            this.buttonNavRemoveBook.Name = "buttonNavRemoveBook";
            this.buttonNavRemoveBook.Size = new System.Drawing.Size(148, 75);
            this.buttonNavRemoveBook.TabIndex = 1;
            this.buttonNavRemoveBook.Text = "Șterge carte";
            this.buttonNavRemoveBook.UseVisualStyleBackColor = true;
            this.buttonNavRemoveBook.Click += new System.EventHandler(this.buttonNavRemoveBook_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContent);
            this.Name = "Administration";
            this.Size = new System.Drawing.Size(820, 605);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNavRemoveBook;
        private System.Windows.Forms.Button buttonNavAddBook;
    }
}
