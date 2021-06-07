using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Caculator
{
    public partial class FrmCaculator : Form
    {
        public static double x;
        public static double y;
        public static string pheptoan;
        public FrmCaculator()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            string b = a.Text;
            string now = textKQ.Text;
            textKQ.Text = now + b;


        }
        private void buttonCong_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textKQ.Text);
            pheptoan = "Cong";
            textKQ.Text = "";
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textKQ.Text);
            pheptoan = "Tru";
            textKQ.Text = "";
        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textKQ.Text);
            pheptoan = "Nhan";
            textKQ.Text = "";
        }

        private void buttonChia_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textKQ.Text);
            pheptoan = "Chia";
            textKQ.Text = "";
        }

        private void buttonBang_Click(object sender, EventArgs e)
        {
            double result = 0;
            y = Convert.ToDouble(textKQ.Text);
            if (pheptoan == "Cong")
            {
                result = x + y;
            }
            if (pheptoan == "Tru")
            {
                result = x - y;
            }
            if (pheptoan == "Nhan")
            {
                result = x * y; 
            }
            if (pheptoan == "Chia")
            {
                result = x / y;
                if (y == 0)
                { MessageBox.Show("Nhap so bi chia khac 0", "Thong bao"); }
            }
            string s = result.ToString();
            textKQ.Text = s;

        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            string k = textKQ.Text; 
            if ( k.Length < 1 )
            {
                textKQ.Text = "" ; 
            }
            else
            {
                k = k.Substring(0, k.Length - 1);
                textKQ.Text = k; 
            }
        }

        private void buttonXoaHet_Click(object sender, EventArgs e)
        {   x = 0 ;
            y = 0;
            pheptoan = "";
            textKQ.Text = "";
        }
    }
}
