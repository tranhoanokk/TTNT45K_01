using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (checkNumIsEmpty(txtSo1.Text) || checkNumIsEmpty(txtSo2.Text))
            {
                MessageBox.Show("Có một số chưa nhập, vui lòng nhập lại", "Thông báo");
                return;
            }
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ=dSo1+dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (checkNumIsEmpty(txtSo1.Text) || checkNumIsEmpty(txtSo2.Text))
            {
                MessageBox.Show("Có một số chưa nhập, vui lòng nhập lại", "Thông báo");
                return;
            }
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 - dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (checkNumIsEmpty(txtSo1.Text) || checkNumIsEmpty(txtSo2.Text))
            {
                MessageBox.Show("Có một số chưa nhập, vui lòng nhập lại", "Thông báo");
                return;
            }
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 * dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (checkNumIsEmpty(txtSo1.Text) || checkNumIsEmpty(txtSo2.Text))
            {
                MessageBox.Show("Có một số chưa nhập, vui lòng nhập lại", "Thông báo");
                return;
            }
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            if (dSo2 == 0)
            {
                MessageBox.Show("Vui lòng nhập số thứ hai khác 0", "Thông báo");
                return;
            }
            decimal dKQ = dSo1 / dSo2;
            txtKQ.Text = dKQ.ToString();
        }
            private bool checkNumIsEmpty(String str)
        {
            if (str == "")
            {

                return true;
            }
            return false;
        }

            private void button1_Click(object sender, EventArgs e)
            {
                txtSo1.Text = " ";
                txtSo2.Text = " ";
                txtKQ.Text = " ";

            }
    }
}
