using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace login_1
{
    public partial class infoBox : Form
    {
        float dpiX;
        string id;
        private Label[] infoLabels;
        private TextBox[] infoTextBoxes;
        private Button btnMessages;
        private Button btnServices;
        private Button btnChangePassword;
        private Button btnLockMachine;
        private double soDuHienTai; // Giả sử số dư ban đầu là 1000
        private double soTienMotGio; // Giả sử số tiền trong một giờ là 100
        private int hoursRemain;
        private int minutesRemain;
        private int secondsRemain;
        private int hoursUsed = 0;
        private int minutesUsed = 0;
        private int secondsUsed = 0;

        public infoBox(string id, string nameAccount, double soDu, double phi)
        {
            this.id = id;
            this.soDuHienTai = soDu;
            this.soTienMotGio = phi;
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
            this.lblUserName.Font = new Font("Inter ExtraBold", fontSize30);
            this.lblSumTime.Font = new Font("Inter SemiBold", fontSize16);
            this.lblUsedTime.Font = new Font("Inter SemiBold", fontSize16);
            this.lblUsedCost.Font = new Font("Inter SemiBold", fontSize16);
            this.lblServiceCost.Font = new Font("Inter SemiBold", fontSize16);
            this.lblRemainTime.Font = new Font("Inter SemiBold", fontSize16);

            hoursRemain = (int)Math.Floor(this.soDuHienTai / this.soTienMotGio);
            minutesRemain = (int)Math.Floor(((this.soDuHienTai % this.soTienMotGio) / this.soTienMotGio) * 60);
            secondsRemain = (int)Math.Ceiling((((this.soDuHienTai % this.soTienMotGio) / this.soTienMotGio) * 60 - minutesRemain) * 60);
            this.txtSumTime.Texts = showTime(hoursRemain, minutesRemain, secondsRemain);
            this.txtUsedTime.Texts = showTime(0, 0, 0);
            this.txtRemainTime.Texts = showTime(hoursRemain, minutesRemain, secondsRemain);
            this.txtUsedCost.Texts = soTienMotGio.ToString("N0");
            this.txtCostService.Texts = "0";
            SetStatusButtonPosition();
            this.timer1.Start();
        }

        private string showTime(int gio, int phut, int giay)
        {
            return string.Format("{0:00}:{1:00}:{2:00}", gio, phut, giay);
        }

        private void SetStatusButtonPosition()
        {
            this.status.Location = new Point(this.lblUserName.Right + 11, this.status.Top);
        }

        static double CalculateMoney(int hours, int minutes, int seconds, double feePerHour)
        {
            int totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

            double totalHours = totalSeconds / 3600.0;

            double totalMoney = totalHours * feePerHour;

            return totalMoney;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsUsed += 1;
            secondsRemain -= 1;

            if (secondsRemain < 0)
            {
                secondsRemain = 59;
                minutesRemain -= 1;
            }

            if (minutesRemain < 0)
            {
                minutesRemain = 59;
                hoursRemain -= 1;
            }

            if (hoursRemain < 0)
            {
                this.Close();
            }
            else
            {
                this.txtRemainTime.Texts = showTime(hoursRemain, minutesRemain, secondsRemain);
            }

            if (secondsUsed > 59)
            {
                secondsUsed = 0;
                minutesUsed += 1;
            }

            if (minutesUsed > 59)
            {
                minutesUsed = 0;
                hoursUsed += 1;
            }

            this.txtUsedTime.Texts = showTime(hoursUsed, minutesUsed, secondsUsed);

        }
        private async Task<string> PostApi(string url, string maKH, double soDu)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var postData = new Dictionary<string, string>{
                { "id", maKH },
                { "tienDu", soDu.ToString() }};

                    var content = new FormUrlEncodedContent(postData);

                    HttpResponseMessage response = await client.PostAsync(url, content);
                    response.EnsureSuccessStatusCode();

                    string result = await response.Content.ReadAsStringAsync();
                    return result;
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
        }

        private async void infoBox_FormClosing(object sender, FormClosingEventArgs e)
        {


            double remainMoney = CalculateMoney(hoursRemain, minutesRemain, secondsRemain, soTienMotGio);

            string urlBase = "https://localhost:7148/TaiKhoans/LogoutAccount";
            string result = await PostApi(urlBase, this.id, remainMoney);

            // Kiểm tra kết quả từ API
            if (!result.StartsWith("Error"))
            {
                using (JsonDocument document = JsonDocument.Parse(result))
                {
                    JsonElement root = document.RootElement;
                    bool success = root.GetProperty("success").GetBoolean();
                    string message = root.GetProperty("msg").GetString();

                    if (success)
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        MessageBox.Show(message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }
    }

}

