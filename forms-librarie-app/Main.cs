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
		private SearchPage searchPage;
		private FavoriteBooks favoriteBooksPage;
		private Administration administrationPage;

		private Color SELECTED_COLOR = Color.FromArgb(222, 220, 82);
		private Color UNSELECTED_COLOR = Color.Empty;

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			panelNavCatalog.Cursor = Cursors.Hand;
			labelNavCatalog.Cursor = Cursors.Hand;
			panelNavMainPage.Cursor = Cursors.Hand;
			labelNavMainPage.Cursor = Cursors.Hand;
			buttonMainPageAuthentification.Cursor = Cursors.Hand;
			buttonMainPageLogOut.Cursor = Cursors.Hand;
			panelNavFavorites.Cursor = Cursors.Hand;
			panelContent.Controls.Add(catalog);
			buttonMainPageLogOut.Visible = false;

			searchPage = new SearchPage(catalog);
			favoriteBooksPage = new FavoriteBooks(catalog);
			administrationPage = new Administration();
			labelNavAdmin.Enabled = false;
			// avoid log in for testing
			authentifyUser(new UserInfo("test", "test", "Manager"));
		}

		// Events

		private void catalog_Click(object sender, MouseEventArgs e)
		{
			if (!isUserAuthentified())
			{
				MessageBox.Show("Vă rugăm să vă autentificați");
				return;
			}

			panelContent.Controls.Clear();
			panelContent.Controls.Add(catalog);
			panelContent.Show();
		}

		private void mainPage_Click(object sender, MouseEventArgs e)
		{
			if (!isUserAuthentified())
			{
				MessageBox.Show("Vă rugăm să vă autentificați");
				return;
			}

			// panelMainPage by default visible
			panelContent.Hide();
		}

		private void search_Click(object sender, MouseEventArgs e)
		{
			if (!isUserAuthentified())
			{
				MessageBox.Show("Vă rugăm să vă autentificați");
				return;
			}

			panelContent.Controls.Clear();
			panelContent.Controls.Add(searchPage);
			panelContent.Show();
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
			if (user.Role == "Manager")
            {
				labelNavAdmin.Enabled = true;
            }

			authentifiedUser = user;
			buttonMainPageAuthentification.Visible = false;
			buttonMainPageLogOut.Visible = true;
			labelMainPageAuthentificationStatus.Text = "Bine ați venit, " + user.Name + "!";
		}

		private void buttonMainPageLogOut_Click(object sender, EventArgs e)
		{
			labelNavAdmin.Enabled = false;

			authentifiedUser = null;
			buttonMainPageAuthentification.Visible = true;
			buttonMainPageLogOut.Visible = false;
			labelMainPageAuthentificationStatus.Text = "Vă rugăm să vă autentificați";
		}

		private void favorites_Click(object sender, MouseEventArgs e)
		{
			if (!isUserAuthentified())
			{
				MessageBox.Show("Vă rugăm să vă autentificați");
				return;
			}

			favoriteBooksPage.fillFavoriteBooksTable();

			panelContent.Controls.Clear();
			panelContent.Controls.Add(favoriteBooksPage);
			panelContent.Show();
		}

        private void labelNavAdmin_Click(object sender, EventArgs e)
        {
			panelContent.Controls.Clear();
			panelContent.Controls.Add(administrationPage);
			panelContent.Show();
        }
    }
}
