using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsContacts
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        #region EVENTOS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenContactDetailDialog();
        }

        #endregion

        #region PRIVATE METHODS

        private void OpenContactDetailDialog()
        {
            //llamamos al segundo formulario
            ContactoDetails contactoDetails = new ContactoDetails();
            contactoDetails.ShowDialog();
        }

        #endregion

    }
    
}
