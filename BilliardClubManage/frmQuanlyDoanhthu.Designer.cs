namespace BilliardClubManage
{
    partial class frmQuanlyDoanhthu
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
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.uiDatePicker2 = new Sunny.UI.UIDatePicker();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.dvDoanhthu = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimhanghoa = new Sunny.UI.UITextBox();
            this.uiButton2 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvDoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.BackColor = System.Drawing.Color.Transparent;
            this.uiDatePicker1.DateFormat = "dd-MM-yyyy";
            this.uiDatePicker1.DateYearMonthFormat = "MM-yyyy";
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.uiDatePicker1.Location = new System.Drawing.Point(181, 14);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 10;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.RectColor = System.Drawing.Color.LightSeaGreen;
            this.uiDatePicker1.Size = new System.Drawing.Size(160, 50);
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.SymbolSize = 20;
            this.uiDatePicker1.TabIndex = 1;
            this.uiDatePicker1.Text = "30-01-2025";
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.uiDatePicker1.Value = new System.DateTime(2025, 1, 30, 0, 0, 0, 0);
            this.uiDatePicker1.Watermark = "Đến ngày";
            // 
            // uiDatePicker2
            // 
            this.uiDatePicker2.BackColor = System.Drawing.Color.Transparent;
            this.uiDatePicker2.DateFormat = "dd-MM-yyyy";
            this.uiDatePicker2.DateYearMonthFormat = "MM-yyyy";
            this.uiDatePicker2.FillColor = System.Drawing.Color.White;
            this.uiDatePicker2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDatePicker2.ForeColor = System.Drawing.Color.Black;
            this.uiDatePicker2.Location = new System.Drawing.Point(13, 14);
            this.uiDatePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker2.MaxLength = 10;
            this.uiDatePicker2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker2.Name = "uiDatePicker2";
            this.uiDatePicker2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker2.RectColor = System.Drawing.Color.LightSeaGreen;
            this.uiDatePicker2.Size = new System.Drawing.Size(160, 50);
            this.uiDatePicker2.SymbolDropDown = 61555;
            this.uiDatePicker2.SymbolNormal = 61555;
            this.uiDatePicker2.SymbolSize = 20;
            this.uiDatePicker2.TabIndex = 2;
            this.uiDatePicker2.Text = "30-01-2025";
            this.uiDatePicker2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.uiDatePicker2.Value = new System.DateTime(2025, 1, 30, 0, 0, 0, 0);
            this.uiDatePicker2.Watermark = "Từ ngày";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton1.Location = new System.Drawing.Point(350, 14);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(5);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 25;
            this.uiButton1.Size = new System.Drawing.Size(133, 50);
            this.uiButton1.TabIndex = 3;
            this.uiButton1.Text = "Truy vấn";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // dvDoanhthu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvDoanhthu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvDoanhthu.BackgroundColor = System.Drawing.Color.White;
            this.dvDoanhthu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvDoanhthu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvDoanhthu.ColumnHeadersHeight = 32;
            this.dvDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvDoanhthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Tongtien,
            this.Trangthai,
            this.IDnv});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvDoanhthu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvDoanhthu.EnableHeadersVisualStyles = false;
            this.dvDoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvDoanhthu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dvDoanhthu.Location = new System.Drawing.Point(13, 72);
            this.dvDoanhthu.Name = "dvDoanhthu";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvDoanhthu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvDoanhthu.RowHeadersVisible = false;
            this.dvDoanhthu.RowHeadersWidth = 50;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvDoanhthu.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvDoanhthu.SelectedIndex = -1;
            this.dvDoanhthu.Size = new System.Drawing.Size(1367, 694);
            this.dvDoanhthu.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvDoanhthu.TabIndex = 4;
            this.dvDoanhthu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvDoanhthu_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDhoadon";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ngaylap";
            this.Column2.HeaderText = "Ngày";
            this.Column2.MinimumWidth = 400;
            this.Column2.Name = "Column2";
            this.Column2.Width = 400;
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "Tongtien";
            this.Tongtien.HeaderText = "Tổng tiền";
            this.Tongtien.MinimumWidth = 300;
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.Width = 300;
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.MinimumWidth = 300;
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.Width = 300;
            // 
            // IDnv
            // 
            this.IDnv.DataPropertyName = "IDnv";
            this.IDnv.HeaderText = "Nhân viên";
            this.IDnv.MinimumWidth = 260;
            this.IDnv.Name = "IDnv";
            this.IDnv.Width = 270;
            // 
            // txtTimhanghoa
            // 
            this.txtTimhanghoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimhanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimhanghoa.Location = new System.Drawing.Point(1095, 14);
            this.txtTimhanghoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimhanghoa.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTimhanghoa.Name = "txtTimhanghoa";
            this.txtTimhanghoa.Padding = new System.Windows.Forms.Padding(5);
            this.txtTimhanghoa.Radius = 40;
            this.txtTimhanghoa.ShowText = false;
            this.txtTimhanghoa.Size = new System.Drawing.Size(280, 50);
            this.txtTimhanghoa.TabIndex = 11;
            this.txtTimhanghoa.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimhanghoa.Watermark = "Nhập mã hóa đơn";
            this.txtTimhanghoa.WatermarkActiveColor = System.Drawing.Color.Silver;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton2.Location = new System.Drawing.Point(989, 14);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(5);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 25;
            this.uiButton2.Size = new System.Drawing.Size(97, 50);
            this.uiButton2.TabIndex = 12;
            this.uiButton2.Text = "Tìm";
            this.uiButton2.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // frmQuanlyDoanhthu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1392, 778);
            this.Controls.Add(this.dvDoanhthu);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.txtTimhanghoa);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiDatePicker2);
            this.Controls.Add(this.uiDatePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanlyDoanhthu";
            this.Text = "frmDoanhthu";
            this.Load += new System.EventHandler(this.frmQuanlyDoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvDoanhthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UIDatePicker uiDatePicker2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIDataGridView dvDoanhthu;
        private Sunny.UI.UITextBox txtTimhanghoa;
        private Sunny.UI.UIButton uiButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDnv;
    }
}