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
    public partial class ContactoDetails : Form
    {

        private BusinessLoginLayer _businessLoginLayer;
        public ContactoDetails()
        {
            InitializeComponent();
            _businessLoginLayer = new BusinessLoginLayer();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ContactoDetails_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Cerrar formulario con cancel
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.FirstName = txtFirstName.Text;
            contact.LastName = txtLastName.Text;
            contact.Phone = txtPhone.Text;
            contact.Email = txtEmail.Text;

            _businessLoginLayer.
        }
    }
}
