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
    public partial class UCMainmenu : UserControl
    {
        public Label lblMenu { get; set; }
        public Label lblSach { get; set; }
        public Label lblDocgia { get; set; }
        public Label lblMuonTra { get; set; }
        public Label lblDuongdan { get; set; }
        public Button btnSach { get; set; }
        public Button btnDocgia { get; set; }
        public Button btnMuonTra { get; set; }
        public Button btnHuongdan { get; set; }
        public UCMainmenu()
        {
            InitializeComponent();
        }

        private void UCMainmenu_Load(object sender, EventArgs e)
        {
            this.Controls.Add(lblMenu);
            this.Controls.Add(lblSach);
            this.Controls.Add(lblDocgia);
            this.Controls.Add(lblMuonTra);
            this.Controls.Add(lblDuongdan);


            this.Controls.Add(btnSach);
            this.Controls.Add(btnDocgia);
            this.Controls.Add(btnMuonTra);
            this.Controls.Add(btnHuongdan);
        }
    }
}
