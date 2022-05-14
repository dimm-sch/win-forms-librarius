using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_librarie_app
{
	public partial class FavoriteBooks : UserControl
	{
		private Catalog catalog;

		public FavoriteBooks(Catalog catalog)
		{
			this.catalog = catalog;
			InitializeComponent();
		}

		private void FavoriteBooks_Load(object sender, EventArgs e)
		{
			dataGridViewFavoriteBooks.Columns[0].Width = 625;
		}

		public void fillFavoriteBooksTable()
		{
			dataGridViewFavoriteBooks.DataSource = catalog.getFavoriteBooksTable();
		}

		private void dataGridViewFavoriteBooks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			catalog.showBookInformation(sender);
		}
	}
}
