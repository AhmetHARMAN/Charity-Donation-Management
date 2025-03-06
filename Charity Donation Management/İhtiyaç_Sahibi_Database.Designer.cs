namespace dernek
{
    partial class İhtiyaç_Sahibi_Database
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İhtiyaç_Sahibi_Database));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            tc_btn = new RadioButton();
            isim_btn = new RadioButton();
            soyisim_btn = new RadioButton();
            panel1 = new Panel();
            panel3 = new Panel();
            birey_btn = new RadioButton();
            reis_btn = new RadioButton();
            ilçe_btn = new RadioButton();
            il_btn = new RadioButton();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1917, 216);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 47;
            label1.Text = "Arama";
            // 
            // tc_btn
            // 
            tc_btn.AutoSize = true;
            tc_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            tc_btn.Location = new Point(281, 15);
            tc_btn.Name = "tc_btn";
            tc_btn.Size = new Size(155, 24);
            tc_btn.TabIndex = 48;
            tc_btn.TabStop = true;
            tc_btn.Text = "T.C ye Göre Arama";
            tc_btn.UseVisualStyleBackColor = true;
            // 
            // isim_btn
            // 
            isim_btn.AutoSize = true;
            isim_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            isim_btn.Location = new Point(455, 15);
            isim_btn.Name = "isim_btn";
            isim_btn.Size = new Size(148, 24);
            isim_btn.TabIndex = 48;
            isim_btn.TabStop = true;
            isim_btn.Text = "İsme Göre Arama";
            isim_btn.UseVisualStyleBackColor = true;
            // 
            // soyisim_btn
            // 
            soyisim_btn.AutoSize = true;
            soyisim_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            soyisim_btn.Location = new Point(606, 15);
            soyisim_btn.Name = "soyisim_btn";
            soyisim_btn.Size = new Size(172, 24);
            soyisim_btn.TabIndex = 49;
            soyisim_btn.TabStop = true;
            soyisim_btn.Text = "Soyisme Göre Arama";
            soyisim_btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(ilçe_btn);
            panel1.Controls.Add(il_btn);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(tc_btn);
            panel1.Controls.Add(soyisim_btn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(isim_btn);
            panel1.Location = new Point(536, 599);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 120);
            panel1.TabIndex = 50;
            // 
            // panel3
            // 
            panel3.Controls.Add(birey_btn);
            panel3.Controls.Add(reis_btn);
            panel3.Location = new Point(5, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 35);
            panel3.TabIndex = 55;
            // 
            // birey_btn
            // 
            birey_btn.AutoSize = true;
            birey_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            birey_btn.Location = new Point(170, 6);
            birey_btn.Name = "birey_btn";
            birey_btn.Size = new Size(129, 24);
            birey_btn.TabIndex = 54;
            birey_btn.TabStop = true;
            birey_btn.Text = "Bireyleri Sırala";
            birey_btn.UseVisualStyleBackColor = true;
            birey_btn.CheckedChanged += birey_btn_CheckedChanged;
            // 
            // reis_btn
            // 
            reis_btn.AutoSize = true;
            reis_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            reis_btn.Location = new Point(12, 6);
            reis_btn.Name = "reis_btn";
            reis_btn.Size = new Size(121, 24);
            reis_btn.TabIndex = 53;
            reis_btn.TabStop = true;
            reis_btn.Text = "Reisleri Sırala";
            reis_btn.UseVisualStyleBackColor = true;
            reis_btn.CheckedChanged += reis_btn_CheckedChanged;
            // 
            // ilçe_btn
            // 
            ilçe_btn.AutoSize = true;
            ilçe_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            ilçe_btn.Location = new Point(455, 43);
            ilçe_btn.Name = "ilçe_btn";
            ilçe_btn.Size = new Size(187, 24);
            ilçe_btn.TabIndex = 52;
            ilçe_btn.TabStop = true;
            ilçe_btn.Text = "Mahalleye Göre Arama";
            ilçe_btn.UseVisualStyleBackColor = true;
            // 
            // il_btn
            // 
            il_btn.AutoSize = true;
            il_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            il_btn.Location = new Point(281, 43);
            il_btn.Name = "il_btn";
            il_btn.Size = new Size(156, 24);
            il_btn.TabIndex = 51;
            il_btn.TabStop = true;
            il_btn.Text = "İlçeye Göre Arama";
            il_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 27);
            textBox1.TabIndex = 50;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(776, 523);
            label2.Name = "label2";
            label2.Size = new Size(298, 41);
            label2.TabIndex = 52;
            label2.Text = "İhtiyaç Sahibi Arama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(765, 220);
            label4.Name = "label4";
            label4.Size = new Size(360, 50);
            label4.TabIndex = 52;
            label4.Text = "İhtiyaç Sahibi Listesi";
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(3, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(1949, 719);
            panel2.TabIndex = 53;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(1517, 615);
            button2.Name = "button2";
            button2.Size = new Size(131, 77);
            button2.TabIndex = 54;
            button2.Text = "Kayıt Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(1729, 615);
            button1.Name = "button1";
            button1.Size = new Size(131, 77);
            button1.TabIndex = 53;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // İhtiyaç_Sahibi_Database
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1977, 1028);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "İhtiyaç_Sahibi_Database";
            Text = "İhtiyaç Sahibi Listesi";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private RadioButton tc_btn;
        private RadioButton isim_btn;
        private RadioButton soyisim_btn;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private RadioButton ilçe_btn;
        private RadioButton il_btn;
        private Panel panel2;
        private Button button1;
        private RadioButton birey_btn;
        private RadioButton reis_btn;
        private Button button2;
        private Panel panel3;
    }
}