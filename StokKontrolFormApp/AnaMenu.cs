namespace StokKontrolFormApp
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void urun_Click(object sender, EventArgs e)
        {
            UrunForm urunForm = new UrunForm();
            urunForm.Show();
        }

        private void atolye_Click(object sender, EventArgs e)
        {
            TedarikciForm atolyeForm = new TedarikciForm();
            atolyeForm.Show();
        }

        private void satis_Click(object sender, EventArgs e)
        {
            SatisForm satisForm = new SatisForm();
            satisForm.Show();
        }

        private void calisan_Click(object sender, EventArgs e)
        {
            CalisanForm calisanForm = new CalisanForm();
            calisanForm.Show();
        }

        private void barkod_Click(object sender, EventArgs e)
        {
            UrunOzellikleriForm barkodForm = new UrunOzellikleriForm();
            barkodForm.Show();
        }

        private void departman_Click(object sender, EventArgs e)
        {
            DepartmanForm departmanForm = new DepartmanForm();
            departmanForm.Show();
        }

        private void alis_Click(object sender, EventArgs e)
        {
            AlisForm alisForm = new AlisForm();
            alisForm.Show();
        }
    }
}
