using MiSPIS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiSPIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Point lastPoint;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ExitStripMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SkladyStripMenu_Click(object sender, EventArgs e)
        {
            SkladyForm skladyForm = new SkladyForm();
            skladyForm.Show();
        }

        private void MaterialyStripMenu_Click(object sender, EventArgs e)
        {
            MaterialyForm materialyForm = new MaterialyForm();
            materialyForm.Show();
        }

        private void PostavschikiStripMenu_Click(object sender, EventArgs e)
        {
            PostavschikiForm postavschikiForm = new PostavschikiForm();
            postavschikiForm.Show();
        }

        private void MOLStripMenu_Click(object sender, EventArgs e)
        {
            MOLForm molForm = new MOLForm();
            molForm.Show();
        }

        private void OtchetyStripMenu_Click(object sender, EventArgs e)
        {
            OtchetyForm otchetyForm = new OtchetyForm();
            otchetyForm.Show();
        }

        private void buttonPrihod_Click(object sender, EventArgs e)
        {
            PrihodForm prihodForm = new PrihodForm();
            prihodForm.Show();
        }

        private void buttonRashod_Click(object sender, EventArgs e)
        {
            RashodForm rashodForm = new RashodForm();
            rashodForm.Show();
        }

        private void buttonOstatki_Click(object sender, EventArgs e)
        {
            OstatkiForm ostatkiForm = new OstatkiForm();
            ostatkiForm.Show();
        }
    }
}




