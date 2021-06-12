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
            frmHoaDon HoaDon= new frmHoaDon();
            HoaDon.MdiParent=this;
            HoaDon.Show();
        }

        private void ThemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHang Hang= new frmHang();
            Hang.MdiParent=this;
            Hang.Show();
        }

        private void TimKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimkiemHH Timkiem = new frmTimkiemHH();
            Timkiem.MdiParent = this;
            Timkiem.Show();
        }
    }
}
