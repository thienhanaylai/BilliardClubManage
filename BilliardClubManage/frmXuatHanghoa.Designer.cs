namespace BilliardClubManage
{
    partial class frmXuatHanghoa
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
            this.txtSl = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.btnClear = new Sunny.UI.UIButton();
            this.btnXacnhan = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // txtSl
            // 
            this.txtSl.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtSl.BackColor = System.Drawing.Color.Transparent;
            this.txtSl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSl.Location = new System.Drawing.Point(52, 170);
            this.txtSl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSl.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSl.Name = "txtSl";
            this.txtSl.Padding = new System.Windows.Forms.Padding(5);
            this.txtSl.Radius = 35;
            this.txtSl.ShowText = false;
            this.txtSl.Size = new System.Drawing.Size(703, 50);
            this.txtSl.TabIndex = 25;
            this.txtSl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSl.Watermark = "Số lượng";
            this.txtSl.WatermarkActiveColor = System.Drawing.Color.Silver;
            this.txtSl.WordWarp = false;
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(46, 122);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(10);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(143, 33);
            this.uiLabel7.TabIndex = 26;
            this.uiLabel7.Text = "Số lượng:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiSymbolButton1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(14, 25);
            this.uiSymbolButton1.Margin = new System.Windows.Forms.Padding(5);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 35;
            this.uiSymbolButton1.Size = new System.Drawing.Size(121, 60);
            this.uiSymbolButton1.Symbol = 61536;
            this.uiSymbolButton1.SymbolSize = 48;
            this.uiSymbolButton1.TabIndex = 27;
            this.uiSymbolButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(421, 243);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Radius = 35;
            this.btnClear.Size = new System.Drawing.Size(164, 54);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Nhập lại";
            this.btnClear.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacnhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacnhan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXacnhan.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacnhan.Location = new System.Drawing.Point(591, 243);
            this.btnXacnhan.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Radius = 35;
            this.btnXacnhan.Size = new System.Drawing.Size(164, 54);
            this.btnXacnhan.TabIndex = 32;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // frmXuatHanghoa
            // 
            this.AcceptButton = this.btnXacnhan;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.uiSymbolButton1;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.uiLabel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXuatHanghoa";
            this.Text = "frmXuatHanghoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox txtSl;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIButton btnClear;
        private Sunny.UI.UIButton btnXacnhan;
    }
}