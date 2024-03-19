using System.ComponentModel.DataAnnotations;
using UtilitiesLibrary;

namespace Agenda;

public partial class SignUp : Form
{
    public SignUp()
    {
        InitializeComponent();
        var today = DateTime.Now;
        var maxDate = new DateTime(today.Year - 11, today.Month, today.Day);
        dtBirthDate.MaxDate = maxDate;
        var minDate = new DateTime(today.Year - 120, today.Month, today.Day);
        dtBirthDate.MinDate = minDate;
    }

    private void tbName_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar))
        {
            if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl((TextBox)sender, true, true, true, true);
            }
        }
    }

    private void tbUserName_KeyPress(object sender, KeyPressEventArgs e)
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

    private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar))
        {
            if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
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

    private void btnSignUp_Click(object sender, EventArgs e)
    {
        var flag = false;

        if (tbName.Text == "")
        {
            lblNameError.Visible = true;
            flag = true;
        }
        else
        {
            lblNameError.Visible = false;
        }

        if (tbUserName.Text == "")
        {
            lblUserNameEmpty.Visible = true;
            flag = true;
        }
        else
        {
            UsernameValidation usernameValidator = new UsernameValidation();

            bool usernameExists = usernameValidator.usernameQuery(tbUserName.Text);

            if (usernameExists)
            {
                lblUserNameError.Visible = true;
                flag = true;
            }
            else
            {
                lblUserNameError.Visible = false;
            }

            lblUserNameEmpty.Visible = false;
        }

        if (tbPhone.Text.Length < 10)
        {
            lblPhoneError.Visible = true;
            flag = true;
        }
        else
        {
            lblPhoneError.Visible = false;
        }

        if (cbSocialNetwork.SelectedItem == null)
        {
            lblSocialNetworkError.Visible = true;
            flag = true;
        }
        else
        {
            lblSocialNetworkError.Visible = false;
        }

        PasswordValidation validator = new PasswordValidation();

        var password = tbPassword.Text;

        if (!validator.validatePassword(password))
        {
            lblPasswordError.ForeColor = Color.Red;

            flag = true;
        }
        else
        {
            lblPasswordError.ForeColor = Color.Green;

            if (password != tbPasswordConfirm.Text)
            {
                lblPasswordConfirmError.Visible = true;
                flag = true;
            }
            else
            {
                lblPasswordConfirmError.Visible = false;
            }
        }

        if (!flag)
        {
            Cryptography cryptography = new Cryptography();

            var name = tbName.Text;
            var username = cryptography.encrypt(tbUserName.Text);
            var phone = tbPhone.Text;
            var year = dtBirthDate.Value.Year;
            var month = dtBirthDate.Value.Month;
            var day = dtBirthDate.Value.Day;
            var socialNetwork = cbSocialNetwork.SelectedItem.ToString();
            var birthDate = new DateOnly(year, month, day);
            password = cryptography.encrypt(tbPassword.Text);
            User user = new User(name, username, phone, birthDate, socialNetwork, password);
            user.writeData();

            MessageBox.Show("Cuenta creada exitosamente, favor de iniciar sesión");
            this.Hide();
            LogIn form2 = new LogIn();
            form2.ShowDialog();
            this.Close();
        }
    }

    private void lblLogIn_Click(object sender, EventArgs e)
    {
        this.Hide();
        LogIn form2 = new LogIn();
        form2.ShowDialog();
        this.Close();
    }
}
