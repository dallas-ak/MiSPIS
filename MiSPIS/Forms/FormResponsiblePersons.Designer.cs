namespace MiSPIS
{
    partial class FormResponsiblePersons
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
            this.dataGridViewResponsiblePersons = new System.Windows.Forms.DataGridView();
            this.buttonAddResponsiblePerson = new System.Windows.Forms.Button();
            this.buttonDeleteResponsiblePersont = new System.Windows.Forms.Button();
            this.textBoxResponsiblePersonName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResponsiblePersons)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResponsiblePersons
            // 
            this.dataGridViewResponsiblePersons.AllowUserToAddRows = false;
            this.dataGridViewResponsiblePersons.AllowUserToDeleteRows = false;
            this.dataGridViewResponsiblePersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResponsiblePersons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewResponsiblePersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResponsiblePersons.Location = new System.Drawing.Point(13, 40);
            this.dataGridViewResponsiblePersons.Name = "dataGridViewResponsiblePersons";
            this.dataGridViewResponsiblePersons.ReadOnly = true;
            this.dataGridViewResponsiblePersons.RowHeadersWidth = 51;
            this.dataGridViewResponsiblePersons.Size = new System.Drawing.Size(496, 296);
            this.dataGridViewResponsiblePersons.TabIndex = 0;
            // 
            // buttonAddResponsiblePerson
            // 
            this.buttonAddResponsiblePerson.Location = new System.Drawing.Point(207, 11);
            this.buttonAddResponsiblePerson.Name = "buttonAddResponsiblePerson";
            this.buttonAddResponsiblePerson.Size = new System.Drawing.Size(148, 23);
            this.buttonAddResponsiblePerson.TabIndex = 1;
            this.buttonAddResponsiblePerson.Text = "Добавить МОЛ";
            this.buttonAddResponsiblePerson.UseVisualStyleBackColor = true;
            this.buttonAddResponsiblePerson.Click += new System.EventHandler(this.buttonAddResponsiblePerson_Click);
            // 
            // buttonDeleteResponsiblePersont
            // 
            this.buttonDeleteResponsiblePersont.Location = new System.Drawing.Point(361, 11);
            this.buttonDeleteResponsiblePersont.Name = "buttonDeleteResponsiblePersont";
            this.buttonDeleteResponsiblePersont.Size = new System.Drawing.Size(148, 23);
            this.buttonDeleteResponsiblePersont.TabIndex = 2;
            this.buttonDeleteResponsiblePersont.Text = "Удалить МОЛ";
            this.buttonDeleteResponsiblePersont.UseVisualStyleBackColor = true;
            this.buttonDeleteResponsiblePersont.Click += new System.EventHandler(this.buttonDeleteResponsiblePerson_Click);
            // 
            // textBoxResponsiblePersonName
            // 
            this.textBoxResponsiblePersonName.Location = new System.Drawing.Point(13, 13);
            this.textBoxResponsiblePersonName.Name = "textBoxResponsiblePersonName";
            this.textBoxResponsiblePersonName.Size = new System.Drawing.Size(177, 20);
            this.textBoxResponsiblePersonName.TabIndex = 3;
            // 
            // FormResponsiblePersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 347);
            this.Controls.Add(this.textBoxResponsiblePersonName);
            this.Controls.Add(this.buttonDeleteResponsiblePersont);
            this.Controls.Add(this.buttonAddResponsiblePerson);
            this.Controls.Add(this.dataGridViewResponsiblePersons);
            this.Name = "FormResponsiblePersons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Материально-ответственные лица (МОЛ)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResponsiblePersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResponsiblePersons;
        private System.Windows.Forms.Button buttonAddResponsiblePerson;
        private System.Windows.Forms.Button buttonDeleteResponsiblePersont;
        private System.Windows.Forms.TextBox textBoxResponsiblePersonName;
    }
}