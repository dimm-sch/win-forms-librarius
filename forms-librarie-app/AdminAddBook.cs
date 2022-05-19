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
    public partial class AdminAddBook : UserControl
    {
        public AdminAddBook()
        {
            InitializeComponent();
        }


		private void AdminAddBook_Load(object sender, EventArgs e)
		{
			cBoxGenre.Items.Clear();
			DataTable genuriTable = LibraryDatabase.getGenuriTable();
			foreach (DataRow row in genuriTable.Rows)
			{
				string genre = row.ItemArray[0].ToString();
				cBoxGenre.Items.Add(genre);
			}

			// set default values for combo boxes
			cBoxStockState.SelectedIndex = 1;
			cBoxType.SelectedIndex = 0;
			cBoxGenre.SelectedIndex = 0;

			// set isbn constraint
			tBoxISBN.MaxLength = 13;

			// set publisher to lowercase
			tBoxPublisher.CharacterCasing = CharacterCasing.Lower;

		}

		private int findAvailableBookId()
        {
			for (int id = 1; id <= int.MaxValue; ++id)
            {
				var ids = LibraryDatabase.getBookIds();
				if (!ids.Contains(id))
                {
					return id;
                }
			}

			return -1;
        }

		private bool checkPrice(string txtPrice)
		{
			if (string.IsNullOrWhiteSpace(tBoxPrice.Text))
			{
				MessageBox.Show("Completați câmpul Preț!");
				return false;
			}

			double price;
			if (!double.TryParse(txtPrice, out price))
			{
				MessageBox.Show("Prețul introdus nu este un număr!");
				return false;
			}

			return true;
		}

		private bool checkPublishingYear(string txtYear)
		{
			if (string.IsNullOrWhiteSpace(txtYear))
			{
				MessageBox.Show("Completați câmpul An Publicare!");
				return false;
			}

			int year;
			if (!int.TryParse(txtYear, out year) 
					|| ((year <= 1500) || (year > 2023)))
			{
				MessageBox.Show("An Publicare introdus nu este valid!");
				return false;
			}

			return true;
		}

		private bool checkPages(string txtPages)
		{
			if (string.IsNullOrWhiteSpace(txtPages))
			{
				MessageBox.Show("Completați câmpul Pagini!");
				return false;
			}

			int pages;
			if (!int.TryParse(txtPages, out pages))
			{
				MessageBox.Show("Câmpul Pagini nu conține un număr întreg valid!");
				return false;
			}

			return true;
		}

		private bool checkDiscount(string txtDiscount)
		{
			if (string.IsNullOrWhiteSpace(txtDiscount))
			{
				MessageBox.Show("Completați câmpul Reducere!");
				return false;
			}

			int discount;
			if (!int.TryParse(txtDiscount, out discount) 
					|| (discount < 1) || (discount > 100))
			{
				MessageBox.Show("Câmpul Reducere nu conține un număr valid de reducere!");
				return false;
			}

			return true;
		}

		private bool checkISBN(string isbn)
		{
			if (string.IsNullOrWhiteSpace(isbn))
			{
				MessageBox.Show("Completați câmpul ISBN!");
				return false;
			}

			long isbnNumber;
			if (!long.TryParse(isbn, out isbnNumber))
			{
				MessageBox.Show("ISBN trebuie să conțină doar cifre!");
				return false;
			}

			if (isbn.Length < 13)
			{
				MessageBox.Show("ISBN trebuie să conțină exact 13 cifre!");
				return false;
			}

			return true;
		}

		private bool checkAuthor(string author)
		{
			if (string.IsNullOrWhiteSpace(author))
			{
				MessageBox.Show("Completați câmpul Autor!");
				return false;
			}
			if (author.Split(' ').Length < 2)
			{
				MessageBox.Show("Introduceți numele și prenumele autorului separat prin spațiu!");
				return false;
			}

			return true;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tBoxName.Text))
			{
				MessageBox.Show("Completați câmpul Denumire!");
				return;
			}
			if (!checkPrice(tBoxPrice.Text))
			{
				tBoxPrice.Clear();
				return;
			}
			if (string.IsNullOrWhiteSpace(tBoxPublisher.Text))
			{
				MessageBox.Show("Completați câmpul Editura!");
				return;
			}
			if (!checkPublishingYear(tBoxPublishingYear.Text))
			{
				tBoxPublishingYear.Clear();
				return;
			}
			if (!checkPages(tBoxPages.Text))
			{
				tBoxPages.Clear();
				return;
			}
			
			if (checkBoxNoDiscount.CheckState.Equals(CheckState.Unchecked))
			{
				if (!checkDiscount(tBoxDiscount.Text))
				{
					tBoxDiscount.Clear();
					return;
				}
			}
			
			if (!checkISBN(tBoxISBN.Text))
			{
				tBoxISBN.Clear();
				return;
			}	
			if (!checkAuthor(tBoxAuthor.Text))
			{
				tBoxAuthor.Clear();
				return;
			}

			bool isPublisherAdded = false;
			var publishers = LibraryDatabase.getBookPublishers();
			if (publishers.Contains(tBoxPublisher.Text))
			{
				isPublisherAdded = true;
			}

			bool isAuthorAdded = false;
			var authors = LibraryDatabase.getBookAuthors();
			if (authors.Contains(tBoxAuthor.Text))
			{
				isAuthorAdded = true;
			}

			string id = findAvailableBookId().ToString();
			string name = tBoxName.Text;
			string price = tBoxPrice.Text;
			string publisherId = (isPublisherAdded) 
				? LibraryDatabase.getPublisherId(tBoxPublisher.Text).ToString() 
				: LibraryDatabase.addPublisher(tBoxPublisher.Text).ToString();
			string publishingYear = tBoxPublishingYear.Text;
			string pages = tBoxPages.Text;
			string stockStateId = LibraryDatabase.getStockStateId(cBoxStockState.Text).ToString();
			string discount = tBoxDiscount.Text;
			if (checkBoxNoDiscount.CheckState.Equals(CheckState.Checked))
			{
				discount = "0";
			}
			string typeId = LibraryDatabase.getBookTypeId(cBoxType.Text).ToString();
			string genreId = LibraryDatabase.getGenreId(cBoxGenre.Text).ToString();
			string isbn = tBoxISBN.Text;

			string[] author = tBoxAuthor.Text.Split(' ');
			string authorLastName = author[0];
			string authorFirstName = author[1];
			string authorId = (isAuthorAdded)
				? LibraryDatabase.getAuthorId(authorLastName, authorFirstName).ToString()
				: LibraryDatabase.addAuthor(authorLastName, authorFirstName).ToString();

			LibraryDatabase.addBook(id, name, price, publisherId, publishingYear, pages, stockStateId, discount, typeId, genreId, isbn, authorId);

			MessageBox.Show($"Cartea '{name}' a fost adăugată cu success în baza de date!");
			clearInputControls();

		}

		private void clearInputControls()
		{
			tBoxName.Clear();
			tBoxPrice.Clear();
			tBoxPublisher.Clear();
			tBoxPublishingYear.Clear();
			tBoxPages.Clear();
			tBoxDiscount.Clear();
			tBoxISBN.Clear();
			tBoxAuthor.Clear();
		}

		private void checkBoxNoDiscount_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxNoDiscount.CheckState.Equals(CheckState.Checked))
			{
				tBoxDiscount.Clear();
				tBoxDiscount.Enabled = false;
			} else
			{
				tBoxDiscount.Enabled = true;
			}
		}

    }
}
