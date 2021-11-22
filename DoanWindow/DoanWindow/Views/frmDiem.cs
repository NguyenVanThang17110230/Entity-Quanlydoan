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
    public partial class frmDiem : Form
    {
        QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
        public frmDiem()
        {
            InitializeComponent();
            this.cID.DataPropertyName = nameof(SinhVien.ID);
            this.cTen.DataPropertyName = nameof(SinhVien.Ten);
            this.cGioitinh.DataPropertyName = nameof(SinhVien.GioiTinh);
            this.cTendt.DataPropertyName = nameof(DeTai.TenDeTai);
            this.cloaidt.DataPropertyName = nameof(LoaiDeTai.LoaiDeTai1);
            this.cNgayBC.DataPropertyName = nameof(HoiDong.NgayBC);
            this.cDiemtong.DataPropertyName = nameof(Diem.Diem1);
            this.cTrangthai.DataPropertyName = nameof(DeTai.TinhTrang);    
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            Load_data();
        }
        public void Load_data()
        {
            var data = from c in sv.DeTais
                       join d in sv.SinhViens on c.ID equals d.DeTai
                       join f in sv.HoiDongs on c.ID equals f.Detai
                       join h in sv.Diems on f.ID equals h.HoiDong
                       join g in sv.LoaiDeTais on c.LoaiDeTai equals g.ID
                       where c.TinhTrang == true
                       select new
                       {
                           ID = d.ID,
                           Ten = d.Ten,
                           GioiTinh = d.GioiTinh,
                           TenDeTai = c.TenDeTai,
                           LoaiDeTai1 = g.LoaiDeTai1,
                           NgayBC = f.NgayBC,
                           Diem1 = h.Diem1,
                           TinhTrang = c.TinhTrang, 
                       };
            
            dgvDiem.DataSource = data.ToList();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            DiemController dc = new DiemController();
            DataTable dt = dc.Searchsv(txtTimkiem.Text);
            dgvDiem.DataSource = dt;
            dgvDiem.Refresh();
        }
    }
}
