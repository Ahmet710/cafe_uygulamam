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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            kayit_ol kayit = new kayit_ol();
            this.Hide();
            kayit.Show();
        }

        private void btn_giris_yap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullanici_Adi.Text.Trim();
            string sifre = txt_sifre.Text.Trim();

            kullanici aktifKullanici = null;

            for (int i = 0; i < GlobalVeri.TumKullanicilar.Count; i++)
            {
                kullanici k = GlobalVeri.TumKullanicilar[i];
                if (k.Kullanici_adi == kullaniciAdi && k.Kullanici_sifre == sifre)
                {
                    aktifKullanici = k;
                    break;
                }
            }

            if (aktifKullanici != null)
            {
                giris_yap hosgeldinForm = new giris_yap();
                this.Hide();
                hosgeldinForm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }
        }
    }
}
