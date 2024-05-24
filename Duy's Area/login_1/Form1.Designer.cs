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
            this.panelContainer = new login_1.asset.RoundPanel();
            this.password = new login_1.asset.RoundedTextBox();
            this.nameAccount = new login_1.asset.RoundedTextBox();
            this.roundImage1 = new login_1.asset.RoundImage();
            this.buttonLogin = new login_1.asset.RoundButton();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login_1.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 81);
            this.panel2.TabIndex = 9;
            // 
            // panelContainer
            // 
            this.panelContainer.BorderRadius = 29;
            this.panelContainer.Controls.Add(this.labelPass);
            this.panelContainer.Controls.Add(this.labelName);
            this.panelContainer.Controls.Add(this.password);
            this.panelContainer.Controls.Add(this.nameAccount);
            this.panelContainer.Controls.Add(this.roundImage1);
            this.panelContainer.Controls.Add(this.buttonLogin);
            this.panelContainer.Controls.Add(this.labelLogin);
            this.panelContainer.Location = new System.Drawing.Point(74, 85);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(784, 417);
            this.panelContainer.TabIndex = 7;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.password.BorderRadius = 16;
            this.password.BorderSize = 2;
            this.password.Enable = true;
            this.password.Font = new System.Drawing.Font("Inter Medium", 11F);
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(385, 236);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(14, 6, 14, 6);
            this.password.PasswordChar = false;
            this.password.PlaceholderColor = System.Drawing.Color.Black;
            this.password.PlaceholderText = "";
            this.password.Size = new System.Drawing.Size(375, 32);
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
            this.nameAccount.Enable = true;
            this.nameAccount.Font = new System.Drawing.Font("Inter Medium", 11F);
            this.nameAccount.ForeColor = System.Drawing.Color.Black;
            this.nameAccount.Location = new System.Drawing.Point(385, 158);
            this.nameAccount.Margin = new System.Windows.Forms.Padding(4);
            this.nameAccount.Multiline = false;
            this.nameAccount.Name = "nameAccount";
            this.nameAccount.Padding = new System.Windows.Forms.Padding(14, 6, 14, 6);
            this.nameAccount.PasswordChar = false;
            this.nameAccount.PlaceholderColor = System.Drawing.Color.Black;
            this.nameAccount.PlaceholderText = "";
            this.nameAccount.Size = new System.Drawing.Size(375, 32);
            this.nameAccount.TabIndex = 8;
            this.nameAccount.Texts = "";
            this.nameAccount.UnderlinedStyle = false;
            // 
            // roundImage1
            // 
            this.roundImage1.BorderRadius = 19;
            this.roundImage1.Image = global::login_1.Properties.Resources.bg_play;
            this.roundImage1.Location = new System.Drawing.Point(12, 13);
            this.roundImage1.Margin = new System.Windows.Forms.Padding(2);
            this.roundImage1.Name = "roundImage1";
            this.roundImage1.Size = new System.Drawing.Size(330, 390);
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
            this.buttonLogin.Location = new System.Drawing.Point(484, 301);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(180, 36);
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
            this.labelLogin.Location = new System.Drawing.Point(477, 62);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(221, 46);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Đăng nhập";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Inter SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelName.Location = new System.Drawing.Point(391, 135);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(108, 19);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Tên tài khoản";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Inter SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPass.Location = new System.Drawing.Point(391, 213);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(78, 19);
            this.labelPass.TabIndex = 11;
            this.labelPass.Text = "Mật khẩu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundImage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelLogin;

        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundPanel panelContainer;
        private Panel panel2;
        private RoundImage roundImage1;
        private RoundButton buttonLogin;
        private RoundedTextBox nameAccount;
        private RoundedTextBox password;
        private Label labelName;
        private Label labelPass;
    }
}

