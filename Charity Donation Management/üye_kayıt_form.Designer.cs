namespace dernek
{
    partial class üye_kayıt_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(üye_kayıt_form));
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label7 = new Label();
            üye_no_text = new TextBox();
            soyisim_text = new TextBox();
            tc_txt = new TextBox();
            adres_text = new TextBox();
            label11 = new Label();
            job_text = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            çık_btn = new Button();
            ekle_btn = new Button();
            memleket_box = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            name_txt = new TextBox();
            tel_no_text = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label9 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label1.Location = new Point(349, 115);
            label1.Name = "label1";
            label1.Size = new Size(42, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label2.Location = new Point(545, 115);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 0;
            label2.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label5.Location = new Point(349, 193);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 0;
            label5.Text = "Meslek:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label7.Location = new Point(35, 277);
            label7.Name = "label7";
            label7.Size = new Size(117, 28);
            label7.TabIndex = 0;
            label7.Text = "Telefon No:";
            // 
            // üye_no_text
            // 
            üye_no_text.BackColor = SystemColors.ControlLightLight;
            üye_no_text.Location = new Point(520, 368);
            üye_no_text.Multiline = true;
            üye_no_text.Name = "üye_no_text";
            üye_no_text.Size = new Size(104, 28);
            üye_no_text.TabIndex = 1;
            // 
            // soyisim_text
            // 
            soyisim_text.BackColor = SystemColors.ControlLightLight;
            soyisim_text.Location = new Point(623, 115);
            soyisim_text.Multiline = true;
            soyisim_text.Name = "soyisim_text";
            soyisim_text.Size = new Size(104, 28);
            soyisim_text.TabIndex = 1;
            // 
            // tc_txt
            // 
            tc_txt.BackColor = SystemColors.ControlLightLight;
            tc_txt.Location = new Point(122, 115);
            tc_txt.Multiline = true;
            tc_txt.Name = "tc_txt";
            tc_txt.Size = new Size(116, 28);
            tc_txt.TabIndex = 1;
            // 
            // adres_text
            // 
            adres_text.BackColor = SystemColors.ControlLightLight;
            adres_text.Location = new Point(122, 368);
            adres_text.Multiline = true;
            adres_text.Name = "adres_text";
            adres_text.Size = new Size(188, 95);
            adres_text.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label11.Location = new Point(349, 368);
            label11.Name = "label11";
            label11.Size = new Size(145, 28);
            label11.TabIndex = 0;
            label11.Text = "Üye Numarası:";
            // 
            // job_text
            // 
            job_text.BackColor = SystemColors.ControlLightLight;
            job_text.Location = new Point(437, 193);
            job_text.Multiline = true;
            job_text.Name = "job_text";
            job_text.Size = new Size(104, 28);
            job_text.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(çık_btn);
            panel1.Controls.Add(ekle_btn);
            panel1.Controls.Add(memleket_box);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(tc_txt);
            panel1.Controls.Add(name_txt);
            panel1.Controls.Add(soyisim_text);
            panel1.Controls.Add(job_text);
            panel1.Controls.Add(tel_no_text);
            panel1.Controls.Add(adres_text);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(üye_no_text);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(527, 250);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 591);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(301, 514);
            button1.Name = "button1";
            button1.Size = new Size(164, 76);
            button1.TabIndex = 12;
            button1.Text = "Formu Temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // çık_btn
            // 
            çık_btn.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            çık_btn.ForeColor = Color.Red;
            çık_btn.Location = new Point(712, 514);
            çık_btn.Name = "çık_btn";
            çık_btn.Size = new Size(164, 76);
            çık_btn.TabIndex = 11;
            çık_btn.Text = "Çıkış";
            çık_btn.UseVisualStyleBackColor = true;
            çık_btn.Click += çık_btn_Click;
            // 
            // ekle_btn
            // 
            ekle_btn.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ekle_btn.Location = new Point(506, 514);
            ekle_btn.Name = "ekle_btn";
            ekle_btn.Size = new Size(164, 76);
            ekle_btn.TabIndex = 10;
            ekle_btn.Text = "Ekle";
            ekle_btn.UseVisualStyleBackColor = true;
            ekle_btn.Click += ekle_btn_Click;
            // 
            // memleket_box
            // 
            memleket_box.DropDownHeight = 100;
            memleket_box.FormattingEnabled = true;
            memleket_box.IntegralHeight = false;
            memleket_box.Location = new Point(473, 277);
            memleket_box.MaxDropDownItems = 3;
            memleket_box.Name = "memleket_box";
            memleket_box.Size = new Size(151, 28);
            memleket_box.TabIndex = 8;
            memleket_box.TextChanged += memleket_box_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(349, 32);
            label6.Name = "label6";
            label6.Size = new Size(147, 41);
            label6.TabIndex = 7;
            label6.Text = "Üye Kayıt";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(180, 195);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // name_txt
            // 
            name_txt.BackColor = SystemColors.ControlLightLight;
            name_txt.Location = new Point(397, 115);
            name_txt.Multiline = true;
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(104, 28);
            name_txt.TabIndex = 1;
            // 
            // tel_no_text
            // 
            tel_no_text.BackColor = SystemColors.ControlLightLight;
            tel_no_text.Location = new Point(170, 277);
            tel_no_text.Multiline = true;
            tel_no_text.Name = "tel_no_text";
            tel_no_text.Size = new Size(104, 28);
            tel_no_text.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label8.Location = new Point(35, 368);
            label8.Name = "label8";
            label8.Size = new Size(75, 28);
            label8.TabIndex = 0;
            label8.Text = "Adres: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 193);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 0;
            label3.Text = "Doğum Tarihi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label9.Location = new Point(349, 277);
            label9.Name = "label9";
            label9.Size = new Size(109, 28);
            label9.TabIndex = 0;
            label9.Text = "Memleket:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label4.Location = new Point(35, 115);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 0;
            label4.Text = "T.C. No:";
            // 
            // üye_kayıt_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1559, 908);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "üye_kayıt_form";
            Text = "Üye Kayıt Formu";
            Load += üye_kayıt_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Label label7;
        private TextBox name_txt;

        private TextBox üye_no_text;
        private TextBox soyisim_text;
        private TextBox tc_txt;
        private TextBox adres_text;
        private Label label11;
        private TextBox job_text;
        private Panel panel1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private ComboBox memleket_box;
        private TextBox tel_no_text;
        private Label label8;
        private Label label9;
        private Button çık_btn;
        private Button ekle_btn;
        private Button button1;
    }
}