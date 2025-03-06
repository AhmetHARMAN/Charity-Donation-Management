using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Modes;
using ZstdSharp.Unsafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dernek
{
    public partial class Kişi_Ekleme : Form
    {

        string isim, soyisim, tcNO, meslek, doğum_tarihi,
            medeni_durum, aile_içi_konum, cinsiyet, engel_durum, ev_durum,
            sgk_durum, tel, ev_tel,
            yardım_derece, destek_durumu, kayıt_tarihi,
            il, ilçe, mahalle, sokak, kapı_no,
            kayıt_no, syc, birey_syc, sayaç_bry;
        string str;
        int sayı;
        int a;
        DialogResult r1;
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=dernek;Uid=root;Pwd=0123456789");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader dr;
        DataTable dt;
        void ilçe_ekle()
        {
            MySqlCommand kmt = new MySqlCommand("Select * From ilçeler", con);
            con.Open();
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                ilçe_box.Items.Add(dr[1]);

            }
            con.Close();

        }

        public void kişi()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM ihtiyac_sahibi_kayıt", con);
            //dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            con.Close();
        }
        public void reis_kişi()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("Select * from reis_listesi", con);
            adapter.Fill(dt);
            con.Close();
        }
        public void birey_kişi()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("Select * from birey_listesi", con);
            adapter.Fill(dt);
            con.Close();
        }
        public Kişi_Ekleme()
        {
            InitializeComponent();

        }

        private void Kişi_Ekleme_Load(object sender, EventArgs e)
        {
            kişi();
            ilçe_ekle();
            reis_kişi();
            birey_kişi();
            Dosya_Okuma();
            this.WindowState = FormWindowState.Maximized;
            panel11.Location = new Point(
            this.ClientSize.Width / 2 - panel11.Size.Width / 2,
            this.ClientSize.Height / 2 - panel11.Size.Height / 2);
            panel11.Anchor = AnchorStyles.None;
            this.ActiveControl = tc_no_textBox;
            button4.Enabled=false;
        }

        public void Tanımlama()
        {
            #region Tanımlamalar
            isim = name_textBox.Text;
            soyisim = surname_textBox.Text;
            tcNO = tc_no_textBox.Text;
            meslek = job_Box.SelectedItem.ToString();
            tel = tel_no_textBox.Text;
            il = il_text.Text;
            ilçe = ilçe_box.SelectedItem.ToString();
            mahalle = mahalle_box.SelectedItem.ToString();
            sokak = sokak_text.Text;
            kapı_no = kapı_text.Text;
            engel_durum = Engel_Durum();
            medeni_durum = Medeni_Durum();
            aile_içi_konum = Aile_İçi_Durum();
            cinsiyet = Cinsiyet_Durum();
            ev_durum = Ev_Durumu();
            sgk_durum = SGK_Durum();
            yardım_derece = Yardım_Derecesi();
            destek_durumu = Destek_Durum();
            kayıt_tarihi = Kayıt_Tarihi();
            doğum_tarihi = Dogum_Tarihi();
            engel_durum = Engel_Durum();
            kayıt_no = kayıt_no_text.Text;
            sayaç_bry = birey_syc;

           

            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(kayıt_tarihi);
            kayıt_tarihi = dt.ToString("yyyy/MM/dd");

            DateTime dateTime = new DateTime();
            dateTime = Convert.ToDateTime(doğum_tarihi);
            doğum_tarihi = dateTime.ToString("yyyy/MM/dd");






            #endregion

        }


        public void Dosya_Okuma()
        {
            str = "deger.txt";

            string veri = File.ReadAllText(str);
            if (int.TryParse(veri, out sayı))
            {
                a = sayı;

            }
            birey_syc = a.ToString();
        }
        #region Buton Metotları
        public string Medeni_Durum()
        {
            if (evli_btn.Checked == true)
                return evli_btn.Text;
            else if (bekar_btn.Checked == true) return bekar_btn.Text;
            else if (dul_btn.Checked == true) return dul_btn.Text;
            else return "Belirtilmedi";
        }
        public string SGK_Durum()
        {
            if (sgk_evt_btn.Checked == true) return sgk_evt_btn.Text;
            else if (sgk_hyr_btn.Checked == true) return sgk_hyr_btn.Text;
            else return "Belirtilmedi";
        }
        public string Destek_Durum()
        {
            if (destek_evt_btn.Checked == true) return destek_evt_btn.Text;
            else return destek_hyr_btn.Text;
        }
        public string Cinsiyet_Durum()
        {
            if (cins_erk_btn.Checked == true) return cins_erk_btn.Text;
            else if (cins_kdn_btn.Checked == true) return cins_kdn_btn.Text;
            else return "Belirtilmedi";
        }
        public string Ev_Durumu()
        {
            if (ev_sahip_btn.Checked == true) return ev_sahip_btn.Text;
            else if (ev_kira_btn.Checked == true) return ev_kira_btn.Text;
            else if (ev_yok_btn.Checked == true) return ev_yok_btn.Text;
            else return "Belirtilmedi";
        }
        public string Aile_İçi_Durum()
        {
            if (aile_reis_btn.Checked == true) return aile_reis_btn.Text;
            else if (aile_bry_btn.Checked == true) return aile_bry_btn.Text;
            else return "Belirtilmedi";
        }
        public string Yardım_Derecesi()
        {
            if (radioButton1.Checked == true) return "1";
            else if (radioButton2.Checked == true) return "2";
            else if (radioButton3.Checked == true) return "3";
            else if (radioButton4.Checked == true) return "4";
            else return "5";
        }
        public string Kayıt_Tarihi()
        {
            if (dateTimePicker1.Checked == true) return dateTimePicker1.Text;
            else return "Belirtilmedi";

        }
        public string Engel_Durum()
        {
            if (radioButton6.Checked == true) return radioButton6.Text;
            else if (radioButton7.Checked == true) return radioButton7.Text;
            return "Belirtilmedi";
        }
        public string Dogum_Tarihi()
        {
            if (dateTimePicker2.Checked == true) return dateTimePicker2.Text;
            else return "Belirtilmedi";

        }

        #endregion



        private void ilçe_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            mahalle_box.Items.Clear();
            mahalle_box.Text = "";


            cmd = new MySqlCommand("Select * from mahalleler where ilçe_id=@p1", con);
            cmd.Parameters.AddWithValue("@p1", ilçe_box.SelectedIndex + 1);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                mahalle_box.Items.Add(dr[1]);
            }
            con.Close();

        }



        private void aile_reis_btn_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void aile_bry_btn_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;

        }

        private void tc_no_textBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true; // Tab tuşunun varsayılan işlevini iptal et
                SelectNextControl((Control)sender, true, true, true, true);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tel_no_textBox.Text) || String.IsNullOrEmpty(tc_no_textBox.Text)
                            || String.IsNullOrEmpty(mahalle_box.Text) || String.IsNullOrEmpty(name_textBox.Text)
                            || String.IsNullOrEmpty(job_Box.Text) || String.IsNullOrEmpty(kapı_text.Text)
                            || String.IsNullOrEmpty(surname_textBox.Text) || String.IsNullOrEmpty(sokak_text.Text)
                            || String.IsNullOrEmpty(ilçe_box.Text) || String.IsNullOrEmpty(kayıt_no_text.Text))
            {
                MessageBox.Show("Boş Alan Var", "Dikkat");
            }

            DialogResult res1 = MessageBox.Show("Kaydı Eklemek İstiyormusunuz? ", "Kayıt Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (res1 == DialogResult.Yes)
            {
                Tanımlama();

                try
                {
                    string sql = "INSERT INTO ihtiyac_sahibi_kayıt(Kayıt_No,İl,İlçe,Mahalle,Sokak,Kapı_No,Tc_No, İsim, Soyisim,Cinsiyet,Dogum_Tarihi, Medeni_Durum,Meslek,Engel_Durumu,SGK_Durumu,Ev_Durumu,Aile_İçi_Konum,Telefon_No,Yardım_Öncelik_Derecesi,Baska_Yardım_VarMı,Kayıt_Tarihi)"
                        + "VALUES(@Kayıt_No,@İl,@İlçe,@Mahalle,@Sokak,@Kapı_No,@Tc_No,@İsim,@Soyisim,@Cinsiyet,@Dogum_Tarihi,@Medeni_Durum,@Meslek,@Engel_Durumu,@SGK_Durumu,@Ev_Durumu,@Aile_İçi_Konum,@Telefon_No,@Yardım_Öncelik_Derecesi,@Baska_Yardım_VarMı,@Kayıt_Tarihi)";

                    #region KOMUT GENEL
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("Kayıt_No", kayıt_no);
                    cmd.Parameters.AddWithValue("Kayıt_Tarihi", kayıt_tarihi);
                    cmd.Parameters.AddWithValue("Tc_No", tcNO);
                    cmd.Parameters.AddWithValue("İsim", isim);
                    cmd.Parameters.AddWithValue("Soyisim", soyisim);
                    cmd.Parameters.AddWithValue("Cinsiyet", cinsiyet);
                    cmd.Parameters.AddWithValue("Dogum_Tarihi", doğum_tarihi);
                    cmd.Parameters.AddWithValue("Medeni_Durum", medeni_durum);
                    cmd.Parameters.AddWithValue("Engel_Durumu", engel_durum);
                    cmd.Parameters.AddWithValue("Meslek", meslek);
                    cmd.Parameters.AddWithValue("SGK_Durumu", sgk_durum);
                    cmd.Parameters.AddWithValue("Ev_Durumu", ev_durum);
                    cmd.Parameters.AddWithValue("Aile_İçi_Konum", aile_içi_konum);
                    cmd.Parameters.AddWithValue("Telefon_No", tel);
                    cmd.Parameters.AddWithValue("Yardım_Öncelik_Derecesi", yardım_derece);
                    cmd.Parameters.AddWithValue("Baska_Yardım_VarMı", destek_durumu);
                    cmd.Parameters.AddWithValue("İl", il);
                    cmd.Parameters.AddWithValue("İlçe", ilçe);
                    cmd.Parameters.AddWithValue("Mahalle", mahalle);
                    cmd.Parameters.AddWithValue("Sokak", sokak);
                    cmd.Parameters.AddWithValue("Kapı_No", kapı_no);
                    #endregion
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();



                    kişi();
                    MessageBox.Show("Kayıt Ekleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Yanlış Bir İşlem Yapıldı, Sayfayı Kapatıp Açın ", "Dikkat");
                    MessageBox.Show("Kayıtları Kontrol Ediniz. ", "Dikkat");
                }
                if (aile_reis_btn.Checked == true)
                {


                    try
                    {
                        string sql_reis = "INSERT INTO reis_listesi(Kayıt_No,İl,İlçe,Mahalle,Sokak,Kapı_No,Tc_No, İsim, Soyisim,Cinsiyet,Dogum_Tarihi, Medeni_Durum,Meslek,Engel_Durumu,SGK_Durumu,Ev_Durumu,Aile_İçi_Konum,Telefon_No,Yardım_Öncelik_Derecesi,Baska_Yardım_VarMı,Kayıt_Tarihi)"
                           + "VALUES(@Kayıt_No,@İl,@İlçe,@Mahalle,@Sokak,@Kapı_No,@Tc_No,@İsim,@Soyisim,@Cinsiyet,@Dogum_Tarihi,@Medeni_Durum,@Meslek,@Engel_Durumu,@SGK_Durumu,@Ev_Durumu,@Aile_İçi_Konum,@Telefon_No,@Yardım_Öncelik_Derecesi,@Baska_Yardım_VarMı,@Kayıt_Tarihi)";
                        MySqlCommand komut = new MySqlCommand(sql_reis, con);
                        komut.Parameters.AddWithValue("Kayıt_No", kayıt_no);
                        komut.Parameters.AddWithValue("Kayıt_Tarihi", kayıt_tarihi);
                        komut.Parameters.AddWithValue("Tc_No", tcNO);
                        komut.Parameters.AddWithValue("İsim", isim);
                        komut.Parameters.AddWithValue("Soyisim", soyisim);
                        komut.Parameters.AddWithValue("Cinsiyet", cinsiyet);
                        komut.Parameters.AddWithValue("Dogum_Tarihi", doğum_tarihi);
                        komut.Parameters.AddWithValue("Medeni_Durum", medeni_durum);
                        komut.Parameters.AddWithValue("Engel_Durumu", engel_durum);
                        komut.Parameters.AddWithValue("Meslek", meslek);
                        komut.Parameters.AddWithValue("SGK_Durumu", sgk_durum);
                        komut.Parameters.AddWithValue("Ev_Durumu", ev_durum);
                        komut.Parameters.AddWithValue("Aile_İçi_Konum", aile_içi_konum);
                        komut.Parameters.AddWithValue("Telefon_No", tel);
                        komut.Parameters.AddWithValue("Yardım_Öncelik_Derecesi", yardım_derece);
                        komut.Parameters.AddWithValue("Baska_Yardım_VarMı", destek_durumu);
                        komut.Parameters.AddWithValue("İl", il);
                        komut.Parameters.AddWithValue("İlçe", ilçe);
                        komut.Parameters.AddWithValue("Mahalle", mahalle);
                        komut.Parameters.AddWithValue("Sokak", sokak);
                        komut.Parameters.AddWithValue("Kapı_No", kapı_no);
                        con.Open();
                        komut.ExecuteNonQuery();
                        con.Close();
                        reis_kişi();
                        MessageBox.Show("Reis Ekleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        a++;
                        syc = a.ToString();
                        File.WriteAllText(str, syc.ToString());
                        Dosya_Okuma();

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Yanlış Bir İşlem Yapıldı, Sayfayı Kapatıp Açın ", "Dikkat");
                        MessageBox.Show("Kayıtları Kontrol Ediniz. ", "Dikkat");
                    }
                }
                /// SAYAÇI 0 YAP /// SAYAÇI 0 YAP/// SAYAÇI 0 YAP/// SAYAÇI 0 YAP/// SAYAÇI 0 YAP
                else if (aile_bry_btn.Checked == true)
                {
                    try
                    {
                        string sql_birey = "INSERT INTO birey_listesi(Reis_No,Kayıt_No,İl,İlçe,Mahalle,Sokak,Kapı_No,Tc_No, İsim, Soyisim,Cinsiyet,Dogum_Tarihi, Medeni_Durum,Meslek,Engel_Durumu,SGK_Durumu,Ev_Durumu,Aile_İçi_Konum,Telefon_No,Yardım_Öncelik_Derecesi,Baska_Yardım_VarMı,Kayıt_Tarihi)"
                            + "VALUES(@Reis_No,@Kayıt_No,@İl,@İlçe,@Mahalle,@Sokak,@Kapı_No,@Tc_No,@İsim,@Soyisim,@Cinsiyet,@Dogum_Tarihi,@Medeni_Durum,@Meslek,@Engel_Durumu,@SGK_Durumu,@Ev_Durumu,@Aile_İçi_Konum,@Telefon_No,@Yardım_Öncelik_Derecesi,@Baska_Yardım_VarMı,@Kayıt_Tarihi)";
                        MySqlCommand command = new MySqlCommand(sql_birey, con);
                        command.Parameters.AddWithValue("Reis_No", sayaç_bry);
                        command.Parameters.AddWithValue("Kayıt_No", kayıt_no);
                        command.Parameters.AddWithValue("Kayıt_Tarihi", kayıt_tarihi);
                        command.Parameters.AddWithValue("Tc_No", tcNO);
                        command.Parameters.AddWithValue("İsim", isim);
                        command.Parameters.AddWithValue("Soyisim", soyisim);
                        command.Parameters.AddWithValue("Cinsiyet", cinsiyet);
                        command.Parameters.AddWithValue("Dogum_Tarihi", doğum_tarihi);
                        command.Parameters.AddWithValue("Medeni_Durum", medeni_durum);
                        command.Parameters.AddWithValue("Engel_Durumu", engel_durum);
                        command.Parameters.AddWithValue("Meslek", meslek);
                        command.Parameters.AddWithValue("SGK_Durumu", sgk_durum);
                        command.Parameters.AddWithValue("Ev_Durumu", ev_durum);
                        command.Parameters.AddWithValue("Aile_İçi_Konum", aile_içi_konum);
                        command.Parameters.AddWithValue("Telefon_No", tel);
                        command.Parameters.AddWithValue("Yardım_Öncelik_Derecesi", yardım_derece);
                        command.Parameters.AddWithValue("Baska_Yardım_VarMı", destek_durumu);
                        command.Parameters.AddWithValue("İl", il);
                        command.Parameters.AddWithValue("İlçe", ilçe);
                        command.Parameters.AddWithValue("Mahalle", mahalle);
                        command.Parameters.AddWithValue("Sokak", sokak);
                        command.Parameters.AddWithValue("Kapı_No", kapı_no);
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                        birey_kişi();
                        MessageBox.Show("Birey Ekleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Yanlış Bir İşlem Yapıldı, Sayfayı Kapatıp Açın ","Dikkat");
                        MessageBox.Show("Kayıtları Kontrol Ediniz. ","Dikkat");
                    }
                }
                else MessageBox.Show("Doldurulmamış Alan Var", "Uyarı");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            #region Silme Komutları
            tc_no_textBox.Clear();
            name_textBox.Clear();
            surname_textBox.Clear();
            tel_no_textBox.Clear();
            kayıt_no_text.Clear();
            sokak_text.Clear();
            kapı_text.Clear();
            aile_bry_btn.Checked = false;
            aile_reis_btn.Checked = false;
            sgk_evt_btn.Checked = false;
            sgk_hyr_btn.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            bekar_btn.Checked = false;
            evli_btn.Checked = false;
            dul_btn.Checked = false;
            cins_erk_btn.Checked = false;
            cins_kdn_btn.Checked = false;
            ev_kira_btn.Checked = false;
            ev_sahip_btn.Checked = false;
            ev_yok_btn.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            destek_evt_btn.Checked = false;
            destek_hyr_btn.Checked = false;
            button4.Enabled = false;
            dateTimePicker1.Refresh();
            #endregion
        }

        private void button5_Click(object sender, EventArgs e)
        {
            İhtiyaç_Sahibi_Database cn = new İhtiyaç_Sahibi_Database();
            cn.kayıt_tarihi = kayıt_tarihi;
            cn.tcNO = tcNO;
            cn.isim = isim;
            cn.soyisim = soyisim; 
            cn.yardım_derece = yardım_derece;
            cn.tel = tel;
            cn.ev_durum = ev_durum;
            cn.ev_tel = ev_tel;
            cn.medeni_durum = medeni_durum;
            cn.meslek = meslek;
            cn.il = il;
            cn.ilçe = ilçe;
            cn.mahalle = mahalle;
            cn.sokak = sokak;
            cn.kapı_no = kapı_no;
            cn.cinsiyet = cinsiyet;
            cn.sgk_durum = sgk_durum;
            cn.aile_içi_konum = aile_içi_konum;
            cn.destek_durumu = destek_durumu;
            cn.engel_durumu = engel_durum;
            cn.dogum_tarihi = doğum_tarihi;
            cn.Show();
            Yardım_Liste yar_lst = new Yardım_Liste();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

////create table ihtiyac_sahibi_kayıt(
//Kayıt_No int not null Primary key AUTO_INCREMENT,
//Tc_No bigint  NOT NULL,
//İsim varchar(20) not null,
//Soyisim varchar(20)not null,
//Yaş INT not null,
//Cinsiyet varchar(10) not null,
//Medeni_Durum varchar(10) not null,
//Meslek varchar(20) not null,
//SGK_Durumu varchar(10) NOT NULL,
//Ev_Durumu varchar(10) NOT NULL,
//Aile_İçi_Konum varchar(10) NOT NULL,
//Telefon_No bigint Not null,
//Ev_Telefon_No bigint not null,
//Yardım_Miktarı int,
//Yardım_Türü varchar(10) NOT NULL,
//Yardım_Öncelik_Derecesi INT Not null,
//Baska_Yardım_VarMı varchar(10) not null,
//Adres varchar(100) NOT NULL,
//Kayıt_Tarihi date Not null
//);
