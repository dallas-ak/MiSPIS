namespace MiSPIS
{
    partial class FormWarehouses
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
            this.dataGridViewWarehouses = new System.Windows.Forms.DataGridView();
            this.buttonAddWarehouse = new System.Windows.Forms.Button();
            this.buttonDeleteWarehouse = new System.Windows.Forms.Button();
            this.textBoxWarehouseName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWarehouses
            // 
            this.dataGridViewWarehouses.AllowUserToAddRows = false;
            this.dataGridViewWarehouses.AllowUserToDeleteRows = false;
            this.dataGridViewWarehouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWarehouses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewWarehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouses.Location = new System.Drawing.Point(13, 40);
            this.dataGridViewWarehouses.Name = "dataGridViewWarehouses";
            this.dataGridViewWarehouses.ReadOnly = true;
            this.dataGridViewWarehouses.Size = new System.Drawing.Size(496, 296);
            this.dataGridViewWarehouses.TabIndex = 0;
            // 
            // buttonAddWarehouse
            // 
            this.buttonAddWarehouse.Location = new System.Drawing.Point(207, 11);
            this.buttonAddWarehouse.Name = "buttonAddWarehouse";
            this.buttonAddWarehouse.Size = new System.Drawing.Size(148, 23);
            this.buttonAddWarehouse.TabIndex = 1;
            this.buttonAddWarehouse.Text = "Добавить склад";
            this.buttonAddWarehouse.UseVisualStyleBackColor = true;
            this.buttonAddWarehouse.Click += new System.EventHandler(this.buttonAddWarehouse_Click);
            // 
            // buttonDeleteWarehouse
            // 
            this.buttonDeleteWarehouse.Location = new System.Drawing.Point(361, 11);
            this.buttonDeleteWarehouse.Name = "buttonDeleteWarehouse";
            this.buttonDeleteWarehouse.Size = new System.Drawing.Size(148, 23);
            this.buttonDeleteWarehouse.TabIndex = 2;
            this.buttonDeleteWarehouse.Text = "Удалить склад";
            this.buttonDeleteWarehouse.UseVisualStyleBackColor = true;
            this.buttonDeleteWarehouse.Click += new System.EventHandler(this.buttonDeleteWarehouse_Click);
            // 
            // textBoxWarehouseName
            // 
            this.textBoxWarehouseName.Location = new System.Drawing.Point(13, 13);
            this.textBoxWarehouseName.Name = "textBoxWarehouseName";
            this.textBoxWarehouseName.Size = new System.Drawing.Size(177, 20);
            this.textBoxWarehouseName.TabIndex = 3;
            // 
            // FormWarehouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 347);
            this.Controls.Add(this.textBoxWarehouseName);
            this.Controls.Add(this.buttonDeleteWarehouse);
            this.Controls.Add(this.buttonAddWarehouse);
            this.Controls.Add(this.dataGridViewWarehouses);
            this.Name = "FormWarehouses";
            this.Text = "Склады";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWarehouses;
        private System.Windows.Forms.Button buttonAddWarehouse;
        private System.Windows.Forms.Button buttonDeleteWarehouse;
        private System.Windows.Forms.TextBox textBoxWarehouseName;
    }
}