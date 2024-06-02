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
            this.toolStripTypeSklad = new System.Windows.Forms.ToolStrip();
            this.toolStripAddType = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteType = new System.Windows.Forms.ToolStripButton();
            this.toolStripTypeSklad.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименоване склада";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип склада";
            // 
            // nameSklad
            // 
            this.nameSklad.Location = new System.Drawing.Point(165, 20);
            this.nameSklad.Name = "nameSklad";
            this.nameSklad.Size = new System.Drawing.Size(300, 20);
            this.nameSklad.TabIndex = 4;
            // 
            // comboBoxTypeSklad
            // 
            this.comboBoxTypeSklad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeSklad.FormattingEnabled = true;
            this.comboBoxTypeSklad.Location = new System.Drawing.Point(165, 56);
            this.comboBoxTypeSklad.Name = "comboBoxTypeSklad";
            this.comboBoxTypeSklad.Size = new System.Drawing.Size(300, 21);
            this.comboBoxTypeSklad.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(165, 95);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 35);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Записать";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // toolStripTypeSklad
            // 
            this.toolStripTypeSklad.AutoSize = false;
            this.toolStripTypeSklad.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTypeSklad.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTypeSklad.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripTypeSklad.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.toolStripTypeSklad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddType,
            this.toolStripDeleteType});
            this.toolStripTypeSklad.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripTypeSklad.Location = new System.Drawing.Point(134, 38);
            this.toolStripTypeSklad.Name = "toolStripTypeSklad";
            this.toolStripTypeSklad.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripTypeSklad.Size = new System.Drawing.Size(28, 72);
            this.toolStripTypeSklad.TabIndex = 8;
            this.toolStripTypeSklad.Text = "toolStrip1";
            // 
            // toolStripAddType
            // 
            this.toolStripAddType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAddType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddType.Image")));
            this.toolStripAddType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddType.Name = "toolStripAddType";
            this.toolStripAddType.Size = new System.Drawing.Size(26, 24);
            this.toolStripAddType.Text = "Добавить тип склада";
            this.toolStripAddType.Click += new System.EventHandler(this.toolStripAddType_Click);
            // 
            // toolStripDeleteType
            // 
            this.toolStripDeleteType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDeleteType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDeleteType.Image")));
            this.toolStripDeleteType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteType.Name = "toolStripDeleteType";
            this.toolStripDeleteType.Size = new System.Drawing.Size(26, 24);
            this.toolStripDeleteType.Text = "Удалить тип склада";
            this.toolStripDeleteType.Click += new System.EventHandler(this.toolStripDeleteType_Click);
            // 
            // AddSkladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 153);
            this.Controls.Add(this.toolStripTypeSklad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxTypeSklad);
            this.Controls.Add(this.nameSklad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddSkladForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить склад";
            this.Load += new System.EventHandler(this.AddSkladForm_Load);
            this.toolStripTypeSklad.ResumeLayout(false);
            this.toolStripTypeSklad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameSklad;
        private System.Windows.Forms.ComboBox comboBoxTypeSklad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ToolStrip toolStripTypeSklad;
        private System.Windows.Forms.ToolStripButton toolStripAddType;
        private System.Windows.Forms.ToolStripButton toolStripDeleteType;
    }
}