namespace MiSPIS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SpravochnikiStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SkladyStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MaterialyStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PostavschikiStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MOLStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OtchetyStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpravochnikiStripMenu,
            this.OtchetyStripMenu,
            this.ExitStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SpravochnikiStripMenu
            // 
            this.SpravochnikiStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SkladyStripMenu,
            this.MaterialyStripMenu,
            this.PostavschikiStripMenu,
            this.MOLStripMenu});
            this.SpravochnikiStripMenu.Name = "SpravochnikiStripMenu";
            this.SpravochnikiStripMenu.Size = new System.Drawing.Size(94, 20);
            this.SpravochnikiStripMenu.Text = "Справочники";
            // 
            // SkladyStripMenu
            // 
            this.SkladyStripMenu.Name = "SkladyStripMenu";
            this.SkladyStripMenu.Size = new System.Drawing.Size(144, 22);
            this.SkladyStripMenu.Text = "Склады";
            // 
            // MaterialyStripMenu
            // 
            this.MaterialyStripMenu.Name = "MaterialyStripMenu";
            this.MaterialyStripMenu.Size = new System.Drawing.Size(144, 22);
            this.MaterialyStripMenu.Text = "Материалы";
            // 
            // PostavschikiStripMenu
            // 
            this.PostavschikiStripMenu.Name = "PostavschikiStripMenu";
            this.PostavschikiStripMenu.Size = new System.Drawing.Size(144, 22);
            this.PostavschikiStripMenu.Text = "Поставщики";
            // 
            // MOLStripMenu
            // 
            this.MOLStripMenu.Name = "MOLStripMenu";
            this.MOLStripMenu.Size = new System.Drawing.Size(144, 22);
            this.MOLStripMenu.Text = "МОЛ";
            // 
            // OtchetyStripMenu
            // 
            this.OtchetyStripMenu.Name = "OtchetyStripMenu";
            this.OtchetyStripMenu.Size = new System.Drawing.Size(60, 20);
            this.OtchetyStripMenu.Text = "Отчеты";
            // 
            // ExitStripMenu
            // 
            this.ExitStripMenu.Name = "ExitStripMenu";
            this.ExitStripMenu.Size = new System.Drawing.Size(54, 20);
            this.ExitStripMenu.Text = "Выход";
            this.ExitStripMenu.Click += new System.EventHandler(this.ExitStripMenu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Приход";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Расход";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Текущие остатки";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(572, 309);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Учет материалов на складе";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SpravochnikiStripMenu;
        private System.Windows.Forms.ToolStripMenuItem SkladyStripMenu;
        private System.Windows.Forms.ToolStripMenuItem MaterialyStripMenu;
        private System.Windows.Forms.ToolStripMenuItem PostavschikiStripMenu;
        private System.Windows.Forms.ToolStripMenuItem MOLStripMenu;
        private System.Windows.Forms.ToolStripMenuItem OtchetyStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitStripMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}