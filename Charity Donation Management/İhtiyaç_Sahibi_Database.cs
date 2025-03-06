using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dernek
{
    public partial class İhtiyaç_Sahibi_Database : Form
    {
        public string kayıt_tarihi, tcNO, isim, soyisim, yaş, cinsiyet, dogum_tarihi,
            medeni_durum, meslek, engel_durumu, sgk_durum, ev_durum, aile_içi_konum
            , tel, ev_tel, yardım_miktarı, yardım_türü, yardım_derece
            , destek_durumu, adres, yardım_tarihi,
            il, ilçe, mahalle, sokak, kapı_no;

        MySqlConnection con = new MySqlConnection("Server=localhost;Database=dernek;Uid=root;Pwd=0123456789");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public void kişi()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM ihtiyac_sahibi_kayıt", con);
            dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            con.Close();
        }

        public İhtiyaç_Sahibi_Database()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kişi();
            this.WindowState = FormWindowState.Maximized;
            panel2.Location = new Point(
    this.ClientSize.Width / 2 - panel2.Size.Width / 2,
    this.ClientSize.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    //Kayıt_No = AUTO_İNCREMENT;
            //    kayıt_tarihi = dataGridView1.CurrentRow.Cells[1].ToString();
            //    tcNO = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //    isim = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //    soyisim = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //    yaş = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //    cinsiyet = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //    medeni_durum = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //    meslek = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //    sgk_durum = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //    ev_durum = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            //    aile_içi_konum = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            //    tel = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            //    ev_tel = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            //    yardım_derece = dataGridView1.CurrentRow.Cells[14].ToString();
            //    destek_durumu = dataGridView1.CurrentRow.Cells[15].ToString();
            //    adres = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
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
            if (tc_btn.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("convert(Tc_No,'System.String')LIKE'%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv;

            }
            if (il_btn.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "İlçe LIKE'" + textBox1.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            if (ilçe_btn.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "Mahalle LIKE'" + textBox1.Text + "%'";
                dataGridView1.DataSource = dv;
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reis_btn_CheckedChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Aile_İçi_Konum LIKE'" + "Reis" + "%'";
            dataGridView1.DataSource = dv;
        }

        private void birey_btn_CheckedChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Aile_İçi_Konum LIKE'" + "Birey" + "%'";
            dataGridView1.DataSource = dv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res1 = MessageBox.Show("Kayıt Silmek İstiyormusunuz? ", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (res1 == DialogResult.Yes)
            {
                string sql = ("DELETE FROM ihtiyac_sahibi_kayıt WHERE Tc_No=@Tc_No");
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("Tc_No", textBox1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                kişi();
                MessageBox.Show("Kayıt Silme Başaralı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else { }
        }
    }
}
