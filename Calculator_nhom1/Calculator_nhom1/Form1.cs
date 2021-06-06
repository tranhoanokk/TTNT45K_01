using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_nhom1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (checkNumIsEmpty(so1.Text) || checkNumIsEmpty(so2.Text))
            {
                MessageBox.Show("Co mot so chua nhap, vui long nhap lai");
                return;
            }

            double s1 = double.Parse(so1.Text);
            double s2 = double.Parse(so2.Text);
            ketqua.Text = (s1 + s2).ToString();
        }

        private void so1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // chỉ cho phép nhập kí tự số
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void so2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (checkNumIsEmpty(so1.Text) || checkNumIsEmpty(so2.Text))
            {
                MessageBox.Show("Co mot so chua nhap, vui long nhap lai");
                return;
            }

            double s1 = double.Parse(so1.Text);
            double s2 = double.Parse(so2.Text);
            ketqua.Text = (s1 - s2).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (checkNumIsEmpty(so1.Text) || checkNumIsEmpty(so2.Text))
            {
                MessageBox.Show("Co mot so chua nhap, vui long nhap lai");
                return;
            }

            double s1 = double.Parse(so1.Text);
            double s2 = double.Parse(so2.Text);
            ketqua.Text = (s1 * s2).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (checkNumIsEmpty(so1.Text) || checkNumIsEmpty(so2.Text))
            {
                MessageBox.Show("Co mot so chua nhap, vui long nhap lai");
                return;
            }

            double s1 = double.Parse(so1.Text);
            double s2 = double.Parse(so2.Text);

            if (s2 == 0)
            {
                MessageBox.Show("Nhap so thu hai khac 0");
                return;
            }

            ketqua.Text = (s1 / s2).ToString();
        }
        private bool checkNumIsEmpty(String str)
        {
            if (str == "")
            {

                return true;
            }
            return false;
        }
    }
}
