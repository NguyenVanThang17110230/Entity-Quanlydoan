using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoanWindow.Models;
using System.Data.Entity.Migrations;
using System.Windows.Forms;
using System.Data;

namespace DoanWindow.Controllers
{
    class DiemController
    {
        public DataTable Searchsv(string Ten)
        {
            QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
            var data = from c in sv.DeTais
                       join d in sv.SinhViens on c.ID equals d.DeTai
                       join f in sv.BaoCaos on c.ID equals f.IDDeTai
                       join g in sv.LoaiDeTais on c.LoaiDeTai equals g.ID
                       where f.TrangThai == true && d.ID.Contains(Ten)
                       select new
                       {
                           ID = d.ID,
                           Ten = d.Ten,
                           GioiTinh = d.GioiTinh,
                           TenDeTai = c.TenDeTai,
                           LoaiDeTai = g.LoaiDeTai1,
                           TrangThai = f.TrangThai
                       };
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ten");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("TenDeTai");
            dt.Columns.Add("LoaiDeTai");
            dt.Columns.Add("TrangThai");
            foreach (var q in data)
            {
                dt.Rows.Add(q.ID, q.Ten, q.GioiTinh, q.TenDeTai, q.LoaiDeTai, q.TrangThai);
            }
            return dt;
        }
    }
}
