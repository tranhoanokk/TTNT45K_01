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
    public partial class frmHangtonkho : Form
    {
        string sCon = "Data Source=DESKTOP-BTBDGRO\\SQLEXPRESS;Initial Catalog=CuaHangTapHoa;Integrated Security=True";
        public frmHangtonkho()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmHangtonkho_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
            }
            DataTable dt = new DataTable();
            string Sql = "select MaH, TenH from Hang";
            SqlCommand cmd = new SqlCommand(Sql, con);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);
                comboBox2.Items.Add(DR[1]);

            }
        }
        //liên kết giữa hai combobox 1 và 2. Khi chọn 1 giá trị ở combobox1 thì combobox2 tự hiển thị giá trị tương ứng 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = comboBox1.SelectedIndex;
        }
        //liên kết giữa hai combobox 1 và 2. Khi chọn 1 giá trị ở combobox2 thì combobox1 tự hiển thị giá trị tương ứng 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Khi ta nhấn nút thống kê thì datagidview sẽ hiển thị số lượng tồn kho của hàng hóa mà chúng ta đã chọn theo ngày
        private void btnThongke_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng", "Thông báo");
                return;
            }
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
                string vaoNgay = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                var sMahang = comboBox1.Text;
                string sQuery = "select Hang.MaH, Hang.TenH, SoLuongLon - TongSoLuongBan as HangTon from Hang inner join  (select MaH, sum(SoLuongBan) as TongSoLuongBan from HD_Ban_Chitiet full outer join HoaDonBan on HoaDonBan.MaHD = HD_Ban_Chitiet.MaHDB  where NgayBan <'" + vaoNgay + "'and MaH=" + sMahang + "group by MaH) HangDaBan on HangDaBan.MaH = Hang.MaH";

                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "HangTonKho");
                dataGridView1.DataSource = ds.Tables["HangTonKho"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
            }
            con.Close();
        }
        //Trả các combobox và datagridview về lại ban đầu
        private void btnThulai_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            
        }
    }
}
