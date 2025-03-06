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
    public partial class Üye_Aidat_Kayıt : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=dernek;Uid=root;Pwd=0123456789");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        MySqlDataReader dr;
        string aidat_miktarı, aidat_tarihi, ad_soyad, tür;
        public Üye_Aidat_Kayıt()
        {
            InitializeComponent();
        }
        public void kişi()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM üye_aidat_takip", con);
            //dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            con.Close();
        }
        public void Tanımlama()
        {
            ad_soyad = comboBox1.SelectedItem.ToString();
            aidat_miktarı = aidat_text.Text;
            aidat_tarihi = Aidat_Tarihi();
            tür = Aidat_Türü();

            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(aidat_tarihi);
            aidat_tarihi = dt.ToString("yyyy/MM/dd");
        }
        public void full_name()
        {

            MySqlCommand kmt = new MySqlCommand("Select Concat(üye_ad,' ',üye_soyad) AS ad_soyad From üye_kayıt_bilgi", con);
            con.Open();
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);

            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(aidat_text.Text)
                || ((radioButton1.Checked) == false) && (radioButton2.Checked) == false) 
            {
                MessageBox.Show("Boş Alan Var", "Dikkat");

            }

            DialogResult res1 = MessageBox.Show("Kaydı Eklemek İstiyormusunuz? ", "Kayıt Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            
            if (res1 == DialogResult.Yes)
            {
                Tanımlama();
                try
                {
                    string sql = "INSERT INTO üye_aidat_takip(ad_soyad,tür,aidat_miktarı,aidat_tarihi)"
                  + "VALUES(@ad_soyad,@tür,@aidat_miktarı,@aidat_tarihi)";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("ad_soyad", ad_soyad);
                    cmd.Parameters.AddWithValue("aidat_tarihi", aidat_tarihi);
                    cmd.Parameters.AddWithValue("aidat_miktarı", aidat_miktarı);
                    cmd.Parameters.AddWithValue("tür", tür);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    kişi();
                    MessageBox.Show("Kayıt Ekleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Kayıtları Kontrol Edin", "Dikkat");
                }
            }
            else
            {

            }
        }
        private void Üye_Aidat_Kayıt_Load(object sender, EventArgs e)
        {
            kişi();
            full_name();
            this.WindowState = FormWindowState.Maximized;

            panel1.Location = new Point(this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Width / 4);
            panel1.Anchor = AnchorStyles.None;
            this.ActiveControl = comboBox1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string Aidat_Tarihi()
        {
            if (dateTimePicker1.Checked == true) return dateTimePicker1.Text;
            else return "Belirtilmedi";
        }
        public string Aidat_Türü()
        {
            if (radioButton1.Checked == true) return radioButton1.Text;
            else if (radioButton2.Checked == true) return radioButton2.Text;
            else { return ""; }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Üye_Aidat_Takip üy_tkp = new Üye_Aidat_Takip();
            üy_tkp.Show();
        }
    }
}

//_thePanel.Location = new Point(
//    this.ClientSize.Width / 2 - _thePanel.Size.Width / 2,
//    this.ClientSize.Height / 2 - _thePanel.Size.Height / 4);
//_thePanel.Anchor = AnchorStyles.None;
