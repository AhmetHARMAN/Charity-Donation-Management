namespace dernek
{
    partial class Yardım_Liste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yardım_Liste));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            isim_btn = new RadioButton();
            soyisim_btn = new RadioButton();
            mik_btn = new RadioButton();
            tür_gıda_btn = new RadioButton();
            label2 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            button4 = new Button();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            tür_nakdi_btn = new RadioButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            tabPage2 = new TabPage();
            button3 = new Button();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox5 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            tabPage3 = new TabPage();
            textBox6 = new TextBox();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(61, 349);
            label1.Name = "label1";
            label1.Size = new Size(101, 38);
            label1.TabIndex = 0;
            label1.Text = "Arama";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(212, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(790, 268);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 403);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // isim_btn
            // 
            isim_btn.AutoSize = true;
            isim_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            isim_btn.Location = new Point(245, 400);
            isim_btn.Name = "isim_btn";
            isim_btn.Size = new Size(148, 24);
            isim_btn.TabIndex = 3;
            isim_btn.TabStop = true;
            isim_btn.Text = "İsme Göre Arama";
            isim_btn.UseVisualStyleBackColor = true;
            // 
            // soyisim_btn
            // 
            soyisim_btn.AutoSize = true;
            soyisim_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            soyisim_btn.Location = new Point(424, 400);
            soyisim_btn.Name = "soyisim_btn";
            soyisim_btn.Size = new Size(172, 24);
            soyisim_btn.TabIndex = 3;
            soyisim_btn.TabStop = true;
            soyisim_btn.Text = "Soyisme Göre Arama";
            soyisim_btn.UseVisualStyleBackColor = true;
            // 
            // mik_btn
            // 
            mik_btn.AutoSize = true;
            mik_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            mik_btn.Location = new Point(245, 433);
            mik_btn.Name = "mik_btn";
            mik_btn.Size = new Size(169, 24);
            mik_btn.TabIndex = 3;
            mik_btn.TabStop = true;
            mik_btn.Text = "Miktara Göre Arama";
            mik_btn.UseVisualStyleBackColor = true;
            // 
            // tür_gıda_btn
            // 
            tür_gıda_btn.AutoSize = true;
            tür_gıda_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            tür_gıda_btn.Location = new Point(245, 466);
            tür_gıda_btn.Name = "tür_gıda_btn";
            tür_gıda_btn.Size = new Size(176, 24);
            tür_gıda_btn.TabIndex = 3;
            tür_gıda_btn.TabStop = true;
            tür_gıda_btn.Text = "Gıda Yardım Sıralama";
            tür_gıda_btn.UseVisualStyleBackColor = true;
            tür_gıda_btn.CheckedChanged += tür_gıda_btn_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(492, 18);
            label2.Name = "label2";
            label2.Size = new Size(265, 38);
            label2.TabIndex = 0;
            label2.Text = "Yardım Takip Listesi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(dateTimePicker3);
            panel1.Controls.Add(dateTimePicker4);
            panel1.Controls.Add(tür_nakdi_btn);
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tür_gıda_btn);
            panel1.Controls.Add(mik_btn);
            panel1.Controls.Add(soyisim_btn);
            panel1.Controls.Add(isim_btn);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 737);
            panel1.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(352, 531);
            label10.Name = "label10";
            label10.Size = new Size(151, 20);
            label10.TabIndex = 15;
            label10.Text = "Tarihe Göre Sıralama";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(475, 657);
            button4.Name = "button4";
            button4.Size = new Size(102, 26);
            button4.TabIndex = 14;
            button4.Text = "Sırala";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label8.Location = new Point(255, 609);
            label8.Name = "label8";
            label8.Size = new Size(48, 25);
            label8.TabIndex = 12;
            label8.Text = "Bitiş";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label9.Location = new Point(255, 561);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 13;
            label9.Text = "Başlangıç";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(434, 609);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(143, 27);
            dateTimePicker3.TabIndex = 10;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(434, 563);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(143, 27);
            dateTimePicker4.TabIndex = 11;
            // 
            // tür_nakdi_btn
            // 
            tür_nakdi_btn.AutoSize = true;
            tür_nakdi_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            tür_nakdi_btn.Location = new Point(424, 466);
            tür_nakdi_btn.Name = "tür_nakdi_btn";
            tür_nakdi_btn.Size = new Size(186, 24);
            tür_nakdi_btn.TabIndex = 9;
            tür_nakdi_btn.TabStop = true;
            tür_nakdi_btn.Text = "Nakdi Yardım Sıralama";
            tür_nakdi_btn.UseVisualStyleBackColor = true;
            tür_nakdi_btn.CheckedChanged += tür_nakdi_btn_CheckedChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(707, 349);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(397, 303);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FloralWhite;
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(389, 270);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Genel Hesaplama";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(201, 155);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(164, 34);
            textBox2.TabIndex = 5;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(218, 212);
            button2.Name = "button2";
            button2.Size = new Size(138, 52);
            button2.TabIndex = 7;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(183, 35);
            label3.TabIndex = 0;
            label3.Text = "Toplam Yardım";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 97);
            label4.Name = "label4";
            label4.Size = new Size(152, 35);
            label4.TabIndex = 0;
            label4.Text = "Gıda Yardım";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(12, 40);
            label5.Name = "label5";
            label5.Size = new Size(167, 35);
            label5.TabIndex = 0;
            label5.Text = "Nakdi Yardım";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox4.Location = new Point(201, 40);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(164, 34);
            textBox4.TabIndex = 5;
            textBox4.Text = "0";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(201, 97);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(164, 34);
            textBox3.TabIndex = 5;
            textBox3.Text = "0";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FloralWhite;
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(radioButton2);
            tabPage2.Controls.Add(radioButton3);
            tabPage2.Controls.Add(radioButton1);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(389, 270);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tarihe Göre Hesaplama";
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(258, 200);
            button3.Name = "button3";
            button3.Size = new Size(108, 48);
            button3.TabIndex = 10;
            button3.Text = "Hesapla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            radioButton2.Location = new Point(299, 134);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 27);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Gıda";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            radioButton3.Location = new Point(93, 134);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(73, 27);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tümü";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            radioButton1.Location = new Point(197, 134);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 27);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nakdi";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox5.Location = new Point(27, 200);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(168, 43);
            textBox5.TabIndex = 8;
            textBox5.Text = "0";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(18, 85);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 7;
            label7.Text = "Bitiş";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(18, 22);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 7;
            label6.Text = "Başlangıç";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(197, 85);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(143, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(197, 24);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(143, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(0, 657);
            button1.Name = "button1";
            button1.Size = new Size(151, 81);
            button1.TabIndex = 4;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FloralWhite;
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(radioButton5);
            tabPage3.Controls.Add(radioButton4);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(389, 270);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kayıt Silme";
            tabPage3.Click += tabPage3_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(25, 25);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(143, 27);
            textBox6.TabIndex = 0;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            radioButton4.Location = new Point(27, 89);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(140, 24);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "İsme Göre Silme";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            radioButton5.Location = new Point(196, 88);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(187, 24);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Text = "Kayıt No'ya Göre Silme";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(222, 199);
            button5.Name = "button5";
            button5.Size = new Size(161, 65);
            button5.TabIndex = 3;
            button5.Text = "Kayıt Silme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Yardım_Liste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1172, 813);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Yardım_Liste";
            Text = "Yardım_Liste";
            Load += Yardım_Liste_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private RadioButton isim_btn;
        private RadioButton soyisim_btn;
        private RadioButton mik_btn;
        private RadioButton tür_gıda_btn;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox5;
        private Button button3;
        private RadioButton tür_nakdi_btn;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Button button4;
        private Label label10;
        private RadioButton radioButton3;
        private TabPage tabPage3;
        private TextBox textBox6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private Button button5;
    }
}