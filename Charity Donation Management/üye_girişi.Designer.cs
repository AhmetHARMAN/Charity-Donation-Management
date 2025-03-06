namespace dernek
{
    partial class üye_girişi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(üye_girişi));
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            onay_btn = new Button();
            üye_btn = new Button();
            çıkış_btn = new Button();
            giris_btn = new Button();
            kod_text = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(onay_btn);
            panel1.Controls.Add(üye_btn);
            panel1.Controls.Add(çıkış_btn);
            panel1.Controls.Add(giris_btn);
            panel1.Controls.Add(kod_text);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(693, 342);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 356);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(310, -2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // onay_btn
            // 
            onay_btn.Location = new Point(371, 204);
            onay_btn.Name = "onay_btn";
            onay_btn.Size = new Size(79, 30);
            onay_btn.TabIndex = 5;
            onay_btn.Text = "Onayla";
            onay_btn.UseVisualStyleBackColor = true;
            onay_btn.Click += onay_btn_Click;
            // 
            // üye_btn
            // 
            üye_btn.Enabled = false;
            üye_btn.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            üye_btn.Location = new Point(344, 279);
            üye_btn.Name = "üye_btn";
            üye_btn.Size = new Size(111, 59);
            üye_btn.TabIndex = 4;
            üye_btn.Text = "YENİ ÜYE KAYDI";
            üye_btn.UseVisualStyleBackColor = true;
            üye_btn.Click += üye_btn_Click;
            // 
            // çıkış_btn
            // 
            çıkış_btn.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            çıkış_btn.Location = new Point(211, 279);
            çıkış_btn.Name = "çıkış_btn";
            çıkış_btn.Size = new Size(111, 59);
            çıkış_btn.TabIndex = 3;
            çıkış_btn.Text = "ÇIKIŞ";
            çıkış_btn.UseVisualStyleBackColor = true;
            çıkış_btn.Click += çıkış_btn_Click;
            // 
            // giris_btn
            // 
            giris_btn.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            giris_btn.Location = new Point(80, 279);
            giris_btn.Name = "giris_btn";
            giris_btn.Size = new Size(111, 59);
            giris_btn.TabIndex = 2;
            giris_btn.Text = "GİRİŞ";
            giris_btn.UseVisualStyleBackColor = true;
            giris_btn.Click += giris_btn_Click;
            // 
            // kod_text
            // 
            kod_text.Location = new Point(166, 207);
            kod_text.Name = "kod_text";
            kod_text.PasswordChar = '*';
            kod_text.Size = new Size(187, 27);
            kod_text.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 152);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 207);
            label3.Name = "label3";
            label3.Size = new Size(160, 28);
            label3.TabIndex = 0;
            label3.Text = "Yeni Kayıt Kodu:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 147);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 99);
            label4.Name = "label4";
            label4.Size = new Size(126, 28);
            label4.TabIndex = 0;
            label4.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 43);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "ÜYE GİRİŞİ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(366, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1181, 260);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // üye_girişi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1505, 813);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "üye_girişi";
            Text = "Üye Girişi";
            Load += üye_girişi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button üye_btn;
        private Button çıkış_btn;
        private Button giris_btn;
        private TextBox kod_text;
        private Label label3;
        private Button onay_btn;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private PictureBox pictureBox1;
    }
}