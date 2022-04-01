using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LOGIN_FORM
{
    public partial class PATIENT_SIGN_FORM : Form
    {
        string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        public PATIENT_SIGN_FORM()
        {
            InitializeComponent();
        }

        private void PATIENT_SIGN_FORM_Load(object sender, EventArgs e)
        {

        }

        private void firstname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstname.Text) == true)
            {
                firstname.Focus(); 
                errorProvider1.SetError(this.firstname, "Please Fill First Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
           char c = e.KeyChar;
            if (char.IsLetter(c) == true)
            {
                e.Handled = false;
            }
            else if (c == 8)
            {
                e.Handled=false;
            }
            else if (c == 32)
            {
                e.Handled=false;
            }
            else
            {
                e.Handled=true; 
            }
        }

        private void lastname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastname.Text) == true)
            {
                lastname.Focus();
                errorProvider2.SetError(this.lastname, "Please Fill Last Name");
            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) == true)
            {
                e.Handled = false;
            }
            else if (c == 8)
            {
                e.Handled = false;
            }
            else if (c == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void mobilenumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nationality.Text) == true)
            {
                nationality.Focus();
                errorProvider3.SetError(this.nationality, "Please Fill the Field Nationallity");
            }
            else
            {
                errorProvider3.Clear();
            }

        }

        private void nationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) == true)
            {
                e.Handled = false;
            }
            else if (c == 8)
            {
                e.Handled = false;
            }
            else if (c == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) == true)
            {
                username.Focus();
                errorProvider5.SetError(this.username, "Please Fill the Field Nationallity");
            }
            else
            {
                errorProvider5.Clear();
            }

        }

        private void gender_Leave(object sender, EventArgs e)
        {
            if (gender.SelectedItem == null)
            {
                gender.Focus();
                errorProvider6.SetError(this.gender, "Please select Gender");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void bloodgroup_Leave(object sender, EventArgs e)
        {
            if (bloodgroup.SelectedItem == null)
            {
                gender.Focus();
                errorProvider8.SetError(this.bloodgroup, "Please select Blood Group");
            }
            else
            {
                errorProvider8.Clear();
            }

        }

        private void emailaddress_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(emailaddress.Text, pattern) == false)
            {
                emailaddress.Focus();
                errorProvider4.SetError(this.emailaddress, "Invalid Email");
            }
            else
            {
                errorProvider4.Clear();
            }
            
        }
        

        

        private void address_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(address.Text) == true)
            {
                address.Focus();
                errorProvider9.SetError(this.address, "Please Fill the Field Address");
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void address_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) == true)
            {
                e.Handled = false;
            }
            else if (c == 8)
            {
                e.Handled = false;
            }
            else if (c == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void mobile_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mobile.Text) == true)
            {
                mobile.Focus();
                errorProvider10.SetError(this.mobile, "Please Fill the Field Mobile Number");
            }
            else
            {
                errorProvider10.Clear();
            }

        }

        private void mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) == true)
            {
                e.Handled = false;
            }
            else if (c == 8)
            {
                e.Handled = false;
            }
            else if (c == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
