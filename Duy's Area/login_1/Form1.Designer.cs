using System.Drawing;
using System.Windows.Forms;
using login_1.asset;
using login_1.Properties;

namespace login_1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new login_1.asset.RoundPanel();
            this.password = new login_1.asset.RoundedTextBox();
            this.nameAccount = new login_1.asset.RoundedTextBox();
            this.roundImage1 = new login_1.asset.RoundImage();
            this.buttonLogin = new login_1.asset.RoundButton();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.readyLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signInTxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login_1.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderRadius = 29;
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.nameAccount);
            this.panel1.Controls.Add(this.roundImage1);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 513);
            this.panel1.TabIndex = 7;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.password.BorderRadius = 16;
            this.password.BorderSize = 2;
            this.password.Font = new System.Drawing.Font("Inter Medium", 11F);
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(513, 290);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(18, 7, 18, 7);
            this.password.PasswordChar = false;
            this.password.PlaceholderColor = System.Drawing.Color.Black;
            this.password.PlaceholderText = "";
            this.password.Size = new System.Drawing.Size(500, 38);
            this.password.TabIndex = 9;
            this.password.Texts = "";
            this.password.UnderlinedStyle = false;
            // 
            // nameAccount
            // 
            this.nameAccount.BackColor = System.Drawing.Color.White;
            this.nameAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.nameAccount.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.nameAccount.BorderRadius = 16;
            this.nameAccount.BorderSize = 2;
            this.nameAccount.Font = new System.Drawing.Font("Inter Medium", 11F);
            this.nameAccount.ForeColor = System.Drawing.Color.Black;
            this.nameAccount.Location = new System.Drawing.Point(513, 195);
            this.nameAccount.Margin = new System.Windows.Forms.Padding(4);
            this.nameAccount.Multiline = false;
            this.nameAccount.Name = "nameAccount";
            this.nameAccount.Padding = new System.Windows.Forms.Padding(18, 7, 18, 7);
            this.nameAccount.PasswordChar = false;
            this.nameAccount.PlaceholderColor = System.Drawing.Color.Black;
            this.nameAccount.PlaceholderText = "";
            this.nameAccount.Size = new System.Drawing.Size(500, 38);
            this.nameAccount.TabIndex = 8;
            this.nameAccount.Texts = "";
            this.nameAccount.UnderlinedStyle = false;
            // 
            // roundImage1
            // 
            this.roundImage1.BorderRadius = 19;
            this.roundImage1.Image = global::login_1.Properties.Resources.bg_play;
            this.roundImage1.Location = new System.Drawing.Point(16, 16);
            this.roundImage1.Name = "roundImage1";
            this.roundImage1.Size = new System.Drawing.Size(440, 480);
            this.roundImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundImage1.TabIndex = 7;
            this.roundImage1.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.buttonLogin.BorderColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BorderRadius = 16;
            this.buttonLogin.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(646, 370);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(240, 44);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.labelLogin.Location = new System.Drawing.Point(636, 76);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(271, 57);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(523, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(523, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(477, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // readyLabel
            // 
            this.readyLabel.AutoSize = true;
            this.readyLabel.BackColor = System.Drawing.Color.White;
            this.readyLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.readyLabel.Location = new System.Drawing.Point(534, 89);
            this.readyLabel.Name = "readyLabel";
            this.readyLabel.Size = new System.Drawing.Size(156, 23);
            this.readyLabel.TabIndex = 1;
            this.readyLabel.Text = "Ready to Login";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(480, 132);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(99, 19);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "User Name";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(484, 154);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(181, 22);
            this.userNameTxt.TabIndex = 3;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(484, 228);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(181, 22);
            this.passwordTxt.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(480, 206);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 19);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // signInTxt
            // 
            this.signInTxt.BackColor = System.Drawing.Color.Black;
            this.signInTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInTxt.ForeColor = System.Drawing.Color.White;
            this.signInTxt.Location = new System.Drawing.Point(477, 313);
            this.signInTxt.Name = "signInTxt";
            this.signInTxt.Size = new System.Drawing.Size(244, 35);
            this.signInTxt.TabIndex = 6;
            this.signInTxt.Text = "Sign In";
            this.signInTxt.UseVisualStyleBackColor = false;
            this.signInTxt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);

            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signInTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.readyLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundImage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelLogin;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RoundPanel panel1;
        private Panel panel2;
        private RoundImage roundImage1;
        private RoundButton buttonLogin;
        private RoundedTextBox nameAccount;
        private RoundedTextBox password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label readyLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button signInTxt;
    }
}

