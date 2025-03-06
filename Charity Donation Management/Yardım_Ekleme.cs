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
    public partial class Yardım_Ekleme : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=dernek;Uid=root;Pwd=0123456789");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        MySqlDataReader dr;
        public string yardım_türü, yardım_tarihi, yardım_miktarı, isim,soyisim,isim_soyisim;
        public Yardım_Ekleme()
        {
            InitializeComponent();
        }
        public void kişi()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM ihtiyac_sahibi_yardım", con);
            // dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            con.Close();
        }
        public void isim_name()
        {

            MySqlCommand kmt = new MySqlCommand("Select * from reis_listesi", con);
            con.Open();
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[4]);
            }
            con.Close();
        }
        private void Yardım_Ekleme_Load(object sender, EventArgs e)
        {
            kişi();
            isim_name();
            this.WindowState = FormWindowState.Maximized;
            panel1.Location = new Point(
    this.ClientSize.Width / 2 - panel1.Size.Width / 2,
    this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            this.ActiveControl = comboBox1;
        }
        public void Tanımlamalar()
        {
            yardım_türü = Yardım_Türü();
            yardım_miktarı = textBox4.Text;
            yardım_tarihi = Kayıt_Tarihi();
            isim = comboBox1.SelectedItem.ToString();
            soyisim = comboBox2.SelectedItem.ToString();
            

            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(yardım_tarihi);
            yardım_tarihi = dt.ToString("yyyy/MM/dd");
            Yardım_Liste iht = new Yardım_Liste();
            iht.isim_soyisim = isim_soyisim;
            iht.yardım_tarih = yardım_tarihi;
            iht.yardım_miktar = yardım_miktarı;
            iht.yardım_tür = yardım_türü;
        }
        public string Kayıt_Tarihi()
        {
            if (dateTimePicker1.Checked == true) return dateTimePicker1.Text;
            else return "Belirtilmedi";
        }
        public string Yardım_Türü()
        {
            if (radioButton1.Checked == true) return radioButton1.Text;
            if (radioButton2.Checked == true) return radioButton2.Text;
            else return "Belirtilmedi";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(comboBox1.Text)
                            || String.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Boş Alan Var", "Dikkat");
            }

            DialogResult res1 = MessageBox.Show("Kaydı Eklemek İstiyormusunuz? ", "Kayıt Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (res1 == DialogResult.Yes)
            {
                Tanımlamalar();

                try
                {
                    
                    string sql = "INSERT INTO ihtiyac_sahibi_yardım(İsim,Soyisim,Yardım_Tarihi,Yardım_Türü,Yardım_Miktarı)" +
                        "VALUES(@İsim,@Soyisim,@Yardım_Tarihi,@Yardım_Türü,@Yardım_Miktarı)";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("Yardım_Tarihi", yardım_tarihi);
                    cmd.Parameters.AddWithValue("İsim", isim);
                    cmd.Parameters.AddWithValue("Soyisim", soyisim);
                    cmd.Parameters.AddWithValue("Yardım_Miktarı", yardım_miktarı);
                    cmd.Parameters.AddWithValue("Yardım_Türü", yardım_türü);
                        con.Open();
                    cmd.ExecuteNonQuery();
                    
                    con.Close();
                    kişi();
                    isim_name();
                    MessageBox.Show("Kayıt Ekleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("T.C Numarası Kaydı Bulunamadı  " + isim_soyisim);
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            SearchComboBox(comboBox1.Text);
        }
        private void SearchComboBox(string text)
        {


            var matched = from object item in comboBox1.Items
                          where item.ToString().ToLower().Contains(text.ToLower())
                          select item;


            comboBox1.DroppedDown = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            comboBox2.Text = "";


            cmd = new MySqlCommand("Select Soyisim from reis_listesi where İsim=@p1", con);
            cmd.Parameters.AddWithValue("@p1", comboBox1.SelectedItem.ToString());
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               comboBox2.Items.Add(dr[0]);
            }
            con.Close();
        }
    }
}
