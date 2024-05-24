using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.background;
            this.WindowState = FormWindowState.Maximized;
            this.panelContainer.Location = new Point(
                (this.ClientSize.Width - this.panelContainer.Width) / 2,
                (this.ClientSize.Height - this.panelContainer.Height) / 2);
            this.Resize += (s, e) =>
            {
                this.panelContainer.Location = new Point(
                    (this.ClientSize.Width - this.panelContainer.Width) / 2,
                    (this.ClientSize.Height - this.panelContainer.Height) / 2
                );
                this.panel2.Size = this.ClientSize;
            };
            this.panel2.Size = this.ClientSize;
            this.pictureBox1.Size = this.ClientSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.nameAccount.Texts;
            string pass = this.password.Texts;
            if (!name.Equals("") && !pass.Equals(""))
            {
                this.Hide();
                infoBox frm2 = new infoBox(name);
                frm2.ShowDialog();
                frm2 = null;
                this.Show();
            }
        }

    }
}
