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
    public partial class Form_QuanLy : Form
    {
        public Form_QuanLy()
        {
            InitializeComponent();
        }
        #region Function
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach(Form i in this.MdiChildren)
            {
                if(i.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form i in this.MdiChildren)
            {
                if (i.Name == name)
                {
                    i.Activate();
                    break;
                }
            }
        }
        #endregion
        #region Event
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            panel1.Width = (panel1.Width == 375) ? 50 : 375;
            panel5.Width = (panel5.Width == 0) ? 325 : 0;
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ChoThue_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Form_ChoThue"))
            {
                Form_ChoThue f = new Form_ChoThue();
                f.MdiParent = this;
                f.Width = 1156;
                f.Height = 802;
                f.Show();
            }
            else ActiveChildForm("Form_ChoThue");
        }
        #endregion
    }
}
