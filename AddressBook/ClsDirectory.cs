using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    class ClsDirectory : Utilities.ClsModule
    {
        public dsAddressBook.directoryRow data;
        public string FirstName = "";
        public string LastName = "";
        public string Email = "";
        public string PhoneNumber = "";

        public override bool Add()
        {
            bool success;
            try
            {
                dsAddressBookTableAdapters.directoryTableAdapter directory = new dsAddressBookTableAdapters.directoryTableAdapter();
                directory.Add(FirstName, LastName, Email, PhoneNumber);

                success = true;
            }
            catch (Exception)
            {
                success = false;
            }
            return success;
        }

        public override bool Update(int id)
        {
            bool success;
            try
            {
                dsAddressBookTableAdapters.directoryTableAdapter directory = new dsAddressBookTableAdapters.directoryTableAdapter();
                directory.Edit(FirstName, LastName, Email, PhoneNumber,id);

                success = true;
            }
            catch (Exception)
            {
                success = false;
            }
            return success;
        }

        public override bool Delete(int id)
        {
            bool success;
            try
            {
                dsAddressBookTableAdapters.directoryTableAdapter directory = new dsAddressBookTableAdapters.directoryTableAdapter();
                directory.DeleteQuery(id);

                success = true;
            }
            catch (Exception)
            {
                success = false;
            }
            return success;
        }

        public override bool GetData(DataGridView dgv)
        {
            throw new NotImplementedException();
        }    
    }
}
