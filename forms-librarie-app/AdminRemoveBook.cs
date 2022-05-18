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
    public partial class AdminRemoveBook : UserControl
    {
        public AdminRemoveBook()
        {
            InitializeComponent();
        }

        private void AdminRemoveBook_Load(object sender, EventArgs e)
        {
			dataGridViewBooks.DataSource = LibraryDatabase.getCarteInfoTable();
			dataGridViewBooks.Columns[0].Width = 514;
        }

		private void updateDataGridViewBooks()
		{
			dataGridViewBooks.DataSource = LibraryDatabase.getCarteInfoTable();
		}

		private void buttonRemoveBook_Click(object sender, EventArgs e)
		{
			var selectedCells = dataGridViewBooks.SelectedCells;
			List<string> booksForRemoval = new List<string>();
			foreach (DataGridViewCell cell in selectedCells)
			{
				string book = cell.Value.ToString();
				booksForRemoval.Add(book);
			}

			foreach (string book in booksForRemoval)
			{
				LibraryDatabase.removeBook(book);
			}

			updateDataGridViewBooks();
		}
	}
}
