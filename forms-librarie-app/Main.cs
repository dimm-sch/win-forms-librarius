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

			// avoid log in for testing
			authentifyUser(new UserInfo("test", "test", "test"));
		}

		// Events

		private void menuEntryCatalog_Select(object sender, EventArgs e)
		{
			panelNavCatalog.BackColor = Color.Yellow;
		}

		private void menuEntryCatalog_Unselect(object sender, EventArgs e)
		{
			panelNavCatalog.BackColor = Color.Empty;
		}

		private void menuEntryMainPage_Select(object sender, EventArgs e)
		{
			panelNavMainPage.BackColor = Color.Yellow;
		}

		private void menuEntryMainPage_Unselect(object sender, EventArgs e)
		{
			panelNavMainPage.BackColor = Color.Empty;
		}

		private void menuEntrySearch_Select(object sender, EventArgs e)
		{
			panelNavSearch.BackColor = Color.Yellow;
		}

		private void menuEntrySearch_Unselect(object sender, EventArgs e)
		{
			panelNavSearch.BackColor = Color.Empty;
		}

		// TODO remove
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
			authentifiedUser = user;
			buttonMainPageAuthentification.Visible = false;
			buttonMainPageLogOut.Visible = true;
			labelMainPageAuthentificationStatus.Text = "Bine ați venit, " + user.Name + "!";
		}

		private void buttonMainPageLogOut_Click(object sender, EventArgs e)
		{
			authentifiedUser = null;
			buttonMainPageAuthentification.Visible = true;
			buttonMainPageLogOut.Visible = false;
			labelMainPageAuthentificationStatus.Text = "Vă rugăm să vă autentificați";
		}

		private void labelNavSearch_Click(object sender, EventArgs e)
		{
			
		}

		private void menuEntryFavorites_Select(object sender, EventArgs e)
		{
			panelNavFavorites.BackColor = Color.Yellow;
		}

		private void menuEntryFavorites_Unselect(object sender, EventArgs e)
		{
			panelNavFavorites.BackColor = Color.Empty;
		}

		private void menuEntryAdmin_Select(object sender, EventArgs e)
		{
			panelNavAdmin.BackColor = Color.Yellow;
		}

		private void menuEntryAdmin_Unselect(object sender, EventArgs e)
		{
			panelNavAdmin.BackColor = Color.Empty;
		}

		private void favorites_Click(object sender, MouseEventArgs e)
		{
			favoriteBooksPage.fillFavoriteBooksTable();

			panelContent.Controls.Clear();
			panelContent.Controls.Add(favoriteBooksPage);
			panelContent.Show();
		}
	}
}
