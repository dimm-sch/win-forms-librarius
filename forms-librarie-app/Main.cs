using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_librarie_app
{
	public partial class Main : Form
	{

		private UserInfo authentifiedUser = null;
		private Catalog catalog = new Catalog();

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			panelCatalog.Cursor = Cursors.Hand;
			labelCatalog.Cursor = Cursors.Hand;
			panelMainPage.Cursor = Cursors.Hand;
			labelMainPage.Cursor = Cursors.Hand;
			buttonMainPageAthentification.Cursor = Cursors.Hand;
			catalog.Visible = false;
			panelContent.Controls.Add(catalog);
		}

		// Events

		private void menuEntryCatalog_Select(object sender, EventArgs e)
		{
			panelCatalog.BackColor = Color.Yellow;
		}

		private void menuEntryCatalog_Unselect(object sender, EventArgs e)
		{
			panelCatalog.BackColor = Color.Empty;
		}

		private void menuEntryMainPage_Select(object sender, EventArgs e)
		{
			panelMainPage.BackColor = Color.Yellow;
		}

		private void menuEntryMainPage_Unselect(object sender, EventArgs e)
		{
			panelMainPage.BackColor = Color.Empty;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Catalog c = new Catalog();
			//panelContent.Controls.Add(c);
		}

		private void catalog_Click(object sender, MouseEventArgs e)
		{
			if (!isUserAuthentified())
			{
				MessageBox.Show("Vă rugăm să vă autentificați");
				return;
			}

			catalog.Visible = true;
		}

		private void mainPage_Click(object sender, MouseEventArgs e)
		{
			if (!isUserAuthentified())
			{
				MessageBox.Show("Vă rugăm să vă autentificați");
				return;
			}

			catalog.Visible = false;
		}

		private void buttonMainPageAthentification_Click(object sender, EventArgs e)
		{
			Authentification a = new Authentification(this);
			a.StartPosition = FormStartPosition.CenterScreen;
			a.Show();
		}

		private bool isUserAuthentified()
		{
			return authentifiedUser != null;
		}

		public void authentifyUser(UserInfo user)
		{
			authentifiedUser = user;
		}


	}
}
