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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Gán sự kiện cho checkbox và button
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
        }

        // Sự kiện checkbox để hiển thị/ẩn mật khẩu
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        // Xử lý đăng nhập
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Kiểm tra tài khoản (giả lập)
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Mở Form2 sau khi đăng nhập thành công
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide(); // Ẩn Form1
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý khi bấm nút REGISTER
        private void button2_Click(object sender, EventArgs e)
        {
            FormRegister registerForm = new FormRegister();
            registerForm.Show();
            this.Hide();
        }
    }
}
