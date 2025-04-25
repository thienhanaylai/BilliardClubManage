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
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNhap = new Sunny.UI.UIButton();
            this.btnSuaHanghoa = new Sunny.UI.UIButton();
            this.btnXuatHanghoa = new Sunny.UI.UIButton();
            this.btnTimHanghoa = new Sunny.UI.UIButton();
            this.txtTimhanghoa = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmName,
            this.clmUnit,
            this.clmQty,
            this.clmPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(12, 82);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView1.RowHeadersVisible = false;
            this.uiDataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.ShowCellErrors = false;
            this.uiDataGridView1.ShowCellToolTips = false;
            this.uiDataGridView1.ShowEditingIcon = false;
            this.uiDataGridView1.ShowRowErrors = false;
            this.uiDataGridView1.Size = new System.Drawing.Size(1368, 684);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.TabIndex = 0;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmName.HeaderText = "NAME";
            this.clmName.MinimumWidth = 700;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 700;
            // 
            // clmUnit
            // 
            this.clmUnit.HeaderText = "UNIT";
            this.clmUnit.MinimumWidth = 130;
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.ReadOnly = true;
            this.clmUnit.Width = 130;
            // 
            // clmQty
            // 
            this.clmQty.HeaderText = "Qty";
            this.clmQty.MinimumWidth = 130;
            this.clmQty.Name = "clmQty";
            this.clmQty.ReadOnly = true;
            this.clmQty.Width = 130;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Price ( VND )";
            this.clmPrice.MinimumWidth = 305;
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Width = 305;
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
            this.Controls.Add(this.uiDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanlyKho";
            this.Text = "frmKho";
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIButton btnNhap;
        private Sunny.UI.UIButton btnSuaHanghoa;
        private Sunny.UI.UIButton btnXuatHanghoa;
        private Sunny.UI.UIButton btnTimHanghoa;
        private Sunny.UI.UITextBox txtTimhanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
    }
}