using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class frmDetailsContact : Form
    {
        public int idAddress = 0;
        ClsDirectory directory = new ClsDirectory();

        public frmDetailsContact()
        {
            InitializeComponent();
        }

        private void frmDetailsContact_Load(object sender, EventArgs e)
        {
            if (idAddress > 0)
            {
                GetData();               
            }
        }

        private void GetData()
        {
            if (directory.GetData(idAddress))
            {
                lblFirstName.Text = directory.data.first_name;
                lblLastName.Text = directory.data.last_name;
                lblPhoneNumber.Text = directory.data.phone_number;
                lblEmail.Text = directory.data.email;
            }
            else
            {
                MessageBox.Show("Occurred a problem to fill the data.");
                this.Close();
            }
        }

        private void llbEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            // idAddress
            if (idAddress > 0)
            {
                frmContact frm = new frmContact();
                frm.idAddress = this.idAddress;
                OpenForm(frm);
            }
        }

        private void OpenForm(frmContact form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void llbBackList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
