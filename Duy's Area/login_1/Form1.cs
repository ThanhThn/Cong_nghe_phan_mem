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

        private async void button1_Click(object sender, EventArgs e)
        {
            string name = this.nameAccount.Texts;
            string pass = this.password.Texts;
            if (!name.Equals("") && !pass.Equals(""))
            {
                string urlBase = "https://localhost:7148/TaiKhoans/LoginAccount";
                string url = $"{urlBase}?username={name}&password={pass}";
                string response = await CallApiAsync(url);
                if (!response.StartsWith("Error"))
                {
                    using (JsonDocument document = JsonDocument.Parse(response))
                    {
                        JsonElement root = document.RootElement;
                        bool success = root.GetProperty("success").GetBoolean();

                        if (success)
                        {
                            JsonElement elements = root.GetProperty("msg");
                            JsonElement user = elements.GetProperty("taiKhoan");
                            string id = user.GetProperty("MaTK").GetString();
                            double soDu = user.GetProperty("SoDu").GetDouble();
                            double phi = elements.GetProperty("phi").GetDouble();
                            this.Hide();
                            infoBox frm2 = new infoBox(id, name, soDu, phi);
                            frm2.ShowDialog();
                            frm2 = null;
                            this.Show();
                        }
                        else
                        {
                            string message = root.GetProperty("msg").GetString();
                            MessageBox.Show(message);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(response);
                }
            }
        }

        private async Task<String> CallApiAsync(String url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
        }
        
    }
}
