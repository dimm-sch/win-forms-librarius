
namespace forms_librarie_app
{
    partial class AdminRemoveBook
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
			this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
			this.buttonRemoveBook = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewBooks
			// 
			this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewBooks.Location = new System.Drawing.Point(39, 112);
			this.dataGridViewBooks.Name = "dataGridViewBooks";
			this.dataGridViewBooks.ReadOnly = true;
			this.dataGridViewBooks.Size = new System.Drawing.Size(575, 288);
			this.dataGridViewBooks.TabIndex = 0;
			// 
			// buttonRemoveBook
			// 
			this.buttonRemoveBook.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRemoveBook.Location = new System.Drawing.Point(174, 454);
			this.buttonRemoveBook.Name = "buttonRemoveBook";
			this.buttonRemoveBook.Size = new System.Drawing.Size(311, 89);
			this.buttonRemoveBook.TabIndex = 1;
			this.buttonRemoveBook.Text = "Șterge";
			this.buttonRemoveBook.UseVisualStyleBackColor = true;
			this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(237, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 37);
			this.label1.TabIndex = 2;
			this.label1.Text = "Șterge cărți";
			// 
			// AdminRemoveBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Orange;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonRemoveBook);
			this.Controls.Add(this.dataGridViewBooks);
			this.Name = "AdminRemoveBook";
			this.Size = new System.Drawing.Size(650, 605);
			this.Load += new System.EventHandler(this.AdminRemoveBook_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.Label label1;
    }
}
