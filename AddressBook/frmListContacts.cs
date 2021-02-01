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
                    Details();
                    break;
                case 7:// btnDelete
                    Delete();
                    break;
            }
        }        
        private void Details()
        {
            // idAddress
            int id = Utilities.FormOperations.GetId(dgvData);
            if (id > 0)
            {
                frmDetailsContact frm = new frmDetailsContact();
                frm.idAddress = id;
                OpenForm(frm);
            }
        }

        private void Delete()
        {
            int id = Utilities.FormOperations.GetId(dgvData);
            if (id > 0)
            {
                if (MessageBox.Show("Are you sure to delete the selected record?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClsDirectory directory = new ClsDirectory();
                    if (directory.Delete(id))
                    {
                        RefreachData();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred");
                    }
                }
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
            try
            {
                this.directoryTableAdapter.Fill(this.dsAddressBook.directory);
            }
            catch (MySql.Data.MySqlClient.MySqlException me)
            {
                MessageBox.Show("A connection error occurred: " + me.Message);
                btnCreateNew.Enabled = false;
            }
            catch(Exception e)
            {
                MessageBox.Show("An error occurred: " + e.Message);
            }          
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
