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
    public partial class frmListContacts : Form
    {
        public frmListContacts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAddressBook.directory' Puede moverla o quitarla según sea necesario.
            this.directoryTableAdapter.Fill(this.dsAddressBook.directory);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:// btnEdit
                    OpenForm(new frmContact());                   
                    break;
                case 6:// btnView 
                    OpenForm(new frmContact());
                    break;
                case 7:// btnDelete
                    MessageBox.Show("button Delete");
                    break;
            }
        }

        public void OpenForm(Form form) 
        {           
            this.Hide();
            form.ShowDialog();
            this.Show();
            this.directoryTableAdapter.Fill(this.dsAddressBook.directory);
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            OpenForm(new frmContact());
        }
    }
}
