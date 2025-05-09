namespace BilliardClubManage
{
    partial class frmBan
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
            this.btnK1 = new Sunny.UI.UIButton();
            this.btnK2 = new Sunny.UI.UIButton();
            this.dsBan = new Sunny.UI.UIPanel();
            this.SuspendLayout();
            // 
            // btnK1
            // 
            this.btnK1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnK1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnK1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK1.Location = new System.Drawing.Point(12, 12);
            this.btnK1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnK1.Name = "btnK1";
            this.btnK1.Radius = 35;
            this.btnK1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnK1.Size = new System.Drawing.Size(150, 60);
            this.btnK1.TabIndex = 3;
            this.btnK1.Text = "Khu 1";
            this.btnK1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnK1.Click += new System.EventHandler(this.btnK1_Click);
            // 
            // btnK2
            // 
            this.btnK2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnK2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnK2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK2.Location = new System.Drawing.Point(168, 12);
            this.btnK2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnK2.Name = "btnK2";
            this.btnK2.Radius = 35;
            this.btnK2.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnK2.Size = new System.Drawing.Size(150, 60);
            this.btnK2.TabIndex = 4;
            this.btnK2.Text = "Khu 2";
            this.btnK2.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnK2.Click += new System.EventHandler(this.btnK2_Click);
            // 
            // dsBan
            // 
            this.dsBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dsBan.Location = new System.Drawing.Point(13, 80);
            this.dsBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dsBan.MinimumSize = new System.Drawing.Size(1, 1);
            this.dsBan.Name = "dsBan";
            this.dsBan.Radius = 1;
            this.dsBan.Size = new System.Drawing.Size(1378, 774);
            this.dsBan.TabIndex = 5;
            this.dsBan.Text = null;
            this.dsBan.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1402, 868);
            this.Controls.Add(this.dsBan);
            this.Controls.Add(this.btnK2);
            this.Controls.Add(this.btnK1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBan";
            this.Text = "frmBan";
            this.Load += new System.EventHandler(this.frmBan_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton btnK1;
        private Sunny.UI.UIButton btnK2;
        private Sunny.UI.UIPanel dsBan;
    }
}