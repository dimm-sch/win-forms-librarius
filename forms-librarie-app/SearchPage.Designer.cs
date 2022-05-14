namespace forms_librarie_app
{
	partial class SearchPage
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
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewResult = new System.Windows.Forms.DataGridView();
			this.radioButtonFilterName = new System.Windows.Forms.RadioButton();
			this.radioButtonFilterAuthor = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(117, 151);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(469, 32);
			this.textBoxSearch.TabIndex = 0;
			this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSearch.Location = new System.Drawing.Point(592, 151);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(109, 32);
			this.buttonSearch.TabIndex = 1;
			this.buttonSearch.Text = "Caută";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(266, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(297, 57);
			this.label1.TabIndex = 2;
			this.label1.Text = "Căutare carte";
			// 
			// dataGridViewResult
			// 
			this.dataGridViewResult.AllowUserToAddRows = false;
			this.dataGridViewResult.AllowUserToDeleteRows = false;
			this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewResult.Location = new System.Drawing.Point(117, 330);
			this.dataGridViewResult.Name = "dataGridViewResult";
			this.dataGridViewResult.ReadOnly = true;
			this.dataGridViewResult.Size = new System.Drawing.Size(584, 225);
			this.dataGridViewResult.TabIndex = 3;
			this.dataGridViewResult.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewResult_CellMouseDoubleClick);
			// 
			// radioButtonFilterName
			// 
			this.radioButtonFilterName.AutoSize = true;
			this.radioButtonFilterName.Checked = true;
			this.radioButtonFilterName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonFilterName.Location = new System.Drawing.Point(117, 228);
			this.radioButtonFilterName.Name = "radioButtonFilterName";
			this.radioButtonFilterName.Size = new System.Drawing.Size(133, 32);
			this.radioButtonFilterName.TabIndex = 6;
			this.radioButtonFilterName.TabStop = true;
			this.radioButtonFilterName.Text = "Denumire";
			this.radioButtonFilterName.UseVisualStyleBackColor = true;
			// 
			// radioButtonFilterAuthor
			// 
			this.radioButtonFilterAuthor.AutoSize = true;
			this.radioButtonFilterAuthor.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonFilterAuthor.Location = new System.Drawing.Point(266, 228);
			this.radioButtonFilterAuthor.Name = "radioButtonFilterAuthor";
			this.radioButtonFilterAuthor.Size = new System.Drawing.Size(89, 32);
			this.radioButtonFilterAuthor.TabIndex = 7;
			this.radioButtonFilterAuthor.Text = "Autor";
			this.radioButtonFilterAuthor.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(112, 197);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 28);
			this.label2.TabIndex = 8;
			this.label2.Text = "După:";
			// 
			// SearchPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Orange;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.radioButtonFilterAuthor);
			this.Controls.Add(this.radioButtonFilterName);
			this.Controls.Add(this.dataGridViewResult);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxSearch);
			this.Name = "SearchPage";
			this.Size = new System.Drawing.Size(820, 605);
			this.Load += new System.EventHandler(this.SearchPage_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.DataGridView dataGridViewResult;
		private System.Windows.Forms.RadioButton radioButtonFilterName;
		private System.Windows.Forms.RadioButton radioButtonFilterAuthor;
		private System.Windows.Forms.Label label2;
	}
}
