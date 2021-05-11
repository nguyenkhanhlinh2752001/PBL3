using QuanLyChungCu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class BLL_canho
    {
        private qlchungcuEntities db;
        private static BLL_canho instance;
        public static BLL_canho Instance()
        {
            if (instance == null)
            {
                instance = new BLL_canho();
            }
            return instance;
        }

        private BLL_canho()
        {
            db = new qlchungcuEntities();
        }
        public List<canho> GetALLCanHo()
        {
            return db.canhoes.Select(p => p).ToList<canho>();
        }
    }
}
