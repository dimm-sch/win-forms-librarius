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
	public partial class BookInformation : Form
	{
		private string link;
		private Catalog catalog;
		private FavoriteBooks favoriteBooksPage;

		public BookInformation(Catalog catalog, FavoriteBooks favoriteBooksPage)
		{
			this.catalog = catalog;
			this.favoriteBooksPage = favoriteBooksPage;
			InitializeComponent();
		}

		public void setLink(string link)
        {
			this.link = link;
        }

		private void BookInformation_Load(object sender, EventArgs e)
		{
			buttonAddFavorite.Cursor = Cursors.Hand;
			labelPlaceholderBookName.Cursor = Cursors.Hand;
			buttonDeleteFavorite.Hide();
			buttonDeleteFavorite.Cursor = Cursors.Hand;
			this.MaximumSize = this.Size;
			this.MinimumSize = this.Size;

			if (catalog.isBookFavorite(labelPlaceholderBookName.Text))
			{
				buttonAddFavorite.Hide();
				buttonDeleteFavorite.Show();
			}
		}

		private void buttonAddFavorite_MouseHover(object sender, EventArgs e)
		{
			buttonAddFavorite.BackColor = Color.FromArgb(73, 232, 56);
		}

		private void buttonAddFavorite_MouseLeave(object sender, EventArgs e)
		{
			buttonAddFavorite.BackColor = Color.Brown;
		}

        private void labelPlaceholderBookName_Click(object sender, EventArgs e)
        {
			System.Diagnostics.Process.Start(link);
		}

		private void buttonAddFavorite_Click(object sender, EventArgs e)
		{
			if (catalog.addFavoriteBook(labelPlaceholderBookName.Text))
			{
				buttonAddFavorite.Hide();
				buttonDeleteFavorite.Show();
			}
		}

		private void buttonDeleteFavorite_Click(object sender, EventArgs e)
		{
			if (catalog.removeFavoriteBook(labelPlaceholderBookName.Text))
			{
				buttonAddFavorite.Show();
				buttonDeleteFavorite.Hide();
				favoriteBooksPage.fillFavoriteBooksTable();
			} else
			{
				throw new NotSupportedException("Unexpected behaviour.");
			}
		}

		private void buttonDeleteFavorite_MouseHover(object sender, EventArgs e)
		{
			buttonDeleteFavorite.BackColor = Color.Red;
		}

		private void buttonDeleteFavorite_MouseLeave(object sender, EventArgs e)
		{
			buttonDeleteFavorite.BackColor = Color.Brown;
		}
	}
}
