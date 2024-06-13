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
            this.StripMenuWarehouses = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.PostavschikiStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MOLStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuClients = new System.Windows.Forms.ToolStripMenuItem();
            this.OtchetyStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuReportsSales = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuReportsManagers = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonInvoices = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonOstatki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpravochnikiStripMenu,
            this.OtchetyStripMenu,
            this.ExitStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SpravochnikiStripMenu
            // 
            this.SpravochnikiStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuWarehouses,
            this.StripMenuProducts,
            this.PostavschikiStripMenu,
            this.MOLStripMenu,
            this.StripMenuClients});
            this.SpravochnikiStripMenu.Name = "SpravochnikiStripMenu";
            this.SpravochnikiStripMenu.Size = new System.Drawing.Size(117, 24);
            this.SpravochnikiStripMenu.Text = "Справочники";
            // 
            // StripMenuWarehouses
            // 
            this.StripMenuWarehouses.Name = "StripMenuWarehouses";
            this.StripMenuWarehouses.Size = new System.Drawing.Size(178, 26);
            this.StripMenuWarehouses.Text = "Склады";
            this.StripMenuWarehouses.Click += new System.EventHandler(this.StripMenuWarehouses_Click);
            // 
            // StripMenuProducts
            // 
            this.StripMenuProducts.Name = "StripMenuProducts";
            this.StripMenuProducts.Size = new System.Drawing.Size(178, 26);
            this.StripMenuProducts.Text = "Товары";
            this.StripMenuProducts.Click += new System.EventHandler(this.StripMenuProducts_Click);
            // 
            // PostavschikiStripMenu
            // 
            this.PostavschikiStripMenu.Name = "PostavschikiStripMenu";
            this.PostavschikiStripMenu.Size = new System.Drawing.Size(178, 26);
            this.PostavschikiStripMenu.Text = "Поставщики";
            this.PostavschikiStripMenu.Click += new System.EventHandler(this.StripMenuSuppliers_Click);
            // 
            // MOLStripMenu
            // 
            this.MOLStripMenu.Name = "MOLStripMenu";
            this.MOLStripMenu.Size = new System.Drawing.Size(178, 26);
            this.MOLStripMenu.Text = "МОЛ";
            this.MOLStripMenu.Click += new System.EventHandler(this.StripMenuResponsiblePersons_Click);
            // 
            // StripMenuClients
            // 
            this.StripMenuClients.Name = "StripMenuClients";
            this.StripMenuClients.Size = new System.Drawing.Size(178, 26);
            this.StripMenuClients.Text = "Клиенты";
            this.StripMenuClients.Click += new System.EventHandler(this.StripMenuClients_Click);
            // 
            // OtchetyStripMenu
            // 
            this.OtchetyStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuReportsSales,
            this.StripMenuReportsManagers});
            this.OtchetyStripMenu.Name = "OtchetyStripMenu";
            this.OtchetyStripMenu.Size = new System.Drawing.Size(73, 24);
            this.OtchetyStripMenu.Text = "Отчёты";
            // 
            // StripMenuReportsSales
            // 
            this.StripMenuReportsSales.Name = "StripMenuReportsSales";
            this.StripMenuReportsSales.Size = new System.Drawing.Size(303, 26);
            this.StripMenuReportsSales.Text = "Отчет по проданным товарам";
            this.StripMenuReportsSales.Click += new System.EventHandler(this.StripMenuReportsSales_Click);
            // 
            // StripMenuReportsManagers
            // 
            this.StripMenuReportsManagers.Name = "StripMenuReportsManagers";
            this.StripMenuReportsManagers.Size = new System.Drawing.Size(303, 26);
            this.StripMenuReportsManagers.Text = "Отчет по менеджерам";
            this.StripMenuReportsManagers.Click += new System.EventHandler(this.StripMenuReportsManagers_Click);
            // 
            // ExitStripMenu
            // 
            this.ExitStripMenu.Name = "ExitStripMenu";
            this.ExitStripMenu.Size = new System.Drawing.Size(67, 24);
            this.ExitStripMenu.Text = "Выход";
            this.ExitStripMenu.Click += new System.EventHandler(this.ExitStripMenu_Click);
            // 
            // buttonInvoices
            // 
            this.buttonInvoices.Location = new System.Drawing.Point(20, 50);
            this.buttonInvoices.Name = "buttonInvoices";
            this.buttonInvoices.Size = new System.Drawing.Size(240, 60);
            this.buttonInvoices.TabIndex = 1;
            this.buttonInvoices.Text = "Покупки";
            this.buttonInvoices.UseVisualStyleBackColor = true;
            this.buttonInvoices.Click += new System.EventHandler(this.buttonInvoices_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.Location = new System.Drawing.Point(20, 135);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(240, 60);
            this.buttonSales.TabIndex = 3;
            this.buttonSales.Text = "Продажи";
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(572, 309);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOstatki);
            this.Controls.Add(this.buttonSales);
            this.Controls.Add(this.buttonInvoices);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem StripMenuWarehouses;
        private System.Windows.Forms.ToolStripMenuItem StripMenuProducts;
        private System.Windows.Forms.ToolStripMenuItem PostavschikiStripMenu;
        private System.Windows.Forms.ToolStripMenuItem MOLStripMenu;
        private System.Windows.Forms.ToolStripMenuItem OtchetyStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitStripMenu;
        private System.Windows.Forms.Button buttonInvoices;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button buttonOstatki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuClients;
        private System.Windows.Forms.ToolStripMenuItem StripMenuReportsSales;
        private System.Windows.Forms.ToolStripMenuItem StripMenuReportsManagers;
    }
}