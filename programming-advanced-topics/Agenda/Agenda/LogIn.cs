using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitiesLibrary;

namespace Agenda
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                if ((e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.SelectNextControl((TextBox)sender, true, true, true, true);
                }
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var username = tbUsername.Text;
            var password = tbPassword.Text;

            UsernameValidation validator = new UsernameValidation();

            bool usernameExists = validator.usernameQuery(username);

            if (usernameExists)
            {
                int lineNum = validator.getLine(username);

                PasswordValidation passwordValidation = new PasswordValidation();

                bool passwordMatches = passwordValidation.passwordQuery(lineNum, password);

                if (passwordMatches)
                {
                    MessageBox.Show("Sesión iniciada correctamente");
                    lblError.Visible = false;
                    this.Hide();
                    MainForm form2 = new MainForm();
                    form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp form2 = new SignUp();
            form2.ShowDialog();
            this.Close();
        }
    }
}
