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
    public partial class MainScreenFrm : Form
    {
        public MainScreenFrm()
        {
            InitializeComponent();
        }

        private void MainScreenFrm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = true;
        }

        private void MainScreenPB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reportslbl_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HeaderPB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReportsPB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InventoryPB_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Inventory");
        }

        private void NewPurchasePB_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("NewPurchasePB_MouseClick");
        }

        private void NewPurchasePB_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("NewPurchasePB_MouseDown");
        }

        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inventorylbl_Click(object sender, EventArgs e)
        {

        }
    }
}
