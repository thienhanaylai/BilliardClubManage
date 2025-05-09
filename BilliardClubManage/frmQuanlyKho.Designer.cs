namespace BilliardClubManage
{
    partial class frmQuanlyKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKho = new Sunny.UI.UIDataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNhap = new Sunny.UI.UIButton();
            this.btnSuaHanghoa = new Sunny.UI.UIButton();
            this.btnXuatHanghoa = new Sunny.UI.UIButton();
            this.btnTimHanghoa = new Sunny.UI.UIButton();
            this.txtTimhanghoa = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKho
            // 
            this.dgvKho.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKho.ColumnHeadersHeight = 32;
            this.dgvKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmName,
            this.clmUnit,
            this.clmPrice,
            this.clmQty});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKho.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKho.EnableHeadersVisualStyles = false;
            this.dgvKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvKho.Location = new System.Drawing.Point(12, 82);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKho.RowHeadersVisible = false;
            this.dgvKho.RowHeadersWidth = 50;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvKho.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKho.SelectedIndex = -1;
            this.dgvKho.ShowCellErrors = false;
            this.dgvKho.ShowCellToolTips = false;
            this.dgvKho.ShowEditingIcon = false;
            this.dgvKho.ShowRowErrors = false;
            this.dgvKho.Size = new System.Drawing.Size(1368, 684);
            this.dgvKho.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvKho.TabIndex = 0;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "IDhanghoa";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmName.DataPropertyName = "Tenhanghoa";
            this.clmName.HeaderText = "NAME";
            this.clmName.MinimumWidth = 700;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 700;
            // 
            // clmUnit
            // 
            this.clmUnit.DataPropertyName = "Donvi";
            this.clmUnit.HeaderText = "UNIT";
            this.clmUnit.MinimumWidth = 130;
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.ReadOnly = true;
            this.clmUnit.Width = 130;
            // 
            // clmPrice
            // 
            this.clmPrice.DataPropertyName = "Gia";
            this.clmPrice.HeaderText = "Price ( VND )";
            this.clmPrice.MinimumWidth = 305;
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Width = 305;
            // 
            // clmQty
            // 
            this.clmQty.DataPropertyName = "Soluong";
            this.clmQty.HeaderText = "Qty";
            this.clmQty.MinimumWidth = 130;
            this.clmQty.Name = "clmQty";
            this.clmQty.ReadOnly = true;
            this.clmQty.Width = 130;
            // 
            // btnNhap
            // 
            this.btnNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhap.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(12, 12);
            this.btnNhap.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Radius = 35;
            this.btnNhap.Size = new System.Drawing.Size(130, 60);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNhap.Click += new System.EventHandler(this.btnThemHanghoa_Click);
            // 
            // btnSuaHanghoa
            // 
            this.btnSuaHanghoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaHanghoa.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHanghoa.Location = new System.Drawing.Point(148, 12);
            this.btnSuaHanghoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSuaHanghoa.Name = "btnSuaHanghoa";
            this.btnSuaHanghoa.Radius = 35;
            this.btnSuaHanghoa.Size = new System.Drawing.Size(130, 60);
            this.btnSuaHanghoa.TabIndex = 5;
            this.btnSuaHanghoa.Text = "Sửa";
            this.btnSuaHanghoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSuaHanghoa.Click += new System.EventHandler(this.btnSuaHanghoa_Click);
            // 
            // btnXuatHanghoa
            // 
            this.btnXuatHanghoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatHanghoa.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHanghoa.Location = new System.Drawing.Point(284, 12);
            this.btnXuatHanghoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXuatHanghoa.Name = "btnXuatHanghoa";
            this.btnXuatHanghoa.Radius = 35;
            this.btnXuatHanghoa.Size = new System.Drawing.Size(130, 60);
            this.btnXuatHanghoa.TabIndex = 7;
            this.btnXuatHanghoa.Text = "Xuất";
            this.btnXuatHanghoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXuatHanghoa.Click += new System.EventHandler(this.btnXuatHanghoa_Click);
            // 
            // btnTimHanghoa
            // 
            this.btnTimHanghoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimHanghoa.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimHanghoa.Location = new System.Drawing.Point(556, 12);
            this.btnTimHanghoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTimHanghoa.Name = "btnTimHanghoa";
            this.btnTimHanghoa.Radius = 35;
            this.btnTimHanghoa.Size = new System.Drawing.Size(130, 60);
            this.btnTimHanghoa.TabIndex = 8;
            this.btnTimHanghoa.Text = "Tìm";
            this.btnTimHanghoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTimHanghoa.Click += new System.EventHandler(this.btnTimHanghoa_Click);
            // 
            // txtTimhanghoa
            // 
            this.txtTimhanghoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimhanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimhanghoa.Location = new System.Drawing.Point(693, 12);
            this.txtTimhanghoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimhanghoa.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTimhanghoa.Name = "txtTimhanghoa";
            this.txtTimhanghoa.Padding = new System.Windows.Forms.Padding(5);
            this.txtTimhanghoa.Radius = 40;
            this.txtTimhanghoa.ShowText = false;
            this.txtTimhanghoa.Size = new System.Drawing.Size(686, 60);
            this.txtTimhanghoa.TabIndex = 9;
            this.txtTimhanghoa.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimhanghoa.Watermark = "Nhập mã hàng, tên hàng";
            this.txtTimhanghoa.WatermarkActiveColor = System.Drawing.Color.Silver;
            // 
            // frmQuanlyKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1392, 778);
            this.Controls.Add(this.txtTimhanghoa);
            this.Controls.Add(this.btnTimHanghoa);
            this.Controls.Add(this.btnXuatHanghoa);
            this.Controls.Add(this.btnSuaHanghoa);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.dgvKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanlyKho";
            this.Text = "frmKho";
            this.Load += new System.EventHandler(this.frmQuanlyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvKho;
        private Sunny.UI.UIButton btnNhap;
        private Sunny.UI.UIButton btnSuaHanghoa;
        private Sunny.UI.UIButton btnXuatHanghoa;
        private Sunny.UI.UIButton btnTimHanghoa;
        private Sunny.UI.UITextBox txtTimhanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
    }
}