using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook.Utilities
{
    abstract class ClsModule
    {
        protected List<string> error = new List<string>();

        /// <summary>
        /// Method that makes the refresh of the data.
        /// </summary>
        /// <param name="dgv">receives the datagridview where to will be updated the data.
        /// <returns>Return if it was a success </returns>
        public abstract bool GetData(DataGridView dgv);

        /// <summary>
        /// Method that adds a record
        /// </summary>
        /// <return>"True" if it was a success </return>
        public abstract bool Add();

        /// <summary>
        /// Method that edit a record.
        /// </summary>
        /// <param name="id">id of the record to update.</param>
        /// <return>"True" if it was a success </return>
        public abstract bool Update(int id);

        /// <summary>
        /// Method that delete a record.
        /// </summary>
        /// <param name="id">id of the record to delete.</param>
        /// <return>"True" if it was a success </return>
        public abstract bool Delete(int id);


   
    }
}
