using login.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Form settings
            this.Text = "Đăng nhập";
            this.Size = new Size(500, 300);

            // PictureBox
            pictureBox1 = new PictureBox();
            pictureBox1.Image = Image.FromFile("path_to_your_image.jpg"); // Add your image path here
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox1);

            // Username Label
            usernameLabel = new Label();
            usernameLabel.Text = "Tên tài khoản";
            usernameLabel.Location = new Point(220, 30);
            this.Controls.Add(usernameLabel);

            // Username TextBox
            usernameTextBox = new TextBox();
            usernameTextBox.Location = new Point(320, 30);
            usernameTextBox.Width = 150;
            this.Controls.Add(usernameTextBox);

            // Password Label
            passwordLabel = new Label();
            passwordLabel.Text = "Mật khẩu";
            passwordLabel.Location = new Point(220, 80);
            this.Controls.Add(passwordLabel);

            // Password TextBox
            passwordTextBox = new TextBox();
            passwordTextBox.Location = new Point(320, 80);
            passwordTextBox.Width = 150;
            passwordTextBox.UseSystemPasswordChar = true;
            this.Controls.Add(passwordTextBox);

            // Login Button
            loginButton = new Button();
            loginButton.Text = "Đăng nhập";
            loginButton.Location = new Point(320, 130);
            loginButton.Click += new EventHandler(LoginButton_Click);
            this.Controls.Add(loginButton);
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Handle login logic here
            MessageBox.Show("Login button clicked");
        }
        private void usernameLabel_Click(Object sender, EventArgs e)
        {
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);

        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

        
    }

