namespace odev3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbox_ekran = new System.Windows.Forms.ListBox();
            this.gbox_aralik_b = new System.Windows.Forms.GroupBox();
            this.pbox_aralik_b = new System.Windows.Forms.PictureBox();
            this.btn_aralik_b = new System.Windows.Forms.Button();
            this.txt_son_deger = new System.Windows.Forms.TextBox();
            this.txt_ilk_deger = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbox_tek_s = new System.Windows.Forms.GroupBox();
            this.pbox_tek_sayi = new System.Windows.Forms.PictureBox();
            this.txt_sayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tek_s = new System.Windows.Forms.Button();
            this.gbox_secenek = new System.Windows.Forms.GroupBox();
            this.rbtn_aralik_b = new System.Windows.Forms.RadioButton();
            this.rbtn_tek_s = new System.Windows.Forms.RadioButton();
            this.gbox_aralik_b.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_aralik_b)).BeginInit();
            this.gbox_tek_s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_tek_sayi)).BeginInit();
            this.gbox_secenek.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbox_ekran
            // 
            this.lbox_ekran.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lbox_ekran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_ekran.FormattingEnabled = true;
            this.lbox_ekran.ItemHeight = 20;
            this.lbox_ekran.Location = new System.Drawing.Point(506, 13);
            this.lbox_ekran.Name = "lbox_ekran";
            this.lbox_ekran.Size = new System.Drawing.Size(282, 424);
            this.lbox_ekran.TabIndex = 11;
            // 
            // gbox_aralik_b
            // 
            this.gbox_aralik_b.BackColor = System.Drawing.Color.SteelBlue;
            this.gbox_aralik_b.Controls.Add(this.pbox_aralik_b);
            this.gbox_aralik_b.Controls.Add(this.btn_aralik_b);
            this.gbox_aralik_b.Controls.Add(this.txt_son_deger);
            this.gbox_aralik_b.Controls.Add(this.txt_ilk_deger);
            this.gbox_aralik_b.Controls.Add(this.label3);
            this.gbox_aralik_b.Controls.Add(this.label2);
            this.gbox_aralik_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_aralik_b.Location = new System.Drawing.Point(12, 253);
            this.gbox_aralik_b.Name = "gbox_aralik_b";
            this.gbox_aralik_b.Size = new System.Drawing.Size(488, 185);
            this.gbox_aralik_b.TabIndex = 10;
            this.gbox_aralik_b.TabStop = false;
            this.gbox_aralik_b.Text = "ARALIK BELİRT";
            // 
            // pbox_aralik_b
            // 
            this.pbox_aralik_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_aralik_b.Image = ((System.Drawing.Image)(resources.GetObject("pbox_aralik_b.Image")));
            this.pbox_aralik_b.Location = new System.Drawing.Point(244, 111);
            this.pbox_aralik_b.Name = "pbox_aralik_b";
            this.pbox_aralik_b.Size = new System.Drawing.Size(49, 51);
            this.pbox_aralik_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_aralik_b.TabIndex = 3;
            this.pbox_aralik_b.TabStop = false;
            this.pbox_aralik_b.Click += new System.EventHandler(this.pbox_aralik_b_Click);
            // 
            // btn_aralik_b
            // 
            this.btn_aralik_b.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_aralik_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aralik_b.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_aralik_b.Location = new System.Drawing.Point(299, 111);
            this.btn_aralik_b.Name = "btn_aralik_b";
            this.btn_aralik_b.Size = new System.Drawing.Size(183, 51);
            this.btn_aralik_b.TabIndex = 6;
            this.btn_aralik_b.Text = "KONTROL ET";
            this.btn_aralik_b.UseVisualStyleBackColor = false;
            this.btn_aralik_b.Click += new System.EventHandler(this.btn_aralik_b_Click);
            // 
            // txt_son_deger
            // 
            this.txt_son_deger.Location = new System.Drawing.Point(10, 134);
            this.txt_son_deger.Name = "txt_son_deger";
            this.txt_son_deger.Size = new System.Drawing.Size(201, 27);
            this.txt_son_deger.TabIndex = 5;
            // 
            // txt_ilk_deger
            // 
            this.txt_ilk_deger.Location = new System.Drawing.Point(10, 46);
            this.txt_ilk_deger.Name = "txt_ilk_deger";
            this.txt_ilk_deger.Size = new System.Drawing.Size(201, 27);
            this.txt_ilk_deger.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "SON DEĞER  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "İLK DEĞER  :";
            // 
            // gbox_tek_s
            // 
            this.gbox_tek_s.BackColor = System.Drawing.Color.DarkOrange;
            this.gbox_tek_s.Controls.Add(this.pbox_tek_sayi);
            this.gbox_tek_s.Controls.Add(this.txt_sayi);
            this.gbox_tek_s.Controls.Add(this.label1);
            this.gbox_tek_s.Controls.Add(this.btn_tek_s);
            this.gbox_tek_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_tek_s.Location = new System.Drawing.Point(12, 121);
            this.gbox_tek_s.Name = "gbox_tek_s";
            this.gbox_tek_s.Size = new System.Drawing.Size(488, 126);
            this.gbox_tek_s.TabIndex = 9;
            this.gbox_tek_s.TabStop = false;
            this.gbox_tek_s.Text = "TEK SAYI";
            // 
            // pbox_tek_sayi
            // 
            this.pbox_tek_sayi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_tek_sayi.Image = ((System.Drawing.Image)(resources.GetObject("pbox_tek_sayi.Image")));
            this.pbox_tek_sayi.Location = new System.Drawing.Point(244, 49);
            this.pbox_tek_sayi.Name = "pbox_tek_sayi";
            this.pbox_tek_sayi.Size = new System.Drawing.Size(49, 52);
            this.pbox_tek_sayi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_tek_sayi.TabIndex = 3;
            this.pbox_tek_sayi.TabStop = false;
            this.pbox_tek_sayi.Click += new System.EventHandler(this.pbox_tek_sayi_Click);
            // 
            // txt_sayi
            // 
            this.txt_sayi.Location = new System.Drawing.Point(10, 64);
            this.txt_sayi.Name = "txt_sayi";
            this.txt_sayi.Size = new System.Drawing.Size(219, 27);
            this.txt_sayi.TabIndex = 2;
            this.txt_sayi.Click += new System.EventHandler(this.txt_sayi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "bir sayı giriniz  :";
            // 
            // btn_tek_s
            // 
            this.btn_tek_s.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_tek_s.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_tek_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tek_s.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_tek_s.Location = new System.Drawing.Point(299, 49);
            this.btn_tek_s.Name = "btn_tek_s";
            this.btn_tek_s.Size = new System.Drawing.Size(183, 52);
            this.btn_tek_s.TabIndex = 3;
            this.btn_tek_s.Text = "KONTROL ET";
            this.btn_tek_s.UseVisualStyleBackColor = false;
            this.btn_tek_s.Click += new System.EventHandler(this.btn_tek_s_Click);
            // 
            // gbox_secenek
            // 
            this.gbox_secenek.BackColor = System.Drawing.Color.OrangeRed;
            this.gbox_secenek.Controls.Add(this.rbtn_aralik_b);
            this.gbox_secenek.Controls.Add(this.rbtn_tek_s);
            this.gbox_secenek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_secenek.Location = new System.Drawing.Point(13, 13);
            this.gbox_secenek.Name = "gbox_secenek";
            this.gbox_secenek.Size = new System.Drawing.Size(487, 102);
            this.gbox_secenek.TabIndex = 8;
            this.gbox_secenek.TabStop = false;
            this.gbox_secenek.Text = "SEÇİM YAP  :";
            // 
            // rbtn_aralik_b
            // 
            this.rbtn_aralik_b.AutoSize = true;
            this.rbtn_aralik_b.Location = new System.Drawing.Point(262, 52);
            this.rbtn_aralik_b.Name = "rbtn_aralik_b";
            this.rbtn_aralik_b.Size = new System.Drawing.Size(193, 24);
            this.rbtn_aralik_b.TabIndex = 1;
            this.rbtn_aralik_b.TabStop = true;
            this.rbtn_aralik_b.Text = "ARALIK BELİRTME";
            this.rbtn_aralik_b.UseVisualStyleBackColor = true;
            // 
            // rbtn_tek_s
            // 
            this.rbtn_tek_s.AutoSize = true;
            this.rbtn_tek_s.Location = new System.Drawing.Point(33, 52);
            this.rbtn_tek_s.Name = "rbtn_tek_s";
            this.rbtn_tek_s.Size = new System.Drawing.Size(111, 24);
            this.rbtn_tek_s.TabIndex = 0;
            this.rbtn_tek_s.TabStop = true;
            this.rbtn_tek_s.Text = "TEK SAYI";
            this.rbtn_tek_s.UseVisualStyleBackColor = true;
            this.rbtn_tek_s.CheckedChanged += new System.EventHandler(this.rbtn_tek_s_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbox_ekran);
            this.Controls.Add(this.gbox_aralik_b);
            this.Controls.Add(this.gbox_tek_s);
            this.Controls.Add(this.gbox_secenek);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harshad Sayısı Bulma";
            this.gbox_aralik_b.ResumeLayout(false);
            this.gbox_aralik_b.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_aralik_b)).EndInit();
            this.gbox_tek_s.ResumeLayout(false);
            this.gbox_tek_s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_tek_sayi)).EndInit();
            this.gbox_secenek.ResumeLayout(false);
            this.gbox_secenek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_ekran;
        private System.Windows.Forms.GroupBox gbox_aralik_b;
        private System.Windows.Forms.Button btn_aralik_b;
        private System.Windows.Forms.TextBox txt_son_deger;
        private System.Windows.Forms.TextBox txt_ilk_deger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbox_tek_s;
        private System.Windows.Forms.TextBox txt_sayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tek_s;
        private System.Windows.Forms.GroupBox gbox_secenek;
        private System.Windows.Forms.RadioButton rbtn_aralik_b;
        private System.Windows.Forms.RadioButton rbtn_tek_s;
        private System.Windows.Forms.PictureBox pbox_aralik_b;
        private System.Windows.Forms.PictureBox pbox_tek_sayi;
    }
}

