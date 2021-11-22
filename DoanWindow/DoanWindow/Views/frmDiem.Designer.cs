namespace DoanWindow.Views
{
    partial class frmDiem
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
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTendt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloaidt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDiemtong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiem
            // 
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cTen,
            this.cGioitinh,
            this.cTendt,
            this.cloaidt,
            this.cNgayBC,
            this.cDiemtong,
            this.cTrangthai});
            this.dgvDiem.Location = new System.Drawing.Point(4, 60);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.RowTemplate.Height = 24;
            this.dgvDiem.Size = new System.Drawing.Size(1131, 429);
            this.dgvDiem.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvDiem);
            this.groupBox1.Location = new System.Drawing.Point(9, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1140, 493);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm số của sinh viên";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(62, 24);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(248, 20);
            this.txtTimkiem.TabIndex = 2;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm:";
            // 
            // cID
            // 
            this.cID.HeaderText = "Mã số sinh viên";
            this.cID.MinimumWidth = 6;
            this.cID.Name = "cID";
            // 
            // cTen
            // 
            this.cTen.HeaderText = "Tên sinh viên";
            this.cTen.MinimumWidth = 6;
            this.cTen.Name = "cTen";
            // 
            // cGioitinh
            // 
            this.cGioitinh.HeaderText = "Giới tính";
            this.cGioitinh.MinimumWidth = 6;
            this.cGioitinh.Name = "cGioitinh";
            // 
            // cTendt
            // 
            this.cTendt.HeaderText = "Tên đề tài";
            this.cTendt.MinimumWidth = 6;
            this.cTendt.Name = "cTendt";
            // 
            // cloaidt
            // 
            this.cloaidt.HeaderText = "Loại đề tài";
            this.cloaidt.MinimumWidth = 6;
            this.cloaidt.Name = "cloaidt";
            // 
            // cNgayBC
            // 
            this.cNgayBC.HeaderText = "Ngày báo cáo";
            this.cNgayBC.MinimumWidth = 6;
            this.cNgayBC.Name = "cNgayBC";
            // 
            // cDiemtong
            // 
            this.cDiemtong.HeaderText = "Điểm tổng";
            this.cDiemtong.MinimumWidth = 6;
            this.cDiemtong.Name = "cDiemtong";
            // 
            // cTrangthai
            // 
            this.cTrangthai.HeaderText = "Trạng Thái";
            this.cTrangthai.MinimumWidth = 6;
            this.cTrangthai.Name = "cTrangthai";
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 523);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDiem";
            this.Text = "Bảng điểm";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTendt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloaidt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiemtong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrangthai;
    }
}