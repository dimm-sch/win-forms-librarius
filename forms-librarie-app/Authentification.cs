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
	public partial class Authentification : Form
	{

		private Main mainSender;

		public Authentification(Main mainSender)
		{
			InitializeComponent();
			this.mainSender = mainSender;
		}

		private void Authentification_Load(object sender, EventArgs e)
		{
			comboBoxLoginType.SelectedItem = comboBoxLoginType.Items[0]; // Client
			buttonLogIn.Cursor = Cursors.Hand;
			this.MaximumSize = this.Size;
			this.MinimumSize = this.Size;
		}

		private void buttonLogIn_Click(object sender, EventArgs e)
		{
			Dictionary<string, UserInfo> usersCredentials = LibraryDatabase.getSavedUsers();

			string username = textBoxUserName.Text;
			string password = textBoxUserPassword.Text;

			if (String.IsNullOrWhiteSpace(username))
			{
				MessageBox.Show("Completați câmpul \"Numele de utilizator\"");
				return;
			}
			if (String.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Completați câmpul \"Parola\"");
				return;
			}

			if (username.Split(' ').Length > 1)
			{
				MessageBox.Show("Numele de utilizator nu trebuie să conțină spații. Puteți alipi cuvinte utilizând \"_\" sau \"-\"");
				return;
			}

			if (!usersCredentials.ContainsKey(username))
			{
				MessageBox.Show("Numele de utilizator introdus nu există!");
				return;
			}

			UserInfo foundUser = usersCredentials[username];
			if (!password.Equals(foundUser.Password))
			{
				MessageBox.Show("Parola introdusă este incorectă!");
				textBoxUserPassword.Clear();
				return;
			}

			string loginType = comboBoxLoginType.SelectedItem.ToString();
			if (!loginType.Equals(foundUser.Role))
			{
				MessageBox.Show("Acest cont nu are permisiuni de " + comboBoxLoginType.Text);
				return;
			}

			this.mainSender.authentifyUser(foundUser);
			this.Close();
		}

		private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Registration r = new Registration(mainSender);
			r.StartPosition = FormStartPosition.CenterScreen;
			r.Show();
			this.Close();
		}

	}
}
