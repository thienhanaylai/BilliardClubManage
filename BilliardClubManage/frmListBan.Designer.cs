namespace BilliardClubManage
{
    partial class frmListBan
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
            this.uiFlowLayoutPanel1 = new Sunny.UI.UIFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // uiFlowLayoutPanel1
            // 
            this.uiFlowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiFlowLayoutPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiFlowLayoutPanel1.Name = "uiFlowLayoutPanel1";
            this.uiFlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.uiFlowLayoutPanel1.ShowText = false;
            this.uiFlowLayoutPanel1.Size = new System.Drawing.Size(1378, 774);
            this.uiFlowLayoutPanel1.TabIndex = 0;
            this.uiFlowLayoutPanel1.Text = "uiFlowLayoutPanel1";
            this.uiFlowLayoutPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiFlowLayoutPanel1.Load += new System.EventHandler(this.uiFlowLayoutPanel1_Load);
            // 
            // frmListBan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1378, 774);
            this.Controls.Add(this.uiFlowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListBan";
            this.Text = "frmListBan";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel uiFlowLayoutPanel1;
    }
}