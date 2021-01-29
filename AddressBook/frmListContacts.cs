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
            RefreachData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:// btnEdit
                    Edit();
                    break;
                case 6:// btnView 
                    OpenForm(new frmContact());
                    break;
                case 7:// btnDelete
                    MessageBox.Show("button Delete");
                    break;
            }
        }

        private void Edit()
        {
            // idAddress
            int id = Utilities.FormOperations.GetId(dgvData);
            if (id > 0)
            {
                frmContact frm = new frmContact();
                frm.idAddress = id;
                OpenForm(frm);
            }
        }

        private void RefreachData()
        {
            this.directoryTableAdapter.Fill(this.dsAddressBook.directory);
        }
        public void OpenForm(Form form) 
        {           
            this.Hide();
            form.ShowDialog();
            this.Show();
            RefreachData();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            OpenForm(new frmContact());
        }
    }
}
