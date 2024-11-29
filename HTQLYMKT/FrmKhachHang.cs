using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQLYMKT
{
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void xemThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTTCN rTTCN = new RTTCN();
            rTTCN.MdiParent = this;
            rTTCN.Show();
        }

        private void sửaThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTTCN sTTCN = new RTTCN();
            sTTCN.MdiParent = this;
            sTTCN.Show();
        }

        private void xóaThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTTCN xTTCN = new RTTCN();
            xTTCN.MdiParent = this;
            xTTCN.Show();
        }

        private void xemTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTTCN xTTTK = new RTTCN();
            xTTTK.MdiParent = this;
            xTTTK.Show();
        }

        private void xemDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTTCN xTTDV = new RTTCN();
            xTTDV.MdiParent = this;
            xTTDV.Show();
        }

        private void xemHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTTCN xTTHD = new RTTCN();
            xTTHD.MdiParent = this;
            xTTHD.Show();
        }
    }
}
