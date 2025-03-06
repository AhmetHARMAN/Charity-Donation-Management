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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dernek
{
    public partial class Üye_Listesi : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=dernek;Uid=root;Pwd=0123456789");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public string isim, soyisim, yaş, ünvan, tel, aidat_miktarı, adres, kullanıcı_adı, kullanıcı_numarası, şifre;

        public Üye_Listesi()
        {
            InitializeComponent();
        }
        public void kişi()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM üye_kayıt_bilgi", con);
            dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                isim = dataGridView1.CurrentRow.Cells[1].ToString();
                soyisim = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                ünvan = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                kullanıcı_adı = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                kullanıcı_numarası = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                yaş = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                ünvan = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                tel = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                adres = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                şifre = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                tel = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isim_btn.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "üye_ad LIKE '" + textBox1.Text + "%'";
                dataGridView1.DataSource = dv;
            }

            if (kul_num_btn.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("convert(üye_numarası,'System.String')LIKE'%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv;

            }
        }



        private void Üye_Listesi_Load(object sender, EventArgs e)
        {
            kişi();
            this.WindowState = FormWindowState.Maximized;
            panel1.Location = new Point(
    this.ClientSize.Width / 2 - panel1.Size.Width / 2,
    this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

        }





        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Üye_Aidat_Takip üy_tk = new Üye_Aidat_Takip();

        private void button1_Click(object sender, EventArgs e)
        {
            üy_tk.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res1 = MessageBox.Show(textBox1.Text + " İsimli Kaydı Silmek İstiyormusunuz? ", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (res1 == DialogResult.Yes)
            {
                if (isim_btn.Checked == true)
                {
                    try
                    {
                        string sql = ("DELETE FROM üye_kayıt_bilgi WHERE üye_ad=@üye_ad");
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("üye_ad", textBox1.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        kişi();
                        MessageBox.Show("Kayıt Silme Başaralı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + "Hatalı İşlem yaptınız.\nKayıtları kontrol ediniz", "Dikkat");
                    }
                }
                if (kul_num_btn.Checked == true)
                {
                    try
                    {
                        string sql = ("DELETE FROM üye_kayıt_bilgi WHERE üye_numarası=@üye_numarası");
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("üye_numarası", textBox1.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        kişi();
                        MessageBox.Show("Kayıt Silme Başaralı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + "Hatalı İşlem yaptınız.\nKayıtları kontrol ediniz", "Dikkat");
                    }
                }
            }
            else { }
        }
    }
}
