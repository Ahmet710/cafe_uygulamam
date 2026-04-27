namespace user_uygulaması
{
    partial class kayit_islemi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgrid_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrid_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrid_hesap_olusturma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgrid_username,
            this.dgrid_password,
            this.dgrid_hesap_olusturma});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(704, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgrid_username
            // 
            this.dgrid_username.HeaderText = "KULLANICI ADI";
            this.dgrid_username.MinimumWidth = 6;
            this.dgrid_username.Name = "dgrid_username";
            this.dgrid_username.Width = 175;
            // 
            // dgrid_password
            // 
            this.dgrid_password.HeaderText = "PAROLA";
            this.dgrid_password.MinimumWidth = 6;
            this.dgrid_password.Name = "dgrid_password";
            this.dgrid_password.Width = 175;
            // 
            // dgrid_hesap_olusturma
            // 
            this.dgrid_hesap_olusturma.HeaderText = "HESAP OLUŞTURMA TARİHİ";
            this.dgrid_hesap_olusturma.MinimumWidth = 6;
            this.dgrid_hesap_olusturma.Name = "dgrid_hesap_olusturma";
            this.dgrid_hesap_olusturma.Width = 300;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "KULLANICI ADI   :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAROLA   :";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(13, 281);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(704, 22);
            this.txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(13, 361);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(704, 22);
            this.txtpassword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(704, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "KULLANICIYI SİSTEME KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayit_islemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kayit_islemi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt İşlemi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrid_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrid_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrid_hesap_olusturma;
        private System.Windows.Forms.Button button1;
    }
}

