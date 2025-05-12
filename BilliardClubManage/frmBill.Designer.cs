namespace BilliardClubManage
{
    partial class frmBill
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
            this.dsOder = new Sunny.UI.UIPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnXacnhan = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.txtThanhTien = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.dsOder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsOder
            // 
            this.dsOder.Controls.Add(this.uiLabel5);
            this.dsOder.Controls.Add(this.uiLabel4);
            this.dsOder.Controls.Add(this.uiLabel3);
            this.dsOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dsOder.Location = new System.Drawing.Point(13, 43);
            this.dsOder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dsOder.MinimumSize = new System.Drawing.Size(1, 1);
            this.dsOder.Name = "dsOder";
            this.dsOder.Size = new System.Drawing.Size(674, 637);
            this.dsOder.TabIndex = 12;
            this.dsOder.Text = null;
            this.dsOder.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(246, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(224, 29);
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "Thông tin hóa đơn";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacnhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacnhan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXacnhan.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacnhan.Location = new System.Drawing.Point(523, 784);
            this.btnXacnhan.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Radius = 35;
            this.btnXacnhan.Size = new System.Drawing.Size(164, 54);
            this.btnXacnhan.TabIndex = 17;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiButton1.FillColor = System.Drawing.Color.Firebrick;
            this.uiButton1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton1.Location = new System.Drawing.Point(13, 784);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 35;
            this.uiButton1.Size = new System.Drawing.Size(127, 54);
            this.uiButton1.TabIndex = 18;
            this.uiButton1.Text = "Hủy";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.ForeColor = System.Drawing.Color.Maroon;
            this.txtThanhTien.Location = new System.Drawing.Point(191, 710);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(265, 47);
            this.txtThanhTien.TabIndex = 20;
            this.txtThanhTien.Text = "0 VND";
            this.txtThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(12, 701);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(173, 60);
            this.uiLabel2.TabIndex = 19;
            this.uiLabel2.Text = "Thành tiền:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(63, 13);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(144, 24);
            this.uiLabel3.TabIndex = 21;
            this.uiLabel3.Text = "Tên sản phẩm";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(349, 13);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(94, 24);
            this.uiLabel4.TabIndex = 22;
            this.uiLabel4.Text = "Số lượng";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel4.Click += new System.EventHandler(this.uiLabel4_Click);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(572, 13);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(41, 24);
            this.uiLabel5.TabIndex = 23;
            this.uiLabel5.Text = "Giá";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 850);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.dsOder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.dsOder.ResumeLayout(false);
            this.dsOder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIPanel dsOder;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnXacnhan;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel txtThanhTien;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel5;
    }
}