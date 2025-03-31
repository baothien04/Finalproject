using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace finalproject
{
    public partial class trangchu : Form
    {
        public trangchu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Đăng xuất
            this.Close(); // Đóng Form trangchu
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mở lại Form Trang Chủ (có thể không cần thiết nếu đây là trang chủ)
            MessageBox.Show("Bạn đang ở trang chủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Mở Form Quản Lý Sản Phẩm
            sanpham sanpham = new sanpham();
            this.Hide(); // Ẩn Form trangchu
            sanpham.ShowDialog(); // Hiển thị Form Quản Lý Sản Phẩm như một hộp thoại
            this.Show(); // Hiển thị lại Form trangchu nếu Form Quản Lý Sản Phẩm đóng
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Mở Form Thông Tin Khách Hàng
            TTkhachhang TTkhachhang = new TTkhachhang();
            this.Hide(); // Ẩn Form trangchu
            TTkhachhang.ShowDialog(); // Hiển thị Form Thông Tin Khách Hàng như một hộp thoại
            this.Show(); // Hiển thị lại Form trangchu nếu Form Thông Tin Khách Hàng đóng
        }

        private void button2_Click_1(object sender, EventArgs e)
        {// Mở lại Form Trang Chủ (có thể không cần thiết nếu đây là trang chủ)
            MessageBox.Show("Bạn đang ở trang chủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form trangchu
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Mở Form Thông Tin Khách Hàng
            TTkhachhang TTkhachhang = new TTkhachhang();
            this.Hide(); // Ẩn Form trangchu
            TTkhachhang.ShowDialog(); // Hiển thị Form Thông Tin Khách Hàng như một hộp thoại
            this.Show(); // Hiển thị lại Form trangchu nếu Form Thông Tin Khách Hàng đóng
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            sanpham sanpham = new sanpham();
            this.Hide(); // Ẩn Form trangchu
            sanpham.ShowDialog(); // Hiển thị Form Quản Lý Sản Phẩm như một hộp thoại
            this.Show(); // Hiển thị lại Form trangchu nếu Form Quản Lý Sản Phẩm đóng
        }
    }
}
