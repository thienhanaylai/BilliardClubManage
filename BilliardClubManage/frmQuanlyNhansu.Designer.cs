namespace BilliardClubManage
{
    partial class frmQuanlyNhansu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNhansu = new Sunny.UI.UIDataGridView();
            this.txtTim = new Sunny.UI.UITextBox();
            this.btnTimnv = new Sunny.UI.UIButton();
            this.btnXoanv = new Sunny.UI.UIButton();
            this.btnSuanv = new Sunny.UI.UIButton();
            this.btnThemnv = new Sunny.UI.UIButton();
            this.billiardClubDataSet = new BilliardClubManage.BilliardClubDataSet();
            this.billiardClubDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhansu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billiardClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billiardClubDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhansu
            // 
            this.dgvNhansu.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvNhansu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhansu.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhansu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhansu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhansu.ColumnHeadersHeight = 40;
            this.dgvNhansu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmName,
            this.Column2,
            this.clmGioitinh,
            this.clmChucvu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhansu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhansu.EnableHeadersVisualStyles = false;
            this.dgvNhansu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvNhansu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvNhansu.Location = new System.Drawing.Point(12, 82);
            this.dgvNhansu.Margin = new System.Windows.Forms.Padding(10);
            this.dgvNhansu.Name = "dgvNhansu";
            this.dgvNhansu.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhansu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhansu.RowHeadersVisible = false;
            this.dgvNhansu.RowHeadersWidth = 50;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvNhansu.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNhansu.RowTemplate.Height = 40;
            this.dgvNhansu.SelectedIndex = -1;
            this.dgvNhansu.ShowCellErrors = false;
            this.dgvNhansu.ShowCellToolTips = false;
            this.dgvNhansu.ShowEditingIcon = false;
            this.dgvNhansu.ShowRowErrors = false;
            this.dgvNhansu.Size = new System.Drawing.Size(1368, 684);
            this.dgvNhansu.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvNhansu.TabIndex = 1;
            this.dgvNhansu.DataSourceChanged += new System.EventHandler(this.dgvNhansu_DataSourceChanged);
            this.dgvNhansu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhansu_CellFormatting);
            // 
            // txtTim
            // 
            this.txtTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTim.Location = new System.Drawing.Point(687, 12);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTim.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTim.Name = "txtTim";
            this.txtTim.Padding = new System.Windows.Forms.Padding(5);
            this.txtTim.Radius = 40;
            this.txtTim.ShowText = false;
            this.txtTim.Size = new System.Drawing.Size(696, 60);
            this.txtTim.TabIndex = 15;
            this.txtTim.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTim.Watermark = "Nhập ID, tên nhân viên";
            this.txtTim.WatermarkActiveColor = System.Drawing.Color.Silver;
            // 
            // btnTimnv
            // 
            this.btnTimnv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimnv.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimnv.Location = new System.Drawing.Point(550, 12);
            this.btnTimnv.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTimnv.Name = "btnTimnv";
            this.btnTimnv.Radius = 35;
            this.btnTimnv.Size = new System.Drawing.Size(130, 60);
            this.btnTimnv.TabIndex = 14;
            this.btnTimnv.Text = "Tìm";
            this.btnTimnv.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTimnv.Click += new System.EventHandler(this.btnTimnv_Click);
            // 
            // btnXoanv
            // 
            this.btnXoanv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoanv.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoanv.Location = new System.Drawing.Point(284, 12);
            this.btnXoanv.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoanv.Name = "btnXoanv";
            this.btnXoanv.Radius = 35;
            this.btnXoanv.Size = new System.Drawing.Size(130, 60);
            this.btnXoanv.TabIndex = 12;
            this.btnXoanv.Text = "Xóa";
            this.btnXoanv.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoanv.Click += new System.EventHandler(this.btnXoanv_Click);
            // 
            // btnSuanv
            // 
            this.btnSuanv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuanv.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuanv.Location = new System.Drawing.Point(148, 12);
            this.btnSuanv.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSuanv.Name = "btnSuanv";
            this.btnSuanv.Radius = 35;
            this.btnSuanv.Size = new System.Drawing.Size(130, 60);
            this.btnSuanv.TabIndex = 11;
            this.btnSuanv.Text = "Sửa";
            this.btnSuanv.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSuanv.Click += new System.EventHandler(this.btnSuanv_Click);
            // 
            // btnThemnv
            // 
            this.btnThemnv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemnv.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnv.Location = new System.Drawing.Point(12, 12);
            this.btnThemnv.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThemnv.Name = "btnThemnv";
            this.btnThemnv.Radius = 35;
            this.btnThemnv.Size = new System.Drawing.Size(130, 60);
            this.btnThemnv.TabIndex = 10;
            this.btnThemnv.Text = "Thêm";
            this.btnThemnv.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThemnv.Click += new System.EventHandler(this.btnThemnv_Click);
            // 
            // billiardClubDataSet
            // 
            this.billiardClubDataSet.DataSetName = "BilliardClubDataSet";
            this.billiardClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billiardClubDataSetBindingSource
            // 
            this.billiardClubDataSetBindingSource.DataSource = this.billiardClubDataSet;
            this.billiardClubDataSetBindingSource.Position = 0;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "IDnv";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmName.DataPropertyName = "Hoten";
            this.clmName.HeaderText = "Họ tên";
            this.clmName.MinimumWidth = 550;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 550;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ngaysinh";
            this.Column2.HeaderText = "Ngày sinh";
            this.Column2.MinimumWidth = 300;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // clmGioitinh
            // 
            this.clmGioitinh.DataPropertyName = "Gioitinh";
            this.clmGioitinh.HeaderText = "Giới tính";
            this.clmGioitinh.Name = "clmGioitinh";
            this.clmGioitinh.ReadOnly = true;
            // 
            // clmChucvu
            // 
            this.clmChucvu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmChucvu.DataPropertyName = "Chucvu";
            this.clmChucvu.HeaderText = "Chức vụ";
            this.clmChucvu.MinimumWidth = 315;
            this.clmChucvu.Name = "clmChucvu";
            this.clmChucvu.ReadOnly = true;
            this.clmChucvu.Width = 315;
            // 
            // frmQuanlyNhansu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1392, 778);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTimnv);
            this.Controls.Add(this.btnXoanv);
            this.Controls.Add(this.btnSuanv);
            this.Controls.Add(this.btnThemnv);
            this.Controls.Add(this.dgvNhansu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanlyNhansu";
            this.Text = "frmNhansu";
            this.Load += new System.EventHandler(this.frmQuanlyNhansu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhansu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billiardClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billiardClubDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvNhansu;
        private Sunny.UI.UITextBox txtTim;
        private Sunny.UI.UIButton btnTimnv;
        private Sunny.UI.UIButton btnXoanv;
        private Sunny.UI.UIButton btnSuanv;
        private Sunny.UI.UIButton btnThemnv;
        private BilliardClubDataSet billiardClubDataSet;
        private System.Windows.Forms.BindingSource billiardClubDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChucvu;
    }
}