using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quản_lí_bán_hàng
{
    public partial class frmDoanhthu : Form
    {
        string sCon = "Data Source=DESKTOP-BTBDGRO\\SQLEXPRESS;Initial Catalog=CuaHangTapHoa;Integrated Security=True";
        public frmDoanhthu()
        {
            InitializeComponent();
        }

        private void frmDoanhthu_Load(object sender, EventArgs e)
        {
         
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
                string tuNgay = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string denNgay = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string sQuery = "select NgayBan,count(MaHD) as SoHD,sum(TongTien) as TongTien from HoaDonBan where NgayBan between '" + tuNgay + "' and '" + denNgay + "' group by NgayBan order by NgayBan desc";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "DoanhThu");
                dataGridView1.DataSource = ds.Tables["DoanhThu"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
            }
           
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
                //hien thi hoa don chi tiet  theo ngay
                string ngay = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["NgayBan"].Value.ToString()).ToString("yyyy-MM-dd");
                string sQuery = "select MaHDB,NgayBan,GioBan, SUM(ThanhTien) as ThanhTien from HD_Ban_Chitiet full outer join HoaDonBan on HoaDonBan.MaHD = HD_Ban_Chitiet.MaHDB where NgayBan='"+ngay+"' group by MaHDB, NgayBan, GioBan";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "DoanhThuChiTiet");
                dataGridView2.DataSource = ds.Tables["DoanhThuChiTiet"];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
            }
            con.Close();
            
        }

        private void btnThulai_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
    }
}
