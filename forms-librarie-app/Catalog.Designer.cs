namespace forms_librarie_app
{
	partial class Catalog
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridViewCategoriiGenuri = new System.Windows.Forms.DataGridView();
			this.dataGridViewGenuri = new System.Windows.Forms.DataGridView();
			this.dataGridViewCarti = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoriiGenuri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenuri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarti)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(116, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Categorii de genuri de cărți";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(820, 62);
			this.panel1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(567, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Genuri de cărți";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(0, 269);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(820, 62);
			this.panel2.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(391, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Cărți";
			// 
			// dataGridViewCategoriiGenuri
			// 
			this.dataGridViewCategoriiGenuri.AllowUserToAddRows = false;
			this.dataGridViewCategoriiGenuri.AllowUserToDeleteRows = false;
			this.dataGridViewCategoriiGenuri.AllowUserToResizeRows = false;
			this.dataGridViewCategoriiGenuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCategoriiGenuri.Location = new System.Drawing.Point(23, 82);
			this.dataGridViewCategoriiGenuri.MultiSelect = false;
			this.dataGridViewCategoriiGenuri.Name = "dataGridViewCategoriiGenuri";
			this.dataGridViewCategoriiGenuri.ReadOnly = true;
			this.dataGridViewCategoriiGenuri.RowHeadersWidth = 46;
			this.dataGridViewCategoriiGenuri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridViewCategoriiGenuri.Size = new System.Drawing.Size(356, 181);
			this.dataGridViewCategoriiGenuri.TabIndex = 3;
			this.dataGridViewCategoriiGenuri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategoriiGenuri_CellClick);
			// 
			// dataGridViewGenuri
			// 
			this.dataGridViewGenuri.AllowUserToAddRows = false;
			this.dataGridViewGenuri.AllowUserToDeleteRows = false;
			this.dataGridViewGenuri.AllowUserToResizeRows = false;
			this.dataGridViewGenuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewGenuri.Location = new System.Drawing.Point(440, 82);
			this.dataGridViewGenuri.MultiSelect = false;
			this.dataGridViewGenuri.Name = "dataGridViewGenuri";
			this.dataGridViewGenuri.ReadOnly = true;
			this.dataGridViewGenuri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridViewGenuri.Size = new System.Drawing.Size(356, 181);
			this.dataGridViewGenuri.TabIndex = 4;
			this.dataGridViewGenuri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGenuri_CellClick);
			// 
			// dataGridViewCarti
			// 
			this.dataGridViewCarti.AllowUserToAddRows = false;
			this.dataGridViewCarti.AllowUserToDeleteRows = false;
			this.dataGridViewCarti.AllowUserToResizeRows = false;
			this.dataGridViewCarti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCarti.Location = new System.Drawing.Point(194, 364);
			this.dataGridViewCarti.MultiSelect = false;
			this.dataGridViewCarti.Name = "dataGridViewCarti";
			this.dataGridViewCarti.ReadOnly = true;
			this.dataGridViewCarti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridViewCarti.Size = new System.Drawing.Size(425, 199);
			this.dataGridViewCarti.TabIndex = 5;
			this.dataGridViewCarti.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarti_CellContentDoubleClick);
			// 
			// Catalog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Orange;
			this.Controls.Add(this.dataGridViewCarti);
			this.Controls.Add(this.dataGridViewGenuri);
			this.Controls.Add(this.dataGridViewCategoriiGenuri);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Catalog";
			this.Size = new System.Drawing.Size(820, 605);
			this.Load += new System.EventHandler(this.Catalog_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoriiGenuri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenuri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarti)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewCategoriiGenuri;
		private System.Windows.Forms.DataGridView dataGridViewGenuri;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridViewCarti;
	}
}
