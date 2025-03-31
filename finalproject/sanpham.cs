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
    public partial class sanpham : Form
    {
        public sanpham()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Đăng xuất
            this.Close(); // Đóng Form sanpham
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mở lại Form Trang Chủ
            trangchu formTrangChu = new trangchu();
            this.Hide(); // Ẩn Form sanpham
            formTrangChu.ShowDialog(); // Hiển thị Form Trang Chủ như một hộp thoại
            this.Show(); // Hiển thị lại Form sanpham nếu Form Trang Chủ đóng
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Có thể thêm logic cho nút PRODUCT nếu cần
            MessageBox.Show("Bạn đang ở trang sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Mở Form Thông Tin Khách Hàng
            TTkhachhang TTkhachhang = new TTkhachhang();
            this.Hide(); // Ẩn Form trangchu
            TTkhachhang.ShowDialog(); // Hiển thị Form Thông Tin Khách Hàng như một hộp thoại
            this.Show(); // Hiển thị lại Form trangchu nếu Form Thông Tin Khách Hàng đóng
        }
    }
}
