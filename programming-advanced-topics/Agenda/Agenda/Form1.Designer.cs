namespace Agenda
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUser = new Label();
            lblPhone = new Label();
            lblBirthDate = new Label();
            lblSocialNetwork = new Label();
            lblPassword = new Label();
            lblPasswordConfirm = new Label();
            tbName = new TextBox();
            tbPhone = new TextBox();
            dtBirthDate = new DateTimePicker();
            tbPassword = new TextBox();
            tbPasswordConfirm = new TextBox();
            cbSocialNetwork = new ComboBox();
            cbShowPassword = new CheckBox();
            btnSignUp = new Button();
            lblNameError = new Label();
            lblPhoneError = new Label();
            lblSocialNetworkError = new Label();
            lblPasswordError = new Label();
            lblPasswordConfirmError = new Label();
            lblUserNameError = new Label();
            tbUserName = new TextBox();
            lblUserName = new Label();
            lblUserNameEmpty = new Label();
            lbl1 = new Label();
            lblLogIn = new Label();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(35, 86);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(54, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "Nombre:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(36, 180);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(55, 15);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Teléfono:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(36, 229);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(122, 15);
            lblBirthDate.TabIndex = 2;
            lblBirthDate.Text = "Fecha de Nacimiento:";
            // 
            // lblSocialNetwork
            // 
            lblSocialNetwork.AutoSize = true;
            lblSocialNetwork.Location = new Point(35, 274);
            lblSocialNetwork.Name = "lblSocialNetwork";
            lblSocialNetwork.Size = new Size(64, 15);
            lblSocialNetwork.TabIndex = 3;
            lblSocialNetwork.Text = "Red Social:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(35, 320);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña:";
            // 
            // lblPasswordConfirm
            // 
            lblPasswordConfirm.AutoSize = true;
            lblPasswordConfirm.Location = new Point(36, 467);
            lblPasswordConfirm.Name = "lblPasswordConfirm";
            lblPasswordConfirm.Size = new Size(125, 15);
            lblPasswordConfirm.TabIndex = 5;
            lblPasswordConfirm.Text = "Confirmar contraseña:";
            // 
            // tbName
            // 
            tbName.Location = new Point(199, 83);
            tbName.MaxLength = 25;
            tbName.Name = "tbName";
            tbName.Size = new Size(218, 23);
            tbName.TabIndex = 1;
            tbName.KeyPress += tbName_KeyPress;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(200, 177);
            tbPhone.MaxLength = 10;
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(218, 23);
            tbPhone.TabIndex = 3;
            tbPhone.KeyPress += tbPhone_KeyPress;
            // 
            // dtBirthDate
            // 
            dtBirthDate.Location = new Point(200, 223);
            dtBirthDate.MaxDate = new DateTime(2024, 3, 13, 22, 19, 11, 0);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(218, 23);
            dtBirthDate.TabIndex = 8;
            dtBirthDate.Value = new DateTime(2024, 3, 13, 0, 0, 0, 0);
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(199, 317);
            tbPassword.MaxLength = 25;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(218, 23);
            tbPassword.TabIndex = 4;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbPasswordConfirm
            // 
            tbPasswordConfirm.Location = new Point(200, 464);
            tbPasswordConfirm.MaxLength = 25;
            tbPasswordConfirm.Name = "tbPasswordConfirm";
            tbPasswordConfirm.Size = new Size(218, 23);
            tbPasswordConfirm.TabIndex = 5;
            tbPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // cbSocialNetwork
            // 
            cbSocialNetwork.AutoCompleteCustomSource.AddRange(new string[] { "Twitter", "Facebook", "Instagram" });
            cbSocialNetwork.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSocialNetwork.FormattingEnabled = true;
            cbSocialNetwork.Items.AddRange(new object[] { "Twitter", "Facebook", "Instagram" });
            cbSocialNetwork.Location = new Point(199, 271);
            cbSocialNetwork.Name = "cbSocialNetwork";
            cbSocialNetwork.Size = new Size(220, 23);
            cbSocialNetwork.TabIndex = 12;
            cbSocialNetwork.TabStop = false;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(199, 346);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(128, 19);
            cbShowPassword.TabIndex = 13;
            cbShowPassword.Text = "Mostrar contraseña";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(173, 530);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(133, 44);
            btnSignUp.TabIndex = 14;
            btnSignUp.Text = "Registrarse";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblNameError
            // 
            lblNameError.AutoSize = true;
            lblNameError.ForeColor = Color.Red;
            lblNameError.Location = new Point(202, 107);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(151, 15);
            lblNameError.TabIndex = 15;
            lblNameError.Text = "* Este campo es obligatorio";
            lblNameError.Visible = false;
            // 
            // lblPhoneError
            // 
            lblPhoneError.AutoSize = true;
            lblPhoneError.ForeColor = Color.Red;
            lblPhoneError.Location = new Point(203, 203);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(213, 15);
            lblPhoneError.TabIndex = 16;
            lblPhoneError.Text = "* Ingrese un número de teléfono válido";
            lblPhoneError.Visible = false;
            // 
            // lblSocialNetworkError
            // 
            lblSocialNetworkError.AutoSize = true;
            lblSocialNetworkError.ForeColor = Color.Red;
            lblSocialNetworkError.Location = new Point(202, 297);
            lblSocialNetworkError.Name = "lblSocialNetworkError";
            lblSocialNetworkError.Size = new Size(151, 15);
            lblSocialNetworkError.TabIndex = 17;
            lblSocialNetworkError.Text = "* Este campo es obligatorio";
            lblSocialNetworkError.Visible = false;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.ForeColor = Color.Black;
            lblPasswordError.Location = new Point(199, 368);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(261, 90);
            lblPasswordError.TabIndex = 18;
            lblPasswordError.Text = "* La contraseña debe contener:\r\n-Al menos 8 caracteres.\r\n-Al menos una letra minúscula.\r\n-Al menos una letra mayúscula.\r\n-Al menos un número.\r\n-Al menos un caracter especial (!, #, $, %, &, /, ¡, *)";
            // 
            // lblPasswordConfirmError
            // 
            lblPasswordConfirmError.AutoSize = true;
            lblPasswordConfirmError.ForeColor = Color.Red;
            lblPasswordConfirmError.Location = new Point(200, 490);
            lblPasswordConfirmError.Name = "lblPasswordConfirmError";
            lblPasswordConfirmError.Size = new Size(170, 15);
            lblPasswordConfirmError.TabIndex = 19;
            lblPasswordConfirmError.Text = "* Las contraseñas no coinciden";
            lblPasswordConfirmError.Visible = false;
            // 
            // lblUserNameError
            // 
            lblUserNameError.AutoSize = true;
            lblUserNameError.ForeColor = Color.Red;
            lblUserNameError.Location = new Point(204, 154);
            lblUserNameError.Name = "lblUserNameError";
            lblUserNameError.Size = new Size(211, 15);
            lblUserNameError.TabIndex = 23;
            lblUserNameError.Text = "* Ya existe una cuenta con este usuario";
            lblUserNameError.Visible = false;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(200, 129);
            tbUserName.MaxLength = 15;
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(218, 23);
            tbUserName.TabIndex = 2;
            tbUserName.KeyPress += tbUserName_KeyPress;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(36, 132);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(50, 15);
            lblUserName.TabIndex = 21;
            lblUserName.Text = "Usuario:";
            // 
            // lblUserNameEmpty
            // 
            lblUserNameEmpty.AutoSize = true;
            lblUserNameEmpty.ForeColor = Color.Red;
            lblUserNameEmpty.Location = new Point(200, 155);
            lblUserNameEmpty.Name = "lblUserNameEmpty";
            lblUserNameEmpty.Size = new Size(151, 15);
            lblUserNameEmpty.TabIndex = 24;
            lblUserNameEmpty.Text = "* Este campo es obligatorio";
            lblUserNameEmpty.Visible = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(137, 586);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(120, 15);
            lbl1.TabIndex = 25;
            lbl1.Text = "¿Ya tiene una cuenta?";
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.ForeColor = SystemColors.MenuHighlight;
            lblLogIn.Location = new Point(263, 586);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(76, 15);
            lblLogIn.TabIndex = 26;
            lblLogIn.Text = "Iniciar Sesión";
            lblLogIn.Click += lblLogIn_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(489, 621);
            Controls.Add(lblLogIn);
            Controls.Add(lbl1);
            Controls.Add(lblUserNameEmpty);
            Controls.Add(lblUserNameError);
            Controls.Add(tbUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblPasswordConfirmError);
            Controls.Add(lblPasswordError);
            Controls.Add(lblSocialNetworkError);
            Controls.Add(lblPhoneError);
            Controls.Add(lblNameError);
            Controls.Add(btnSignUp);
            Controls.Add(cbShowPassword);
            Controls.Add(cbSocialNetwork);
            Controls.Add(tbPasswordConfirm);
            Controls.Add(tbPassword);
            Controls.Add(dtBirthDate);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Controls.Add(lblPasswordConfirm);
            Controls.Add(lblPassword);
            Controls.Add(lblSocialNetwork);
            Controls.Add(lblBirthDate);
            Controls.Add(lblPhone);
            Controls.Add(lblUser);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPhone;
        private Label lblBirthDate;
        private Label lblSocialNetwork;
        private Label lblPassword;
        private Label lblPasswordConfirm;
        private TextBox tbName;
        private TextBox tbPhone;
        private DateTimePicker dtBirthDate;
        private TextBox tbPassword;
        private TextBox tbPasswordConfirm;
        private ComboBox cbSocialNetwork;
        private CheckBox cbShowPassword;
        private Button btnSignUp;
        private Label lblNameError;
        private Label lblPhoneError;
        private Label lblSocialNetworkError;
        private Label lblPasswordError;
        private Label lblPasswordConfirmError;
        private Label lblUserNameError;
        private TextBox tbUserName;
        private Label lblUserName;
        private Label lblUserNameEmpty;
        private Label lbl1;
        private Label lblLogIn;
    }
}
