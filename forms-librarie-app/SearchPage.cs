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
	public partial class SearchPage : UserControl
	{

		private Catalog catalog;

		public SearchPage(Catalog catalog)
		{
			this.catalog = catalog;
			InitializeComponent();
		}

		private void SearchPage_Load(object sender, EventArgs e)
		{
			
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			executeSearchQuery();
		}

		private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar.Equals((char)13))
			{
				executeSearchQuery();
			}
		}

		private void executeSearchQuery()
		{
			if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
			{
				MessageBox.Show("Completați bara de căutare!");
				return;
			}

			string request = textBoxSearch.Text;
			DataTable result = null;
			if (radioButtonFilterName.Checked)
			{
				result = LibraryDatabase.searchBooksByName(request);
			}
			if (radioButtonFilterAuthor.Checked)
			{
				result = LibraryDatabase.searchBooksByAuthor(request);
			}

			dataGridViewResult.DataSource = result;
			dataGridViewResult.Columns[0].Width = 322;
			dataGridViewResult.Columns[1].Width = 202;
		}

		private void dataGridViewResult_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var data = (DataGridView)sender;
			string colName = data.Columns[data.CurrentCell.ColumnIndex].Name;

			if (colName.Equals("Cartea"))
			{
				catalog.showBookInformation(sender);
			}
		}
	}
}
