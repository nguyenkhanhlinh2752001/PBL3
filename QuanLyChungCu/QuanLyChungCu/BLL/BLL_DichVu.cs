using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.BLL
{
    class BLL_DichVu
    {
        qlchungcuEntities db = new qlchungcuEntities();
        public IEnumerable<object> HienThiDanhSachDichVu()
        {
            var query = from p in db.dichvus
                        select new
                        {
                            p.madichvu,
                            p.tendichvu,
                            p.gia,
                        };
            return query.ToList();
        }

        public int LayMaDichVuLonNhat()
        {
            var query = (from p in db.dichvus select p.madichvu);
            List<int> madv = new List<int>();
            foreach(int i in query)
            {
                madv.Add(i);
            }
            return madv.Max();
        }
        public void ThemDichVu(dichvu dv)
        {
            var query = db.dichvus.Where(p => p.madichvu == dv.madichvu).Count();
            if (query == 0)
            {
                db.dichvus.Add(dv);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lỗi! Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SuaDichVu(dichvu dv)
        {
            var query = (from p in db.dichvus
                         where p.madichvu == dv.madichvu
                         select p).SingleOrDefault();
            query.madichvu = dv.madichvu;
            query.tendichvu = dv.tendichvu;
            query.gia = dv.gia;

            try
            {
                db.SaveChanges();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public void XoaDichVu(List<int> maList)
        {
            foreach(int i in maList)
            {
                var query = db.dichvus.Where(p => p.madichvu.Equals(i)).SingleOrDefault();
                db.dichvus.Remove(query);
                db.SaveChanges();
            }
        }

        public dichvu LayThongTin1DichVu(int madv)
        {
            var query = db.dichvus.Where(p => p.madichvu == madv).SingleOrDefault();
            return query;
        }
        


    }
}
