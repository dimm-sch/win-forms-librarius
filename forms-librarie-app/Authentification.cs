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

		private Dictionary<string, UserInfo> usersCredentials = new Dictionary<string, UserInfo>();
		private Main sender;

		public Authentification(Main sender)
		{
			InitializeComponent();
			this.sender = sender;
		}

		private void Authentification_Load(object sender, EventArgs e)
		{
			comboBoxLoginType.SelectedItem = comboBoxLoginType.Items[0]; // Client
			buttonLogIn.Cursor = Cursors.Hand;
		}

		private void buttonLogIn_Click(object sender, EventArgs e)
		{
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

			if (!usersCredentials.ContainsKey(username))
			{
				MessageBox.Show("Numele de utilizator introdus nu există!");
				return;
			}

			UserInfo foundUser = usersCredentials[username];
			if (!password.Equals(foundUser.Password))
			{
				MessageBox.Show("Parola introdusă este incorectă!");
				return;
			}

			string loginType = comboBoxLoginType.SelectedItem.ToString();
			if (!loginType.Equals(foundUser.Role))
			{
				MessageBox.Show("Acest cont nu are permisiuni de " + foundUser.Role);
				return;
			}

			this.sender.authentifyUser(foundUser);
			this.Close();
		}
	}
}
