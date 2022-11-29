using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class Login : Form
    {
        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        public Login()
        {
            InitializeComponent();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            taikhoan.TK = textBox1.Text;
            taikhoan.MK= textBox2.Text;
            string getuser = TKBLL.Checklogic(taikhoan);

            switch(getuser)
            {
                    case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                    case "requeid_password":
                    MessageBox.Show("Mật Khẩu không được để trống");
                    return;

                    case "Không chính xác!":
                    MessageBox.Show("Không chính xác!");
                    return;
            }
            MessageBox.Show("Đăng Nhập thành công");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
