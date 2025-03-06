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
    public partial class üye_kayıt_form : Form
    {
        string üye_no, isim, soyisim, meslek, tel,
            memleket, doğum_tarihi, adres, tc_no;
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=dernek;Uid=root;Pwd=0123456789");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader dr;
        DataTable dt;
        public üye_kayıt_form()
        {
            InitializeComponent();

        }

        private void üye_kayıt_form_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            il_ekle();
            üye();
        }
        public void üye()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM üye_kayıt_bilgi", con);
            //dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            con.Close();
        }
        void il_ekle()
        {
            MySqlCommand kmt = new MySqlCommand("Select * From iller", con);
            con.Open();
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                memleket_box.Items.Add(dr[1]);

            }
            con.Close();
        }
        public void Tanımlamalar()
        {
            isim = name_txt.Text;
            soyisim = soyisim_text.Text;
            tc_no = tc_txt.Text;
            memleket = memleket_box.SelectedItem.ToString();
            doğum_tarihi = dateTimePicker1.Text;
            üye_no = üye_no_text.Text;
            tel = tel_no_text.Text;
            adres = adres_text.Text;
            meslek = job_text.Text;
            Üye_Listesi üye_list = new Üye_Listesi();
            üye_list.isim = isim;
            üye_list.soyisim = soyisim;

            DateTime dateTime = new DateTime();
            dateTime = Convert.ToDateTime(doğum_tarihi);
            doğum_tarihi = dateTime.ToString("yyyy/MM/dd");


        }

        private void memleket_box_TextChanged(object sender, EventArgs e)
        {
            SearchComboBox(memleket_box.Text);
        }
        private void SearchComboBox(string text)
        {


            var matched = from object item in memleket_box.Items
                          where item.ToString().ToLower().Contains(text.ToLower())
                          select item;


            memleket_box.DroppedDown = true;
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tel_no_text.Text) || String.IsNullOrEmpty(name_txt.Text) ||
                String.IsNullOrEmpty(adres_text.Text) || String.IsNullOrEmpty(job_text.Text) ||
                String.IsNullOrEmpty(soyisim_text.Text) || String.IsNullOrEmpty(memleket_box.Text) ||
                String.IsNullOrEmpty(tc_txt.Text) || String.IsNullOrEmpty(dateTimePicker1.Text) ||
                String.IsNullOrEmpty(üye_no_text.Text))
            {
                MessageBox.Show("Boş Alan Var", "Dikkat");
            }

            DialogResult res1 = MessageBox.Show("Kaydı Eklemek İstiyormusunuz? ", "Kayıt Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (res1 == DialogResult.Yes)
            {
                Tanımlamalar();

                try
                {
                    string sql = "INSERT INTO üye_kayıt_bilgi( üye_ad, üye_soyad,üye_numarası,üye_tc_no,üye_doğum_tarihi,üye_meslek,üye_tel_no,üye_adres,üye_memleket)"
               + "VALUES(@üye_ad, @üye_soyad,@üye_numarası,@üye_tc_no,@üye_doğum_tarihi,@üye_meslek,@üye_tel_no,@üye_adres,@üye_memleket)";

                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("üye_ad", isim);
                    cmd.Parameters.AddWithValue("üye_soyad", soyisim);
                    cmd.Parameters.AddWithValue("üye_tc_no", tc_no);
                    cmd.Parameters.AddWithValue("üye_numarası", üye_no);
                    cmd.Parameters.AddWithValue("üye_doğum_tarihi", doğum_tarihi);
                    cmd.Parameters.AddWithValue("üye_meslek", meslek);
                    cmd.Parameters.AddWithValue("üye_tel_no", tel);
                    cmd.Parameters.AddWithValue("üye_adres", adres);
                    cmd.Parameters.AddWithValue("üye_memleket", memleket);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    üye();
                    MessageBox.Show("Kayıt Ekleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void çık_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tc_txt.Clear();
            name_txt.Clear();
            soyisim_text.Clear();
            tel_no_text.Clear();
            adres_text.Clear();
            üye_no_text.Clear();
            job_text.Clear();
            
        }
    }
}

