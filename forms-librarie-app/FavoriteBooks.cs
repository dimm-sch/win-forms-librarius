using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronXL;
using IronXL.Styles;

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
			IronXL.License.LicenseKey = "IRONXL.DUMITRUCEITI.18955-187FF7CBA2-D5TB2Z-5SZCWEMNKGLQ-P4IPFW4TVPJD-QO5R6VNO4VSP-MEAQCETEMFIJ-Q6S5DRLJNTKW-BEVGPL-T43W7I6FH72FUA-DEPLOYMENT.TRIAL-6N3MDI.TRIAL.EXPIRES.14.JUN.2022";
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

		private WorkSheet initializeWorkBook()
		{
			WorkBook workBook = WorkBook.Create(ExcelFileFormat.XLSX);
			var sheet = workBook.CreateWorkSheet("Cărți favorite");

			string librarius = "D2:E2";
			sheet[librarius].Value = "Librarius";
			sheet[librarius].Style.Font.Bold = true;
			sheet[librarius].Style.Font.Height = 20;
			sheet.Merge(librarius);

			sheet["B5"].Value = "Carte";
			sheet["C5"].Value = "Autor";
			sheet["D5"].Value = "Editura";
			sheet["E5"].Value = "Anul";
			sheet["F5"].Value = "Pagini";
			sheet["G5"].Value = "Gen";
			sheet["H5"].Value = "ISBN";
			sheet["I5"].Value = "Preț";
			
			string tableNameRange = "B4:I4";
			var tableName = sheet[tableNameRange];
			tableName.Value = "Cărți favorite";
			tableName.Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
			tableName.Style.Font.Bold = true;
			wrapCellWithBorders(sheet, tableNameRange, BorderType.Thin);
			sheet.Merge(tableNameRange);

			var header = sheet["B5:I5"];
			header.Style.Font.Bold = true;
			wrapCellWithBorders(sheet, "B5:I5", BorderType.Thin);
			header.Style.ShrinkToFit = true;

			return sheet;
		}

		private void writeDateToWorkSheet(WorkSheet sheet)
		{
			int startDataRow = 6;
			int rowCounter = fetchFavoriteBooks().Length;
			int offset = 2;
			int dateRowNumber = rowCounter + startDataRow + offset;
			char dateRowLetter = 'B';
			string dateCellLocation = dateRowLetter.ToString() + dateRowNumber.ToString();

			string date = DateTime.Now.ToString("MM/dd/yyyy H:mm");
			string dateCellContent = $"Data exportării: {date}";
			sheet[dateCellLocation].Value = dateCellContent;
		}

		private string[] fetchFavoriteBooks()
		{
			var rows = dataGridViewFavoriteBooks.Rows;
			string[] favoriteBooks = new string[rows.Count];
			string bookName = "";

			for (int i = 0; i < rows.Count; ++i)
			{
				bookName = rows[i].Cells[0].Value.ToString();
				favoriteBooks[i] = bookName;
			}

			return favoriteBooks;
		}

		private string[] prepareAttributesForExport(string[] attributes)
		{
			string[] exportAttributes = new string[8];
			int[] requiredAttributesIndex = new int[] { 0, 10, 2, 3, 4, 8, 9, 1 };

			for (int i = 0; i < exportAttributes.Length; ++i)
			{
				exportAttributes[i] = attributes[requiredAttributesIndex[i]];
			}

			return exportAttributes;
		}


		private void wrapCellWithBorders(WorkSheet sheet, string cell, BorderType borderType)
		{
			var c = sheet[cell];
			c.Style.LeftBorder.Type = borderType;
			c.Style.TopBorder.Type = borderType;
			c.Style.RightBorder.Type = borderType;
			c.Style.BottomBorder.Type = borderType;
		}

		private void addRowToExportSheet(WorkSheet sheet, string[] exportAttributes, int rowIndex)
		{
			if (rowIndex < 0)
			{
				MessageBox.Show("Eroare: Index Negativ.");
				return;
			}
				 
			int firstRowNumber = 6;
			int rowNumber = firstRowNumber + rowIndex;
			string[] columnLetters = new string[] {"B", "C", "D", "E", "F", "G", "H", "I"};

			for (int i = 0; i < columnLetters.Length; ++i)
			{
				string cell = columnLetters[i] + rowNumber;
				sheet[cell].Value = exportAttributes[i];
				wrapCellWithBorders(sheet, cell, BorderType.Thin);

				// styling
				var c = sheet[cell];
				c.Style.VerticalAlignment = VerticalAlignment.Center;
			}

			string bookName = exportAttributes[0];
			if (bookName.Length > 30)
			{
				int rows = sheet.Rows.Length;
				sheet.Rows[rows - 1].Height = 1300;
				sheet["B" + rowNumber].Style.WrapText = true;
			}

		}


		private void buttonExport_Click(object sender, EventArgs e)
		{
			var sheet = initializeWorkBook();
			var favoriteBooks = fetchFavoriteBooks();

			int rowCounter = 0;
			foreach (var book in favoriteBooks)
			{
				string[] attributes = LibraryDatabase.getBookAttributes(book);
				string[] exportAttributes = prepareAttributesForExport(attributes);
				addRowToExportSheet(sheet, exportAttributes, rowCounter);
				++rowCounter;
			}

			writeDateToWorkSheet(sheet);
			try
			{
				sheet.SaveAs("carti_favorite.xlsx");
				MessageBox.Show("Datele au fost exportate!");
			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
