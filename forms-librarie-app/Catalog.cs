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

		private void dataGridViewCarti_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			BookInformation bookInfo = new BookInformation();
			Control[] label1Control = bookInfo.Controls.Find("label1", false);
			Label label = (Label) label1Control[0];
			label.Text = "You found me!";

			bookInfo.Show();
		}
	}
}
