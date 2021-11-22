namespace DoanWindow.Views
{
    partial class frmHoiDong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbNhanXet = new System.Windows.Forms.RichTextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTimeBC = new System.Windows.Forms.DateTimePicker();
            this.cbbDetai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHoiDong = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDetai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoNguoiHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNhanXet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rtbNhanXet);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpTimeBC);
            this.groupBox1.Controls.Add(this.cbbDetai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hội đồng";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(200, 394);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(64, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(136, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(68, 394);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(62, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhận xét:";
            // 
            // rtbNhanXet
            // 
            this.rtbNhanXet.Location = new System.Drawing.Point(9, 235);
            this.rtbNhanXet.Name = "rtbNhanXet";
            this.rtbNhanXet.Size = new System.Drawing.Size(255, 137);
            this.rtbNhanXet.TabIndex = 8;
            this.rtbNhanXet.Text = "";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(10, 187);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(255, 20);
            this.txtSoLuong.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số người trong hội đồng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày báo cáo:";
            // 
            // dtpTimeBC
            // 
            this.dtpTimeBC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeBC.Location = new System.Drawing.Point(10, 139);
            this.dtpTimeBC.Name = "dtpTimeBC";
            this.dtpTimeBC.Size = new System.Drawing.Size(255, 20);
            this.dtpTimeBC.TabIndex = 4;
            // 
            // cbbDetai
            // 
            this.cbbDetai.FormattingEnabled = true;
            this.cbbDetai.Location = new System.Drawing.Point(10, 92);
            this.cbbDetai.Name = "cbbDetai";
            this.cbbDetai.Size = new System.Drawing.Size(255, 21);
            this.cbbDetai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đề tài:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(10, 48);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(255, 20);
            this.txtMaHD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hội đồng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHoiDong);
            this.groupBox2.Location = new System.Drawing.Point(312, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hội đồng";
            // 
            // dgvHoiDong
            // 
            this.dgvHoiDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoiDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoiDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cDetai,
            this.cNgayBC,
            this.cSoNguoiHD,
            this.cNhanXet});
            this.dgvHoiDong.Location = new System.Drawing.Point(6, 19);
            this.dgvHoiDong.Name = "dgvHoiDong";
            this.dgvHoiDong.Size = new System.Drawing.Size(647, 398);
            this.dgvHoiDong.TabIndex = 0;
            this.dgvHoiDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoiDong_CellClick);
            // 
            // cID
            // 
            this.cID.HeaderText = "Mã hội đồng";
            this.cID.Name = "cID";
            // 
            // cDetai
            // 
            this.cDetai.HeaderText = "Mã đề tài";
            this.cDetai.Name = "cDetai";
            // 
            // cNgayBC
            // 
            this.cNgayBC.HeaderText = "Ngày báo cáo";
            this.cNgayBC.Name = "cNgayBC";
            // 
            // cSoNguoiHD
            // 
            this.cSoNguoiHD.HeaderText = "Số người trong hội đồng";
            this.cSoNguoiHD.Name = "cSoNguoiHD";
            // 
            // cNhanXet
            // 
            this.cNhanXet.HeaderText = "Nhận xét";
            this.cNhanXet.Name = "cNhanXet";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmHoiDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoiDong";
            this.Text = "frmHoiDong";
            this.Load += new System.EventHandler(this.frmHoiDong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbNhanXet;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTimeBC;
        private System.Windows.Forms.ComboBox cbbDetai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvHoiDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDetai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoNguoiHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNhanXet;
        private System.Windows.Forms.ErrorProvider error;
    }
}