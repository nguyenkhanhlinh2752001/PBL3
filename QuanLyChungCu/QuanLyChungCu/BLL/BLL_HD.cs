using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChungCu.DAL;

namespace QuanLyChungCu.BLL
{
    class BLL_HD
    {
        private qlchungcuEntities db;
        private static BLL_HD instance;
        public static BLL_HD Instance()
        {
            if (instance == null)
            {
                instance = new BLL_HD();
            }
            return instance;
        }

        private BLL_HD()
        {
            db = new qlchungcuEntities();
        }
        public List<hopdong> GetAllHD()
        {
            List<hopdong> data = new List<hopdong>();
            var l1 = db.hopdongs.Select(p => p);
            data = l1.ToList<hopdong>();
            return data;
        }
        public void AddorUpdate(hopdong a)
        {
            if (db.hopdongs.Where(p => p.mahopdong.Equals(a.mahopdong)).Select(p => p).FirstOrDefault() != null)
            {
                var l1 = db.hopdongs.Where(p => p.mahopdong.Equals(a.mahopdong)).Select(p => p).FirstOrDefault();
                l1.mahopdong = a.mahopdong;
                l1.maho = a.maho;
                l1.macanho = a.macanho;
                l1.giatien = a.giatien;
                l1.thoihan = a.thoihan;
                l1.manhanvien = a.manhanvien;
                l1.ngayki = a.ngayki;
                l1.dahuy = a.dahuy;
                l1.tenhopdong = a.tenhopdong;
                db.SaveChanges();
            }
            else
            {
                db.hopdongs.Add(a);
                db.SaveChanges();
            }
        }




        public Array GetALLHDViews()
        {
            var l1 = db.hopdongs.Select(p => new { p.mahopdong, p.manhanvien, p.macanho, p.maho, p.tenhopdong, p.giatien, p.thoihan, p.ngayki, p.dahuy });
            return l1.ToArray();
        }
        public Array GetHDbyIDViews(int id)
        {
            var l1 = db.hopdongs.Where(p => p.mahopdong.Equals(id) == true).Select(p => new { p.mahopdong, p.manhanvien, p.macanho, p.maho, p.tenhopdong, p.giatien, p.thoihan, p.ngayki, p.dahuy });
            return l1.ToArray();
        }
        public Array GetHDByNameViews(string name)
        {
            var l1 = db.hopdongs.Where(p => p.tenhopdong.Contains(name)).Select(p => new { p.mahopdong, p.manhanvien, p.macanho, p.maho, p.tenhopdong, p.giatien, p.thoihan, p.ngayki, p.dahuy });
            return l1.ToArray();
        }
        public hopdong GetHDdetail(int id)
        {
            if (db.hopdongs.Where(p => p.mahopdong.Equals(id)).Select(p => p).FirstOrDefault() != null)
            {
                var l1 = db.hopdongs.Where(p => p.mahopdong.Equals(id)).Select(p => p).FirstOrDefault();
                hopdong a = (hopdong)l1;
                return a;
            }
            return null;
        }
        public void Delete(int MAHD)
        {
            var l1 = db.hopdongs.Where(p => p.mahopdong.Equals(MAHD)).Select(p => p).FirstOrDefault();
            db.hopdongs.Remove((hopdong)l1);
            db.SaveChanges();
        }
        public List<hopdong> Sort(string properties)
        {
            List<hopdong> data = new List<hopdong>();
            // data = db.hopdongs.Select(p => p).ToList<hopdong>();
            data = GetAllHD();
            if (properties.Equals("Name"))
            {
                for (int i = 0; i < data.Count - 1; i++)
                {
                    for (int j = i + 1; j < data.Count; j++)
                    {
                        if (string.Compare(data[i].tenhopdong, data[j].tenhopdong, false) > 0)
                        {
                            hopdong temp = data[i];
                            data[i] = data[j];
                            data[j] = temp;
                        }
                    }
                }
            }
            if (properties.Equals("ThoiHan"))
            {
                for (int i = 0; i < data.Count - 1; i++)
                {
                    for (int j = i + 1; j < data.Count; j++)
                    {
                        if (Convert.ToInt32(data[i].thoihan) > Convert.ToInt32(data[j].thoihan))
                        {
                            hopdong temp = data[i];
                            data[i] = data[j];
                            data[j] = temp;
                        }
                    }
                }
            }
            if (properties.Equals("GiaTien"))
            {
                for (int i = 0; i < data.Count - 1; i++)
                {
                    for (int j = i + 1; j < data.Count; j++)
                    {
                        if (Convert.ToDouble(data[i].giatien) > Convert.ToDouble(data[j].giatien))
                        {
                            hopdong temp = data[i];
                            data[i] = data[j];
                            data[j] = temp;
                        }
                    }
                }
            }
            return data;
        }
    }
}
