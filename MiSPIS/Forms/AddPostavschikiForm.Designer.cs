namespace MiSPIS.Forms
{
    partial class AddPostavschikiForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.INN = new System.Windows.Forms.TextBox();
            this.KPP = new System.Windows.Forms.TextBox();
            this.ShortName = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.comboBoxTypePostavschiki = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(165, 156);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 35);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Записать";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // INN
            // 
            this.INN.Location = new System.Drawing.Point(165, 41);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(300, 20);
            this.INN.TabIndex = 2;
            this.INN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.INN_KeyPress);
            // 
            // KPP
            // 
            this.KPP.Location = new System.Drawing.Point(165, 67);
            this.KPP.Name = "KPP";
            this.KPP.Size = new System.Drawing.Size(300, 20);
            this.KPP.TabIndex = 3;
            this.KPP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KPP_KeyPress);
            // 
            // ShortName
            // 
            this.ShortName.Location = new System.Drawing.Point(165, 93);
            this.ShortName.Name = "ShortName";
            this.ShortName.Size = new System.Drawing.Size(300, 20);
            this.ShortName.TabIndex = 4;
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(165, 120);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(300, 20);
            this.FullName.TabIndex = 5;
            // 
            // comboBoxTypePostavschiki
            // 
            this.comboBoxTypePostavschiki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypePostavschiki.FormattingEnabled = true;
            this.comboBoxTypePostavschiki.Location = new System.Drawing.Point(165, 15);
            this.comboBoxTypePostavschiki.Name = "comboBoxTypePostavschiki";
            this.comboBoxTypePostavschiki.Size = new System.Drawing.Size(300, 21);
            this.comboBoxTypePostavschiki.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вид контрагента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "ИНН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "КПП";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Краткое наименование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Полное наименование";
            // 
            // AddPostavschikiForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypePostavschiki);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.ShortName);
            this.Controls.Add(this.KPP);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPostavschikiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить поставщика";
            this.Load += new System.EventHandler(this.AddPostavschikiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox INN;
        private System.Windows.Forms.TextBox KPP;
        private System.Windows.Forms.TextBox ShortName;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBoxTypePostavschiki;
    }
}