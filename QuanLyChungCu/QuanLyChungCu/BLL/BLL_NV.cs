using QuanLyChungCu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class BLL_NV
    {
        private qlchungcuEntities db;
        private static BLL_NV instance;
        public static BLL_NV Instance()
        {
            if (instance == null)
            {
                instance = new BLL_NV();
            }
            return instance;
        }

        private BLL_NV()
        {
            db = new qlchungcuEntities();
        }
        public List<nhanvien> GetALLNhanVien()
        {
            return db.nhanviens.Select(p => p).ToList<nhanvien>();
        }

    }
}
