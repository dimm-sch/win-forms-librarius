using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_librarie_app
{
	public partial class Administration : UserControl
	{

		private AdminAddBook addBookPage = new AdminAddBook();
		private AdminRemoveBook removeBookPage = new AdminRemoveBook();

		public Administration()
		{
			InitializeComponent();
		}

        private void buttonNavAddBook_Click(object sender, EventArgs e)
        {
			panelContent.Controls.Clear();
			panelContent.Controls.Add(addBookPage);
        }

        private void buttonNavRemoveBook_Click(object sender, EventArgs e)
        {
			panelContent.Controls.Clear();
			panelContent.Controls.Add(removeBookPage);
        }
    }
}
