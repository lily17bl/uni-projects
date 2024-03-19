namespace Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Encryption encryption = new Encryption();

            string message = tbMessage.Text;
            string encryptedMessage = "";

            if (cbMethod.SelectedIndex == -1) {
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;

                message = tbMessage.Text;

                switch (cbMethod.SelectedIndex)
                {
                    case 0:
                        encryptedMessage = encryption.CaesarMethod(message);
                        lblMessage.Text = "Mensaje encriptado: " + encryptedMessage;
                        break;
                    case 1:
                        encryptedMessage = encryption.AESMethod(message);
                        lblMessage.Text = "Mensaje encriptado: " + encryptedMessage;
                        break;
                    case 2:
                        encryptedMessage = encryption.ECDsaMethod(message);
                        lblMessage.Text = encryptedMessage;
                        break;
                }

            }
        }
    }
}
