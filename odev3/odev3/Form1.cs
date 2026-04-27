using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_sayi_Click(object sender, EventArgs e)
        {
            txt_sayi.Text = "";
        }

        private void rbtn_tek_s_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_tek_s.Checked)
            {
                gbox_aralik_b.Enabled = false;
                gbox_tek_s.Enabled = true;
            }

            else
            {
                gbox_tek_s.Enabled = false;
                gbox_aralik_b.Enabled = true;
            }
        }

        private void btn_tek_s_Click(object sender, EventArgs e)
        {

            string kullanici_girdisi = txt_sayi.Text.Trim();


            bool sadece_rakamlar = true;

            for (int i = 0; i < kullanici_girdisi.Length; i++)
            {
                if (kullanici_girdisi[i] < '0' || kullanici_girdisi[i] > '9')
                {
                    sadece_rakamlar = false;
                    break;
                }
            }

            if (!string.IsNullOrEmpty(kullanici_girdisi) && sadece_rakamlar)
            {
                int sayi = 0;
                for (int i = 0; i < kullanici_girdisi.Length; i++)
                {
                    sayi = sayi * 10 + (kullanici_girdisi[i] - '0');
                }



                int basamak_toplami = 0;
                for (int i = 0; i < kullanici_girdisi.Length; i++)
                {
                    basamak_toplami += (kullanici_girdisi[i] - '0');
                }



                if (sayi % basamak_toplami == 0)
                {
                    lbox_ekran.Items.Add(sayi);
                    MessageBox.Show("Sayı Harshad sayısıdır...","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }


                else
                {
                    MessageBox.Show("Sayı Harshad sayısı değildir!!!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz...","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }



        private void btn_aralik_b_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ilk_deger.Text) || string.IsNullOrEmpty(txt_son_deger.Text))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                int ilk_deger = 0;
                int son_deger = 0;

                for (int i = 0; i < txt_ilk_deger.Text.Length; i++)
                {
                    ilk_deger = ilk_deger * 10 + Convert.ToInt32(txt_ilk_deger.Text[i].ToString());
                }


                for (int i = 0; i < txt_son_deger.Text.Length; i++)
                {
                    son_deger = son_deger * 10 + Convert.ToInt32(txt_son_deger.Text[i].ToString());
                }

                lbox_ekran.Items.Clear();


                for (int i = ilk_deger; i <= son_deger; i++)
                {
                    int sayi = i;
                    int basamak_toplami = 0;

                    string sayiStr = sayi.ToString();
                    for (int j = 0; j < sayiStr.Length; j++)
                    {
                        basamak_toplami += Convert.ToInt32(sayiStr[j].ToString());
                    }


                    if (sayi % basamak_toplami == 0)
                    {
                        lbox_ekran.Items.Add(sayi);
                    }
                }



                if (lbox_ekran.Items.Count > 0)
                {
                    MessageBox.Show("Girilen aralıktaki Harshad sayıları listeye eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else
                {
                    MessageBox.Show("Girilen aralıkta hiçbir Harshad sayısı bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }



        private void pbox_tek_sayi_Click(object sender, EventArgs e)
        {

            string kullanici_girdisi = txt_sayi.Text.Trim();


            bool sadece_rakamlar = true;

            for (int i = 0; i < kullanici_girdisi.Length; i++)
            {
                if (kullanici_girdisi[i] < '0' || kullanici_girdisi[i] > '9')
                {
                    sadece_rakamlar = false;
                    break;
                }
            }

            if (!string.IsNullOrEmpty(kullanici_girdisi) && sadece_rakamlar)
            {
                int sayi = 0;
                for (int i = 0; i < kullanici_girdisi.Length; i++)
                {
                    sayi = sayi * 10 + (kullanici_girdisi[i] - '0');
                }



                int basamak_toplami = 0;
                for (int i = 0; i < kullanici_girdisi.Length; i++)
                {
                    basamak_toplami += (kullanici_girdisi[i] - '0');
                }


                if (sayi % basamak_toplami == 0)
                {
                    lbox_ekran.Items.Add(sayi);
                    MessageBox.Show("Sayı Harshad sayısıdır...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else
                {
                    MessageBox.Show("Sayı Harshad sayısı değildir!!!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void pbox_aralik_b_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ilk_deger.Text) || string.IsNullOrEmpty(txt_son_deger.Text))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                int ilk_deger = 0;
                int son_deger = 0;

                for (int i = 0; i < txt_ilk_deger.Text.Length; i++)
                {
                    ilk_deger = ilk_deger * 10 + Convert.ToInt32(txt_ilk_deger.Text[i].ToString());
                }


                for (int i = 0; i < txt_son_deger.Text.Length; i++)
                {
                    son_deger = son_deger * 10 + Convert.ToInt32(txt_son_deger.Text[i].ToString());
                }

                lbox_ekran.Items.Clear();


                for (int i = ilk_deger; i <= son_deger; i++)
                {
                    int sayi = i;
                    int basamak_toplami = 0;

                    string sayiStr = sayi.ToString();
                    for (int j = 0; j < sayiStr.Length; j++)
                    {
                        basamak_toplami += Convert.ToInt32(sayiStr[j].ToString());
                    }


                    if (sayi % basamak_toplami == 0)
                    {
                        lbox_ekran.Items.Add(sayi);
                    }
                }



                if (lbox_ekran.Items.Count > 0)
                {
                    MessageBox.Show("Girilen aralıktaki Harshad sayıları listeye eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else
                {
                    MessageBox.Show("Girilen aralıkta hiçbir Harshad sayısı bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
