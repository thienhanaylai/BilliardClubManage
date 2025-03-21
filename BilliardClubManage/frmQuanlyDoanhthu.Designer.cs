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
            this.uiLineChart1 = new Sunny.UI.UILineChart();
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.uiDatePicker2 = new Sunny.UI.UIDatePicker();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiLineChart1
            // 
            this.uiLineChart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLineChart1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLineChart1.Location = new System.Drawing.Point(12, 72);
            this.uiLineChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart1.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            this.uiLineChart1.Name = "uiLineChart1";
            this.uiLineChart1.Size = new System.Drawing.Size(1368, 694);
            this.uiLineChart1.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiLineChart1.TabIndex = 0;
            this.uiLineChart1.Text = "uiLineChart1";
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
            // frmDoanhthu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1392, 778);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiDatePicker2);
            this.Controls.Add(this.uiDatePicker1);
            this.Controls.Add(this.uiLineChart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoanhthu";
            this.Text = "frmDoanhthu";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILineChart uiLineChart1;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UIDatePicker uiDatePicker2;
        private Sunny.UI.UIButton uiButton1;
    }
}