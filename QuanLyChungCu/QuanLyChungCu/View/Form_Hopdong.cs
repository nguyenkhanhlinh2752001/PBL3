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
using QuanLyChungCu.BLL;

namespace QuanLyChungCu.View
{
    public partial class Form_Hopdong : Form
    {
        public Form_Hopdong()
        {
            InitializeComponent();
        }
        public void ShowAllHDViews()
        {
            dataGridView1.DataSource = BLL_HD.Instance().GetALLHDViews();
        }
        private void BtsearchNameID_Click(object sender, EventArgs e)
        {
            if (TXTsearch.TextLength == 0)
            {
                ShowAllHDViews();
            }
            else
            {
                if (TXTsearch.Text.All(char.IsDigit))
                {
                    int value = Convert.ToInt32(TXTsearch.Text);
                    dataGridView1.DataSource = BLL_HD.Instance().GetHDbyIDViews(value);
                }
                else
                {
                    string name = TXTsearch.Text;
                    dataGridView1.DataSource = BLL_HD.Instance().GetHDByNameViews(name);
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DetailDH a = new DetailDH(0);
            a.d += new DetailDH.mydel(ShowAllHDViews);
            a.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int IDHD = (int)dataGridView1.SelectedRows[0].Cells["mahopdong"].Value;
                DetailDH a = new DetailDH(IDHD);
                a.d += new DetailDH.mydel(ShowAllHDViews);
                a.Show();
            }
        }

        private void btSearchdate_Click(object sender, EventArgs e)
        {   
            foreach (hopdong i in BLL_HD.Instance().GetAllHD())
            {
                if ((dateTimePickerNgayKi.Value.Month.Equals(i.ngayki.Month) && dateTimePickerNgayKi.Value.Year.Equals(i.ngayki.Year)))  
                    //dateTimePickerNgayHetHan.Value.Month.Equals(i.ngayki.Month + Convert.ToDateTime(i.thoihan).Month))
                {           
                        cbboxHD.Items.Add(new CBBItem
                        {
                            Value = i.mahopdong,
                            Text = i.tenhopdong,
                        });
                    
                }
                
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    int MAHD = Convert.ToInt32(i.Cells["mahopdong"].Value);
                    BLL_HD.Instance().Delete(MAHD);
                }
                ShowAllHDViews();
            }
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            if(cbbProperties.SelectedItem!=null)
            {
                dataGridView1.DataSource = BLL_HD.Instance().Sort(cbbProperties.Text);
            }
        }

        private void cbboxHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbboxHD.Items.Clear();
        }

        public Boolean check1()
        {
            if(txtMAHO.Text.All(char.IsDigit) && BLL_Hogiadinh.Instance().GetHoGiaDinhByid(Convert.ToInt32(txtMAHO.Text))==null)
            {
                return true;
            }
            return false;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            if(txtMAHO.TextLength>0 && txtNamechuho.TextLength>0 && cbbthanhvien.SelectedIndex>=0)
            {
                if(check1()==true)
                {
                    hogiadinh a = new hogiadinh();
                    a.maho = Convert.ToInt32(txtMAHO.Text);
                    a.tenchuho = txtNamechuho.Text.ToString();
                    a.sothanhvien = Convert.ToInt32(cbbthanhvien.SelectedItem);
                    BLL_Hogiadinh.Instance().ADD(a);
                    MessageBox.Show("dang ki thanh cong");
                    btEdit_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Ma so gia dinh bi trung");
                    var l1 = BLL_Hogiadinh.Instance().GetAllHogiadinh();
                    string dem = "ma so : ";
                    foreach(hogiadinh i in l1)
                    {
                        dem +=" " + i.maho;
                    }
                    MessageBox.Show("khong duoc trung cac  " +dem);
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            txtMAHO.Clear();
            txtNamechuho.Clear();
            cbbthanhvien.SelectedIndex = -1;
        }
    }
    
}
