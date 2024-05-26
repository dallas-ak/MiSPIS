namespace MiSPIS.Forms
{
    partial class AddSkladForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSkladForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameSklad = new System.Windows.Forms.TextBox();
            this.comboBoxTypeSklad = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAddType = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteType = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименоване склада";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип склада";
            // 
            // nameSklad
            // 
            this.nameSklad.Location = new System.Drawing.Point(204, 50);
            this.nameSklad.Margin = new System.Windows.Forms.Padding(4);
            this.nameSklad.Name = "nameSklad";
            this.nameSklad.Size = new System.Drawing.Size(265, 22);
            this.nameSklad.TabIndex = 4;
            // 
            // comboBoxTypeSklad
            // 
            this.comboBoxTypeSklad.FormattingEnabled = true;
            this.comboBoxTypeSklad.Location = new System.Drawing.Point(204, 96);
            this.comboBoxTypeSklad.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTypeSklad.Name = "comboBoxTypeSklad";
            this.comboBoxTypeSklad.Size = new System.Drawing.Size(265, 24);
            this.comboBoxTypeSklad.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(153, 144);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(201, 43);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddType,
            this.toolStripDeleteType});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(512, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAddType
            // 
            this.toolStripAddType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddType.Image")));
            this.toolStripAddType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddType.Name = "toolStripAddType";
            this.toolStripAddType.Size = new System.Drawing.Size(178, 24);
            this.toolStripAddType.Text = "Добавить тип склада";
            this.toolStripAddType.Click += new System.EventHandler(this.toolStripAddType_Click);
            // 
            // toolStripDeleteType
            // 
            this.toolStripDeleteType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDeleteType.Image")));
            this.toolStripDeleteType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteType.Name = "toolStripDeleteType";
            this.toolStripDeleteType.Size = new System.Drawing.Size(167, 24);
            this.toolStripDeleteType.Text = "Удалить тип склада";
            this.toolStripDeleteType.Click += new System.EventHandler(this.toolStripDeleteType_Click);
            // 
            // AddSkladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 206);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxTypeSklad);
            this.Controls.Add(this.nameSklad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSkladForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить склад";
            this.Load += new System.EventHandler(this.AddSkladForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameSklad;
        private System.Windows.Forms.ComboBox comboBoxTypeSklad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAddType;
        private System.Windows.Forms.ToolStripButton toolStripDeleteType;
    }
}