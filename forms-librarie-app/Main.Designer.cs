namespace forms_librarie_app
{
	partial class Main
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
			this.components = new System.ComponentModel.Container();
			this.panelSidebar = new System.Windows.Forms.Panel();
			this.panelCatalog = new System.Windows.Forms.Panel();
			this.labelCatalog = new System.Windows.Forms.Label();
			this.panelMainPage = new System.Windows.Forms.Panel();
			this.labelMainPage = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxDebug = new System.Windows.Forms.TextBox();
			this.panelContent = new System.Windows.Forms.Panel();
			this.panelSidebar.SuspendLayout();
			this.panelCatalog.SuspendLayout();
			this.panelMainPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSidebar
			// 
			this.panelSidebar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panelSidebar.Controls.Add(this.panelCatalog);
			this.panelSidebar.Controls.Add(this.panelMainPage);
			this.panelSidebar.Controls.Add(this.button1);
			this.panelSidebar.Controls.Add(this.textBoxDebug);
			this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSidebar.Location = new System.Drawing.Point(0, 0);
			this.panelSidebar.Name = "panelSidebar";
			this.panelSidebar.Size = new System.Drawing.Size(220, 605);
			this.panelSidebar.TabIndex = 0;
			// 
			// panelCatalog
			// 
			this.panelCatalog.Controls.Add(this.labelCatalog);
			this.panelCatalog.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelCatalog.Location = new System.Drawing.Point(0, 102);
			this.panelCatalog.Name = "panelCatalog";
			this.panelCatalog.Size = new System.Drawing.Size(220, 105);
			this.panelCatalog.TabIndex = 1;
			this.panelCatalog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.catalog_Click);
			this.panelCatalog.MouseEnter += new System.EventHandler(this.menuEntryCatalog_Select);
			this.panelCatalog.MouseLeave += new System.EventHandler(this.menuEntryCatalog_Unselect);
			// 
			// labelCatalog
			// 
			this.labelCatalog.AutoSize = true;
			this.labelCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCatalog.Location = new System.Drawing.Point(42, 33);
			this.labelCatalog.Name = "labelCatalog";
			this.labelCatalog.Size = new System.Drawing.Size(128, 37);
			this.labelCatalog.TabIndex = 1;
			this.labelCatalog.Text = "Catalog";
			this.labelCatalog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.catalog_Click);
			this.labelCatalog.MouseEnter += new System.EventHandler(this.menuEntryCatalog_Select);
			// 
			// panelMainPage
			// 
			this.panelMainPage.Controls.Add(this.labelMainPage);
			this.panelMainPage.Location = new System.Drawing.Point(0, 3);
			this.panelMainPage.Name = "panelMainPage";
			this.panelMainPage.Size = new System.Drawing.Size(220, 105);
			this.panelMainPage.TabIndex = 3;
			this.panelMainPage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPage_Click);
			this.panelMainPage.MouseEnter += new System.EventHandler(this.menuEntryMainPage_Select);
			this.panelMainPage.MouseLeave += new System.EventHandler(this.menuEntryMainPage_Unselect);
			// 
			// labelMainPage
			// 
			this.labelMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMainPage.Location = new System.Drawing.Point(25, 6);
			this.labelMainPage.Name = "labelMainPage";
			this.labelMainPage.Size = new System.Drawing.Size(168, 81);
			this.labelMainPage.TabIndex = 2;
			this.labelMainPage.Text = "Pagina principală";
			this.labelMainPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelMainPage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPage_Click);
			this.labelMainPage.MouseEnter += new System.EventHandler(this.menuEntryMainPage_Select);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(58, 304);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 51);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxDebug
			// 
			this.textBoxDebug.Location = new System.Drawing.Point(12, 383);
			this.textBoxDebug.Multiline = true;
			this.textBoxDebug.Name = "textBoxDebug";
			this.textBoxDebug.Size = new System.Drawing.Size(190, 90);
			this.textBoxDebug.TabIndex = 1;
			// 
			// panelContent
			// 
			this.panelContent.BackColor = System.Drawing.Color.Brown;
			this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContent.Location = new System.Drawing.Point(220, 0);
			this.panelContent.Name = "panelContent";
			this.panelContent.Size = new System.Drawing.Size(818, 605);
			this.panelContent.TabIndex = 3;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(1038, 605);
			this.Controls.Add(this.panelContent);
			this.Controls.Add(this.panelSidebar);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1054, 643);
			this.MinimumSize = new System.Drawing.Size(1054, 643);
			this.Name = "Main";
			this.Text = "Librarius";
			this.Load += new System.EventHandler(this.Main_Load);
			this.panelSidebar.ResumeLayout(false);
			this.panelSidebar.PerformLayout();
			this.panelCatalog.ResumeLayout(false);
			this.panelCatalog.PerformLayout();
			this.panelMainPage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelSidebar;
		private System.Windows.Forms.Panel panelCatalog;
		private System.Windows.Forms.Label labelCatalog;
		private System.Windows.Forms.TextBox textBoxDebug;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panelContent;
		private System.Windows.Forms.Panel panelMainPage;
		private System.Windows.Forms.Label labelMainPage;
	}
}

