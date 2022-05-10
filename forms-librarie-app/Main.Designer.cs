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
			this.panelSidebar = new System.Windows.Forms.Panel();
			this.panelNavCatalog = new System.Windows.Forms.Panel();
			this.labelNavCatalog = new System.Windows.Forms.Label();
			this.panelNavMainPage = new System.Windows.Forms.Panel();
			this.labelNavMainPage = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxDebug = new System.Windows.Forms.TextBox();
			this.panelContent = new System.Windows.Forms.Panel();
			this.panelMainPage = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.labelMainPageAuthentificationStatus = new System.Windows.Forms.Label();
			this.buttonMainPageAuthentification = new System.Windows.Forms.Button();
			this.buttonMainPageLogOut = new System.Windows.Forms.Button();
			this.panelSidebar.SuspendLayout();
			this.panelNavCatalog.SuspendLayout();
			this.panelNavMainPage.SuspendLayout();
			this.panelContent.SuspendLayout();
			this.panelMainPage.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSidebar
			// 
			this.panelSidebar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panelSidebar.Controls.Add(this.panelNavCatalog);
			this.panelSidebar.Controls.Add(this.panelNavMainPage);
			this.panelSidebar.Controls.Add(this.button1);
			this.panelSidebar.Controls.Add(this.textBoxDebug);
			this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSidebar.Location = new System.Drawing.Point(0, 0);
			this.panelSidebar.Name = "panelSidebar";
			this.panelSidebar.Size = new System.Drawing.Size(220, 605);
			this.panelSidebar.TabIndex = 0;
			// 
			// panelNavCatalog
			// 
			this.panelNavCatalog.Controls.Add(this.labelNavCatalog);
			this.panelNavCatalog.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelNavCatalog.Location = new System.Drawing.Point(0, 102);
			this.panelNavCatalog.Name = "panelNavCatalog";
			this.panelNavCatalog.Size = new System.Drawing.Size(220, 105);
			this.panelNavCatalog.TabIndex = 1;
			this.panelNavCatalog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.catalog_Click);
			this.panelNavCatalog.MouseEnter += new System.EventHandler(this.menuEntryCatalog_Select);
			this.panelNavCatalog.MouseLeave += new System.EventHandler(this.menuEntryCatalog_Unselect);
			// 
			// labelNavCatalog
			// 
			this.labelNavCatalog.AutoSize = true;
			this.labelNavCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNavCatalog.Location = new System.Drawing.Point(42, 33);
			this.labelNavCatalog.Name = "labelNavCatalog";
			this.labelNavCatalog.Size = new System.Drawing.Size(128, 37);
			this.labelNavCatalog.TabIndex = 1;
			this.labelNavCatalog.Text = "Catalog";
			this.labelNavCatalog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.catalog_Click);
			this.labelNavCatalog.MouseEnter += new System.EventHandler(this.menuEntryCatalog_Select);
			// 
			// panelNavMainPage
			// 
			this.panelNavMainPage.Controls.Add(this.labelNavMainPage);
			this.panelNavMainPage.Location = new System.Drawing.Point(0, 3);
			this.panelNavMainPage.Name = "panelNavMainPage";
			this.panelNavMainPage.Size = new System.Drawing.Size(220, 105);
			this.panelNavMainPage.TabIndex = 3;
			this.panelNavMainPage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPage_Click);
			this.panelNavMainPage.MouseEnter += new System.EventHandler(this.menuEntryMainPage_Select);
			this.panelNavMainPage.MouseLeave += new System.EventHandler(this.menuEntryMainPage_Unselect);
			// 
			// labelNavMainPage
			// 
			this.labelNavMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNavMainPage.Location = new System.Drawing.Point(25, 6);
			this.labelNavMainPage.Name = "labelNavMainPage";
			this.labelNavMainPage.Size = new System.Drawing.Size(168, 81);
			this.labelNavMainPage.TabIndex = 2;
			this.labelNavMainPage.Text = "Pagina principală";
			this.labelNavMainPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelNavMainPage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPage_Click);
			this.labelNavMainPage.MouseEnter += new System.EventHandler(this.menuEntryMainPage_Select);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(64, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 51);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxDebug
			// 
			this.textBoxDebug.Location = new System.Drawing.Point(12, 284);
			this.textBoxDebug.Multiline = true;
			this.textBoxDebug.Name = "textBoxDebug";
			this.textBoxDebug.Size = new System.Drawing.Size(190, 90);
			this.textBoxDebug.TabIndex = 1;
			// 
			// panelContent
			// 
			this.panelContent.BackColor = System.Drawing.Color.Brown;
			this.panelContent.Controls.Add(this.panelMainPage);
			this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContent.Location = new System.Drawing.Point(220, 0);
			this.panelContent.Name = "panelContent";
			this.panelContent.Size = new System.Drawing.Size(818, 605);
			this.panelContent.TabIndex = 3;
			// 
			// panelMainPage
			// 
			this.panelMainPage.Controls.Add(this.buttonMainPageLogOut);
			this.panelMainPage.Controls.Add(this.panel2);
			this.panelMainPage.Controls.Add(this.labelMainPageAuthentificationStatus);
			this.panelMainPage.Controls.Add(this.buttonMainPageAuthentification);
			this.panelMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMainPage.Location = new System.Drawing.Point(0, 0);
			this.panelMainPage.Name = "panelMainPage";
			this.panelMainPage.Size = new System.Drawing.Size(818, 605);
			this.panelMainPage.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = global::forms_librarie_app.Properties.Resources.logo_removebg;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(138, 31);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(542, 247);
			this.panel2.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(19, 181);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(520, 41);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cartea preferată pentru fiecare";
			// 
			// labelMainPageAuthentificationStatus
			// 
			this.labelMainPageAuthentificationStatus.AutoSize = true;
			this.labelMainPageAuthentificationStatus.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMainPageAuthentificationStatus.ForeColor = System.Drawing.Color.White;
			this.labelMainPageAuthentificationStatus.Location = new System.Drawing.Point(232, 359);
			this.labelMainPageAuthentificationStatus.Name = "labelMainPageAuthentificationStatus";
			this.labelMainPageAuthentificationStatus.Size = new System.Drawing.Size(353, 34);
			this.labelMainPageAuthentificationStatus.TabIndex = 7;
			this.labelMainPageAuthentificationStatus.Text = "Vă rugăm să vă autentificați";
			// 
			// buttonMainPageAuthentification
			// 
			this.buttonMainPageAuthentification.BackColor = System.Drawing.Color.Brown;
			this.buttonMainPageAuthentification.Font = new System.Drawing.Font("Cambria", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMainPageAuthentification.ForeColor = System.Drawing.Color.White;
			this.buttonMainPageAuthentification.Location = new System.Drawing.Point(185, 408);
			this.buttonMainPageAuthentification.Name = "buttonMainPageAuthentification";
			this.buttonMainPageAuthentification.Size = new System.Drawing.Size(451, 94);
			this.buttonMainPageAuthentification.TabIndex = 6;
			this.buttonMainPageAuthentification.Text = "Autentificare";
			this.buttonMainPageAuthentification.UseVisualStyleBackColor = false;
			this.buttonMainPageAuthentification.Click += new System.EventHandler(this.buttonMainPageAthentification_Click);
			// 
			// buttonMainPageLogOut
			// 
			this.buttonMainPageLogOut.BackColor = System.Drawing.Color.Brown;
			this.buttonMainPageLogOut.Font = new System.Drawing.Font("Cambria", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMainPageLogOut.ForeColor = System.Drawing.Color.White;
			this.buttonMainPageLogOut.Location = new System.Drawing.Point(185, 408);
			this.buttonMainPageLogOut.Name = "buttonMainPageLogOut";
			this.buttonMainPageLogOut.Size = new System.Drawing.Size(451, 94);
			this.buttonMainPageLogOut.TabIndex = 9;
			this.buttonMainPageLogOut.Text = "Deconectare";
			this.buttonMainPageLogOut.UseVisualStyleBackColor = false;
			this.buttonMainPageLogOut.Click += new System.EventHandler(this.buttonMainPageLogOut_Click);
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
			this.panelNavCatalog.ResumeLayout(false);
			this.panelNavCatalog.PerformLayout();
			this.panelNavMainPage.ResumeLayout(false);
			this.panelContent.ResumeLayout(false);
			this.panelMainPage.ResumeLayout(false);
			this.panelMainPage.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelSidebar;
		private System.Windows.Forms.Panel panelNavCatalog;
		private System.Windows.Forms.Label labelNavCatalog;
		private System.Windows.Forms.TextBox textBoxDebug;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panelContent;
		private System.Windows.Forms.Panel panelNavMainPage;
		private System.Windows.Forms.Label labelNavMainPage;
		private System.Windows.Forms.Panel panelMainPage;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelMainPageAuthentificationStatus;
		private System.Windows.Forms.Button buttonMainPageAuthentification;
		private System.Windows.Forms.Button buttonMainPageLogOut;
	}
}

