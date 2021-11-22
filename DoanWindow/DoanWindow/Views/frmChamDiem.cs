using DoanWindow.Controllers;
using DoanWindow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanWindow.Views
{
    public partial class frmChamDiem : Form
    {
        private QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
        public frmChamDiem()
        {
            InitializeComponent();
            this.cID.DataPropertyName = nameof(Diem.ID);
            this.cHoiDong.DataPropertyName = nameof(Diem.HoiDong);
            this.cDiem.DataPropertyName = nameof(Diem.Diem1);
        }

        private void frmChamDiem_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            Load_data();
            Load_cbb_IDHoiDong();
        }

        public void Load_cbb_IDHoiDong()
        {
            List<HoiDong> hoidong = sv.HoiDongs.ToList();
            
                cbbHoiDong.DataSource = hoidong;
                cbbHoiDong.ValueMember = "ID";
                cbbHoiDong.DisplayMember = "ID";
            

        }


        public void clean()
        {
            this.txtMaDiem.Text = "";
            this.cbbHoiDong.Text = "";
            this.txtDiem.Text = "";
        }
        public void Load_data()
        {
            var data = from c in sv.Diems
                       select new
                       {
                           ID = c.ID,
                           HoiDong = c.HoiDong,
                           Diem1 = c.Diem1,
                       };
            dgvDiem.DataSource = data.ToList();
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            this.txtMaDiem.Enabled = false;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDiem.Rows[e.RowIndex];
            txtMaDiem.Text = row.Cells[0].Value.ToString();
            cbbHoiDong.Text = row.Cells[1].Value.ToString();
            txtDiem.Text = row.Cells[2].Value.ToString();  
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Diem diem = new Diem();
            if (txtMaDiem.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtMaDiem, "Hãy nhập mã chấm điểm!!!");
                return;
            }
            else if (ChamDiemController.getDiem(txtMaDiem.Text.Trim()) != null)
            {
                this.error.SetError(txtMaDiem, "Mã chấm điểm đã tồn tại!!!");
                return;
            }
            this.error.Clear();

            if (cbbHoiDong.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbHoiDong, "Hãy nhập mã hội đồng cần chấm điểm!!!");
                return;
            }
            else if (ChamDiemController.getidhd(cbbHoiDong.SelectedValue.ToString()) != null)
            {
                this.error.SetError(cbbHoiDong, "Đồ án của hội đồng này đã được chấm điểm!!!");
                return;
            }
            this.error.Clear();

            string phone = txtDiem.Text.ToString();
            Regex rg = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            rg.IsMatch(phone);
            if (txtDiem.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtDiem, "Điểm không được để trống!!!");
                return;
            }
            if (rg.IsMatch(phone) == false)
            {
                this.error.SetError(txtDiem, "Điểm không chứa chữ cái!!!");
                return;
            }
            else if (float.Parse(txtDiem.Text.Trim()) < 0 || float.Parse(txtDiem.Text.Trim()) > 10)
            {
                this.error.SetError(txtDiem, "Điểm không nằm trong phạm vi cho phép!!!");
                return;
            }
            this.error.Clear();

            diem.ID = this.txtMaDiem.Text.Trim();
            diem.HoiDong = this.cbbHoiDong.SelectedValue.ToString();
            diem.Diem1 = int.Parse(this.txtDiem.Text.Trim());

            if (ChamDiemController.addDiem(diem) == false)
            {
                MessageBox.Show("thêm thất bại");

            }
            Load_data();
            clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbbHoiDong.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbHoiDong, "Hãy nhập mã hội đồng cần chấm điểm!!!");
                return;
            }
            else if (HoiDongController.getiddetaied(txtMaDiem.Text, cbbHoiDong.SelectedValue.ToString()) == null)
            {
                if (HoiDongController.getiddetai(cbbHoiDong.SelectedValue.ToString()) != null)
                {
                    this.error.SetError(cbbHoiDong, "Đồ án của hội đồng này đã được chấm điểm!!!");
                    return;
                }

            }
            this.error.Clear();
            string phone = txtDiem.Text.ToString();
            Regex rg = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            rg.IsMatch(phone);
            if (txtDiem.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtDiem, "Điểm không được để trống!!!");
                return;
            }
            if (rg.IsMatch(phone) == false)
            {
                this.error.SetError(txtDiem, "Điểm không chứa chữ cái!!!");
                return;
            }
            else if (float.Parse(txtDiem.Text.Trim()) < 0 || float.Parse(txtDiem.Text.Trim()) > 10)
            {
                this.error.SetError(txtDiem, "Điểm không nằm trong phạm vi cho phép!!!");
                return;
            }
            this.error.Clear();
            string ID = this.dgvDiem.CurrentRow.Cells[0].Value.ToString();
            Diem diem = sv.Diems.Single(t => t.ID.Equals(ID));
            diem.HoiDong = this.cbbHoiDong.SelectedValue.ToString();
            diem.Diem1 = int.Parse(this.txtDiem.Text.Trim().ToString());

            if (ChamDiemController.updateDiem(diem) == false)
            {
                MessageBox.Show("sửa thất bại");

            }
            Load_data();
            clean();
            this.txtMaDiem.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MaDiem = this.dgvDiem.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                try
                {
                    Diem diem = sv.Diems.Single(t => t.ID.Equals(MaDiem));
                    sv.Diems.Remove(diem);
                    sv.SaveChanges();
                    Load_data();
                    MessageBox.Show("Xóa thành công!!!");
                    clean();
                    txtMaDiem.Enabled = true;

                }
                catch
                { MessageBox.Show("Xóa thất bại"); }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}
