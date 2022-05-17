using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace forms_librarie_app
{
	public partial class Catalog : UserControl
	{

		private HashSet<string> favouriteBooks = new HashSet<string>();

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

		public void showBookInformation(object sender)
		{
			BookInformation bookInfo = new BookInformation(this);
			bookInfo.Text = "Detalii Carte";

			DataGridView dataGrid = (DataGridView)sender;
			DataGridViewCell selectedCell = dataGrid.SelectedCells[0];
			string bookName = (string)selectedCell.Value;


			string[] list = {
				"BookName", "Price", "Publisher", "PublishYear", "Pages", "StockState", "Discount", "Type", "Genre", "ISBN", "Author"
			};

			string[] bookAttributes = LibraryDatabase.getBookAttributes(bookName);
			//string price = bookAttributes[1];
			//string publisher = bookAttributes[2];
			//string publishYear = bookAttributes[3];
			//string pages = bookAttributes[4];
			//string stockState = bookAttributes[5];
			//string discount = bookAttributes[6];
			//string type = bookAttributes[7];
			//string genre = bookAttributes[8];
			//string isbn = bookAttributes[9];
			//string author = bookAttributes[10]
			//string imagePath = bookAttributes[11]
			//string link = bookAttributes[12]

			string labelPrefix = "labelPlaceholder";
			for (int i = 0; i <= 10; ++i)
			{
				Control[] labelControl = bookInfo.Controls.Find(labelPrefix + list[i], true);
				Control ctrl = labelControl[0];
				Label label = (Label)ctrl;
				label.Text = bookAttributes[i];
			}

			string discount = bookAttributes[6];
			string price = bookAttributes[1];
			if (!string.IsNullOrEmpty((discount)))
			{
				formatDiscountControls(bookInfo, price, discount);
			}
			else
			{
				hideDiscountControls(bookInfo);
				shrinkPriceSection(bookInfo);
			}

			Control[] pictureControl = bookInfo.Controls.Find("pictureBoxPlaceholderBookImage", true);
			PictureBox picture = (PictureBox)pictureControl[0];
			string imagePath = bookAttributes[11];
			picture.Image = Image.FromFile("..\\..\\..\\" + imagePath);

			string link = bookAttributes[12];
			bookInfo.setLink(link);

			bookInfo.Show();
		}

		private void dataGridViewCarti_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			showBookInformation(sender);
		}

		private void formatDiscountControls(BookInformation bookInfo, string price, string discount)
		{
			double priceNum = double.Parse(price);
			double total =  priceNum - (double.Parse(discount) * 0.01) * priceNum;
			Control[] labelControl = bookInfo.Controls.Find("labelPlaceholderPriceWithDiscount", true);
			Label label = (Label)labelControl[0];
			label.Text = total.ToString();

			labelControl = bookInfo.Controls.Find("labelPlaceholderDiscount", true);
			label = (Label)labelControl[0];
			label.Text += "%";
		}

		private void hideDiscountControls(BookInformation bookInfo)
		{
			Control[] labelControl = bookInfo.Controls.Find("labelPriceWithDiscount", true);
			Label label = (Label)labelControl[0];
			label.Hide();

			labelControl = bookInfo.Controls.Find("labelPlaceholderPriceWithDiscount", true);
			label = (Label)labelControl[0];
			label.Hide();

			labelControl = bookInfo.Controls.Find("labelDiscount", true);
			label = (Label)labelControl[0];
			label.Hide();
		}

		private void shrinkPriceSection(BookInformation bookInfo)
		{
			Control[] panelControl = bookInfo.Controls.Find("panelPriceSection", true);
			Panel panel = (Panel)panelControl[0];
			panel.Size = new Size(80, 82);
			panel.Location = new Point(520, 416);
		}

		public bool addFavoriteBook(string bookName)
		{
			return favouriteBooks.Add(bookName);
		}

		public bool removeFavoriteBook(string bookName)
		{
			return favouriteBooks.Remove(bookName);
		}

		public bool isBookFavorite(string bookName)
		{
			return favouriteBooks.Contains(bookName);
		}

		public DataTable getFavoriteBooksTable()
		{
			DataTable table = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter();
			table.Columns.Add("Cartea");
			
			foreach (var book in favouriteBooks)
			{
				table.Rows.Add(book);
			}

			return table;
		}

    }
}
