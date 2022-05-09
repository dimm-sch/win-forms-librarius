using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_librarie_app
{
	public class UserInfo
	{

		private string name;
		private string password;
		private string role;

		public UserInfo(string name, string password, string role)
		{
			this.name = name;
			this.password = password;
			this.role = role;
		}

		public string Password { get => password; }
		public string Name { get => name; }
		public string Role { get => role; }
	}
}
