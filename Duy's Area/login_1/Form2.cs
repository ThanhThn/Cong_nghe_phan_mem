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
    public partial class infoBox : Form
    {
        float dpiX;
        private Label[] infoLabels;
        private TextBox[] infoTextBoxes;
        private Button btnMessages;
        private Button btnServices;
        private Button btnChangePassword;
        private Button btnLockMachine;
        private decimal soDuHienTai = 1000; // Giả sử số dư ban đầu là 1000
        private decimal soTienMotGio = 100; // Giả sử số tiền trong một giờ là 100

        public infoBox(string nameAccount)
        {
            InitializeDPI();
            InitializeComponent();
            this.lblUserName.Text = TrimTextToFit(nameAccount, this.lblUserName, 80);
            this.Size = new Size(411, 497);
            this.containerTime.Width = 353;
            this.containerTime.Height = 208;
            this.containerButton.Width = 353;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = ColorTranslator.FromHtml("#F7F7F5");
            float fontSize30 = PixelsToPoints(26);
            float fontSize16 = PixelsToPoints(14);
            this.lblUserName.Font = new Font("Inter ExtraBold", fontSize30, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblSumTime.Font = new Font("Inter SemiBold", fontSize16, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedTime.Font = new System.Drawing.Font("Inter SemiBold", fontSize16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedCost.Font = new System.Drawing.Font("Inter SemiBold", fontSize16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCost.Font = new System.Drawing.Font("Inter SemiBold", fontSize16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainTime.Font = new System.Drawing.Font("Inter SemiBold", fontSize16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SetStatusButtonPosition();

        }
        private void SetStatusButtonPosition()
        {
            this.status.Location = new Point(this.lblUserName.Right + 11, this.status.Top);
        }


        private void InitializeDPI()
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                dpiX = graphics.DpiX;
            }
        }
        private string TrimTextToFit(string text, Label label, int maxWidth)
        {
            string trimmedText = text;
            using (Graphics g = label.CreateGraphics())
            {
                SizeF size = g.MeasureString(trimmedText, label.Font);
                while (size.Width > maxWidth)
                {
                    if (trimmedText.Length > 0)
                    {
                        trimmedText = trimmedText.Substring(0, trimmedText.Length - 1);
                        size = g.MeasureString(trimmedText + "...", label.Font);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return trimmedText + (trimmedText.Length < text.Length ? "..." : "");
        }
        public float PixelsToPoints(int pixels)
        {
            return pixels * 72 / dpiX;
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Logout button clicked");
            soDuHienTai = TinhToanSoDu(soDuHienTai, soTienMotGio);

        }
        private void btnMessages1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Messages button clicked");
        }

        private void btnServices1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Services button clicked");
        }

        private void btnChangePassword1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password button clicked");
        }

        private void btnLockMachine1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lock Machine button clicked");
        }

        private decimal TinhToanSoDu(decimal soDuHienTai, decimal soTienMotGio)
        {
            decimal soTienTrongMotGio = soTienMotGio * 1; // Ví dụ, 1 giờ
            decimal soDuSauKhiDung = soDuHienTai - soTienTrongMotGio;
            return soDuSauKhiDung;
        }
        private void lblUserName_TextChanged(object sender, EventArgs e)
        {
            this.status.Location = new Point(this.lblUserName.Width + this.lblUserName.Location.X + 11, this.status.Location.Y);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

