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
            frmContact frm = new frmContact();
            switch (e.ColumnIndex)
            {
                case 5:// btnEdit

                    MessageBox.Show("button Edit");
                    frm.Show();
                    break;
                case 6:// btnView 
                    MessageBox.Show("button View");
                    break;
                case 7:// btnDelete
                    MessageBox.Show("button Delete");
                    break;
            }
        }


        public int ObtenertId(DataGridView dgv)
        {
            // this.dataGridView1.Rows[e.RowIndex].Selected = true;
            // int id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            try
            {
                int id = 0;
                id = int.Parse(dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString());
                return id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /*
         *  
            this.rowIndex = e.RowIndex;
            
            this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
            contextMenuStrip1.Show(Cursor.Position);
         */
    }
}
