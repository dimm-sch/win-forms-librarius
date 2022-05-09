using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_librarie_app
{
	public partial class Registration : Form
	{
		private static string PROJECT_ROOT_PATH = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
		private static string USERS_CREDENTIALS_PATH = PROJECT_ROOT_PATH + ".\\resources\\users-credentials.txt";
		
		private Main mainSender;


		public Registration(Main mainSender)
		{
			InitializeComponent();
			this.mainSender = mainSender;
		}

		private void saveUser(UserInfo user)
		{
			File.AppendAllText(USERS_CREDENTIALS_PATH, user.Name + " " + user.Password + " " + user.Role + "\r\n");
		}

		private void buttonSignUp_Click(object sender, EventArgs e)
		{
			string username = textBoxUserName.Text;
			string password = textBoxUserPassword.Text;
			string repeatedPassword = textBoxUserPasswordRepeated.Text;

			if (string.IsNullOrWhiteSpace(username))
			{
				MessageBox.Show("Completați câmpul \"Numele de utilizator\"!");
				return;
			}
			if (string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Completați câmpul \"Parola\"");
				return;
			}
			if (string.IsNullOrWhiteSpace(repeatedPassword))
			{
				MessageBox.Show("Completați câmpul \"Parola repetat\"");
				return;
			}

			if (username.Split(' ').Length > 1)
			{
				MessageBox.Show("Numele de utilizator trebuia să conțină doar un cuvânt. Puteți alipi cuvinte utilizând \"_\" sau \"-\"");
				return;
			}

			if (!password.Equals(repeatedPassword))
			{
				MessageBox.Show("Parolele introduse nu coincid!");
				return;
			}

			Dictionary<string, UserInfo> users = readSavedUsers();
			if (users.ContainsKey(username))
			{
				MessageBox.Show("Numele de utilizator introdus este ocupat. Vă rugăm să introduceți alt nume!");
				return;
			}

			UserInfo newUser = new UserInfo(username, password, "Client");
			saveUser(newUser);
			mainSender.authentifyUser(newUser);
			this.Close();
		}

		public static Dictionary<string, UserInfo> readSavedUsers()
		{
			string[] lines = File.ReadAllLines(USERS_CREDENTIALS_PATH);
			Dictionary<string, UserInfo> usersCredentials = new Dictionary<string, UserInfo>();

			foreach (string line in lines)
			{
				string[] words = line.Split(' ');
				string username = words[0];
				string password = words[1];
				string role = words[2];
				UserInfo user = new UserInfo(username, password, role);

				usersCredentials.Add(username, user);
			}

			return usersCredentials;
		}
	}
}
