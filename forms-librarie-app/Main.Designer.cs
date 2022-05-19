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
            this.panelNavAdmin = new System.Windows.Forms.Panel();
            this.labelNavAdmin = new System.Windows.Forms.Label();
            this.panelNavFavorites = new System.Windows.Forms.Panel();
            this.labelNavFavorites = new System.Windows.Forms.Label();
            this.panelNavSearch = new System.Windows.Forms.Panel();
            this.labelNavSearch = new System.Windows.Forms.Label();
            this.panelNavCatalog = new System.Windows.Forms.Panel();
            this.labelNavCatalog = new System.Windows.Forms.Label();
            this.panelNavMainPage = new System.Windows.Forms.Panel();
            this.labelNavMainPage = new System.Windows.Forms.Label();
            this.panelMainPage = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.buttonMainPageLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMainPageAuthentificationStatus = new System.Windows.Forms.Label();
            this.buttonMainPageAuthentification = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelNavAdmin.SuspendLayout();
            this.panelNavFavorites.SuspendLayout();
            this.panelNavSearch.SuspendLayout();
            this.panelNavCatalog.SuspendLayout();
            this.panelNavMainPage.SuspendLayout();
            this.panelMainPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSidebar.Controls.Add(this.panelNavAdmin);
            this.panelSidebar.Controls.Add(this.panelNavFavorites);
            this.panelSidebar.Controls.Add(this.panelNavSearch);
            this.panelSidebar.Controls.Add(this.panelNavCatalog);
            this.panelSidebar.Controls.Add(this.panelNavMainPage);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 604);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelNavAdmin
            // 
            this.panelNavAdmin.Controls.Add(this.labelNavAdmin);
            this.panelNavAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavAdmin.Location = new System.Drawing.Point(0, 501);
            this.panelNavAdmin.Name = "panelNavAdmin";
            this.panelNavAdmin.Size = new System.Drawing.Size(220, 105);
            this.panelNavAdmin.TabIndex = 6;
            // 
            // labelNavAdmin
            // 
            this.labelNavAdmin.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNavAdmin.Location = new System.Drawing.Point(12, 8);
            this.labelNavAdmin.Name = "labelNavAdmin";
            this.labelNavAdmin.Size = new System.Drawing.Size(202, 89);
            this.labelNavAdmin.TabIndex = 1;
            this.labelNavAdmin.Text = "Administrare";
            this.labelNavAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNavAdmin.Click += new System.EventHandler(this.labelNavAdmin_Click);
            // 
            // panelNavFavorites
            // 
            this.panelNavFavorites.Controls.Add(this.labelNavFavorites);
            this.panelNavFavorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavFavorites.Location = new System.Drawing.Point(0, 310);
            this.panelNavFavorites.Name = "panelNavFavorites";
            this.panelNavFavorites.Size = new System.Drawing.Size(220, 105);
            this.panelNavFavorites.TabIndex = 5;
            this.panelNavFavorites.MouseClick += new System.Windows.Forms.MouseEventHandler(this.favorites_Click);
            // 
            // labelNavFavorites
            // 
            this.labelNavFavorites.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNavFavorites.Location = new System.Drawing.Point(35, 8);
            this.labelNavFavorites.Name = "labelNavFavorites";
            this.labelNavFavorites.Size = new System.Drawing.Size(151, 89);
            this.labelNavFavorites.TabIndex = 1;
            this.labelNavFavorites.Text = "Cărți Favorite";
            this.labelNavFavorites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNavFavorites.MouseClick += new System.Windows.Forms.MouseEventHandler(this.favorites_Click);
            // 
            // panelNavSearch
            // 
            this.panelNavSearch.Controls.Add(this.labelNavSearch);
            this.panelNavSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavSearch.Location = new System.Drawing.Point(0, 205);
            this.panelNavSearch.Name = "panelNavSearch";
            this.panelNavSearch.Size = new System.Drawing.Size(220, 105);
            this.panelNavSearch.TabIndex = 4;
            this.panelNavSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search_Click);
            // 
            // labelNavSearch
            // 
            this.labelNavSearch.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNavSearch.Location = new System.Drawing.Point(35, 8);
            this.labelNavSearch.Name = "labelNavSearch";
            this.labelNavSearch.Size = new System.Drawing.Size(151, 89);
            this.labelNavSearch.TabIndex = 1;
            this.labelNavSearch.Text = "Căutare";
            this.labelNavSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNavSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search_Click);
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
            // 
            // labelNavCatalog
            // 
            this.labelNavCatalog.AutoSize = true;
            this.labelNavCatalog.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNavCatalog.Location = new System.Drawing.Point(48, 34);
            this.labelNavCatalog.Name = "labelNavCatalog";
            this.labelNavCatalog.Size = new System.Drawing.Size(120, 37);
            this.labelNavCatalog.TabIndex = 1;
            this.labelNavCatalog.Text = "Catalog";
            this.labelNavCatalog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.catalog_Click);
            // 
            // panelNavMainPage
            // 
            this.panelNavMainPage.Controls.Add(this.labelNavMainPage);
            this.panelNavMainPage.Location = new System.Drawing.Point(0, 3);
            this.panelNavMainPage.Name = "panelNavMainPage";
            this.panelNavMainPage.Size = new System.Drawing.Size(220, 105);
            this.panelNavMainPage.TabIndex = 3;
            this.panelNavMainPage.Click += new System.EventHandler(this.mainPage_Click);
            // 
            // labelNavMainPage
            // 
            this.labelNavMainPage.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNavMainPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNavMainPage.Location = new System.Drawing.Point(25, 6);
            this.labelNavMainPage.Name = "labelNavMainPage";
            this.labelNavMainPage.Size = new System.Drawing.Size(168, 81);
            this.labelNavMainPage.TabIndex = 2;
            this.labelNavMainPage.Text = "Pagina principală";
            this.labelNavMainPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNavMainPage.Click += new System.EventHandler(this.mainPage_Click);
            // 
            // panelMainPage
            // 
            this.panelMainPage.Controls.Add(this.panelContent);
            this.panelMainPage.Controls.Add(this.buttonMainPageLogOut);
            this.panelMainPage.Controls.Add(this.panel2);
            this.panelMainPage.Controls.Add(this.labelMainPageAuthentificationStatus);
            this.panelMainPage.Controls.Add(this.buttonMainPageAuthentification);
            this.panelMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainPage.Location = new System.Drawing.Point(220, 0);
            this.panelMainPage.Name = "panelMainPage";
            this.panelMainPage.Size = new System.Drawing.Size(818, 604);
            this.panelMainPage.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.BurlyWood;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(818, 604);
            this.panelContent.TabIndex = 10;
            this.panelContent.Visible = false;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1038, 604);
            this.Controls.Add(this.panelMainPage);
            this.Controls.Add(this.panelSidebar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1054, 643);
            this.MinimumSize = new System.Drawing.Size(1054, 643);
            this.Name = "Main";
            this.Text = "Librarius";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelNavAdmin.ResumeLayout(false);
            this.panelNavFavorites.ResumeLayout(false);
            this.panelNavSearch.ResumeLayout(false);
            this.panelNavCatalog.ResumeLayout(false);
            this.panelNavCatalog.PerformLayout();
            this.panelNavMainPage.ResumeLayout(false);
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
		private System.Windows.Forms.Panel panelNavMainPage;
		private System.Windows.Forms.Label labelNavMainPage;
		private System.Windows.Forms.Panel panelNavSearch;
		private System.Windows.Forms.Label labelNavSearch;
		private System.Windows.Forms.Panel panelMainPage;
		private System.Windows.Forms.Button buttonMainPageLogOut;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelMainPageAuthentificationStatus;
		private System.Windows.Forms.Button buttonMainPageAuthentification;
		private System.Windows.Forms.Panel panelNavFavorites;
		private System.Windows.Forms.Label labelNavFavorites;
		private System.Windows.Forms.Panel panelNavAdmin;
		private System.Windows.Forms.Label labelNavAdmin;
        private System.Windows.Forms.Panel panelContent;
    }
}

