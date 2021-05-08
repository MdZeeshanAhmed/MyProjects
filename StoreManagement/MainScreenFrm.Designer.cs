namespace StoreManagement
{
    partial class MainScreenFrm
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
            this.MainScreenPB = new System.Windows.Forms.FlowLayoutPanel();
            this.InventoryPB = new JGradient_Panel.JGradientPanel();
            this.Inventorylbl = new System.Windows.Forms.Label();
            this.NewPurchasePB = new JGradient_Panel.JGradientPanel();
            this.NewPurchaselbl = new System.Windows.Forms.Label();
            this.OrderHistoryPB = new JGradient_Panel.JGradientPanel();
            this.OrderHistorylbl = new System.Windows.Forms.Label();
            this.AdministrationPB = new JGradient_Panel.JGradientPanel();
            this.Administrationlbl = new System.Windows.Forms.Label();
            this.ReportsPB = new JGradient_Panel.JGradientPanel();
            this.Reportlbl = new System.Windows.Forms.Label();
            this.Reportslbl = new System.Windows.Forms.Label();
            this.HeaderPB = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.Logolbl = new System.Windows.Forms.Label();
            this.MainScreenPB.SuspendLayout();
            this.InventoryPB.SuspendLayout();
            this.NewPurchasePB.SuspendLayout();
            this.OrderHistoryPB.SuspendLayout();
            this.AdministrationPB.SuspendLayout();
            this.ReportsPB.SuspendLayout();
            this.HeaderPB.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainScreenPB
            // 
            this.MainScreenPB.BackColor = System.Drawing.Color.White;
            this.MainScreenPB.Controls.Add(this.InventoryPB);
            this.MainScreenPB.Controls.Add(this.NewPurchasePB);
            this.MainScreenPB.Controls.Add(this.OrderHistoryPB);
            this.MainScreenPB.Controls.Add(this.AdministrationPB);
            this.MainScreenPB.Controls.Add(this.ReportsPB);
            this.MainScreenPB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScreenPB.Location = new System.Drawing.Point(0, 36);
            this.MainScreenPB.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MainScreenPB.Name = "MainScreenPB";
            this.MainScreenPB.Size = new System.Drawing.Size(1007, 694);
            this.MainScreenPB.TabIndex = 0;
            this.MainScreenPB.Paint += new System.Windows.Forms.PaintEventHandler(this.MainScreenPB_Paint);
            // 
            // InventoryPB
            // 
            this.InventoryPB.BackColor = System.Drawing.Color.DarkCyan;
            this.InventoryPB.ColorBottom = System.Drawing.Color.Empty;
            this.InventoryPB.ColorTop = System.Drawing.Color.Empty;
            this.InventoryPB.Controls.Add(this.Inventorylbl);
            this.InventoryPB.ForeColor = System.Drawing.Color.White;
            this.InventoryPB.Location = new System.Drawing.Point(3, 3);
            this.InventoryPB.Name = "InventoryPB";
            this.InventoryPB.Size = new System.Drawing.Size(195, 100);
            this.InventoryPB.TabIndex = 0;
            this.InventoryPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InventoryPB_MouseClick);
            // 
            // Inventorylbl
            // 
            this.Inventorylbl.AutoSize = true;
            this.Inventorylbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventorylbl.Location = new System.Drawing.Point(38, 39);
            this.Inventorylbl.Name = "Inventorylbl";
            this.Inventorylbl.Size = new System.Drawing.Size(95, 22);
            this.Inventorylbl.TabIndex = 0;
            this.Inventorylbl.Text = "Inventory";
            this.Inventorylbl.Click += new System.EventHandler(this.Inventorylbl_Click);
            // 
            // NewPurchasePB
            // 
            this.NewPurchasePB.BackColor = System.Drawing.Color.Tan;
            this.NewPurchasePB.ColorBottom = System.Drawing.Color.Empty;
            this.NewPurchasePB.ColorTop = System.Drawing.Color.Empty;
            this.NewPurchasePB.Controls.Add(this.NewPurchaselbl);
            this.NewPurchasePB.Location = new System.Drawing.Point(204, 3);
            this.NewPurchasePB.Name = "NewPurchasePB";
            this.NewPurchasePB.Size = new System.Drawing.Size(195, 100);
            this.NewPurchasePB.TabIndex = 1;
            this.NewPurchasePB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NewPurchasePB_MouseClick);
            this.NewPurchasePB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewPurchasePB_MouseDown);
            // 
            // NewPurchaselbl
            // 
            this.NewPurchaselbl.AutoSize = true;
            this.NewPurchaselbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPurchaselbl.ForeColor = System.Drawing.Color.White;
            this.NewPurchaselbl.Location = new System.Drawing.Point(31, 39);
            this.NewPurchaselbl.Name = "NewPurchaselbl";
            this.NewPurchaselbl.Size = new System.Drawing.Size(140, 22);
            this.NewPurchaselbl.TabIndex = 1;
            this.NewPurchaselbl.Text = "New Purchase";
            // 
            // OrderHistoryPB
            // 
            this.OrderHistoryPB.BackColor = System.Drawing.Color.LightSeaGreen;
            this.OrderHistoryPB.ColorBottom = System.Drawing.Color.Empty;
            this.OrderHistoryPB.ColorTop = System.Drawing.Color.Empty;
            this.OrderHistoryPB.Controls.Add(this.OrderHistorylbl);
            this.OrderHistoryPB.Location = new System.Drawing.Point(405, 3);
            this.OrderHistoryPB.Name = "OrderHistoryPB";
            this.OrderHistoryPB.Size = new System.Drawing.Size(195, 100);
            this.OrderHistoryPB.TabIndex = 2;
            // 
            // OrderHistorylbl
            // 
            this.OrderHistorylbl.AutoSize = true;
            this.OrderHistorylbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderHistorylbl.ForeColor = System.Drawing.Color.White;
            this.OrderHistorylbl.Location = new System.Drawing.Point(29, 39);
            this.OrderHistorylbl.Name = "OrderHistorylbl";
            this.OrderHistorylbl.Size = new System.Drawing.Size(134, 22);
            this.OrderHistorylbl.TabIndex = 2;
            this.OrderHistorylbl.Text = "Orders History";
            // 
            // AdministrationPB
            // 
            this.AdministrationPB.BackColor = System.Drawing.Color.SteelBlue;
            this.AdministrationPB.ColorBottom = System.Drawing.Color.Empty;
            this.AdministrationPB.ColorTop = System.Drawing.Color.Empty;
            this.AdministrationPB.Controls.Add(this.Administrationlbl);
            this.AdministrationPB.Location = new System.Drawing.Point(606, 3);
            this.AdministrationPB.Name = "AdministrationPB";
            this.AdministrationPB.Size = new System.Drawing.Size(195, 100);
            this.AdministrationPB.TabIndex = 3;
            // 
            // Administrationlbl
            // 
            this.Administrationlbl.AutoSize = true;
            this.Administrationlbl.BackColor = System.Drawing.Color.SteelBlue;
            this.Administrationlbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrationlbl.ForeColor = System.Drawing.Color.White;
            this.Administrationlbl.Location = new System.Drawing.Point(22, 39);
            this.Administrationlbl.Name = "Administrationlbl";
            this.Administrationlbl.Size = new System.Drawing.Size(145, 22);
            this.Administrationlbl.TabIndex = 2;
            this.Administrationlbl.Text = "Administration";
            // 
            // ReportsPB
            // 
            this.ReportsPB.BackColor = System.Drawing.Color.Teal;
            this.ReportsPB.ColorBottom = System.Drawing.Color.Empty;
            this.ReportsPB.ColorTop = System.Drawing.Color.Empty;
            this.ReportsPB.Controls.Add(this.Reportlbl);
            this.ReportsPB.Location = new System.Drawing.Point(807, 3);
            this.ReportsPB.Name = "ReportsPB";
            this.ReportsPB.Size = new System.Drawing.Size(195, 100);
            this.ReportsPB.TabIndex = 5;
            // 
            // Reportlbl
            // 
            this.Reportlbl.AutoSize = true;
            this.Reportlbl.BackColor = System.Drawing.Color.Teal;
            this.Reportlbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportlbl.ForeColor = System.Drawing.Color.White;
            this.Reportlbl.Location = new System.Drawing.Point(62, 39);
            this.Reportlbl.Name = "Reportlbl";
            this.Reportlbl.Size = new System.Drawing.Size(80, 22);
            this.Reportlbl.TabIndex = 2;
            this.Reportlbl.Text = "Reports";
            // 
            // Reportslbl
            // 
            this.Reportslbl.Location = new System.Drawing.Point(0, 0);
            this.Reportslbl.Name = "Reportslbl";
            this.Reportslbl.Size = new System.Drawing.Size(100, 23);
            this.Reportslbl.TabIndex = 0;
            // 
            // HeaderPB
            // 
            this.HeaderPB.BackColor = System.Drawing.Color.White;
            this.HeaderPB.Controls.Add(this.closebtn);
            this.HeaderPB.Controls.Add(this.Logolbl);
            this.HeaderPB.Location = new System.Drawing.Point(0, 1);
            this.HeaderPB.Name = "HeaderPB";
            this.HeaderPB.Size = new System.Drawing.Size(1007, 32);
            this.HeaderPB.TabIndex = 1;
            this.HeaderPB.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderPB_Paint);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.White;
            this.closebtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.closebtn.Location = new System.Drawing.Point(964, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(40, 32);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // Logolbl
            // 
            this.Logolbl.AutoSize = true;
            this.Logolbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logolbl.Location = new System.Drawing.Point(3, 8);
            this.Logolbl.Name = "Logolbl";
            this.Logolbl.Size = new System.Drawing.Size(166, 19);
            this.Logolbl.TabIndex = 0;
            this.Logolbl.Text = "Store Management";
            // 
            // MainScreenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.HeaderPB);
            this.Controls.Add(this.MainScreenPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainScreenFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreenFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainScreenFrm_Load);
            this.MainScreenPB.ResumeLayout(false);
            this.InventoryPB.ResumeLayout(false);
            this.InventoryPB.PerformLayout();
            this.NewPurchasePB.ResumeLayout(false);
            this.NewPurchasePB.PerformLayout();
            this.OrderHistoryPB.ResumeLayout(false);
            this.OrderHistoryPB.PerformLayout();
            this.AdministrationPB.ResumeLayout(false);
            this.AdministrationPB.PerformLayout();
            this.ReportsPB.ResumeLayout(false);
            this.ReportsPB.PerformLayout();
            this.HeaderPB.ResumeLayout(false);
            this.HeaderPB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainScreenPB;
        private JGradient_Panel.JGradientPanel InventoryPB;
        private System.Windows.Forms.Label Inventorylbl;
        private JGradient_Panel.JGradientPanel NewPurchasePB;
        private JGradient_Panel.JGradientPanel OrderHistoryPB;
        private System.Windows.Forms.Label NewPurchaselbl;
        private System.Windows.Forms.Label OrderHistorylbl;
        private JGradient_Panel.JGradientPanel AdministrationPB;
        private System.Windows.Forms.Label Administrationlbl;
        private System.Windows.Forms.Label Reportslbl;
        private JGradient_Panel.JGradientPanel ReportsPB;
        private System.Windows.Forms.Label Reportlbl;
        private System.Windows.Forms.Panel HeaderPB;
        private System.Windows.Forms.Label Logolbl;
        private System.Windows.Forms.Button closebtn;
    }
}