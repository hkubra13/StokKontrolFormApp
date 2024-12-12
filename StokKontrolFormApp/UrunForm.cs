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
        public UrunForm()
        {
            InitializeComponent();
        }

        private void urunGoster_btn_Click(object sender, EventArgs e)
        {
            BindingSource urunBindingSource = new BindingSource();
            urunBindingSource.DataSource = urunDAO.TumUrunler();
            urunDataGrid.DataSource = urunBindingSource;
        }

        private void urunAra_btn_Click(object sender, EventArgs e)
        {
            BindingSource urunBindingSource = new BindingSource();
            urunBindingSource.DataSource = urunDAO.UrunArama(urunAra_txt.Text);
            urunDataGrid.DataSource = urunBindingSource;
        }
    }
}
