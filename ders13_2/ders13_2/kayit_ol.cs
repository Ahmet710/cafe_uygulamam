using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders13_2
{
    public partial class kayit_ol : Form
    {
        public kayit_ol()
        {
            InitializeComponent();
        }

        private void kayit_ol_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                Application.OpenForms["menu"].Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_kayit_ol_kayit_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullanici_adi_kayit.Text.Trim();
            string sifre = txt_sifre_kayit.Text.Trim();
            string ad = txt_ad_kayit.Text.Trim();
            string soyad = txt_soyad_kayit.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre) ||
                string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            kullanici yeni = new kullanici(kullaniciAdi, sifre, ad, soyad);
            GlobalVeri.TumKullanicilar.Add(yeni);

            MessageBox.Show("Kayıt başarılı!");
            this.Close();
            Application.OpenForms["menu"].Show();
        }
    }
}