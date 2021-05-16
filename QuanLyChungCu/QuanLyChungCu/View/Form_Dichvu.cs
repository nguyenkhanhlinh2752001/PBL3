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
    public partial class Form_Dichvu : Form
    {
        BLL_HoaDonDichVu hd_bll = new BLL_HoaDonDichVu();
        public Form_Dichvu()
        {
            InitializeComponent();
            HienThiDanhSachHoaDon();
            LoadCbxThoiGian();
            LoadCbxTimKiem();
        }

        public void HienThiDanhSachHoaDon()
        {
            dgvHoaDonDV.DataSource = hd_bll.HienThiDanhSachHoaDon();
            lbTongSoDon.Text = hd_bll.TongSoHoaDon().ToString();
            DoanhThu();
        }

        private void DoanhThu()
        {
            int sum = 0;
            for (int i = 0; i < dgvHoaDonDV.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvHoaDonDV["tongtien", i].Value);
            }
            lbTien.Text = sum.ToString("0,00.##");
        }

        public void LoadCbxThoiGian()
        {
            cbxThoiGian.Items.AddRange(new string[] { "Toàn bộ", "Ngày", "Từ ngày đến ngày" });
            cbxThoiGian.SelectedIndex = 0;
        }

        public void LoadCbxTimKiem()
        {
            cbxTimKiem.Items.AddRange(new string[] {"None","Mã hóa đơn", "Mã căn hộ", "Tên nhân viên", "Thanh Toán" });
            cbxTimKiem.SelectedIndex = 0;
        }
        void TimKiem()
        {
            if(cbxThoiGian.SelectedIndex==-1 || cbxThoiGian.SelectedIndex == 0)
            {
                lbTu.Visible = false;
                lbDen.Visible = false;
                dtpTu.Visible = false;
                dtpDen.Visible = false;
 
                lbVao.Visible = false;
                dtpVao.Visible = false;               
            }
            else if (cbxThoiGian.SelectedIndex == 1)
            {
                lbTu.Visible = false;
                lbDen.Visible = false;
                dtpTu.Visible = false;
                dtpDen.Visible = false;

                lbVao.Visible = true;
                dtpVao.Visible = true;

            }
            else if (cbxThoiGian.SelectedIndex == 2)
            {
                lbTu.Visible = true;
                lbDen.Visible = true;
                dtpTu.Visible = true;
                dtpDen.Visible = true;

                lbVao.Visible = false;
                dtpVao.Visible = false;
            }
        }
        private void cbxTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }


        private void dgvHoaDonDV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int mahd=int.Parse(dgvHoaDonDV.SelectedRows[0].Cells["mahoadon"].Value.ToString());
            int mach = Convert.ToInt32(hd_bll.LayMaCanHoTuMaHoaDon(mahd).ToString());
            int manv= Convert.ToInt32(hd_bll.LayMaNhanVienTuMaHoaDon(mahd).ToString());

            Form_ChiTietHoaDonDV f = new Form_ChiTietHoaDonDV(mahd, mach, manv);
            f.Show();
            this.Show();
        }

        private void btnThemHDDV_Click(object sender, EventArgs e)
        {
            int macuoi = hd_bll.LayMaHDLonNhat();
            int mamoi = macuoi + 1;
            Form_ThemHoaDonDV f = new Form_ThemHoaDonDV(mamoi);
            f.On_HienThi += HienThiDanhSachHoaDon;
            f.ShowDialog();
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                btnTimKiem.Enabled = false;
            }
            else btnTimKiem.Enabled = true;           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int choice = cbxTimKiem.SelectedIndex;            
            if (choice == 0)
            {
                if (cbxThoiGian.SelectedIndex == 0)
                {
                    HienThiDanhSachHoaDon();
                    txtTimKiem.Clear();
                }                   
                else if (cbxThoiGian.SelectedIndex == 1)
                    dgvHoaDonDV.DataSource = hd_bll.DanhSachHoaDonVaoNgay(dtpVao.Value.Date);
                else
                    dgvHoaDonDV.DataSource = hd_bll.DanhSachHoaDonNgayDenNgay(dtpTu.Value.Date, dtpDen.Value.Date);
                txtTimKiem.Enabled = false;
            }
            else if (choice == 1)
            {
                dgvHoaDonDV.DataSource = hd_bll.HoaDonTheoMaHD(Convert.ToInt32(txtTimKiem.Text));
            }
            else if (choice == 2)
            {
                if (cbxThoiGian.SelectedIndex == 0)
                    dgvHoaDonDV.DataSource = hd_bll.DanhSachHoaDonTheoMaCH(Convert.ToInt32(txtTimKiem.Text));
                else if (cbxThoiGian.SelectedIndex == 1)
                    dgvHoaDonDV.DataSource = hd_bll.DanhSachHoaDonTheoMaCHVaoNgay(dtpVao.Value.Date, Convert.ToInt32(txtTimKiem.Text));
                else
                    dgvHoaDonDV.DataSource = hd_bll.DanhSachHoaDonTheoMaCHNgayDenNgay(dtpTu.Value.Date, dtpDen.Value.Date, Convert.ToInt32(txtTimKiem.Text));
            }
            else if (choice == 3)
            {
                if (cbxThoiGian.SelectedIndex == 0)
                    dgvHoaDonDV.DataSource = hd_bll.DanhSachHoaDonTheoTenNV(txtTimKiem.Text);
                else if (cbxThoiGian.SelectedIndex == 1)
                    dgvHoaDonDV.DataSource = hd_bll.DanhSachHoaDonTheoTenNVVaoNgay(dtpVao.Value.Date,txtTimKiem.Text);
                else
                    dgvHoaDonDV.DataSource = hd_bll.DanhSachHoaDonTheoTenNVNgayDenNgay(dtpTu.Value.Date, dtpDen.Value.Date, txtTimKiem.Text);               
            }
            else if (choice == 4)
            {
                if (cbxThoiGian.SelectedIndex == 0)
                    dgvHoaDonDV.DataSource = hd_bll.DanhSachHoaDonTheoThanhToan(rdRoi.Checked? true:false);
                else if (cbxThoiGian.SelectedIndex == 1)
                    dgvHoaDonDV.DataSource = hd_bll.DanhSachHoaDonTheoThanhToanVaoNgay(dtpVao.Value.Date, rdRoi.Checked ? true : false);
                else
                    dgvHoaDonDV.DataSource = hd_bll.DanhSachHoaDonTheoThanhToanNgayDenNgay(dtpTu.Value.Date, dtpDen.Value.Date, rdRoi.Checked ? true : false);
            }
            DoanhThu();
            
        }
        private void cbxTimKiem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxTimKiem.SelectedIndex == 0)
            {
                    txtTimKiem.Enabled = false;
                    txtTimKiem.Visible = true;
                    rdChua.Visible = false;
                    rdRoi.Visible = false;
                    txtTimKiem.Clear();
                    cbxThoiGian.Enabled = true;
                    btnTimKiem.Enabled = true;              
            }
            else if (cbxTimKiem.SelectedIndex == 1)
            {
                txtTimKiem.Enabled = true;
                cbxThoiGian.Enabled = false;
                cbxThoiGian.SelectedIndex = 0;
                if (txtTimKiem.Text == "")
                {
                    btnTimKiem.Enabled = false;
                }
                else
                {                   
                    btnTimKiem.Enabled = true;                   
                }               
            }
            else if (cbxTimKiem.SelectedIndex == 4)
            {
                btnTimKiem.Enabled = true;
                txtTimKiem.Visible = false;
                rdChua.Visible = true;
                rdRoi.Visible = true;
                cbxThoiGian.Enabled = true;
            }
            else
            {
                if (txtTimKiem.Text == "")
                {
                    btnTimKiem.Enabled = false;
                }
                else
                {
                    btnTimKiem.Enabled = true;
                }
                txtTimKiem.Enabled = true;
                txtTimKiem.Visible = true;
                rdChua.Visible = false;
                rdRoi.Visible = false;
                cbxThoiGian.Enabled = true;
                txtTimKiem.Clear();
            }
        }

        private void dgvHoaDonDV_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int numRows = dgvHoaDonDV.Rows.Count;
            lbTongSoDon.Text = numRows.ToString();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            HienThiDanhSachHoaDon();
            cbxThoiGian.SelectedIndex = 0;
            cbxTimKiem.SelectedIndex = 0;
            txtTimKiem.Clear();
            btnTimKiem.Enabled = true;
        }

        void KeyPressOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Không cho nhập kí tự khác số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            int choice = cbxTimKiem.SelectedIndex;
            if (choice == 1 || choice == 2)
            {
                KeyPressOnlyNumber(sender, e);
            }
        }

        
    }
}
