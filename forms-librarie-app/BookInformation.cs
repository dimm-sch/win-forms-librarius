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
	public partial class BookInformation : Form
	{
		private string link;

		public BookInformation()
		{
			InitializeComponent();
		}

		public void setLink(string link)
        {
			this.link = link;
        }

		private void BookInformation_Load(object sender, EventArgs e)
		{
			buttonAddFavorite.Cursor = Cursors.Hand;
			labelPlaceholderBookName.Cursor = Cursors.Hand;
		}

		private void buttonAddFavorite_MouseHover(object sender, EventArgs e)
		{
			buttonAddFavorite.BackColor = Color.Crimson;
		}

		private void buttonAddFavorite_MouseLeave(object sender, EventArgs e)
		{
			buttonAddFavorite.BackColor = Color.Brown;
		}

        private void labelPlaceholderBookName_Click(object sender, EventArgs e)
        {
			System.Diagnostics.Process.Start(link);
		}
    }
}
