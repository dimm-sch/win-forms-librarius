using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Net;

namespace forms_librarie_app
{
	class LibraryDatabase
	{

		private static SqlConnection connection = null;

		static LibraryDatabase()
		{
			string hostname = Dns.GetHostName();
			string serverName = ("win-7".Equals(hostname)) ? "sqlserver" : "sqlexpress";
			string dataSource = hostname + "\\" + serverName;
			string database = "librarius";
			string connectionString = "Data Source=" + dataSource + "; Database=" + database + "; Integrated Security = true;";
			connection = new SqlConnection(connectionString);
			connection.Open();
		}

		public static DataTable getCategoriiGenuriTable()
		{
			SqlCommand command = new SqlCommand("select denumire as [Categorie] from CategoriiGenuri", connection);
			SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);

			return dataTable;
		}

		public static DataTable getGenuriTable()
		{
			string query = "select denumire as [Gen] from Genuri";
			SqlCommand command = new SqlCommand(query, connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);

			return dataTable;
		}

		public static DataTable getGenuriTable(string categorieGen)
		{
			SqlCommand command = new SqlCommand(
				"select g.denumire as [Gen] from Genuri g" +
				" where idCategorieGen in" +
				" (select id from CategoriiGenuri" +
				" where CategoriiGenuri.denumire like '" + categorieGen + "')", connection);

			SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);

			return dataTable;
		}

		public static DataTable getCartiTable(string gen)
		{
			SqlCommand command = new SqlCommand(
			"select denumire as [Carte] from carti" +
			" where idGen = " +
			" (select id from Genuri where denumire like '" + gen + "')", connection);

			SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);

			return dataTable;
		}

		/* Cartea, Pretul cartii, Editura, Anul publicarii, nrPagini,
		Starea stocului, reducere, Tipul, Gen, isbn, author, imagePath, link */
		public static DataTable getCarteInfoTable(string bookName)
		{
			SqlCommand command = new SqlCommand("select * from vCartiInfo where cartea like N\'"
				+ bookName + "\'", connection);
			SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);

			return dataTable;
		}

		/* Get all books from database*/
		public static DataTable getCarteInfoTable()
		{
			SqlCommand command = new SqlCommand("select Cartea from vCartiInfo", connection);
			SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);

			return dataTable;
		}

		public static string[] getBookAttributes(string bookName)
		{
			DataTable carteInfo = LibraryDatabase.getCarteInfoTable(bookName);
			DataRow attributesRow = carteInfo.Rows[0];
			object[] attributes = attributesRow.ItemArray;

			const string NULL_ATTRIBUTE_MESSAGE = "nespecificat";
			const string NULL_DISCOUNT_MESSAGE = "";
			string[] bookAttributes = new string[attributes.Length];
			for (int i = 0; i < attributes.Length; ++i)
			{
				bookAttributes[i] = (!string.IsNullOrEmpty(attributes[i].ToString()))
					? attributes[i].ToString()
					: NULL_ATTRIBUTE_MESSAGE;
			}

			double price = double.Parse(bookAttributes[1]);
			string txtPrice = price.ToString("0.##");
			bookAttributes[1] = txtPrice;

			string discount = bookAttributes[6];
			if (discount.Equals(NULL_ATTRIBUTE_MESSAGE))
			{
				bookAttributes[6] = NULL_DISCOUNT_MESSAGE;
			}

			return bookAttributes;
		}

		public static DataTable searchBooksByName(string bookName)
		{
			SqlCommand command = new SqlCommand(
				"select Cartea, Autor from vCartiInfo where Cartea like \'%" + bookName + "%\'", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);

			return table;
		}

		public static DataTable searchBooksByAuthor(string author)
		{
			SqlCommand command = new SqlCommand(
				"select Cartea, Autor from vCartiInfo where Autor like \'%" + author + "%\'", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);

			return table;
		}

		public static HashSet<int> getBookIds()
		{
			SqlCommand command = new SqlCommand(
				"select id from Carti", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);

			HashSet<int> ids = new HashSet<int>();
			foreach (DataRow row in table.Rows)
			{
				int id = (int)row.ItemArray[0];
				ids.Add(id);
			}

			return ids;
		}

		public static HashSet<string> getBookPublishers()
		{
			SqlCommand command = new SqlCommand(
				"select denumire from Edituri", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);

			HashSet<string> publishers = new HashSet<string>();
			foreach (DataRow row in table.Rows)
			{
				string publisher = row.ItemArray[0].ToString().ToLower();
				publishers.Add(publisher);
			}

			return publishers;
		}

		public static HashSet<string> getBookAuthors()
		{
			SqlCommand command = new SqlCommand(
				"select Autor from vCartiInfo", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);

			HashSet<string> authors = new HashSet<string>();
			foreach (DataRow row in table.Rows)
			{
				string author = row.ItemArray[0].ToString().ToLower();
				authors.Add(author);
			}

			return authors;
		}

		public static int getAuthorId(string lastName, string firstName) 
		{
			SqlCommand command = new SqlCommand(
				$"select id from Autori where nume = '{lastName}' and prenume = '{firstName}'", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			DataRow row = table.Rows[0];

			return (int)row.ItemArray[0];
		}

		public static int getPublisherId(string publisher)
		{
			SqlCommand command = new SqlCommand(
				$"select id from Edituri where denumire = '{publisher}'", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			DataRow row = table.Rows[0];

			return (int)row.ItemArray[0];
		}

		public static int getStockStateId(string stockState)
		{
			SqlCommand command = new SqlCommand(
				$"select id from StariStoc where denumire = '{stockState}'", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			DataRow row = table.Rows[0];

			return (int)row.ItemArray[0];
		}

		public static int getBookTypeId(string type)
		{
			SqlCommand command = new SqlCommand(
				$"select id from TipuriCarti where denumire = '{type}'", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			DataRow row = table.Rows[0];

			return (int)row.ItemArray[0];
		}

		public static int getGenreId(string genre)
		{
			SqlCommand command = new SqlCommand(
				$"select id from Genuri where denumire = '{genre}'", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			DataRow row = table.Rows[0];

			return (int)row.ItemArray[0];
		}

		public static Dictionary<string, UserInfo> getSavedUsers()
		{
			string query = "select nume, parola, rol from Users";
			SqlCommand command = new SqlCommand(query, connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);

			var rows = table.Rows;
			string name;
			string password;
			string role;
			UserInfo user;
			Dictionary<string, UserInfo> users = new Dictionary<string, UserInfo>();
			foreach (DataRow row in rows)
			{
				var items = row.ItemArray;
				name = items[0].ToString();
				password = items[1].ToString();
				role = items[2].ToString();
				user = new UserInfo(name, password, role);
				users.Add(name, user);
			}

			return users;
		}

		public static void saveUser(string name, string password, string role)
		{
			string statement = $"INSERT INTO Users(nume, parola, rol) VALUES('{name}', '{password}', '{role}')";
			SqlCommand command = new SqlCommand(statement, connection);
			command.ExecuteNonQuery();
		}

		public static int addAuthor(string lastName, string firstName)
		{
			SqlCommand command = new SqlCommand("sp_addAuthor", connection);
			command.CommandType = CommandType.StoredProcedure;
			command.Parameters.Add(new SqlParameter("@lastName", lastName));
			command.Parameters.Add(new SqlParameter("@firstName", firstName));
			command.ExecuteNonQuery();

			return getAuthorId(lastName, firstName);
		}

		public static int addPublisher(string publisher)
		{
			SqlCommand command = new SqlCommand("sp_addPublisher", connection);
			command.CommandType = CommandType.StoredProcedure;
			command.Parameters.Add(new SqlParameter("@name", publisher));
			command.ExecuteNonQuery();

			return getPublisherId(publisher);
		}

		public static void addBook(
			string id, string name, string price,
			string publisherId, string publishingYear, string pages,
			string stockStateId, string discount, string typeId,
			string genreId, string isbn, string authorId)
		{
			SqlCommand command = new SqlCommand("sp_addBook", connection);
			command.CommandType = CommandType.StoredProcedure;
			command.Parameters.Add(new SqlParameter("@id", id));
			command.Parameters.Add(new SqlParameter("@name", name));
			command.Parameters.Add(new SqlParameter("@price", price));
			command.Parameters.Add(new SqlParameter("@publisherId", publisherId));
			command.Parameters.Add(new SqlParameter("@publishingYear", publishingYear));
			command.Parameters.Add(new SqlParameter("@pages", pages));
			command.Parameters.Add(new SqlParameter("@stockStateId", stockStateId));
			command.Parameters.Add(new SqlParameter("@discount", discount));
			command.Parameters.Add(new SqlParameter("@typeId", typeId));
			command.Parameters.Add(new SqlParameter("@genreId", genreId));
			command.Parameters.Add(new SqlParameter("@isbn", isbn));
			command.Parameters.Add(new SqlParameter("@authorId", authorId));

			command.ExecuteNonQuery();
		}

		public static void removeBook(string book)
		{
			SqlCommand command = new SqlCommand("sp_removeBook", connection);
			command.CommandType = CommandType.StoredProcedure;
			command.Parameters.Add(new SqlParameter("@denumireCarte", book));
			command.ExecuteNonQuery();
		}
	}
}
