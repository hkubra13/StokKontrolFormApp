using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokKontrolFormApp
{
    public partial class UrunForm : Form
    {
        UrunDAO urunDAO = new UrunDAO();
        DepartmanDAO departmanDAO = new DepartmanDAO();

        public UrunForm()
        {
            InitializeComponent();
        }

        private void urunGoster_btn_Click(object sender, EventArgs e)
        {
            BindingSource urunBindingSource = new BindingSource();
            urunBindingSource.DataSource = urunDAO.TumUrunler();
            urunDataGrid.DataSource = urunBindingSource;
            urunDataGrid.Columns["departmanId"].Visible = false;
        }

        private void urunAra_btn_Click(object sender, EventArgs e)
        {
            BindingSource urunBindingSource = new BindingSource();
            urunBindingSource.DataSource = urunDAO.UrunArama(urunAra_txt.Text);
            urunDataGrid.DataSource = urunBindingSource;
            urunDataGrid.Columns["departmanId"].Visible = false;
        }

        private void urunEkle_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(urunKod_txt.Text)
                || string.IsNullOrEmpty(urunAd_txt.Text)
                || string.IsNullOrEmpty(seriNo_txt.Text)
                || string.IsNullOrEmpty(urunStok_txt.Text))
            {
                MessageBox.Show("Lütfen tüm kutuları doldurunuz.");
                return;
            }

            Urun urun = new Urun()
            {
                urunId = Convert.ToInt32(urunKod_txt.Text),
                urunAd = urunAd_txt.Text,
                departmanId = Convert.ToInt32(departmanUrun_combo.SelectedValue),
                seriId = seriNo_txt.Text,
                urunStok = Convert.ToInt32(urunStok_txt.Text)
            };

            int sonuc = urunDAO.UrunEkle(urun);
            MessageBox.Show(sonuc + " yeni ürün eklendi.");
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            List<Departman> departmanlar = departmanDAO.TumDepartmanlar();
            departmanUrun_combo.DataSource = departmanlar;
            departmanUrun_combo.DisplayMember = "departmanAd";
            departmanUrun_combo.ValueMember = "departmanId";

            BindingSource urunBindingSource = new BindingSource();
            urunBindingSource.DataSource = urunDAO.TumUrunler();
            urunDataGrid.DataSource = urunBindingSource;
            urunDataGrid.Columns["departmanId"].Visible = false;
        }

        private void urunGuncelle_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(urunKod_txt.Text)
                || string.IsNullOrEmpty(urunAd_txt.Text)
                || string.IsNullOrEmpty(seriNo_txt.Text)
                || string.IsNullOrEmpty(urunStok_txt.Text))
            {
                MessageBox.Show("Lütfen tüm kutuları doldurunuz.");
                return;
            }

            Urun urun = new Urun()
            {
                urunId = Convert.ToInt32(urunKod_txt.Text),
                urunAd = urunAd_txt.Text,
                departmanId = Convert.ToInt32(departmanUrun_combo.SelectedValue),
                seriId = seriNo_txt.Text,
                urunStok = Convert.ToInt32(urunStok_txt.Text)
            };

            int sonuc = urunDAO.UrunGuncelle(urun);
            MessageBox.Show(sonuc + " ürün güncellendi.");
        }

        private void urunDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int seciliSatir = urunDataGrid.CurrentRow.Index;
            urunKod_txt.Text = urunDataGrid.Rows[seciliSatir].Cells[0].Value.ToString();
            urunAd_txt.Text = urunDataGrid.Rows[seciliSatir].Cells[1].Value.ToString();
            departmanUrun_combo.SelectedValue = urunDataGrid.Rows[seciliSatir].Cells[5].Value;
            seriNo_txt.Text = urunDataGrid.Rows[seciliSatir].Cells[4].Value.ToString();
            urunStok_txt.Text = urunDataGrid.Rows[seciliSatir].Cells[2].Value.ToString();
        }

        private void urunSil_btn_Click(object sender, EventArgs e)
        {
            if (urunDataGrid.SelectedRows.Count == 1)
            {
                int seciliSatir = urunDataGrid.CurrentRow.Index;
                int urunId = (int)urunDataGrid.Rows[seciliSatir].Cells[0].Value;
                int sonuc = urunDAO.UrunSil(urunId);
                MessageBox.Show(sonuc + " ürün silindi.");
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz.");
            }
        }

        private void Temizle()
        {
            urunKod_txt.Clear();
            urunAd_txt.Clear();
            departmanUrun_combo.SelectedIndex = -1;
            seriNo_txt.Clear();
            urunStok_txt.Clear();
        }

        private void urunTemizle_btn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
