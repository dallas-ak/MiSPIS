using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiSPIS.Forms
{
    public partial class AddSkladForm : Form
    {
        public AddSkladForm()
        {
            InitializeComponent();
        }

        private void toolStripAddType_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTypeSkladForm addTypeSkladForm = new AddTypeSkladForm();
            addTypeSkladForm.Show();
        }
    }
}
