namespace MiSPIS
{
    partial class FormStock
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
            this.comboBoxWarehouses = new System.Windows.Forms.ComboBox();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.buttonLoadStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxWarehouses
            // 
            this.comboBoxWarehouses.FormattingEnabled = true;
            this.comboBoxWarehouses.Location = new System.Drawing.Point(12, 14);
            this.comboBoxWarehouses.Name = "comboBoxWarehouses";
            this.comboBoxWarehouses.Size = new System.Drawing.Size(254, 21);
            this.comboBoxWarehouses.TabIndex = 0;
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AllowUserToAddRows = false;
            this.dataGridViewStock.AllowUserToDeleteRows = false;
            this.dataGridViewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewStock.Location = new System.Drawing.Point(0, 53);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.ReadOnly = true;
            this.dataGridViewStock.RowHeadersWidth = 51;
            this.dataGridViewStock.Size = new System.Drawing.Size(682, 600);
            this.dataGridViewStock.TabIndex = 1;
            // 
            // buttonLoadStock
            // 
            this.buttonLoadStock.Location = new System.Drawing.Point(498, 12);
            this.buttonLoadStock.Name = "buttonLoadStock";
            this.buttonLoadStock.Size = new System.Drawing.Size(172, 23);
            this.buttonLoadStock.TabIndex = 2;
            this.buttonLoadStock.Text = "Заполнить";
            this.buttonLoadStock.UseVisualStyleBackColor = true;
            this.buttonLoadStock.Click += new System.EventHandler(this.buttonLoadStock_Click);
            // 
            // FormStock
            // 
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.buttonLoadStock);
            this.Controls.Add(this.dataGridViewStock);
            this.Controls.Add(this.comboBoxWarehouses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Остатки на складах";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWarehouses;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.Button buttonLoadStock;
    }
}