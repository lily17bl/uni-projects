namespace Encryption
{
    partial class Form1
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
            tbMessage = new TextBox();
            cbMethod = new ComboBox();
            lblMethod = new Label();
            btnEncrypt = new Button();
            lblMessage = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(64, 83);
            tbMessage.MaxLength = 50;
            tbMessage.Name = "tbMessage";
            tbMessage.PlaceholderText = "Mensaje";
            tbMessage.Size = new Size(400, 23);
            tbMessage.TabIndex = 1;
            // 
            // cbMethod
            // 
            cbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMethod.FormattingEnabled = true;
            cbMethod.Items.AddRange(new object[] { "Método César", "Método de AES", "Método ECDsa" });
            cbMethod.Location = new Point(218, 125);
            cbMethod.Name = "cbMethod";
            cbMethod.Size = new Size(246, 23);
            cbMethod.TabIndex = 2;
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Location = new Point(64, 128);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(137, 15);
            lblMethod.TabIndex = 3;
            lblMethod.Text = "Método de encriptación:";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(218, 221);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(69, 26);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Encriptar";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(64, 274);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(114, 15);
            lblMessage.TabIndex = 5;
            lblMessage.Text = "Mensaje encriptado:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(218, 161);
            lblError.Name = "lblError";
            lblError.Size = new Size(268, 15);
            lblError.TabIndex = 6;
            lblError.Text = "* Por favor seleccione un método de encriptación";
            lblError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 538);
            Controls.Add(lblError);
            Controls.Add(lblMessage);
            Controls.Add(btnEncrypt);
            Controls.Add(lblMethod);
            Controls.Add(cbMethod);
            Controls.Add(tbMessage);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encriptación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMessage;
        private ComboBox cbMethod;
        private Label lblMethod;
        private Button btnEncrypt;
        private Label lblMessage;
        private Label lblError;
    }
}
