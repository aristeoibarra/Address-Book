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
            throw new NotImplementedException();
        }
        public override bool Update()
        {
            throw new NotImplementedException();
        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }

        public override bool GetData(DataGridView dgv)
        {
            throw new NotImplementedException();
        }    
    }
}
