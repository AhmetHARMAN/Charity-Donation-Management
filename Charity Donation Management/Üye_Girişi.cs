using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dernek
{
    public partial class üye_girişi : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=dernek;Uid=root;Pwd=0123456789");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        MySqlDataReader dr;
        string kod = "12345";
        public void kişi()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM üye_kayıt_bilgi", con);
            //dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            con.Close();
        }
        public üye_girişi()
        {
            InitializeComponent();
        }

        private void üye_girişi_Load(object sender, EventArgs e)
        {
            kişi();
            this.WindowState= FormWindowState.Maximized;
            panel1.Location = new Point(
    this.ClientSize.Width / 2 - panel1.Size.Width / 2,
    this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM üye_kayıt_bilgi where üye_kullanıcı_adı=@üye_kullanıcı_adı AND üye_şifre=@üye_şifre";
            cmd = new MySqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("üye_kullanıcı_adı", textBox1.Text);
            cmd.Parameters.AddWithValue("üye_şifre", textBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            Form1 op = new Form1();

            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                op.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
            con.Close();
        }

        private void üye_btn_Click(object sender, EventArgs e)
        {
            üye_kayıt_form cn = new üye_kayıt_form();
            cn.ShowDialog();
        }



        private void çıkış_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onay_btn_Click(object sender, EventArgs e)
        {
            if (kod == kod_text.Text) { üye_btn.Enabled = true;
                MessageBox.Show("Kodunuz Doğru, Yeni Kayıt Yapabilirsiniz", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                üye_btn.Enabled = false;
            MessageBox.Show("Kodunuz Yanlış, Aşir Hocadan Kod isteyiniz"
                , "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
