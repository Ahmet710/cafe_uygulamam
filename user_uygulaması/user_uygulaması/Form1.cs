using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_uygulaması
{
    public partial class kayit_islemi : Form
    {
        public static string[] usernames = new string[128];
        public static string[] passwords = new string[128];
        public static int userindex=0;
        public kayit_islemi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username=txtusername.Text;
            string password=txtpassword.Text;

            dataGridView1.Rows.Add(username, password, DateTime.Now);

            usernames[userindex] = username;
            passwords[userindex] = password;

            userindex++;

            MessageBox.Show($"Kullanıcı sisteme başarıyla eklendi! [kullanıcı no: {userindex.ToString()}]","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
