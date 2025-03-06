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
    public partial class Üye_Aidat_Takip : Form
    {
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=dernek;Uid=root;Pwd=0123456789");
        DataTable dt;
        public string ad, soyad, miktar, tarih;

        public Üye_Aidat_Takip()
        {
            InitializeComponent();
        }
        public void aidat()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("SELECT * from üye_aidat_takip", con);
            dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            con.Close();
        }
        private void Üye_Aidat_Takip_Load(object sender, EventArgs e)
        {
            aidat();
            this.WindowState = FormWindowState.Maximized;
            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;


        }

        public void Toplam_Yardım_Aidat()
        {
            string yardım = "select sum(aidat_miktarı) as toplam from üye_aidat_takip where tür='Yardım'";
            string aidat = "select sum(aidat_miktarı) as toplam from üye_aidat_takip where tür='Aidat'";



            MySqlCommand mySqlCommand = new MySqlCommand(yardım, con);
            MySqlCommand mySqlComman = new MySqlCommand(aidat, con);
            try
            {
                con.Open();

                object result = mySqlCommand.ExecuteScalar();
                object res = mySqlComman.ExecuteScalar();

                if ((result != null) && (res != null))
                {
                    textBox2.Text = result.ToString();
                    textBox3.Text = res.ToString();
                }
                else
                {
                    textBox2.Text = "0";
                    textBox3.Text = "0";
                    MessageBox.Show("Toplanılacak Veri Yok");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından Bilgi Alınamadı: " + ex.Message);
            }
            con.Close();


        }
        public void Tar_Aidat_Yardım()
        {
            DateTime baş_tar = dateTimePicker1.Value;
            DateTime bit_tar = dateTimePicker2.Value;
            string tarih_yardım = "Select sum(aidat_miktarı) as toplam from üye_aidat_takip where tür='Yardım' and aidat_tarihi between DATE_SUB(@baş,INTERVAL 1 DAY) and @bit";
            string tarih_aidat = "Select sum(aidat_miktarı) as toplam from üye_aidat_takip where tür='Aidat' and aidat_tarihi between DATE_SUB(@baş,INTERVAL 1 DAY) and @bit";
            string tarih_tam = "Select sum(aidat_miktarı) as toplam from üye_aidat_takip where aidat_tarihi between DATE_SUB(@baş,INTERVAL 1 DAY) and @bit";
            MySqlCommand cmd = new MySqlCommand(tarih_yardım, con);
            MySqlCommand comma = new MySqlCommand(tarih_aidat, con);
            MySqlCommand tamco = new MySqlCommand(tarih_tam, con);
            cmd.Parameters.AddWithValue("@baş", baş_tar);
            cmd.Parameters.AddWithValue("@bit", bit_tar);
            comma.Parameters.AddWithValue("@baş", baş_tar);
            comma.Parameters.AddWithValue("@bit", bit_tar);
            tamco.Parameters.AddWithValue("@baş", baş_tar);
            tamco.Parameters.AddWithValue("@bit", bit_tar);
            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                object res = comma.ExecuteScalar();
                object restam = tamco.ExecuteScalar();
                if (radioButton1.Checked == true)
                {
                    textBox4.Text = result.ToString();
                }
                if (radioButton2.Checked == true)
                {
                    textBox4.Text = res.ToString();
                }
                if (radioButton3.Checked == true)
                {
                    textBox4.Text = restam.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından bilgi alınamadı " + ex.Message);
            }
            con.Close();

        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ad = dataGridView1.CurrentRow.Cells[0].ToString();
                soyad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                miktar = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tarih = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isim_btn.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "ad_soyad LIKE '" + textBox1.Text + "%'";
                dataGridView1.DataSource = dv;
            }

            if (miktar_btn.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("convert(aidat_miktarı,'System.String')LIKE'%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv;

            }
        }


        private void yrdm_btn_CheckedChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "tür LIKE'" + "Yardım" + "%'";
            dataGridView1.DataSource = dv;
        }

        private void aidat_btn_CheckedChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "tür LIKE'" + "Aidat" + "%'";
            dataGridView1.DataSource = dv;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Tar_Aidat_Yardım();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Toplam_Yardım_Aidat();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime _baş_tar = dateTimePicker4.Value;
            DateTime _bit_tar = dateTimePicker3.Value;
            if (dateTimePicker3.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"aidat_tarihi >= '{_baş_tar.ToString("yyyy-MM-dd")}' AND aidat_tarihi <= '{_bit_tar.ToString("yyyy-MM-dd")}'";
                dataGridView1.DataSource = dv;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult res1 = MessageBox.Show(textBox5.Text + " İsimli Kaydı Silmek İstiyormusunuz? ", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (res1 == DialogResult.Yes)
            {
                if (radioButton4.Checked == true)
                {
                    try
                    {
                        string sql = ("DELETE FROM üye_aidat_takip WHERE ad_soyad=@ad_soyad");
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("ad_soyad", textBox5.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        aidat();
                        MessageBox.Show("Kayıt Silme Başaralı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + "Hatalı İşlem yaptınız.\n Kayıtları kontrol ediniz", "Dikkat");
                    }
                }
                if (radioButton5.Checked == true)
                {
                    try
                    {
                        string sql = ("DELETE FROM üye_aidat_takip WHERE aidat_id=@aidat_id");
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("aidat_id", textBox5.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        aidat();
                        MessageBox.Show("Kayıt Silme Başaralı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + "Hatalı İşlem yaptınız.\n Kayıtları kontrol ediniz", "Dikkat");
                    }
                }
            }
            else { }
        }
    }
}

