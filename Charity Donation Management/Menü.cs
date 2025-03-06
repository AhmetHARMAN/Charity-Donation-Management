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



        private void yard�m_kay�t_Click(object sender, EventArgs e)
        {
            Yard�m_Ekleme yar_ekl = new Yard�m_Ekleme();
            yar_ekl.Show();
        }

        private void ihtiya�_kay�t_Click(object sender, EventArgs e)
        {

            Ki�i_Ekleme ge�i� = new Ki�i_Ekleme();
            ge�i�.Show();
        }

        private void �ye_kyt_bnt_Click(object sender, EventArgs e)
        {
            �ye_Listesi �y_lst = new �ye_Listesi();
            �y_lst.Show();
        }

        private void yard�m_lst_btn_Click(object sender, EventArgs e)
        {
            Yard�m_Liste cn = new Yard�m_Liste();
            cn.Show();
        }

        private void aidat_kyt_btn_Click(object sender, EventArgs e)
        {
            �ye_Aidat_Kay�t �y_kay = new �ye_Aidat_Kay�t();
            �y_kay.Show();
        }




        private void �ye_aidat_btn_Click_1(object sender, EventArgs e)
        {
            �ye_Aidat_Takip �y_tkp = new �ye_Aidat_Takip();
            �y_tkp.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            �ye_kay�t_form �ye_kay�t = new �ye_kay�t_form();
            �ye_kay�t.Show();
        }

        private void ihtiyat_lst_btn_Click(object sender, EventArgs e)
        {
            �htiya�_Sahibi_Database cn = new �htiya�_Sahibi_Database();
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
