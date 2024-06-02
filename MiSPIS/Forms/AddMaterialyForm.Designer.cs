namespace MiSPIS.Forms
{
    partial class AddMaterialyForm
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
            this.comboBoxNameSklad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.articleMaterial = new System.Windows.Forms.TextBox();
            this.nameMaterial = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxNameSklad
            // 
            this.comboBoxNameSklad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNameSklad.FormattingEnabled = true;
            this.comboBoxNameSklad.Location = new System.Drawing.Point(164, 97);
            this.comboBoxNameSklad.Name = "comboBoxNameSklad";
            this.comboBoxNameSklad.Size = new System.Drawing.Size(224, 21);
            this.comboBoxNameSklad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Наименование товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Склад";
            // 
            // articleMaterial
            // 
            this.articleMaterial.Location = new System.Drawing.Point(164, 29);
            this.articleMaterial.MaxLength = 6;
            this.articleMaterial.Name = "articleMaterial";
            this.articleMaterial.Size = new System.Drawing.Size(224, 20);
            this.articleMaterial.TabIndex = 0;
            this.articleMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.articleMaterial_KeyPress);
            // 
            // nameMaterial
            // 
            this.nameMaterial.Location = new System.Drawing.Point(164, 64);
            this.nameMaterial.Name = "nameMaterial";
            this.nameMaterial.Size = new System.Drawing.Size(224, 20);
            this.nameMaterial.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(123, 139);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(151, 35);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Добавить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddMaterialyForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 203);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.nameMaterial);
            this.Controls.Add(this.articleMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNameSklad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddMaterialyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товаров";
            this.Load += new System.EventHandler(this.AddMaterialyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNameSklad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox articleMaterial;
        private System.Windows.Forms.TextBox nameMaterial;
        private System.Windows.Forms.Button buttonSave;
    }
}