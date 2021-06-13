using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lí_bán_hàng
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ThemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemhoadon ThemHD= new frmThemhoadon();
            ThemHD.MdiParent = this;
            ThemHD.Show();
        }

        private void ThemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmThemhanghoa ThemHH= new frmThemhanghoa();
            ThemHH.MdiParent = this;
            ThemHH.Show();
        }

        private void TimKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimkiemHH Timkiem = new frmTimkiemHH();
            Timkiem.MdiParent = this;
            Timkiem.Show();
        }

        private void SuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuahoadon SuaHD = new frmSuahoadon();
            SuaHD.MdiParent = this;
            SuaHD.Show();
        }

        private void XoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXoahoadon XoaHD = new frmXoahoadon();
            XoaHD.MdiParent = this;
            XoaHD.Show();
        }

        private void SuaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSuaHanghoa SuaHH = new frmSuaHanghoa();
            SuaHH.MdiParent = this;
            SuaHH.Show();
        }

        private void XoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmXoahanghoa XoaHH = new frmXoahanghoa();
            XoaHH.MdiParent = this;
            XoaHH.Show();
        }
    }
}
