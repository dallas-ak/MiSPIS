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
            this.buttonPrihod = new System.Windows.Forms.Button();
            this.buttonRashod = new System.Windows.Forms.Button();
            this.buttonOstatki = new System.Windows.Forms.Button();
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
            this.SkladyStripMenu.Click += new System.EventHandler(this.SkladyStripMenu_Click);
            // 
            // MaterialyStripMenu
            // 
            this.MaterialyStripMenu.Name = "MaterialyStripMenu";
            this.MaterialyStripMenu.Size = new System.Drawing.Size(144, 22);
            this.MaterialyStripMenu.Text = "Материалы";
            this.MaterialyStripMenu.Click += new System.EventHandler(this.MaterialyStripMenu_Click);
            // 
            // PostavschikiStripMenu
            // 
            this.PostavschikiStripMenu.Name = "PostavschikiStripMenu";
            this.PostavschikiStripMenu.Size = new System.Drawing.Size(144, 22);
            this.PostavschikiStripMenu.Text = "Поставщики";
            this.PostavschikiStripMenu.Click += new System.EventHandler(this.PostavschikiStripMenu_Click);
            // 
            // MOLStripMenu
            // 
            this.MOLStripMenu.Name = "MOLStripMenu";
            this.MOLStripMenu.Size = new System.Drawing.Size(144, 22);
            this.MOLStripMenu.Text = "МОЛ";
            this.MOLStripMenu.Click += new System.EventHandler(this.MOLStripMenu_Click);
            // 
            // OtchetyStripMenu
            // 
            this.OtchetyStripMenu.Name = "OtchetyStripMenu";
            this.OtchetyStripMenu.Size = new System.Drawing.Size(60, 20);
            this.OtchetyStripMenu.Text = "Отчёты";
            this.OtchetyStripMenu.Click += new System.EventHandler(this.OtchetyStripMenu_Click);
            // 
            // ExitStripMenu
            // 
            this.ExitStripMenu.Name = "ExitStripMenu";
            this.ExitStripMenu.Size = new System.Drawing.Size(54, 20);
            this.ExitStripMenu.Text = "Выход";
            this.ExitStripMenu.Click += new System.EventHandler(this.ExitStripMenu_Click);
            // 
            // buttonPrihod
            // 
            this.buttonPrihod.Location = new System.Drawing.Point(20, 50);
            this.buttonPrihod.Name = "buttonPrihod";
            this.buttonPrihod.Size = new System.Drawing.Size(240, 60);
            this.buttonPrihod.TabIndex = 1;
            this.buttonPrihod.Text = "Приход";
            this.buttonPrihod.UseVisualStyleBackColor = true;
            this.buttonPrihod.Click += new System.EventHandler(this.buttonPrihod_Click);
            // 
            // buttonRashod
            // 
            this.buttonRashod.Location = new System.Drawing.Point(20, 135);
            this.buttonRashod.Name = "buttonRashod";
            this.buttonRashod.Size = new System.Drawing.Size(240, 60);
            this.buttonRashod.TabIndex = 3;
            this.buttonRashod.Text = "Расход";
            this.buttonRashod.UseVisualStyleBackColor = true;
            this.buttonRashod.Click += new System.EventHandler(this.buttonRashod_Click);
            // 
            // buttonOstatki
            // 
            this.buttonOstatki.Location = new System.Drawing.Point(20, 220);
            this.buttonOstatki.Name = "buttonOstatki";
            this.buttonOstatki.Size = new System.Drawing.Size(240, 60);
            this.buttonOstatki.TabIndex = 4;
            this.buttonOstatki.Text = "Текущие остатки";
            this.buttonOstatki.UseVisualStyleBackColor = true;
            this.buttonOstatki.Click += new System.EventHandler(this.buttonOstatki_Click);
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
            this.Controls.Add(this.buttonOstatki);
            this.Controls.Add(this.buttonRashod);
            this.Controls.Add(this.buttonPrihod);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Учет материалов на складе";
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
        private System.Windows.Forms.Button buttonPrihod;
        private System.Windows.Forms.Button buttonRashod;
        private System.Windows.Forms.Button buttonOstatki;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}