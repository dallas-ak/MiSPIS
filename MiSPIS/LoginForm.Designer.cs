namespace MiSPIS
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(33, 36);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(80, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Пользователь";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(33, 71);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Пароль";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(142, 33);
            this.loginField.MaxLength = 20;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(174, 20);
            this.loginField.TabIndex = 2;
            this.loginField.TextChanged += new System.EventHandler(this.loginField_TextChanged);
            // 
            // passwordField
            // 
            this.passwordField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.passwordField.Location = new System.Drawing.Point(142, 68);
            this.passwordField.MaxLength = 12;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(174, 20);
            this.passwordField.TabIndex = 3;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(142, 111);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(92, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button buttonLogin;

    }
}

