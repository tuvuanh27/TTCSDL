﻿
namespace WindowsFormsApp2
{
    partial class FormQLHocSinh
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnQuanLyHocPhi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachHocVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(72, 482);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(251, 57);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm học viên";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnQuanLyHocPhi
            // 
            this.btnQuanLyHocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHocPhi.Location = new System.Drawing.Point(413, 482);
            this.btnQuanLyHocPhi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyHocPhi.Name = "btnQuanLyHocPhi";
            this.btnQuanLyHocPhi.Size = new System.Drawing.Size(776, 57);
            this.btnQuanLyHocPhi.TabIndex = 35;
            this.btnQuanLyHocPhi.Text = "Quản lý thu học phí";
            this.btnQuanLyHocPhi.UseVisualStyleBackColor = true;
            this.btnQuanLyHocPhi.Click += new System.EventHandler(this.btnQuanLyHocPhi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1081, 404);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(155, 39);
            this.btnTimKiem.TabIndex = 34;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimKiem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbTimKiem.Location = new System.Drawing.Point(249, 404);
            this.txbTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(767, 34);
            this.txbTimKiem.TabIndex = 33;
            this.txbTimKiem.Text = "Nhập thông tin muốn tìm kiếm";
            this.txbTimKiem.ForeColorChanged += new System.EventHandler(this.txbTimKiem_ForeColorChanged);
            this.txbTimKiem.Enter += new System.EventHandler(this.txbTimKiem_Enter);
            this.txbTimKiem.Leave += new System.EventHandler(this.txbTimKiem_Leave);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã học viên",
            "Họ tên"});
            this.cbbTimKiem.Location = new System.Drawing.Point(48, 404);
            this.cbbTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(176, 33);
            this.cbbTimKiem.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(73, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1117, 47);
            this.label1.TabIndex = 31;
            this.label1.Text = "QUẢN LÝ HỌC SINH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDanhSachHocVien
            // 
            this.dgvDanhSachHocVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachHocVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachHocVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachHocVien.Location = new System.Drawing.Point(48, 80);
            this.dgvDanhSachHocVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSachHocVien.Name = "dgvDanhSachHocVien";
            this.dgvDanhSachHocVien.RowHeadersWidth = 51;
            this.dgvDanhSachHocVien.Size = new System.Drawing.Size(1163, 288);
            this.dgvDanhSachHocVien.TabIndex = 30;
            this.dgvDanhSachHocVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHocVien_CellDoubleClick);
            // 
            // FormQLHocSinh
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 550);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnQuanLyHocPhi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.cbbTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachHocVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQLHocSinh";
            this.Text = "FormQLHocSinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQLHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnQuanLyHocPhi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachHocVien;
    }
}