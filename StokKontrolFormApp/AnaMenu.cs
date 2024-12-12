namespace StokKontrolFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
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
            AtolyeForm atolyeForm = new AtolyeForm();
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
            BarkodForm barkodForm = new BarkodForm();
            barkodForm.Show();
        }

        private void departman_Click(object sender, EventArgs e)
        {
            DepartmanForm departmanForm = new DepartmanForm();
            departmanForm.Show();
        }

        private void alis_Click(object sender, EventArgs e)
        {
            urunAlis_combo alisForm = new urunAlis_combo();
            alisForm.Show();
        }
    }
}
