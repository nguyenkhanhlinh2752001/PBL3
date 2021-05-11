using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyChungCu.BLL;

namespace QuanLyChungCu.View
{
    public partial class Form_ThongTinDichVu : Form
    {
        BLL_DichVu dv_bll = new BLL_DichVu();
        public delegate void HienThi_delegate();
        int maDV;
        public HienThi_delegate On_HienThi;
        public Form_ThongTinDichVu(int madv)
        {
            InitializeComponent();
            maDV = madv;
            GUI();
        }
        public void GUI()
        {
            dichvu dv = dv_bll.LayThongTin1DichVu(maDV);
            txtMaDV.Text = dv.madichvu.ToString();
            txtTenDV.Text = dv.tendichvu;
            txtGia.Text = dv.gia.ToString();
        }

        public int SuaDichVu()
        {
            dichvu dv = new dichvu
            {
                madichvu = Convert.ToInt32( txtMaDV.Text),
                tendichvu = txtTenDV.Text,
                gia = Convert.ToDouble(txtGia.Text),

            };
            dv_bll.SuaDichVu(dv);
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
        }

        public int XoaDichVu()
        {
            DialogResult kq = MessageBox.Show("Xóa dịch vụ sẽ xóa mọi hóa đơn liên quan đến dịch vụ này, "+ "Bạn có muốn xóa không?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (kq == DialogResult.No)
            {
                return 0;
            }
            List<int> maList = new List<int>();
            maList.Add(maDV);
            dv_bll.XoaDichVu(maList);
            MessageBox.Show("Xóa dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenDV.Text=="" || txtGia.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
                return;
            }
            if (SuaDichVu() == 1)
            {
                this.Close();
                if (On_HienThi != null) On_HienThi();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XoaDichVu() == 1)
            {
                this.Close();
                if (On_HienThi != null) On_HienThi();
            }
        }



    }
}
