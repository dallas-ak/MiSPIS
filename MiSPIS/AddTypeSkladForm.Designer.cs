namespace MiSPIS
{
    partial class AddTypeSkladForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.typeField = new System.Windows.Forms.TextBox();
            this.labelNameType = new System.Windows.Forms.Label();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(379, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // typeField
            // 
            this.typeField.Location = new System.Drawing.Point(129, 42);
            this.typeField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeField.Name = "typeField";
            this.typeField.Size = new System.Drawing.Size(219, 20);
            this.typeField.TabIndex = 1;
            // 
            // labelNameType
            // 
            this.labelNameType.AutoSize = true;
            this.labelNameType.Location = new System.Drawing.Point(13, 45);
            this.labelNameType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameType.Name = "labelNameType";
            this.labelNameType.Size = new System.Drawing.Size(95, 15);
            this.labelNameType.TabIndex = 2;
            this.labelNameType.Text = "Наименование";
            // 
            // buttonAddType
            // 
            this.buttonAddType.Location = new System.Drawing.Point(146, 96);
            this.buttonAddType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(100, 28);
            this.buttonAddType.TabIndex = 3;
            this.buttonAddType.Text = "Добавить";
            this.buttonAddType.UseVisualStyleBackColor = true;
            this.buttonAddType.Click += new System.EventHandler(this.buttonAddType_Click);
            // 
            // AddTypeSkladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 137);
            this.Controls.Add(this.buttonAddType);
            this.Controls.Add(this.labelNameType);
            this.Controls.Add(this.typeField);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddTypeSkladForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить тип склада";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox typeField;
        private System.Windows.Forms.Label labelNameType;
        private System.Windows.Forms.Button buttonAddType;
    }
}