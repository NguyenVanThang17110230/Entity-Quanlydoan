using DoanWindow.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanWindow.Controllers
{
    internal class ChamDiemController
    {
        public static bool addDiem(Diem diem)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                _context.Diems.Add(diem);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool updateDiem(Diem diem)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                _context.Diems.AddOrUpdate(diem);
                _context.SaveChanges();
                return true;
            }
        }

        public static Diem getDiem(string ID)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                var diem = (from u in _context.Diems
                            where u.ID == ID
                            select u).ToList();
                if (diem.Count == 1)
                {
                    return diem[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static Diem getidhd(string ID)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                var diem = (from u in _context.Diems
                               where u.HoiDong == ID
                               select u).ToList();
                if (diem.Count == 1)
                {
                    return diem[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public static Diem getidhoidong(string ID, string IDHD)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                var hoidong = (from u in _context.Diems
                               where u.ID == ID && u.HoiDong == IDHD
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
    }
}
