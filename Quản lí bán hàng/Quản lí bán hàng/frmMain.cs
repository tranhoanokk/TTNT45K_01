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

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadon hoadon = new frmHoadon();
            hoadon.MdiParent = this;
            hoadon.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHanghoa hanghoa = new frmHanghoa();
            hanghoa.MdiParent = this;
            hanghoa.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoanhthu tkdoanhthu = new frmDoanhthu();
            tkdoanhthu.MdiParent = this;
            tkdoanhthu.Show();
        }

        private void hangtonkhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangtonkho tkhangtk = new frmHangtonkho();
            tkhangtk.MdiParent = this;
            tkhangtk.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
