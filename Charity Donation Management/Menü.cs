using System.Windows.Forms;

namespace dernek
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            panel1.Location = new Point(
    this.ClientSize.Width / 2 - panel1.Size.Width / 2,
    this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

        }



        private void yardým_kayýt_Click(object sender, EventArgs e)
        {
            Yardým_Ekleme yar_ekl = new Yardým_Ekleme();
            yar_ekl.Show();
        }

        private void ihtiyaç_kayýt_Click(object sender, EventArgs e)
        {

            Kiþi_Ekleme geçiþ = new Kiþi_Ekleme();
            geçiþ.Show();
        }

        private void üye_kyt_bnt_Click(object sender, EventArgs e)
        {
            Üye_Listesi üy_lst = new Üye_Listesi();
            üy_lst.Show();
        }

        private void yardým_lst_btn_Click(object sender, EventArgs e)
        {
            Yardým_Liste cn = new Yardým_Liste();
            cn.Show();
        }

        private void aidat_kyt_btn_Click(object sender, EventArgs e)
        {
            Üye_Aidat_Kayýt üy_kay = new Üye_Aidat_Kayýt();
            üy_kay.Show();
        }




        private void üye_aidat_btn_Click_1(object sender, EventArgs e)
        {
            Üye_Aidat_Takip üy_tkp = new Üye_Aidat_Takip();
            üy_tkp.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            üye_kayýt_form üye_kayýt = new üye_kayýt_form();
            üye_kayýt.Show();
        }

        private void ihtiyat_lst_btn_Click(object sender, EventArgs e)
        {
            Ýhtiyaç_Sahibi_Database cn = new Ýhtiyaç_Sahibi_Database();
            cn.Show();
        }

        private void reis_button_Click(object sender, EventArgs e)
        {
            Reis_Listesi reis = new Reis_Listesi();
            reis.Show();
        }

        private void birey_button_Click(object sender, EventArgs e)
        {
            Birey_Listesi birey = new Birey_Listesi();
            birey.Show();
        }
    }
}
