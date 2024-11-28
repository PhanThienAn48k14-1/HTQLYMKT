namespace HTQLYMKT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tạoThêmThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CQLKH cQLKH = new CQLKH();
            cQLKH.MdiParent = this;
            cQLKH.Show();
        }

        private void xemThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RQLKH rQLKH = new RQLKH();
            rQLKH.MdiParent = this;
            rQLKH.Show();
        }

        private void sửaThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UQLKH uQLKH = new UQLKH();
            uQLKH.MdiParent = this;
            uQLKH.Show();
        }

        private void xóaThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DQLKH dQLKH = new DQLKH();
            dQLKH.MdiParent = this;
            dQLKH.Show();
        }

        private void tạoThêmThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CQLNV cQLNV = new CQLNV();
            cQLNV.MdiParent = this;
            cQLNV.Show();
        }

        private void xemThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RQLNV rQLNV = new RQLNV();
            rQLNV.MdiParent = this;
            rQLNV.Show();
        }

        private void sửaThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UQLNV uQLNV = new UQLNV();
            uQLNV.MdiParent = this;
            uQLNV.Show();
        }

        private void xóaThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DQLNV dQLNV = new DQLNV();
            dQLNV.MdiParent = this;
            dQLNV.Show();
        }

        private void tạoThêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CQLTK cQLTK = new CQLTK();
            cQLTK.MdiParent = this;
            cQLTK.Show();
        }

        private void xemThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RQLTK rqLTK = new RQLTK();
            rqLTK.MdiParent = this;
            rqLTK.Show();
        }

        private void sửaThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UQLTK uQLTK = new UQLTK();
            uQLTK.MdiParent = this;
            uQLTK.Show();
        }

        private void xóaThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DQLTK dQLTK = new DQLTK();
            dQLTK.MdiParent = this;
            dQLTK.Show();
        }

        private void tạoHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CQLHD cQLHD = new CQLHD();
            cQLHD.MdiParent = this;
            cQLHD.Show();
        }

        private void xemHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RQLHD rQLHD = new RQLHD();
            rQLHD.MdiParent = this;
            rQLHD.Show();
        }

        private void sửaHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UQLHD uQLHD = new UQLHD();
            uQLHD.MdiParent = this;
            uQLHD.Show();
        }

        private void xóaHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DQLHD dQLHD = new DQLHD();
            dQLHD.MdiParent = this;
            dQLHD.Show();
        }

        private void tạoThêmDịchVụMarketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CQLDV cQLDV = new CQLDV();
            cQLDV.MdiParent = this;
            cQLDV.Show();
        }

        private void xemThôngTinDịchVụMarketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RQLDV rQLDV = new RQLDV();
            rQLDV.MdiParent = this;
            rQLDV.Show();
        }

        private void sửaThôngTinDịchVụMarketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UQLDV uQLDV = new UQLDV();
            uQLDV.MdiParent = this;
            uQLDV.Show();
        }

        private void xóaThôngTinDịchVụMarketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DQLDV dQLDV = new DQLDV();
            dQLDV.MdiParent = this;
            dQLDV.Show();
        }
    }
}
