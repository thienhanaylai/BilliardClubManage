﻿using System.Windows.Forms;

namespace BilliardClubManage
{
    partial class frmQuanlyban
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
            this.txtTimban = new Sunny.UI.UITextBox();
            this.btnTimban = new Sunny.UI.UIButton();
            this.btnXoaban = new Sunny.UI.UIButton();
            this.btnSuaban = new Sunny.UI.UIButton();
            this.btnThemban = new Sunny.UI.UIButton();
            this.dgvBan = new Sunny.UI.UIDataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLoaiban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimban
            // 
            this.txtTimban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimban.Location = new System.Drawing.Point(693, 12);
            this.txtTimban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimban.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTimban.Name = "txtTimban";
            this.txtTimban.Padding = new System.Windows.Forms.Padding(5);
            this.txtTimban.Radius = 40;
            this.txtTimban.ShowText = false;
            this.txtTimban.Size = new System.Drawing.Size(686, 60);
            this.txtTimban.TabIndex = 16;
            this.txtTimban.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimban.Watermark = "Nhập ID bàn, tên bàn";
            this.txtTimban.WatermarkActiveColor = System.Drawing.Color.Silver;
            // 
            // btnTimban
            // 
            this.btnTimban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimban.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimban.Location = new System.Drawing.Point(556, 12);
            this.btnTimban.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTimban.Name = "btnTimban";
            this.btnTimban.Radius = 35;
            this.btnTimban.Size = new System.Drawing.Size(130, 60);
            this.btnTimban.TabIndex = 15;
            this.btnTimban.Text = "Tìm";
            this.btnTimban.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTimban.Click += new System.EventHandler(this.btnTimban_Click);
            // 
            // btnXoaban
            // 
            this.btnXoaban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaban.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaban.Location = new System.Drawing.Point(284, 12);
            this.btnXoaban.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoaban.Name = "btnXoaban";
            this.btnXoaban.Radius = 35;
            this.btnXoaban.Size = new System.Drawing.Size(130, 60);
            this.btnXoaban.TabIndex = 13;
            this.btnXoaban.Text = "Xóa";
            this.btnXoaban.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoaban.Click += new System.EventHandler(this.btnXoaban_Click);
            // 
            // btnSuaban
            // 
            this.btnSuaban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaban.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaban.Location = new System.Drawing.Point(148, 12);
            this.btnSuaban.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSuaban.Name = "btnSuaban";
            this.btnSuaban.Radius = 35;
            this.btnSuaban.Size = new System.Drawing.Size(130, 60);
            this.btnSuaban.TabIndex = 12;
            this.btnSuaban.Text = "Sửa";
            this.btnSuaban.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSuaban.Click += new System.EventHandler(this.btnSuaban_Click);
            // 
            // btnThemban
            // 
            this.btnThemban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemban.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemban.Location = new System.Drawing.Point(12, 12);
            this.btnThemban.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThemban.Name = "btnThemban";
            this.btnThemban.Radius = 35;
            this.btnThemban.Size = new System.Drawing.Size(130, 60);
            this.btnThemban.TabIndex = 11;
            this.btnThemban.Text = "Thêm";
            this.btnThemban.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThemban.Click += new System.EventHandler(this.btnThemban_Click);
            // 
            // dgvBan
            // 
            this.dgvBan.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBan.ColumnHeadersHeight = 32;
            this.dgvBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmName,
            this.tinhtrang,
            this.dongia,
            this.clmQty,
            this.clmLoaiban});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBan.EnableHeadersVisualStyles = false;
            this.dgvBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvBan.Location = new System.Drawing.Point(12, 82);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBan.RowHeadersVisible = false;
            this.dgvBan.RowHeadersWidth = 50;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvBan.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBan.RowTemplate.Height = 35;
            this.dgvBan.SelectedIndex = -1;
            this.dgvBan.ShowCellErrors = false;
            this.dgvBan.ShowCellToolTips = false;
            this.dgvBan.ShowEditingIcon = false;
            this.dgvBan.ShowRowErrors = false;
            this.dgvBan.Size = new System.Drawing.Size(1368, 684);
            this.dgvBan.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvBan.TabIndex = 10;
            this.dgvBan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBan_CellFormatting);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "IDban";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmName.DataPropertyName = "Tenban";
            this.clmName.HeaderText = "Tên bàn";
            this.clmName.MinimumWidth = 300;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 300;
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "Tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.MinimumWidth = 300;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.ReadOnly = true;
            this.tinhtrang.Width = 300;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "Dongia";
            this.dongia.HeaderText = "Đơn giá ";
            this.dongia.MinimumWidth = 230;
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            this.dongia.Width = 230;
            // 
            // clmQty
            // 
            this.clmQty.DataPropertyName = "Khuvuc";
            this.clmQty.HeaderText = "Khu vực";
            this.clmQty.MinimumWidth = 335;
            this.clmQty.Name = "clmQty";
            this.clmQty.ReadOnly = true;
            this.clmQty.Width = 335;
            // 
            // clmLoaiban
            // 
            this.clmLoaiban.DataPropertyName = "Loaiban";
            this.clmLoaiban.HeaderText = "Loai Ban";
            this.clmLoaiban.MinimumWidth = 100;
            this.clmLoaiban.Name = "clmLoaiban";
            this.clmLoaiban.ReadOnly = true;
            // 
            // frmQuanlyban
            // 
            this.AcceptButton = this.btnTimban;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1392, 778);
            this.Controls.Add(this.txtTimban);
            this.Controls.Add(this.btnTimban);
            this.Controls.Add(this.btnXoaban);
            this.Controls.Add(this.btnSuaban);
            this.Controls.Add(this.btnThemban);
            this.Controls.Add(this.dgvBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanlyban";
            this.Text = "frmQuanlyban";
            this.Load += new System.EventHandler(this.frmQuanlyban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox txtTimban;
        private Sunny.UI.UIButton btnTimban;
        private Sunny.UI.UIButton btnXoaban;
        private Sunny.UI.UIButton btnSuaban;
        private Sunny.UI.UIButton btnThemban;
        private Sunny.UI.UIDataGridView dgvBan;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn tinhtrang;
        private DataGridViewTextBoxColumn dongia;
        private DataGridViewTextBoxColumn clmQty;
        private DataGridViewTextBoxColumn clmLoaiban;
    }
}