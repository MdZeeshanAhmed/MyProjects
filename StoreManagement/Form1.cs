using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainScreenFrm msf = new MainScreenFrm();
            msf.MaximizeBox = true;
            msf.Show();
        }

        private void forgotPwdbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void developedbylbl_Click(object sender, EventArgs e)
        {

        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ZEEtechnolbl_Click(object sender, EventArgs e)
        {

        }

        private void systemlbl_Click(object sender, EventArgs e)
        {

        }

        private void servicelbl_Click(object sender, EventArgs e)
        {

        }

        private void welomelbl_Click(object sender, EventArgs e)
        {

        }

        private void passwordPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void LogoPB_Click(object sender, EventArgs e)
        {

        }

        private void passwordPB_Click(object sender, EventArgs e)
        {

        }

        private void userPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginAcclbl_Click(object sender, EventArgs e)
        {

        }

        private void userImgPB_Click(object sender, EventArgs e)
        {

        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Form1
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "Form1";
        //    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        //    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        //    this.ResumeLayout(false);

        //}
    }
}
