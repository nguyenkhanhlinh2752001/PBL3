using QuanLyChungCu.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.View
{
    public partial class DetailDH : Form
    {
        public delegate void mydel();
        public mydel d { get; set; }
        public DetailDH(int MAHD)
        {
            InitializeComponent();
            SetGUI(MAHD);
            setcbb();
        }
        public void setcbb()
        {
            foreach (nhanvien i in BLL.BLL_NV.Instance().GetALLNhanVien())
            {
                if (i.machucvu != 3)
                {
                    cbbMaNHv.Items.Add(new CBBItem
                    {
                        Value = i.manhanvien,
                        Text = i.tennhanvien
                    });
                }
            }
            foreach (canho i in BLL.BLL_canho.Instance().GetALLCanHo())
            {
                cbbMaCanHo.Items.Add(i.macanho);
            }
            foreach(hogiadinh i in BLL.BLL_Hogiadinh.Instance().GetAllHogiadinh())
            {
                cbbHogiadinh.Items.Add(new CBBItem
                {
                    Text = i.tenchuho,
                    Value = i.maho
                });
            }

        }
        public void SetGUI(int MAHD)
        {
            if (MAHD != 0)
            {
                hopdong a = BLL.BLL_HD.Instance().GetHDdetail(MAHD);
                txtMaHD.Text = (a.mahopdong).ToString();
                txtMaHD.Enabled = false;
                txtTenHD.Text = a.tenhopdong.ToString();
                txtThoiHan.Text = a.thoihan.ToString();
                txtGiaTien.Text = a.giatien.ToString();
                txtThoiHan.Text = a.thoihan.ToString();
                dateTimePicker1.Value = a.ngayki;
               
            }
        }
        public bool Check()
        {
            double tien;

            if (txtMaHD.Enabled == false) //edit
            {
                if (double.TryParse(txtGiaTien.Text, out tien) && txtThoiHan.Text.All(char.IsDigit))
                {
                    return true;
                }
            }
            else // add
            {
                if (txtMaHD.Text.All(char.IsDigit) && BLL.BLL_HD.Instance().GetHDdetail(Convert.ToInt32(txtMaHD.Text)) == null)
                {
                    if (double.TryParse(txtGiaTien.Text, out tien) && txtThoiHan.Text.All(char.IsDigit))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                try
                {
                    hopdong a = new hopdong();
                    a.mahopdong = Convert.ToInt32(txtMaHD.Text);
                    a.manhanvien = ((CBBItem)cbbMaNHv.SelectedItem).Value;
                    a.macanho = Convert.ToInt32(cbbMaCanHo.SelectedItem);
                    a.maho = Convert.ToInt32(((CBBItem)cbbHogiadinh.SelectedItem).Value);
                    a.tenhopdong = txtTenHD.Text;
                    a.giatien = Convert.ToDouble(txtGiaTien.Text);
                    a.thoihan = txtThoiHan.Text;
                    a.ngayki = dateTimePicker1.Value;
                    a.dahuy = false;

                    BLL.BLL_HD.Instance().AddorUpdate(a);
                    d();
                    this.Close();
                }
                catch (Exception t)
                {

                }
            }
            else
            {
                MessageBox.Show("sai Format or trung MaHD ");
                this.Close();
            }
        }

        private void btEixt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
