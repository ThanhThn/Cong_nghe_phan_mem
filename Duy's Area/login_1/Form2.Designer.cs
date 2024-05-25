using System.Drawing;

namespace login_1
{
    partial class infoBox
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
            this.components = new System.ComponentModel.Container();
            this.lblUserName = new System.Windows.Forms.Label();
            this.roundButton1 = new login_1.asset.RoundButton();
            this.status = new login_1.asset.RoundPanel();
            this.containerTime = new login_1.asset.RoundPanel();
            this.txtCostService = new login_1.asset.RoundedTextBox();
            this.txtUsedCost = new login_1.asset.RoundedTextBox();
            this.txtRemainTime = new login_1.asset.RoundedTextBox();
            this.txtUsedTime = new login_1.asset.RoundedTextBox();
            this.txtSumTime = new login_1.asset.RoundedTextBox();
            this.lblSumTime = new System.Windows.Forms.Label();
            this.lblUsedTime = new System.Windows.Forms.Label();
            this.lblRemainTime = new System.Windows.Forms.Label();
            this.lblUsedCost = new System.Windows.Forms.Label();
            this.lblServiceCost = new System.Windows.Forms.Label();
            this.containerButton = new login_1.asset.RoundPanel();
            this.btnLockMachine1 = new login_1.asset.RoundButton();
            this.btnServices1 = new login_1.asset.RoundButton();
            this.btnChangePassword1 = new login_1.asset.RoundButton();
            this.btnMessages1 = new login_1.asset.RoundButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.containerTime.SuspendLayout();
            this.containerButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Location = new System.Drawing.Point(45, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "HIEU113";
            this.lblUserName.TextChanged += new System.EventHandler(this.lblUserName_TextChanged);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundButton1.BorderColor = System.Drawing.Color.Transparent;
            this.roundButton1.BorderRadius = 29;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Image = global::login_1.Properties.Resources.Sign_in_circle;
            this.roundButton1.Location = new System.Drawing.Point(464, 25);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(40, 40);
            this.roundButton1.TabIndex = 20;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.status.BorderRadius = 12;
            this.status.Location = new System.Drawing.Point(145, 40);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(12, 12);
            this.status.TabIndex = 19;
            // 
            // containerTime
            // 
            this.containerTime.BackColor = System.Drawing.Color.White;
            this.containerTime.BorderRadius = 11;
            this.containerTime.Controls.Add(this.txtCostService);
            this.containerTime.Controls.Add(this.txtUsedCost);
            this.containerTime.Controls.Add(this.txtRemainTime);
            this.containerTime.Controls.Add(this.txtUsedTime);
            this.containerTime.Controls.Add(this.txtSumTime);
            this.containerTime.Controls.Add(this.lblSumTime);
            this.containerTime.Controls.Add(this.lblUsedTime);
            this.containerTime.Controls.Add(this.lblRemainTime);
            this.containerTime.Controls.Add(this.lblUsedCost);
            this.containerTime.Controls.Add(this.lblServiceCost);
            this.containerTime.Location = new System.Drawing.Point(29, 74);
            this.containerTime.Name = "containerTime";
            this.containerTime.Size = new System.Drawing.Size(494, 265);
            this.containerTime.TabIndex = 17;
            // 
            // txtCostService
            // 
            this.txtCostService.BackColor = System.Drawing.SystemColors.Window;
            this.txtCostService.BorderColor = System.Drawing.Color.Black;
            this.txtCostService.BorderFocusColor = System.Drawing.Color.Black;
            this.txtCostService.BorderRadius = 6;
            this.txtCostService.BorderSize = 1;
            this.txtCostService.Enable = true;
            this.txtCostService.Enabled = false;
            this.txtCostService.Font = new System.Drawing.Font("Inter SemiBold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCostService.ForeColor = System.Drawing.Color.Black;
            this.txtCostService.Location = new System.Drawing.Point(200, 208);
            this.txtCostService.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostService.Multiline = false;
            this.txtCostService.Name = "txtCostService";
            this.txtCostService.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtCostService.PasswordChar = false;
            this.txtCostService.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCostService.PlaceholderText = "";
            this.txtCostService.Size = new System.Drawing.Size(252, 32);
            this.txtCostService.TabIndex = 16;
            this.txtCostService.Texts = "";
            this.txtCostService.UnderlinedStyle = false;
            // 
            // txtUsedCost
            // 
            this.txtUsedCost.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsedCost.BorderColor = System.Drawing.Color.Black;
            this.txtUsedCost.BorderFocusColor = System.Drawing.Color.Black;
            this.txtUsedCost.BorderRadius = 6;
            this.txtUsedCost.BorderSize = 1;
            this.txtUsedCost.Enable = true;
            this.txtUsedCost.Enabled = false;
            this.txtUsedCost.Font = new System.Drawing.Font("Inter SemiBold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsedCost.ForeColor = System.Drawing.Color.Black;
            this.txtUsedCost.Location = new System.Drawing.Point(200, 161);
            this.txtUsedCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsedCost.Multiline = false;
            this.txtUsedCost.Name = "txtUsedCost";
            this.txtUsedCost.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtUsedCost.PasswordChar = false;
            this.txtUsedCost.PlaceholderColor = System.Drawing.Color.Black;
            this.txtUsedCost.PlaceholderText = "";
            this.txtUsedCost.Size = new System.Drawing.Size(252, 32);
            this.txtUsedCost.TabIndex = 15;
            this.txtUsedCost.Texts = "";
            this.txtUsedCost.UnderlinedStyle = false;
            // 
            // txtRemainTime
            // 
            this.txtRemainTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtRemainTime.BorderColor = System.Drawing.Color.Black;
            this.txtRemainTime.BorderFocusColor = System.Drawing.Color.Black;
            this.txtRemainTime.BorderRadius = 6;
            this.txtRemainTime.BorderSize = 1;
            this.txtRemainTime.Enable = true;
            this.txtRemainTime.Enabled = false;
            this.txtRemainTime.Font = new System.Drawing.Font("Inter SemiBold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtRemainTime.ForeColor = System.Drawing.Color.Black;
            this.txtRemainTime.Location = new System.Drawing.Point(200, 114);
            this.txtRemainTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemainTime.Multiline = false;
            this.txtRemainTime.Name = "txtRemainTime";
            this.txtRemainTime.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtRemainTime.PasswordChar = false;
            this.txtRemainTime.PlaceholderColor = System.Drawing.Color.Black;
            this.txtRemainTime.PlaceholderText = "";
            this.txtRemainTime.Size = new System.Drawing.Size(252, 32);
            this.txtRemainTime.TabIndex = 14;
            this.txtRemainTime.Texts = "";
            this.txtRemainTime.UnderlinedStyle = false;
            // 
            // txtUsedTime
            // 
            this.txtUsedTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsedTime.BorderColor = System.Drawing.Color.Black;
            this.txtUsedTime.BorderFocusColor = System.Drawing.Color.Black;
            this.txtUsedTime.BorderRadius = 6;
            this.txtUsedTime.BorderSize = 1;
            this.txtUsedTime.Enable = true;
            this.txtUsedTime.Enabled = false;
            this.txtUsedTime.Font = new System.Drawing.Font("Inter SemiBold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsedTime.ForeColor = System.Drawing.Color.Black;
            this.txtUsedTime.Location = new System.Drawing.Point(200, 67);
            this.txtUsedTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsedTime.Multiline = false;
            this.txtUsedTime.Name = "txtUsedTime";
            this.txtUsedTime.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtUsedTime.PasswordChar = false;
            this.txtUsedTime.PlaceholderColor = System.Drawing.Color.Black;
            this.txtUsedTime.PlaceholderText = "";
            this.txtUsedTime.Size = new System.Drawing.Size(252, 32);
            this.txtUsedTime.TabIndex = 13;
            this.txtUsedTime.Texts = "";
            this.txtUsedTime.UnderlinedStyle = false;
            // 
            // txtSumTime
            // 
            this.txtSumTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtSumTime.BorderColor = System.Drawing.Color.Black;
            this.txtSumTime.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSumTime.BorderRadius = 6;
            this.txtSumTime.BorderSize = 1;
            this.txtSumTime.Enable = true;
            this.txtSumTime.Enabled = false;
            this.txtSumTime.Font = new System.Drawing.Font("Inter SemiBold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSumTime.ForeColor = System.Drawing.Color.Black;
            this.txtSumTime.Location = new System.Drawing.Point(200, 20);
            this.txtSumTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtSumTime.Multiline = false;
            this.txtSumTime.Name = "txtSumTime";
            this.txtSumTime.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtSumTime.PasswordChar = false;
            this.txtSumTime.PlaceholderColor = System.Drawing.Color.Black;
            this.txtSumTime.PlaceholderText = "";
            this.txtSumTime.Size = new System.Drawing.Size(252, 32);
            this.txtSumTime.TabIndex = 12;
            this.txtSumTime.Texts = "";
            this.txtSumTime.UnderlinedStyle = false;
            // 
            // lblSumTime
            // 
            this.lblSumTime.AutoSize = true;
            this.lblSumTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSumTime.Location = new System.Drawing.Point(15, 25);
            this.lblSumTime.Name = "lblSumTime";
            this.lblSumTime.Size = new System.Drawing.Size(92, 16);
            this.lblSumTime.TabIndex = 3;
            this.lblSumTime.Text = "Tổng thời gian";
            // 
            // lblUsedTime
            // 
            this.lblUsedTime.AutoSize = true;
            this.lblUsedTime.BackColor = System.Drawing.Color.Transparent;
            this.lblUsedTime.Location = new System.Drawing.Point(15, 72);
            this.lblUsedTime.Name = "lblUsedTime";
            this.lblUsedTime.Size = new System.Drawing.Size(113, 16);
            this.lblUsedTime.TabIndex = 5;
            this.lblUsedTime.Text = "Thời gian sử dụng";
            // 
            // lblRemainTime
            // 
            this.lblRemainTime.AutoSize = true;
            this.lblRemainTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRemainTime.Location = new System.Drawing.Point(15, 119);
            this.lblRemainTime.Name = "lblRemainTime";
            this.lblRemainTime.Size = new System.Drawing.Size(105, 16);
            this.lblRemainTime.TabIndex = 11;
            this.lblRemainTime.Text = "Thời gian còn lại";
            // 
            // lblUsedCost
            // 
            this.lblUsedCost.AutoSize = true;
            this.lblUsedCost.BackColor = System.Drawing.Color.Transparent;
            this.lblUsedCost.Location = new System.Drawing.Point(15, 166);
            this.lblUsedCost.Name = "lblUsedCost";
            this.lblUsedCost.Size = new System.Drawing.Size(97, 16);
            this.lblUsedCost.TabIndex = 9;
            this.lblUsedCost.Text = "Chi phí sử dụng";
            // 
            // lblServiceCost
            // 
            this.lblServiceCost.AutoSize = true;
            this.lblServiceCost.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceCost.Location = new System.Drawing.Point(15, 213);
            this.lblServiceCost.Name = "lblServiceCost";
            this.lblServiceCost.Size = new System.Drawing.Size(92, 16);
            this.lblServiceCost.TabIndex = 7;
            this.lblServiceCost.Text = "Chi phí dịch vụ";
            // 
            // containerButton
            // 
            this.containerButton.BackColor = System.Drawing.Color.White;
            this.containerButton.BorderRadius = 11;
            this.containerButton.Controls.Add(this.btnLockMachine1);
            this.containerButton.Controls.Add(this.btnServices1);
            this.containerButton.Controls.Add(this.btnChangePassword1);
            this.containerButton.Controls.Add(this.btnMessages1);
            this.containerButton.Location = new System.Drawing.Point(29, 356);
            this.containerButton.Name = "containerButton";
            this.containerButton.Size = new System.Drawing.Size(480, 190);
            this.containerButton.TabIndex = 18;
            // 
            // btnLockMachine1
            // 
            this.btnLockMachine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.btnLockMachine1.BorderColor = System.Drawing.Color.Transparent;
            this.btnLockMachine1.BorderRadius = 12;
            this.btnLockMachine1.BorderSize = 0;
            this.btnLockMachine1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockMachine1.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockMachine1.ForeColor = System.Drawing.Color.Black;
            this.btnLockMachine1.Image = global::login_1.Properties.Resources._lock;
            this.btnLockMachine1.Location = new System.Drawing.Point(246, 102);
            this.btnLockMachine1.Name = "btnLockMachine1";
            this.btnLockMachine1.Size = new System.Drawing.Size(200, 52);
            this.btnLockMachine1.TabIndex = 16;
            this.btnLockMachine1.Text = "  Khóa máy";
            this.btnLockMachine1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLockMachine1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLockMachine1.UseVisualStyleBackColor = false;
            this.btnLockMachine1.Click += new System.EventHandler(this.btnLockMachine1_Click);
            // 
            // btnServices1
            // 
            this.btnServices1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.btnServices1.BorderColor = System.Drawing.Color.White;
            this.btnServices1.BorderRadius = 12;
            this.btnServices1.BorderSize = 0;
            this.btnServices1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices1.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices1.ForeColor = System.Drawing.Color.Black;
            this.btnServices1.Image = global::login_1.Properties.Resources.shop;
            this.btnServices1.Location = new System.Drawing.Point(246, 32);
            this.btnServices1.Name = "btnServices1";
            this.btnServices1.Size = new System.Drawing.Size(200, 52);
            this.btnServices1.TabIndex = 14;
            this.btnServices1.Text = "  Dịch vụ";
            this.btnServices1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServices1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServices1.UseVisualStyleBackColor = false;
            this.btnServices1.Click += new System.EventHandler(this.btnServices1_Click);
            // 
            // btnChangePassword1
            // 
            this.btnChangePassword1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.btnChangePassword1.BorderColor = System.Drawing.Color.White;
            this.btnChangePassword1.BorderRadius = 12;
            this.btnChangePassword1.BorderSize = 0;
            this.btnChangePassword1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword1.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword1.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword1.Image = global::login_1.Properties.Resources.password;
            this.btnChangePassword1.Location = new System.Drawing.Point(32, 102);
            this.btnChangePassword1.Name = "btnChangePassword1";
            this.btnChangePassword1.Size = new System.Drawing.Size(200, 52);
            this.btnChangePassword1.TabIndex = 15;
            this.btnChangePassword1.Text = "  Mật khẩu";
            this.btnChangePassword1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePassword1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword1.UseVisualStyleBackColor = false;
            this.btnChangePassword1.Click += new System.EventHandler(this.btnChangePassword1_Click);
            // 
            // btnMessages1
            // 
            this.btnMessages1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.btnMessages1.BorderColor = System.Drawing.Color.White;
            this.btnMessages1.BorderRadius = 12;
            this.btnMessages1.BorderSize = 0;
            this.btnMessages1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages1.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages1.ForeColor = System.Drawing.Color.Black;
            this.btnMessages1.Image = global::login_1.Properties.Resources.chat;
            this.btnMessages1.Location = new System.Drawing.Point(32, 32);
            this.btnMessages1.Name = "btnMessages1";
            this.btnMessages1.Size = new System.Drawing.Size(200, 52);
            this.btnMessages1.TabIndex = 13;
            this.btnMessages1.Text = "  Tin nhắn";
            this.btnMessages1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMessages1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMessages1.UseVisualStyleBackColor = false;
            this.btnMessages1.Click += new System.EventHandler(this.btnMessages1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // infoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 546);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.containerTime);
            this.Controls.Add(this.containerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "infoBox";
            this.Text = "Form2";
            this.containerTime.ResumeLayout(false);
            this.containerTime.PerformLayout();
            this.containerButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSumTime;
        private System.Windows.Forms.Label lblUsedTime;
        private System.Windows.Forms.Label lblServiceCost;
        private System.Windows.Forms.Label lblUsedCost;
        private System.Windows.Forms.Label lblRemainTime;
        private asset.RoundPanel containerTime;
        private asset.RoundedTextBox txtSumTime;
        private asset.RoundedTextBox txtCostService;
        private asset.RoundedTextBox txtUsedCost;
        private asset.RoundedTextBox txtRemainTime;
        private asset.RoundedTextBox txtUsedTime;
        private asset.RoundPanel containerButton;
        private asset.RoundButton btnMessages1;
        private asset.RoundButton btnServices1;
        private asset.RoundButton btnChangePassword1;
        private asset.RoundButton btnLockMachine1;
        private asset.RoundPanel status;
        private asset.RoundButton roundButton1;
        private System.Windows.Forms.Timer timer1;
    }
}