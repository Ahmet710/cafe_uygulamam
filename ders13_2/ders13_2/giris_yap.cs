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
    public partial class giris_yap : Form
    {
        private kullanici aktifKullanici;  // aktif kullanıcıyı burada tanımlıyoruz

        // Yapıcı metod (constructor), aktif kullanıcıyı parametre olarak alıyor
        internal giris_yap(kullanici k)
        {
            InitializeComponent();
            aktifKullanici = k;  // Aktif kullanıcıyı saklıyoruz
        }

        private void giris_yap_Load(object sender, EventArgs e)
        {
            // Form açıldığında, aktif kullanıcının adını ekranda gösteriyoruz
            if (aktifKullanici != null)
            {
                ekran.Text = $"Sn. {aktifKullanici.Ad} hoşgeldiniz!";
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            // Ana menüye geri dönmek için
            Application.OpenForms["menu"].Show();
            this.Close();
        }

        private void giris_yap_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form kapanırken ana menüyü göster
            Application.OpenForms["menu"].Show();
        }
    }
}