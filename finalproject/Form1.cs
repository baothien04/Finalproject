using System;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        // Xử lý sự kiện Login
        private void Button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Kiểm tra thông tin đăng nhập (tài khoản cố định)
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2(username);
                this.Hide();  // Ẩn Form đăng nhập
                form2.ShowDialog();
                this.Show();  // Hiển thị lại Form1 khi Form2 đóng // Ẩn Form đăng nhập
                              //  MainForm mainForm = new MainForm();
                              //   mainForm.ShowDialog();
                this.Show();  // Hiển thị lại nếu người dùng thoát MainForm
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện hiển thị mật khẩu
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        // Xử lý sự kiện mở Form đăng ký (giả lập)
        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đăng ký chưa được triển khai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


