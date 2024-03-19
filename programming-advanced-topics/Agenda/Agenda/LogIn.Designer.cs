namespace Agenda
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUserName = new Label();
            lblPassword = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogIn = new Button();
            cbShowPassword = new CheckBox();
            lblError = new Label();
            lblSignUp = new Label();
            lbl1 = new Label();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(28, 100);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(50, 15);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Usuario:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(28, 146);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Contraseña:";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(146, 97);
            tbUsername.MaxLength = 15;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(214, 23);
            tbUsername.TabIndex = 2;
            tbUsername.KeyPress += tbUsername_KeyPress;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(146, 143);
            tbPassword.MaxLength = 25;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(214, 23);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(120, 240);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(153, 55);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "Iniciar Sesión";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(146, 172);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(128, 19);
            cbShowPassword.TabIndex = 14;
            cbShowPassword.Text = "Mostrar contraseña";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(146, 203);
            lblError.Name = "lblError";
            lblError.Size = new Size(188, 15);
            lblError.TabIndex = 15;
            lblError.Text = "* Usuario o contraseña incorrectos";
            lblError.Visible = false;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.ForeColor = SystemColors.MenuHighlight;
            lblSignUp.Location = new Point(239, 308);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(64, 15);
            lblSignUp.TabIndex = 28;
            lblSignUp.Text = "Registrarse";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(86, 308);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(147, 15);
            lbl1.TabIndex = 27;
            lbl1.Text = "¿Aún no tiene una cuenta?";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 365);
            Controls.Add(lblSignUp);
            Controls.Add(lbl1);
            Controls.Add(lblError);
            Controls.Add(cbShowPassword);
            Controls.Add(btnLogIn);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LogIn";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblPassword;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogIn;
        private CheckBox cbShowPassword;
        private Label lblError;
        private Label lblSignUp;
        private Label lbl1;
    }
}