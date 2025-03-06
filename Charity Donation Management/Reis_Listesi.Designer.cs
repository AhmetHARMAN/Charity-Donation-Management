namespace dernek
{
    partial class Reis_Listesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reis_Listesi));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            mahalle_btn = new RadioButton();
            ilçe_btn = new RadioButton();
            textBox1 = new TextBox();
            tc_btn = new RadioButton();
            soyisim_btn = new RadioButton();
            label1 = new Label();
            isim_btn = new RadioButton();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(1913, 1011);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(1503, 565);
            button2.Name = "button2";
            button2.Size = new Size(138, 67);
            button2.TabIndex = 56;
            button2.Text = "Birey Listesi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(1684, 565);
            button1.Name = "button1";
            button1.Size = new Size(138, 67);
            button1.TabIndex = 55;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(897, 26);
            label3.Name = "label3";
            label3.Size = new Size(234, 41);
            label3.TabIndex = 54;
            label3.Text = "Aile Reisi Listesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(887, 416);
            label2.Name = "label2";
            label2.Size = new Size(240, 41);
            label2.TabIndex = 54;
            label2.Text = "Aile Reisi Arama";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(mahalle_btn);
            panel2.Controls.Add(ilçe_btn);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(tc_btn);
            panel2.Controls.Add(soyisim_btn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(isim_btn);
            panel2.Location = new Point(592, 498);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 81);
            panel2.TabIndex = 53;
            // 
            // mahalle_btn
            // 
            mahalle_btn.AutoSize = true;
            mahalle_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            mahalle_btn.Location = new Point(455, 49);
            mahalle_btn.Name = "mahalle_btn";
            mahalle_btn.Size = new Size(187, 24);
            mahalle_btn.TabIndex = 53;
            mahalle_btn.TabStop = true;
            mahalle_btn.Text = "Mahalleye Göre Arama";
            mahalle_btn.UseVisualStyleBackColor = true;
            // 
            // ilçe_btn
            // 
            ilçe_btn.AutoSize = true;
            ilçe_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            ilçe_btn.Location = new Point(294, 49);
            ilçe_btn.Name = "ilçe_btn";
            ilçe_btn.Size = new Size(156, 24);
            ilçe_btn.TabIndex = 52;
            ilçe_btn.TabStop = true;
            ilçe_btn.Text = "İlçeye Göre Arama";
            ilçe_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 27);
            textBox1.TabIndex = 50;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tc_btn
            // 
            tc_btn.AutoSize = true;
            tc_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            tc_btn.Location = new Point(294, 19);
            tc_btn.Name = "tc_btn";
            tc_btn.Size = new Size(155, 24);
            tc_btn.TabIndex = 48;
            tc_btn.TabStop = true;
            tc_btn.Text = "T.C ye Göre Arama";
            tc_btn.UseVisualStyleBackColor = true;
            // 
            // soyisim_btn
            // 
            soyisim_btn.AutoSize = true;
            soyisim_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            soyisim_btn.Location = new Point(606, 19);
            soyisim_btn.Name = "soyisim_btn";
            soyisim_btn.Size = new Size(172, 24);
            soyisim_btn.TabIndex = 49;
            soyisim_btn.TabStop = true;
            soyisim_btn.Text = "Soyisme Göre Arama";
            soyisim_btn.UseVisualStyleBackColor = true;
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
            // isim_btn
            // 
            isim_btn.AutoSize = true;
            isim_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            isim_btn.Location = new Point(455, 19);
            isim_btn.Name = "isim_btn";
            isim_btn.Size = new Size(148, 24);
            isim_btn.TabIndex = 48;
            isim_btn.TabStop = true;
            isim_btn.Text = "İsme Göre Arama";
            isim_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1917, 265);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // Reis_Listesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1924, 1105);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Reis_Listesi";
            Text = "Aile Reisi Listesi";
            Load += Reis_Listesi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label2;
        private Panel panel2;
        private RadioButton ilçe_btn;
        private TextBox textBox1;
        private RadioButton tc_btn;
        private RadioButton soyisim_btn;
        private Label label1;
        private RadioButton isim_btn;
        private Label label3;
        private RadioButton mahalle_btn;
        private Button button1;
        private Button button2;
    }
}