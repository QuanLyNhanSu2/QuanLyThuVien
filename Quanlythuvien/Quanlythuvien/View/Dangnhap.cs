using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien.View
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtTaikhoan.Clear();
            txtMatkhau.Clear();
        }
        private bool Login(string user, string pass)
        {
            return user.Equals("a") && pass.Equals("a");
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (Login(txtTaikhoan.Text, txtMatkhau.Text))
            {
                Main m = new Main();
                m.FormClosed += M_FormClosed;
                m.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                m.Show();
                Reset();
            }
            else
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng");
        }

        private void M_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtMatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Login(txtTaikhoan.Text, txtMatkhau.Text))
                {
                    Main m = new Main();
                    m.FormClosed += M_FormClosed;
                    m.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    m.Show();
                    Reset();
                }
                else
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng");
            }
        }

        private void txtTaikhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Login(txtTaikhoan.Text, txtMatkhau.Text))
                {
                    Main m = new Main();
                    m.FormClosed += M_FormClosed;
                    m.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    m.Show();
                    Reset();
                }
                else
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng");
            }
        }

        private void Dangnhap_Load_1(object sender, EventArgs e)
        {
            txtTaikhoan.Text = "a";
            txtMatkhau.Text = "a";
        }
    }
}
