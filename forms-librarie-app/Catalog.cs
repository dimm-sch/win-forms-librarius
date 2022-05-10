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
	public partial class Catalog : UserControl
	{
		public Catalog()
		{
			InitializeComponent();
		}

		private void Catalog_Load(object sender, EventArgs e)
		{
			dataGridViewCategoriiGenuri.DataSource = LibraryDatabase.getCategoriiGenuriTable();
			dataGridViewCategoriiGenuri.Columns[0].Width = 330;
		}

		private void dataGridViewCategoriiGenuri_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridViewCarti.DataSource = null;

			string categorieGen = dataGridViewCategoriiGenuri.SelectedCells[0].Value.ToString();

			DataTable genuriTable = LibraryDatabase.getGenuriTable(categorieGen);
			dataGridViewGenuri.ClearSelection();
			dataGridViewGenuri.CurrentCell = null;
			dataGridViewGenuri.DataSource = genuriTable;
			dataGridViewGenuri.Columns[0].Width = 300;
		}

		private void dataGridViewGenuri_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string gen = dataGridViewGenuri.SelectedCells[0].Value.ToString();

			DataTable cartiTable = LibraryDatabase.getCartiTable(gen);
			dataGridViewCarti.ClearSelection();
			dataGridViewCarti.CurrentCell = null;
			dataGridViewCarti.DataSource = cartiTable;
			dataGridViewCarti.Columns[0].Width = 450;
		}

		private void dataGridViewCarti_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BookInformation bookInfo = new BookInformation();

			DataGridView dataGrid = (DataGridView)sender;
			DataGridViewCell selectedCell = dataGrid.SelectedCells[0];
			string bookName = (string)selectedCell.Value;

			Control[] control;
			control = bookInfo.Controls.Find("labelPlaceholderBookName", false);
			Label labelBookName = (Label)control[0];
			labelBookName.Text = bookName;

			DataTable carteInfo = LibraryDatabase.getCarteInfoTable(bookName);
			DataRow attributesRow = carteInfo.Rows[0];
			object[] attributes = attributesRow.ItemArray;
			
			const string NULL_ATTRIBUTE_MESSAGE = "nespecificat";
			string[] stringAttributes = new string[attributes.Length];
			for (int i = 0; i < attributes.Length; ++i)
			{
				stringAttributes[i] = (!string.IsNullOrEmpty(attributes[i].ToString()))
					? attributes[i].ToString() 
					: NULL_ATTRIBUTE_MESSAGE;
			}

			string price = stringAttributes[1];
			string publisher = stringAttributes[2];
			string publishYear = stringAttributes[3];
			string pages = stringAttributes[4];
			string stockState = stringAttributes[5];
			string discount = stringAttributes[6];
			string type = stringAttributes[7];
			string genre = stringAttributes[8];
			string isbn = stringAttributes[9];

			string output = "";
			foreach (var elm in stringAttributes)
			{
				output += elm + "\r\n";
			}

			MessageBox.Show(output);

			/* TODO: maybe return the stringAttributes from separate method (either declared here or in LibraryDatabase)
				possible signature: string[] getBookAttributes(string bookName) 
			*/


			//string pret = (string)carteProperties[1].; 

			//control = bookInfo.Controls.Find("labelPlaceholderAuthor", false);
			//Label labelAuthor = (Label)control[0];
			//labelAuthor.Text = pret;

			//bookInfo.Show();
		}
	}
}
