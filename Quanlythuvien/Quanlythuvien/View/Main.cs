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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        UCMainmenu mn = new UCMainmenu();
        private void Main_Load(object sender, EventArgs e)
        {
            mn.Dock = DockStyle.Fill;
            mn.btnSach = this.btnSach;
            mn.btnDocgia = this.btnDocgia;
            mn.btnMuonTra = this.btnMuonTra;
            mn.btnHuongdan = this.btnHuongdan;
            mn.lblDocgia = this.lblDocgia;
            mn.lblDuongdan = this.lblHuongdan;
            mn.lblMenu = this.lblMenu;
            mn.lblMuonTra = this.lblMuonTra;
            mn.lblSach = this.lblSach;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            UCSach ucsach = new UCSach();
            ucsach.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucsach);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(mn);
        }

        private void btnDocgia_Click(object sender, EventArgs e)
        {
            UCDocgia ucdocgia = new UCDocgia();
            ucdocgia.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucdocgia);
        }
    }
}
