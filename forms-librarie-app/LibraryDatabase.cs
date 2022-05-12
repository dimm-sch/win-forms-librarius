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

		public static DataTable getGenuriTable(string categorieGen)
		{
			SqlCommand command = new SqlCommand(
				"select g.denumire as [Gen] from Genuri g" +
				" where idCategorieGen in" +
				" (select id from CategoriiGenuri" +
				" where CategoriiGenuri.denumire like '"+ categorieGen + "')", connection);

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
		Starea stocului, reducere, Tipul, Gen, isbn */
		public static DataTable getCarteInfoTable(string bookName)
		{
			SqlCommand command = new SqlCommand("select * from vCartiInfo where cartea like N\'" 
				+ bookName + "\'", connection);
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

			string discount = bookAttributes[6];
			if (discount.Equals(NULL_ATTRIBUTE_MESSAGE))
			{
				bookAttributes[6] = NULL_DISCOUNT_MESSAGE;
			}

			return bookAttributes;
		}

	}
}
