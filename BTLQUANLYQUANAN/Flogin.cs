namespace BTLQUANLYQUANAN
{
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();

        }

        private void pic_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            ThongtinNV thongtinNV = new ThongtinNV();
            this.Close(); //đỡ lỗi
            thongtinNV.Show();
        }
    }
}
