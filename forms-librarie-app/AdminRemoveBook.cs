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
    public partial class AdminRemoveBook : UserControl
    {
        public AdminRemoveBook()
        {
            InitializeComponent();
        }

        private void AdminRemoveBook_Load(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = LibraryDatabase.getCarteInfoTable();
            dataGridViewBooks.Columns[0].Width = 514;
        }
    }
}
