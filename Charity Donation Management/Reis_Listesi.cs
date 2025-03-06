using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace dernek
{
    public partial class Reis_Listesi : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=dernek;Uid=root;Pwd=0123456789");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt,dh;
        public Reis_Listesi()
        {
            InitializeComponent();
        }

        private void Reis_Listesi_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            panel1.Location = new Point(
    this.ClientSize.Width / 2 - panel1.Size.Width / 2,
    this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            reis_kişi();
            
        }
        public void reis_kişi()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("Select * from reis_listesi", con);
            dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            con.Close();
        }
        
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

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
            if (ilçe_btn.Checked == true)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "İlçe LIKE'" + textBox1.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            if (mahalle_btn.Checked == true)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Birey_Listesi bry = new Birey_Listesi();
            bry.Show();
        }

      
    }
}
