using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace finalproject
{
    public partial class TTkhachhang : Form
    {
        public TTkhachhang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mở lại Form Trang Chủ
            trangchu trangchu = new trangchu();
            this.Hide(); // Ẩn Form TTkhachhang
            trangchu.ShowDialog(); // Hiển thị Form Trang Chủ như một hộp thoại
            this.Show(); // Hiển thị lại Form TTkhachhang nếu Form Trang Chủ đóng
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Mở Form Thông Tin Khách Hàng (nếu có form này)
            // Có thể thêm logic để hiển thị thông tin chi tiết của khách hàng
            MessageBox.Show("Thông tin khách hàng sẽ được hiển thị ở đây.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Mở Form Quản Lý Sản Phẩm
            sanpham sanpham = new sanpham();
            this.Hide(); // Ẩn Form TTkhachhang
            sanpham.ShowDialog(); // Hiển thị Form Quản Lý Sản Phẩm như một hộp thoại
            this.Show(); // Hiển thị lại Form TTkhachhang nếu Form Quản Lý Sản Phẩm đóng
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Đăng xuất
            this.Close(); // Đóng Form TTkhachhang
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
