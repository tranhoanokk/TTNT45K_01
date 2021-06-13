using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            int n = int.Parse(a.Text);
            int h = int.Parse(b.Text);
            label1.Text = (n + h).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void minus_Click(object sender, EventArgs e)
        {
            int n = int.Parse(a.Text);
            int h = int.Parse(b.Text);
            label1.Text = (n - h).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            int n = int.Parse(a.Text);
            int h = int.Parse(b.Text);
            label1.Text = (n * h).ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            float n = float.Parse(a.Text);
            float h = float.Parse(b.Text);
            label1.Text = (n / h).ToString();
        }
    }
}
