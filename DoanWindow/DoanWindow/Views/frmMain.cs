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
    public partial class frmMain : Form
    {
        frmBaoCao formbaocao;
        frmDeTai formdetai;
        frmSinhVien formsinhvien;
        frmGiangVien formgiangvien;
        frmDiem formdiem;
        frmHoiDong formHD;
        frmChamDiem formCD;
        
        public frmMain()
        {
            InitializeComponent();      
            Width = 1200;
            Height = 600;
          
        }
        private void sinhvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
                if (this.formsinhvien is null || this.formsinhvien.IsDisposed)
                {
                    this.formsinhvien = new frmSinhVien();
                    formsinhvien.MdiParent = this;
                    this.formsinhvien.Show();
                }
                else
                {
                    this.formsinhvien.Select();
                }
            
        }

        private void giangvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                if (this.formgiangvien is null || this.formgiangvien.IsDisposed)
                {
                    this.formgiangvien = new frmGiangVien();
                    formgiangvien.MdiParent = this;
                    this.formgiangvien.Show();
                }
                else
                {
                    this.formgiangvien.Select();
                }
            
        }

        private void detaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formdetai is null || this.formdetai.IsDisposed)
            {
                this.formdetai = new frmDeTai();
                formdetai.MdiParent = this;
                this.formdetai.Show();
            }
            else
            {
                this.formdetai.Select();
            }
        }

        private void tiendoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                if (this.formbaocao is null || this.formbaocao.IsDisposed)
                {
                    this.formbaocao = new frmBaoCao();
                    formbaocao.MdiParent = this;
                    this.formbaocao.Show();
                }
                else
                {
                    this.formbaocao.Select();
                }
             
            
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;

            if (this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabMain;
                this.tabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedTab != null && this.tabMain.SelectedTab.Tag != null)
            {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
        }

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo);
            if(dialog==System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                Form lg = new frmLogin();
                lg.ShowDialog();
                this.Close();
            }
        }

        private void xemdiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formdiem is null || this.formdiem.IsDisposed)
            {
                this.formdiem = new frmDiem();
                formdiem.MdiParent = this;
                this.formdiem.Show();
            }
            else
            {
                this.formdiem.Select();
            }
        }

        private void hoidongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formHD is null || this.formHD.IsDisposed)
            {
                this.formHD = new frmHoiDong();
                formHD.MdiParent = this;
                this.formHD.Show();
            }
            else
            {
                this.formHD.Select();
            }
        }

        private void chamdiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formCD is null || this.formCD.IsDisposed)
            {
                this.formCD = new frmChamDiem();
                formCD.MdiParent = this;
                this.formCD.Show();
            }
            else
            {
                this.formCD.Select();
            }
        }
    }
}
