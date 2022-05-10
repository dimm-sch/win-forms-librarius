﻿using System;
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
			string dataSource = hostname + "\\sqlserver";
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
			SqlCommand command = new SqlCommand("select * from vCartiInfo where cartea like \'" 
				+ bookName + "\'", connection);
			SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);

			return dataTable;
		}

		//public static DataRow getCarteInfoRow(string bookName)
		//{
		//	DataTable cartiInfo = getCartiInfoTable();
		//	DataRow row = cartiInfo.Rows.Find(bookName);
		//	return row;
		//}
	}
}
