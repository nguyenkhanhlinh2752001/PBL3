using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChungCu.BLL;

namespace QuanLyChungCu.View
{
    public partial class Form_QuanLyDichVu : Form
    {
        BLL_DichVu dv_bll = new BLL_DichVu();
        int maHD;

        public Form_QuanLyDichVu()
        {
            InitializeComponent();
            HienThiDanhSachDichVu();
            btnChon.Visible = false;
        }       
        public Form_QuanLyDichVu(int mahd)
        {
            InitializeComponent();
            HienThiDanhSachDichVu();
            maHD = mahd;
            btnAdd.Visible = false;
            btnDel.Visible = false;
        }
        void HienThiDanhSachDichVu()
        {
            dgvQuanLyDV.DataSource = dv_bll.HienThiDanhSachDichVu();
        }

        public delegate void HienThi_delegate();
        public HienThi_delegate On_HienThi;
        void XoaDichVu()
        {
            DataGridViewSelectedRowCollection tem = dgvQuanLyDV.SelectedRows;
            int ma;
            List<int> maList = new List<int>();
            foreach(DataGridViewRow r in tem)
            {
                ma = Convert.ToInt32( r.Cells[0].Value.ToString());
                maList.Add(ma);
            }
            dv_bll.XoaDichVu(maList);
            MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiDanhSachDichVu();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int macuoi = dv_bll.LayMaDichVuLonNhat();
            int mamoi = macuoi + 1;
            Form_ThemDichVu f = new Form_ThemDichVu(mamoi);
            f.On_HienThi += HienThiDanhSachDichVu;
            f.ShowDialog();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            XoaDichVu();
        }

        private void dgvQuanLyDV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ma;
            ma = Convert.ToInt32(dgvQuanLyDV.SelectedRows[0].Cells["madichvu"].Value);
            Form_ThongTinDichVu f = new Form_ThongTinDichVu(ma);
            f.On_HienThi += HienThiDanhSachDichVu;
            f.ShowDialog();
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            int madv;
            madv =Convert.ToInt32( dgvQuanLyDV.SelectedRows[0].Cells["madichvu"].Value);
            Form_ChonSoLuongDV f = new Form_ChonSoLuongDV(maHD, madv);
            f.ShowDialog();
            if (On_HienThi != null) On_HienThi();
            this.Close();

        }
    }
}
