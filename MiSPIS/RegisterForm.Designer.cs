namespace MiSPIS
{
    partial class RegisterForm
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(178, 127);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(125, 23);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Зарегистрироваться";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // passwordField
            // 
            this.passwordField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.passwordField.Location = new System.Drawing.Point(259, 73);
            this.passwordField.MaxLength = 12;
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(174, 20);
            this.passwordField.TabIndex = 11;
            this.passwordField.UseSystemPasswordChar = true;
            this.passwordField.Enter += new System.EventHandler(this.passwordField_Enter);
            this.passwordField.Leave += new System.EventHandler(this.passwordField_Leave);
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(44, 73);
            this.loginField.MaxLength = 20;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(174, 20);
            this.loginField.TabIndex = 10;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(44, 22);
            this.userNameField.MaxLength = 20;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(174, 20);
            this.userNameField.TabIndex = 8;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // userSurnameField
            // 
            this.userSurnameField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.userSurnameField.Location = new System.Drawing.Point(259, 22);
            this.userSurnameField.MaxLength = 12;
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(174, 20);
            this.userSurnameField.TabIndex = 9;
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 175);
            this.Controls.Add(this.userSurnameField);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Name = "RegisterForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.TextBox loginField;
    }
}