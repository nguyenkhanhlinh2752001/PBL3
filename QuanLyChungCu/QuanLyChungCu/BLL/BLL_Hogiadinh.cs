using QuanLyChungCu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class BLL_Hogiadinh
    {
        private qlchungcuEntities db;
        private static BLL_Hogiadinh instance;
        public static BLL_Hogiadinh Instance()
        {
            if (instance == null)
            {
                instance = new BLL_Hogiadinh();
            }
            return instance;
        }

        private BLL_Hogiadinh()
        {
            db = new qlchungcuEntities();
        }

        public List<hogiadinh> GetAllHogiadinh()
        {
            return db.hogiadinhs.Select(p => p).ToList<hogiadinh>();
        }
        public hogiadinh GetHoGiaDinhByid(int ID)
        {
            return db.hogiadinhs.Where(p => p.maho.Equals(ID)).Select(p => p).FirstOrDefault();
        }
        public void ADD(hogiadinh a)
        {
            db.hogiadinhs.Add(a);
            db.SaveChanges();
        }
    }
}
