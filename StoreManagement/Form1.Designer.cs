namespace StoreManagement
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ZEEtechnolbl = new System.Windows.Forms.Label();
            this.developedbylbl = new System.Windows.Forms.Label();
            this.systemlbl = new System.Windows.Forms.Label();
            this.servicelbl = new System.Windows.Forms.Label();
            this.welomelbl = new System.Windows.Forms.Label();
            this.LogoPB = new System.Windows.Forms.PictureBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.forgotPwdbtn = new System.Windows.Forms.LinkLabel();
            this.loginbtn = new System.Windows.Forms.Button();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.passwordPB = new System.Windows.Forms.PictureBox();
            this.userPanel = new System.Windows.Forms.Panel();
            this.userNametxt = new System.Windows.Forms.TextBox();
            this.userImgPB = new System.Windows.Forms.PictureBox();
            this.loginAcclbl = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).BeginInit();
            this.RightPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPB)).BeginInit();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImgPB)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.LeftPanel.Controls.Add(this.ZEEtechnolbl);
            this.LeftPanel.Controls.Add(this.developedbylbl);
            this.LeftPanel.Controls.Add(this.systemlbl);
            this.LeftPanel.Controls.Add(this.servicelbl);
            this.LeftPanel.Controls.Add(this.welomelbl);
            this.LeftPanel.Controls.Add(this.LogoPB);
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(290, 530);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.TabStop = true;
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftPanel_Paint);
            // 
            // ZEEtechnolbl
            // 
            this.ZEEtechnolbl.AutoSize = true;
            this.ZEEtechnolbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZEEtechnolbl.ForeColor = System.Drawing.Color.White;
            this.ZEEtechnolbl.Location = new System.Drawing.Point(146, 487);
            this.ZEEtechnolbl.Name = "ZEEtechnolbl";
            this.ZEEtechnolbl.Size = new System.Drawing.Size(140, 16);
            this.ZEEtechnolbl.TabIndex = 6;
            this.ZEEtechnolbl.Text = "ZEE Technologies PVT Ltd";
            this.ZEEtechnolbl.Click += new System.EventHandler(this.ZEEtechnolbl_Click);
            // 
            // developedbylbl
            // 
            this.developedbylbl.AutoSize = true;
            this.developedbylbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developedbylbl.ForeColor = System.Drawing.Color.White;
            this.developedbylbl.Location = new System.Drawing.Point(199, 471);
            this.developedbylbl.Name = "developedbylbl";
            this.developedbylbl.Size = new System.Drawing.Size(85, 16);
            this.developedbylbl.TabIndex = 5;
            this.developedbylbl.Text = "Developed By";
            this.developedbylbl.Click += new System.EventHandler(this.developedbylbl_Click);
            // 
            // systemlbl
            // 
            this.systemlbl.AutoSize = true;
            this.systemlbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemlbl.ForeColor = System.Drawing.Color.White;
            this.systemlbl.Location = new System.Drawing.Point(211, 250);
            this.systemlbl.Name = "systemlbl";
            this.systemlbl.Size = new System.Drawing.Size(73, 22);
            this.systemlbl.TabIndex = 4;
            this.systemlbl.Text = "System";
            this.systemlbl.Click += new System.EventHandler(this.systemlbl_Click);
            // 
            // servicelbl
            // 
            this.servicelbl.AutoSize = true;
            this.servicelbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicelbl.ForeColor = System.Drawing.Color.White;
            this.servicelbl.Location = new System.Drawing.Point(76, 228);
            this.servicelbl.Name = "servicelbl";
            this.servicelbl.Size = new System.Drawing.Size(210, 22);
            this.servicelbl.TabIndex = 3;
            this.servicelbl.Text = "Service Management";
            this.servicelbl.Click += new System.EventHandler(this.servicelbl_Click);
            // 
            // welomelbl
            // 
            this.welomelbl.AutoSize = true;
            this.welomelbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welomelbl.ForeColor = System.Drawing.Color.White;
            this.welomelbl.Location = new System.Drawing.Point(129, 206);
            this.welomelbl.Name = "welomelbl";
            this.welomelbl.Size = new System.Drawing.Size(155, 22);
            this.welomelbl.TabIndex = 2;
            this.welomelbl.Text = "Welcome to the";
            this.welomelbl.Click += new System.EventHandler(this.welomelbl_Click);
            // 
            // LogoPB
            // 
            this.LogoPB.BackColor = System.Drawing.Color.Transparent;
            this.LogoPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoPB.Image = global::StoreManagement.Properties.Resources.gears;
            this.LogoPB.Location = new System.Drawing.Point(118, 30);
            this.LogoPB.Name = "LogoPB";
            this.LogoPB.Size = new System.Drawing.Size(124, 132);
            this.LogoPB.TabIndex = 0;
            this.LogoPB.TabStop = false;
            this.LogoPB.Click += new System.EventHandler(this.LogoPB_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.BackColor = System.Drawing.Color.White;
            this.RightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightPanel.Controls.Add(this.forgotPwdbtn);
            this.RightPanel.Controls.Add(this.loginbtn);
            this.RightPanel.Controls.Add(this.passwordPanel);
            this.RightPanel.Controls.Add(this.userPanel);
            this.RightPanel.Controls.Add(this.loginAcclbl);
            this.RightPanel.Controls.Add(this.closebtn);
            this.RightPanel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightPanel.ForeColor = System.Drawing.Color.DarkCyan;
            this.RightPanel.Location = new System.Drawing.Point(290, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(460, 530);
            this.RightPanel.TabIndex = 4;
            this.RightPanel.TabStop = true;
            this.RightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RightPanel_Paint);
            // 
            // forgotPwdbtn
            // 
            this.forgotPwdbtn.ActiveLinkColor = System.Drawing.Color.Red;
            this.forgotPwdbtn.AutoSize = true;
            this.forgotPwdbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPwdbtn.LinkColor = System.Drawing.Color.DarkCyan;
            this.forgotPwdbtn.Location = new System.Drawing.Point(242, 350);
            this.forgotPwdbtn.Name = "forgotPwdbtn";
            this.forgotPwdbtn.Size = new System.Drawing.Size(127, 17);
            this.forgotPwdbtn.TabIndex = 6;
            this.forgotPwdbtn.TabStop = true;
            this.forgotPwdbtn.Text = "Forgot Password ?";
            this.forgotPwdbtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPwdbtn_LinkClicked);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.loginbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(98, 337);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(0);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(121, 39);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // passwordPanel
            // 
            this.passwordPanel.Controls.Add(this.passwordtxt);
            this.passwordPanel.Controls.Add(this.passwordPB);
            this.passwordPanel.Location = new System.Drawing.Point(0, 240);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(443, 45);
            this.passwordPanel.TabIndex = 3;
            this.passwordPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.passwordPanel_Paint_1);
            // 
            // passwordtxt
            // 
            this.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordtxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.passwordtxt.Location = new System.Drawing.Point(42, 7);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(389, 31);
            this.passwordtxt.TabIndex = 3;
            this.passwordtxt.UseSystemPasswordChar = true;
            this.passwordtxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            // 
            // passwordPB
            // 
            this.passwordPB.BackColor = System.Drawing.Color.Transparent;
            this.passwordPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordPB.Image = global::StoreManagement.Properties.Resources.lock_blue_private_icon;
            this.passwordPB.Location = new System.Drawing.Point(3, 7);
            this.passwordPB.Name = "passwordPB";
            this.passwordPB.Size = new System.Drawing.Size(33, 31);
            this.passwordPB.TabIndex = 1;
            this.passwordPB.TabStop = false;
            this.passwordPB.Click += new System.EventHandler(this.passwordPB_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.userNametxt);
            this.userPanel.Controls.Add(this.userImgPB);
            this.userPanel.Location = new System.Drawing.Point(0, 189);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(443, 45);
            this.userPanel.TabIndex = 2;
            this.userPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userPanel_Paint);
            // 
            // userNametxt
            // 
            this.userNametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNametxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.userNametxt.Location = new System.Drawing.Point(41, 7);
            this.userNametxt.Name = "userNametxt";
            this.userNametxt.Size = new System.Drawing.Size(389, 31);
            this.userNametxt.TabIndex = 2;
            this.userNametxt.TextChanged += new System.EventHandler(this.userNametxt_TextChanged);
            // 
            // userImgPB
            // 
            this.userImgPB.BackColor = System.Drawing.Color.Transparent;
            this.userImgPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userImgPB.Image = global::StoreManagement.Properties.Resources.User_blue_icon;
            this.userImgPB.Location = new System.Drawing.Point(3, 7);
            this.userImgPB.Name = "userImgPB";
            this.userImgPB.Size = new System.Drawing.Size(32, 31);
            this.userImgPB.TabIndex = 1;
            this.userImgPB.TabStop = false;
            this.userImgPB.Click += new System.EventHandler(this.userImgPB_Click);
            // 
            // loginAcclbl
            // 
            this.loginAcclbl.AutoSize = true;
            this.loginAcclbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAcclbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.loginAcclbl.Location = new System.Drawing.Point(94, 121);
            this.loginAcclbl.Name = "loginAcclbl";
            this.loginAcclbl.Size = new System.Drawing.Size(214, 22);
            this.loginAcclbl.TabIndex = 3;
            this.loginAcclbl.Text = "Login to your account";
            this.loginAcclbl.Click += new System.EventHandler(this.loginAcclbl_Click);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.White;
            this.closebtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.closebtn.Location = new System.Drawing.Point(419, -1);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(40, 40);
            this.closebtn.TabIndex = 0;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPB)).EndInit();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImgPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.PictureBox LogoPB;
        private System.Windows.Forms.Label welomelbl;
        private System.Windows.Forms.Label servicelbl;
        private System.Windows.Forms.Label systemlbl;
        private System.Windows.Forms.Label developedbylbl;
        private System.Windows.Forms.Label ZEEtechnolbl;
        private System.Windows.Forms.Button closebtn;

        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.PictureBox userImgPB;
        private System.Windows.Forms.Label loginAcclbl;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.PictureBox passwordPB;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox userNametxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.LinkLabel forgotPwdbtn;
    }
}

