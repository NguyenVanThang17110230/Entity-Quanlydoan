using DoanWindow.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanWindow.Controllers
{
    internal class HoiDongController
    {
        public static bool addhd(HoiDong hoidong)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                _context.HoiDongs.Add(hoidong);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool updatehd(HoiDong hoidong)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                _context.HoiDongs.AddOrUpdate(hoidong);
                _context.SaveChanges();
                return true;
            }
        }

        public static HoiDong gethd(string ID)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                var user = (from u in _context.HoiDongs
                            where u.ID == ID
                            select u).ToList();
                if (user.Count == 1)
                {
                    return user[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static HoiDong getiddetai(string ID)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                var hoidong = (from u in _context.HoiDongs
                              where u.Detai == ID
                              select u).ToList();
                if (hoidong.Count == 1)
                {
                    return hoidong[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public static HoiDong getiddetaied(string ID,string IDDT)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                var hoidong = (from u in _context.HoiDongs
                               where u.ID == ID && u.Detai == IDDT
                               select u).ToList();
                if (hoidong.Count == 1)
                {
                    return hoidong[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public DataTable Searchsv(string Ten)
        {
            QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
            var data = from p in sv.BaoCaos
                       where p.IDDeTai.Contains(Ten) || p.IDBaoCao.Contains(Ten)
                       select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("IDBaoCao");
            dt.Columns.Add("IDDeTai");
            dt.Columns.Add("LanBaoCao");
            dt.Columns.Add("TaiLieu");
            dt.Columns.Add("NhanXet");
            dt.Columns.Add("TrangThai");
            foreach (var q in data)
            {
                dt.Rows.Add(q.IDBaoCao, q.IDDeTai, q.LanBaoCao, q.TaiLieu, q.NhanXet, q.TrangThai);
            }
            return dt;
        }
    }
}
