using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class frmContact : Form
    {
        public int idAddress = 0;
        readonly ClsDirectory directory = new ClsDirectory(); 

        public frmContact()
        {
            InitializeComponent();
        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            if (idAddress > 0)
            {
                GetData();
                lblTitle.Text = "Edit";
            }
            else
                lblTitle.Text = "Create";      
        }

        private void GetData()
        {
            if (directory.GetData(idAddress))
            {
                txtFirstName.Text = directory.data.first_name;
                txtLastName.Text = directory.data.last_name;
                txtPhoneNumber.Text = directory.data.phone_number;
                txtEmail.Text = directory.data.email;
            }
            else
            {
                MessageBox.Show("Occurred a problem to fill the data.");
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (idAddress <= 0)
            {
                Add();
            }
            else
            {
                Edit();
            }
        }

        private void DataPerson()
        {
            directory.FirstName = ToTitleCase(txtFirstName.Text.Trim());
            directory.LastName = ToTitleCase(txtLastName.Text.Trim());
            directory.PhoneNumber = txtPhoneNumber.Text.Trim();
            directory.Email = txtEmail.Text.Trim();
        }

        private void Add()
        {
            try
            {
                //Validations
                if (txtFirstName.Text.Trim().Equals("") || txtLastName.Text.Trim().Equals("")
                    || txtEmail.Text.Trim().Equals("") || txtPhoneNumber.Text.Trim().Equals(""))
                {
                    MessageBox.Show("FirstName, LastName, Email and PhoneNumber are required");
                    return;
                }
                if (!Utilities.FormOperations.IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("The email is not valid", "Warning");
                    return;
                }
                if (!IsValidPhone(txtPhoneNumber.Text))
                {
                    MessageBox.Show("the phone number is not valid");
                    return;
                }
                
                //DATA
                DataPerson();

                if (directory.Add()) 
                {
                    MessageBox.Show("Registration successful");
                    this.Close();
                }
                else
                    MessageBox.Show("An error occurred");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }          
        }

        private void Edit()
        {
            try
            {
                //Validations
                if (txtFirstName.Text.Trim().Equals("") || txtLastName.Text.Trim().Equals("")
                    || txtEmail.Text.Trim().Equals("") || txtPhoneNumber.Text.Trim().Equals(""))
                {
                    MessageBox.Show("FirstName, LastName, Email and PhoneNumber are required");
                    return;
                }
                if (!Utilities.FormOperations.IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email must be valid", "Warning");
                    return;
                }
                if (!IsValidPhone(txtPhoneNumber.Text))
                {
                    MessageBox.Show("the phone number is not valid");
                    return;
                }

                //DATA
                DataPerson();

                if (directory.Update(idAddress))
                {
                    MessageBox.Show("Registration modified successfully");
                    this.Close();
                }
                else
                    MessageBox.Show("An error occurred");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void llbBackList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => this.Close();

        /// Validations
        private void OnlyLetters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)
                && (e.KeyChar != (char)Keys.Back)
                && (e.KeyChar != (char)Keys.Space))
            { e.Handled = true; return; }
        }

        private bool IsValidPhone(string number)
        {
            Func<string, bool> isValid = num => num.Trim().Length == 12;
            return isValid(number);
        }

        private string ToTitleCase(string text) => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(text);
    }
}
