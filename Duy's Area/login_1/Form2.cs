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
    public partial class infoTextBoxes5 : Form
    {
    
        private Label[] infoLabels;
        private TextBox[] infoTextBoxes;
        private Button btnMessages;
        private Button btnServices;
        private Button btnChangePassword;
        private Button btnLockMachine;
        private decimal soDuHienTai = 1000; // Giả sử số dư ban đầu là 1000
        private decimal soTienMotGio = 100; // Giả sử số tiền trong một giờ là 100

        public infoTextBoxes5()
        {
            InitializeComponent1();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
        private void InitializeComponent1()
        {
            this.lblUserName = new Label();
            this.lblStatus = new Label();
            this.btnLogout = new Button();

            // Set properties and add controls
            // User Label
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new Point(20, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new Size(100, 29);
            this.lblUserName.Text = "HIEU123";
            this.Controls.Add(this.lblUserName);
            // Status Indicator
            lblStatus = new Label
            {
                Text = "●",
                ForeColor = Color.Green,
                Location = new Point(150, 28),
                AutoSize = true
            };
            this.Controls.Add(lblStatus);
            // Logout Button
            this.btnLogout.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new Point(350, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(30, 30);
            this.btnLogout.Text = "⟳";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
            this.Controls.Add(this.btnLogout);

            // Information Labels and TextBoxes
            string[] infoTexts = { "Tổng thời gian", "Thời gian sử dụng", "Thời gian còn lại", "Chi phí sử dụng", "Chi phí dịch vụ" };
            this.infoLabels = new Label[infoTexts.Length];
            this.infoTextBoxes = new TextBox[infoTexts.Length];

            int yPosition = 70;
            for (int i = 0; i < infoTexts.Length; i++)
            {
                this.infoLabels[i] = new Label
                {
                    Text = infoTexts[i],
                    Location = new Point(20, yPosition),
                    AutoSize = true
                };
                this.Controls.Add(this.infoLabels[i]);

                this.infoTextBoxes[i] = new TextBox
                {
                    Location = new Point(150, yPosition - 4),
                    Size = new Size(200, 22),
                    ReadOnly = true,
                    BackColor = Color.LightGray
                };
                this.Controls.Add(this.infoTextBoxes[i]);

                yPosition += 40;
            }
            // Buttons
            btnMessages = new Button
            {
                Text = "Tin nhắn",
                Location = new Point(20, yPosition + 20),
                Size = new Size(160, 40),
                BackColor = Color.LightGray
            };
            btnMessages.Click += btnMessages1_Click;
            this.Controls.Add(btnMessages);

            btnServices = new Button
            {
                Text = "Dịch vụ",
                Location = new Point(200, yPosition + 20),
                Size = new Size(160, 40),
                BackColor = Color.LightGray
            };
            btnServices.Click += btnServices1_Click;
            this.Controls.Add(btnServices);

            btnChangePassword = new Button
            {
                Text = "Mật khẩu",
                Location = new Point(20, yPosition + 80),
                Size = new Size(160, 40),
                BackColor = Color.YellowGreen
            };
            btnChangePassword.Click += btnChangePassword1_Click;
            this.Controls.Add(btnChangePassword);

            btnLockMachine = new Button
            {
                Text = "Khóa máy",
                Location = new Point(200, yPosition + 80),
                Size = new Size(160, 40),
                BackColor = Color.GreenYellow
            };
            btnLockMachine.Click += btnLockMachine1_Click;
            this.Controls.Add(btnLockMachine);
        }

        private decimal TinhToanSoDu(decimal soDuHienTai, decimal soTienMotGio)
        {
            decimal soTienTrongMotGio = soTienMotGio * 1; // Ví dụ, 1 giờ
            decimal soDuSauKhiDung = soDuHienTai - soTienTrongMotGio;
            return soDuSauKhiDung;
        }
    }


}

