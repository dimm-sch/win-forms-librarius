namespace forms_librarie_app
{
	partial class FavoriteBooks
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
			this.label1 = new System.Windows.Forms.Label();
			this.buttonExport = new System.Windows.Forms.Button();
			this.dataGridViewFavoriteBooks = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavoriteBooks)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(190, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(465, 72);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lista cărților favorite";
			// 
			// buttonExport
			// 
			this.buttonExport.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExport.Location = new System.Drawing.Point(295, 443);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(240, 85);
			this.buttonExport.TabIndex = 1;
			this.buttonExport.Text = "Exportă în Excel";
			this.buttonExport.UseVisualStyleBackColor = true;
			// 
			// dataGridViewFavoriteBooks
			// 
			this.dataGridViewFavoriteBooks.AllowUserToAddRows = false;
			this.dataGridViewFavoriteBooks.AllowUserToDeleteRows = false;
			this.dataGridViewFavoriteBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFavoriteBooks.Location = new System.Drawing.Point(74, 137);
			this.dataGridViewFavoriteBooks.Name = "dataGridViewFavoriteBooks";
			this.dataGridViewFavoriteBooks.ReadOnly = true;
			this.dataGridViewFavoriteBooks.Size = new System.Drawing.Size(669, 263);
			this.dataGridViewFavoriteBooks.TabIndex = 2;
			this.dataGridViewFavoriteBooks.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFavoriteBooks_CellMouseDoubleClick);
			// 
			// FavoriteBooks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Orange;
			this.Controls.Add(this.dataGridViewFavoriteBooks);
			this.Controls.Add(this.buttonExport);
			this.Controls.Add(this.label1);
			this.Name = "FavoriteBooks";
			this.Size = new System.Drawing.Size(820, 605);
			this.Load += new System.EventHandler(this.FavoriteBooks_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavoriteBooks)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonExport;
		private System.Windows.Forms.DataGridView dataGridViewFavoriteBooks;
	}
}
