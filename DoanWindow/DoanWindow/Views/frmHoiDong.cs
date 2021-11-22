using DoanWindow.Controllers;
using DoanWindow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanWindow.Views
{
    public partial class frmHoiDong : Form
    {
        private QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
        public frmHoiDong()
        {
            InitializeComponent();
            this.cID.DataPropertyName = nameof(HoiDong.ID);
            this.cDetai.DataPropertyName = nameof(HoiDong.Detai);
            this.cNgayBC.DataPropertyName = nameof(HoiDong.NgayBC);
            this.cSoNguoiHD.DataPropertyName = nameof(HoiDong.SoNguoiHD);
            this.cNhanXet.DataPropertyName = nameof(HoiDong.NhanXet);
        }

        private void frmHoiDong_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            Load_data();
            Load_cbb_IDDetai();

        }

        public void Load_data()
        {
            var data = from c in sv.HoiDongs
                       select new
                       {
                           ID = c.ID,
                           Detai = c.Detai,
                           NgayBC = c.NgayBC,
                           SoNguoiHD = c.SoNguoiHD,
                           NhanXet = c.NhanXet,
                           
                       };
            dgvHoiDong.DataSource = data.ToList();
        }
        public void clean()
        {
            this.txtMaHD.Text = "";
            this.txtSoLuong.Text = "";
            this.dtpTimeBC.Value = DateTime.Today;
            this.cbbDetai.Text = "";
            this.rtbNhanXet.Text = "";
        }

        public void Load_cbb_IDDetai()
        {
            List<DeTai> detai = sv.DeTais.Where(data => data.TinhTrang == true).ToList();
            if(detai.Count > 0)
            {
                cbbDetai.DataSource = detai;
                cbbDetai.ValueMember = "ID";
                cbbDetai.DisplayMember = "TenDeTai";
            }
            else
            {
                MessageBox.Show("Hiện không có đề tài nào đủ yêu cầu báo cáo!");
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HoiDong hd = new HoiDong();
            if (txtMaHD.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtMaHD, "Hãy nhập mã cho hội đồng!!!");
                return;
            }
            else if (HoiDongController.gethd(txtMaHD.Text.Trim()) != null)
            {
                this.error.SetError(txtMaHD, "Mã hội đồng đã tồn tại!!!");
                return;
            }
            this.error.Clear();
            
            if (cbbDetai.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbDetai, "Hãy nhập mã đề tài cho hội đồng!!!");
                return;
            }
            else if(HoiDongController.getiddetai(cbbDetai.SelectedValue.ToString()) != null)
            {
                this.error.SetError(cbbDetai, "Đề tài này đã có hội đồng chấm thi!!!");
                return;
            }
            this.error.Clear();

            if (txtSoLuong.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbDetai, "Hãy nhập số lượng người trong hội đồng!!!");
                return;
            }
            this.error.Clear();

            hd.ID = this.txtMaHD.Text.Trim();
            hd.Detai = this.cbbDetai.SelectedValue.ToString();
            hd.NgayBC = this.dtpTimeBC.Value.Date;
            hd.SoNguoiHD = int.Parse(this.txtSoLuong.Text.Trim().ToString());
            hd.NhanXet = this.rtbNhanXet.Text.Trim();
            

            if (HoiDongController.addhd(hd) == false)
            {
                MessageBox.Show("thêm thất bại");

            }
            Load_data();
            clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (cbbDetai.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbDetai, "Hãy nhập mã đề tài cho hội đồng!!!");
                return;
            }
            else if (HoiDongController.getiddetaied(txtMaHD.Text,cbbDetai.SelectedValue.ToString()) == null)
            {
                if(HoiDongController.getiddetai(cbbDetai.SelectedValue.ToString()) != null)
                {
                    this.error.SetError(cbbDetai, "Đề tài này đã có hội đồng chấm thi!!!");
                    return;
                }
                
            }
            this.error.Clear();

            if (txtSoLuong.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbDetai, "Hãy nhập số lượng người trong hội đồng!!!");
                return;
            }
            this.error.Clear();
            string ID = this.dgvHoiDong.CurrentRow.Cells[0].Value.ToString();
            HoiDong hd = sv.HoiDongs.Single(t => t.ID.Equals(ID));
            hd.Detai = this.cbbDetai.SelectedValue.ToString();
            hd.NgayBC = this.dtpTimeBC.Value.Date;
            hd.SoNguoiHD = int.Parse(this.txtSoLuong.Text.Trim().ToString());
            hd.NhanXet = this.rtbNhanXet.Text.Trim();
            
            if (HoiDongController.updatehd(hd) == false)
            {
                MessageBox.Show("sửa thất bại");

            }
            Load_data();
            clean();
            this.txtMaHD.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MaHD = this.dgvHoiDong.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                try
                {
                    HoiDong hd = sv.HoiDongs.Single(t => t.ID.Equals(MaHD));
                    sv.HoiDongs.Remove(hd);
                    sv.SaveChanges();
                    Load_data();
                    MessageBox.Show("Xóa thành công!!!");
                    clean();
                    txtMaHD.Enabled = true;

                }
                catch
                { MessageBox.Show("Xóa thất bại"); }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void dgvHoiDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            this.txtMaHD.Enabled = false;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHoiDong.Rows[e.RowIndex];
            txtMaHD.Text = row.Cells[0].Value.ToString();
            cbbDetai.Text = row.Cells[1].Value.ToString();
            dtpTimeBC.Value = (DateTime)row.Cells[2].Value;
            txtSoLuong.Text = row.Cells[3].Value.ToString();
            rtbNhanXet.Text = row.Cells[4].Value.ToString();
        }
    }
}
