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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemHanghoa = new Sunny.UI.UIButton();
            this.btnSuaHanghoa = new Sunny.UI.UIButton();
            this.btnXoaHanghoa = new Sunny.UI.UIButton();
            this.btnXuatHanghoa = new Sunny.UI.UIButton();
            this.btnTimHanghoa = new Sunny.UI.UIButton();
            this.txtTimhanghoa = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowDrop = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmName,
            this.clmUnit,
            this.clmQty,
            this.clmPrice});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(12, 82);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.uiDataGridView1.RowHeadersVisible = false;
            this.uiDataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
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
            // btnThemHanghoa
            // 
            this.btnThemHanghoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemHanghoa.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHanghoa.Location = new System.Drawing.Point(12, 12);
            this.btnThemHanghoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThemHanghoa.Name = "btnThemHanghoa";
            this.btnThemHanghoa.Radius = 35;
            this.btnThemHanghoa.Size = new System.Drawing.Size(130, 60);
            this.btnThemHanghoa.TabIndex = 4;
            this.btnThemHanghoa.Text = "Thêm";
            this.btnThemHanghoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThemHanghoa.Click += new System.EventHandler(this.btnThemHanghoa_Click);
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
            // btnXoaHanghoa
            // 
            this.btnXoaHanghoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaHanghoa.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHanghoa.Location = new System.Drawing.Point(284, 12);
            this.btnXoaHanghoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoaHanghoa.Name = "btnXoaHanghoa";
            this.btnXoaHanghoa.Radius = 35;
            this.btnXoaHanghoa.Size = new System.Drawing.Size(130, 60);
            this.btnXoaHanghoa.TabIndex = 6;
            this.btnXoaHanghoa.Text = "Xóa";
            this.btnXoaHanghoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnXuatHanghoa
            // 
            this.btnXuatHanghoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatHanghoa.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHanghoa.Location = new System.Drawing.Point(420, 12);
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
            // frmKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1392, 778);
            this.Controls.Add(this.txtTimhanghoa);
            this.Controls.Add(this.btnTimHanghoa);
            this.Controls.Add(this.btnXuatHanghoa);
            this.Controls.Add(this.btnXoaHanghoa);
            this.Controls.Add(this.btnSuaHanghoa);
            this.Controls.Add(this.btnThemHanghoa);
            this.Controls.Add(this.uiDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKho";
            this.Text = "frmKho";
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIButton btnThemHanghoa;
        private Sunny.UI.UIButton btnSuaHanghoa;
        private Sunny.UI.UIButton btnXoaHanghoa;
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