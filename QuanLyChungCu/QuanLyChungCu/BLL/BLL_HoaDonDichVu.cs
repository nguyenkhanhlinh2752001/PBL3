using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.BLL
{
    class BLL_HoaDonDichVu
    {
        qlchungcuEntities db = new qlchungcuEntities();
        public IEnumerable<object> HienThiDanhSachHoaDon()
        {
            var query = from p in db.hoadondichvus
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }

        public int TongSoHoaDon()
        {
            var query = (from p in db.hoadondichvus select p.mahoadon).Count();
            return query;
        }


        public IEnumerable<Object> DanhSachHoaDonVaoNgay(DateTime VaoNgay)
        {
            var query = from p in db.hoadondichvus
                        where p.ngaylap == VaoNgay
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonNgayDenNgay(DateTime TuNgay, DateTime DenNgay)
        {
            var query = from p in db.hoadondichvus
                        where (p.ngaylap <= DenNgay && p.ngaylap >= TuNgay)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }

        public IEnumerable<Object> DanhSachHoaDonTheoMaCH(int mach)
        {
            var query = from p in db.hoadondichvus
                        where p.macanho == mach
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonTheoMaCHVaoNgay(DateTime VaoNgay, int mach)
        {
            var query = from p in db.hoadondichvus
                        where p.ngaylap == VaoNgay && p.macanho==mach
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonTheoMaCHNgayDenNgay(DateTime TuNgay, DateTime DenNgay, int mach)
        {
            var query = from p in db.hoadondichvus
                        where (p.ngaylap <= DenNgay && p.ngaylap >= TuNgay) && p.macanho == mach
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }


        public IEnumerable<Object> DanhSachHoaDonTheoTenNV(string ten)
        {
            var query = from p in db.hoadondichvus
                        where p.nhanvien.tennhanvien.Contains(ten)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonTheoTenNVVaoNgay(DateTime VaoNgay, string ten)
        {
            var query = from p in db.hoadondichvus
                        where p.ngaylap == VaoNgay && p.nhanvien.tennhanvien.Contains(ten)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonTheoTenNVNgayDenNgay(DateTime TuNgay, DateTime DenNgay, string ten)
        {
            var query = from p in db.hoadondichvus
                        where (p.ngaylap <= DenNgay && p.ngaylap >= TuNgay) && p.nhanvien.tennhanvien.Contains(ten)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }

        public IEnumerable<Object> DanhSachHoaDonTheoThanhToan(Boolean check)
        {
            var query = from p in db.hoadondichvus
                        where p.dathanhtoan.Equals(check)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonTheoThanhToanVaoNgay(DateTime VaoNgay, Boolean check)
        {
            var query = from p in db.hoadondichvus
                        where p.ngaylap == VaoNgay && p.dathanhtoan.Equals(check)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonTheoThanhToanNgayDenNgay(DateTime TuNgay, DateTime DenNgay, Boolean check)
        {
            var query = from p in db.hoadondichvus
                        where (p.ngaylap <= DenNgay && p.ngaylap >= TuNgay) && p.dathanhtoan.Equals(check)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }

        public IEnumerable<Object> HoaDonTheoMaHD(int mahd)
        {
            var query = from p in db.hoadondichvus
                        where p.mahoadon==mahd
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }

        public string LayMaCanHoTuMaHoaDon(int mahd)
        {
            var query = (from p in db.hoadondichvus
                         where p.mahoadon == mahd
                         select p.macanho).SingleOrDefault().ToString();
            return query;
        }


        public string LayMaNhanVienTuMaHoaDon(int mahd)
        {
            var query = (from p in db.hoadondichvus
                         where p.mahoadon == mahd
                         select p.manhanvien).SingleOrDefault().ToString();
            return query;
        }

        public canho LayThongTin1CanHo(int maCH)
        {
            var query = db.canhoes.Where(p => p.macanho == maCH).SingleOrDefault();
            return query;
        }


        public nhanvien LayThongTin1NhanVien(int maNV)
        {
            var query = db.nhanviens.Where(p => p.manhanvien == maNV).SingleOrDefault();
            return query;
        }

        public hoadondichvu LayThongTin1HoaDon(int maHD)
        {
            var query = db.hoadondichvus.Where(p => p.mahoadon == maHD).SingleOrDefault();
            return query;
        }

        public IEnumerable<Object> HienThiDanhSachDichVuDaSuDung(int maHD)
        {
            var query = from p in db.chitiethoadons
                        where p.mahoadon == maHD
                        select new
                        {
                            //p.madichvu,
                            p.dichvu.tendichvu,
                            p.dichvu.gia,
                            p.soluong,
                            thanhtien=p.soluong*p.dichvu.gia
                        };
            return query.ToList();
        }

        public int LayMaHDLonNhat()
        {
            var query = (from p in db.hoadondichvus select p.mahoadon);
            List<int> maHD = new List<int>();
            foreach(int i in query)
            {
                maHD.Add(i);
            }
            return maHD.Max();

        }

        public IEnumerable<object> HienThiDSDichVuDaChon(int mahd)
        {
            var query = from p in db.chitiethoadons
                        where p.mahoadon == mahd
                        select new
                        {
                            p.madichvu,
                            p.dichvu.tendichvu,
                            p.soluong,
                            p.dichvu.gia,
                            thanhtien=p.soluong*p.dichvu.gia,
                            
                        };
            return query.ToList();

        }

        public void ThemDichVuVaoHD(chitiethoadon cthd)
        {
            var query = db.chitiethoadons.Where(p => p.mahoadon == cthd.mahoadon && p.madichvu == cthd.madichvu).Count();
            if (query == 0)
            {
                db.chitiethoadons.Add(cthd);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Bạn đã chọn dịch vụ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void XoaDichVuKhoiHD(int mahd, int madv)
        {
            var query = db.chitiethoadons.Where(p => p.mahoadon.Equals(mahd) && p.madichvu.Equals(madv)).SingleOrDefault();
            db.chitiethoadons.Remove(query);
            db.SaveChanges();
        }

        public void ThemHoaDonDV(hoadondichvu hd)
        {
            var query = db.hoadondichvus.Where(p => p.mahoadon == hd.mahoadon).Count();
            if (query == 0)
            {
                db.hoadondichvus.Add(hd);
                db.SaveChanges();
                //MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void SuaHoaDonDV(hoadondichvu hd)
        {
            var query = (from p in db.hoadondichvus
                         where p.mahoadon == hd.mahoadon
                         select p).SingleOrDefault();
            query.mahoadon = hd.mahoadon;
            query.macanho = hd.macanho;
            query.manhanvien = hd.manhanvien;
            query.tongtien = hd.tongtien;
            query.ngaylap = hd.ngaylap;
            query.dathanhtoan = hd.dathanhtoan;

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Boolean KiemTraCanHoTonTai(int maCH)
        {
            var query =(from p in db.canhoes where p.macanho.Equals(maCH) select p).Any();
            if (query == true) return true;
            else return false;

        } 

        public IEnumerable<Object> TimKiemHDTheoTenNV(string ten)
        {
            var query = from p in db.hoadondichvus
                        where p.nhanvien.tennhanvien.Contains(ten)
                        select new
                        {
                            p.mahoadon,
                            p.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }







    }
}
