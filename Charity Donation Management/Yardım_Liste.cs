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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dernek
{
    public partial class Yardım_Liste : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=dernek;Uid=root;Pwd=0123456789");
        MySqlConnection bal = new MySqlConnection("Server=localhost;Database=dernek;Uid=root;Pwd=0123456789");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public string isim_soyisim, yardım_tarih, yardım_tür, yardım_miktar;
        string baş_tar, bit_tar;
        public Yardım_Liste()
        {
            InitializeComponent();
        }
        public void data_read()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("select*from ihtiyac_sahibi_yardım", con);
            dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            con.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            isim_soyisim = dataGridView1.CurrentRow.Cells[0].ToString();
            yardım_tarih = dataGridView1.CurrentRow.Cells[1].ToString();
            yardım_miktar = dataGridView1.CurrentRow.Cells[2].ToString();
            yardım_tür = dataGridView1.CurrentRow.Cells[3].ToString();

        }

        private void Yardım_Liste_Load(object sender, EventArgs e)
        {
            data_read();
            this.WindowState = FormWindowState.Maximized;

            panel1.Location = new Point(
    this.ClientSize.Width / 2 - panel1.Size.Width / 2,
    this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (isim_btn.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "İsim LIKE '" + textBox1.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            if (soyisim_btn.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "Soyisim LIKE '" + textBox1.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            if (mik_btn.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("convert(Yardım_Miktarı,'System.String')LIKE'%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv;
            }
            if (tür_gıda_btn.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "Yardım_Türü LIKE '" + textBox1.Text + "%'";
                dataGridView1.DataSource = dv;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Toplam_Yardım()
        {

            string yardım = "select sum(Yardım_miktarı) as toplam from ihtiyac_sahibi_yardım";
            string nakdi_yardım = "select sum(Yardım_miktarı) as toplam from ihtiyac_sahibi_yardım where Yardım_Türü = 'Nakdi'";
            string gıda_yardım = "select sum(Yardım_miktarı) as toplam from ihtiyac_sahibi_yardım where Yardım_Türü = 'Gıda'";


            MySqlCommand mySqlCommand = new MySqlCommand(yardım, con);
            MySqlCommand mySqlComman = new MySqlCommand(nakdi_yardım, con);
            MySqlCommand mySqlCmd = new MySqlCommand(gıda_yardım, con);


            try
            {
                con.Open();

                object result = mySqlCommand.ExecuteScalar();
                object n_res = mySqlComman.ExecuteScalar();
                object g_res = mySqlCmd.ExecuteScalar();



                if ((result != null) && (n_res != null) && (g_res != null))
                {
                    textBox2.Text = result.ToString();
                    textBox4.Text = n_res.ToString();
                    textBox3.Text = g_res.ToString();

                }
                else
                {
                    textBox2.Text = "0";

                    MessageBox.Show("Toplanılacak Veri Yok");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından Bilgi Alınamadı: " + ex.Message);
            }
            con.Close();


        }
        public void Tar_Yar()
        {
            DateTime baş_tar = dateTimePicker1.Value;
            DateTime bit_tar = dateTimePicker2.Value;
            string nakdi_tar_yardım = "select sum(Yardım_miktarı) as toplam from ihtiyac_sahibi_yardım where Yardım_Türü = 'Nakdi' and Yardım_Tarihi between DATE_SUB(@baş,INTERVAL 1 DAY) and @bit";
            string gıda_tar_yardım = "select sum(Yardım_miktarı) as toplam from ihtiyac_sahibi_yardım where Yardım_Türü = 'Gıda' and Yardım_Tarihi between DATE_SUB(@baş,INTERVAL 1 DAY) and @bit";
            string tam_yardım = "select sum(Yardım_miktarı) as toplam from ihtiyac_sahibi_yardım where Yardım_Tarihi between DATE_SUB(@baş,INTERVAL 1 DAY) and @bit";
            MySqlCommand tar_g_cmd = new MySqlCommand(gıda_tar_yardım, con);
            MySqlCommand tar_n_cmd = new MySqlCommand(nakdi_tar_yardım, con);
            MySqlCommand tam_cmd = new MySqlCommand(tam_yardım, con);
            tar_g_cmd.Parameters.AddWithValue("@baş", baş_tar);
            tar_g_cmd.Parameters.AddWithValue("@bit", bit_tar);
            tar_n_cmd.Parameters.AddWithValue("@baş", baş_tar);
            tar_n_cmd.Parameters.AddWithValue("@bit", bit_tar);
            tam_cmd.Parameters.AddWithValue("@baş", baş_tar);
            tam_cmd.Parameters.AddWithValue("@bit", bit_tar);

            try
            {
                con.Open();
                object t_g = tar_g_cmd.ExecuteScalar();
                object t_n = tar_n_cmd.ExecuteScalar();
                object t_m = tam_cmd.ExecuteScalar();

                if (radioButton1.Checked == true)
                {
                    textBox5.Text = t_n.ToString();
                }
                if (radioButton2.Checked == true)
                {
                    textBox5.Text = t_g.ToString();
                }
                if (radioButton3.Checked == true)
                {
                    textBox5.Text = t_m.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            con.Close();
        }





        private void button2_Click(object sender, EventArgs e)
        {
            Toplam_Yardım();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tar_Yar();
        }

        private void tür_gıda_btn_CheckedChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Yardım_Türü LIKE'" + "Gıda" + "%'";
            dataGridView1.DataSource = dv;
        }

        private void tür_nakdi_btn_CheckedChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Yardım_Türü LIKE'" + "Nakdi" + "%'";
            dataGridView1.DataSource = dv;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime _baş_tar = dateTimePicker4.Value;
            DateTime _bit_tar = dateTimePicker3.Value;
            if (dateTimePicker3.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Yardım_Tarihi >= '{_baş_tar.ToString("yyyy-MM-dd")}' AND Yardım_Tarihi <= '{_bit_tar.ToString("yyyy-MM-dd")}'";
                dataGridView1.DataSource = dv;
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult res1 = MessageBox.Show(textBox6.Text + " İsimli Kaydı Silmek İstiyormusunuz? ", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (res1 == DialogResult.Yes)
            {
                if (radioButton4.Checked == true)
                {
                    try
                    {
                        string sql = ("DELETE FROM ihtiyac_sahibi_yardım WHERE İsim=@İsim");
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("İsim", textBox6.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        data_read();
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
                        string sql = ("DELETE FROM ihtiyac_sahibi_yardım WHERE  Kayıt_No=@Kayıt_No");
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("Kayıt_no", textBox6.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        data_read();
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
