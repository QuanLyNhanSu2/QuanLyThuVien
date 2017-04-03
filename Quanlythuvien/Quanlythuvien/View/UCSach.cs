using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien.View
{
    public partial class UCSach : UserControl
    {
        public UCSach()
        {
            InitializeComponent();
        }

        private void btnThemHinhanh_Click(object sender, EventArgs e)
        {

        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in grbTTNhanvien.Controls)
            {
                if (ctr is TextBox | ctr is RichTextBox)
                    ctr.Text = "";
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

        }

        private void btnLammoidanhsach_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
