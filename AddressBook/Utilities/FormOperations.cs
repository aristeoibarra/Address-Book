using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook.Utilities
{
    /// <summary>
    /// OperationsForm Class contains common functions of a form and its controllers.
    /// Autor: Aristeo Ibarra Melgar
    /// Fecha de Creación: 27/01/2021
    /// </summary>
    class FormOperations
    {
        /// <summary>
        /// Get the Id of the data grid view containing in the first cell
        /// </summary>
        /// <param name="dgv">Datagridview to get the Id</param>
        public static int Getid(DataGridView dgv) 
        {
            try
            {
                int id = int.Parse(dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString());
                return id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// Method that validates an email
        /// </summary>
        /// <param name="email">receive an email</param>

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
