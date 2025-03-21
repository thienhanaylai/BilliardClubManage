namespace BilliardClubManage
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChucvu = new Sunny.UI.UILabel();
            this.lbTennv = new Sunny.UI.UILabel();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.btnExit = new Sunny.UI.UIHeaderButton();
            this.btnQuanly = new Sunny.UI.UIHeaderButton();
            this.btnOder = new Sunny.UI.UIHeaderButton();
            this.btnBan = new Sunny.UI.UIHeaderButton();
            this.FrmChild = new Sunny.UI.UIPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.lbChucvu);
            this.panel1.Controls.Add(this.lbTennv);
            this.panel1.Controls.Add(this.uiAvatar1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnQuanly);
            this.panel1.Controls.Add(this.btnOder);
            this.panel1.Controls.Add(this.btnBan);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1426, 98);
            this.panel1.TabIndex = 0;
            // 
            // lbChucvu
            // 
            this.lbChucvu.AutoSize = true;
            this.lbChucvu.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucvu.ForeColor = System.Drawing.Color.White;
            this.lbChucvu.Location = new System.Drawing.Point(1115, 52);
            this.lbChucvu.Name = "lbChucvu";
            this.lbChucvu.Size = new System.Drawing.Size(80, 27);
            this.lbChucvu.TabIndex = 7;
            this.lbChucvu.Text = "Admin";
            // 
            // lbTennv
            // 
            this.lbTennv.AutoSize = true;
            this.lbTennv.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTennv.ForeColor = System.Drawing.Color.White;
            this.lbTennv.Location = new System.Drawing.Point(1115, 19);
            this.lbTennv.Name = "lbTennv";
            this.lbTennv.Size = new System.Drawing.Size(149, 27);
            this.lbTennv.TabIndex = 6;
            this.lbTennv.Text = "Ngô Gia Bảo";
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiAvatar1.ForeColor = System.Drawing.Color.Aqua;
            this.uiAvatar1.Location = new System.Drawing.Point(1048, 19);
            this.uiAvatar1.Margin = new System.Windows.Forms.Padding(19);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar1.Symbol = 62144;
            this.uiAvatar1.TabIndex = 5;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // btnExit
            // 
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExit.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnExit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Arial", 88F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1298, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.btnExit.Radius = 0;
            this.btnExit.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnExit.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnExit.Size = new System.Drawing.Size(126, 98);
            this.btnExit.Style = Sunny.UI.UIStyle.Custom;
            this.btnExit.Symbol = 0;
            this.btnExit.SymbolSize = 72;
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExit.TipsForeColor = System.Drawing.Color.Turquoise;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQuanly
            // 
            this.btnQuanly.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnQuanly.FillSelectedColor = System.Drawing.Color.Black;
            this.btnQuanly.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanly.Image = global::BilliardClubManage.Properties.Resources.admin;
            this.btnQuanly.Location = new System.Drawing.Point(388, 0);
            this.btnQuanly.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuanly.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnQuanly.Name = "btnQuanly";
            this.btnQuanly.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.btnQuanly.Radius = 0;
            this.btnQuanly.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnQuanly.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnQuanly.Size = new System.Drawing.Size(263, 98);
            this.btnQuanly.TabIndex = 3;
            this.btnQuanly.Text = "Quản lý";
            this.btnQuanly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanly.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnQuanly.Click += new System.EventHandler(this.btnQuanly_Click);
            // 
            // btnOder
            // 
            this.btnOder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnOder.FillSelectedColor = System.Drawing.Color.Black;
            this.btnOder.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOder.Image = global::BilliardClubManage.Properties.Resources.order_food;
            this.btnOder.Location = new System.Drawing.Point(183, 0);
            this.btnOder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOder.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOder.Name = "btnOder";
            this.btnOder.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.btnOder.Radius = 0;
            this.btnOder.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnOder.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnOder.Size = new System.Drawing.Size(202, 98);
            this.btnOder.TabIndex = 2;
            this.btnOder.Text = "Oder";
            this.btnOder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOder.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOder.Click += new System.EventHandler(this.btnOder_Click);
            // 
            // btnBan
            // 
            this.btnBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnBan.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnBan.FillSelectedColor = System.Drawing.Color.Black;
            this.btnBan.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.Image = global::BilliardClubManage.Properties.Resources.billiard_1;
            this.btnBan.Location = new System.Drawing.Point(0, 0);
            this.btnBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnBan.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBan.Name = "btnBan";
            this.btnBan.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.btnBan.Radius = 0;
            this.btnBan.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnBan.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnBan.Size = new System.Drawing.Size(181, 98);
            this.btnBan.TabIndex = 0;
            this.btnBan.Text = "Bàn";
            this.btnBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBan.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // FrmChild
            // 
            this.FrmChild.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FrmChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FrmChild.Location = new System.Drawing.Point(10, 104);
            this.FrmChild.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FrmChild.MinimumSize = new System.Drawing.Size(1, 1);
            this.FrmChild.Name = "FrmChild";
            this.FrmChild.Radius = 40;
            this.FrmChild.Size = new System.Drawing.Size(1402, 868);
            this.FrmChild.TabIndex = 1;
            this.FrmChild.Text = null;
            this.FrmChild.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.FrmChild);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billiards Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIHeaderButton btnBan;
        private Sunny.UI.UIPanel FrmChild;
        private Sunny.UI.UIHeaderButton btnQuanly;
        private Sunny.UI.UIHeaderButton btnOder;
        private Sunny.UI.UIHeaderButton btnExit;
        private Sunny.UI.UILabel lbChucvu;
        private Sunny.UI.UILabel lbTennv;
        private Sunny.UI.UIAvatar uiAvatar1;
    }
}