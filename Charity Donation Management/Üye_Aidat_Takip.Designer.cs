namespace dernek
{
    partial class Üye_Aidat_Takip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Üye_Aidat_Takip));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            isim_btn = new RadioButton();
            miktar_btn = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            aidat_btn = new RadioButton();
            yrdm_btn = new RadioButton();
            button1 = new Button();
            tabPage4 = new TabPage();
            button5 = new Button();
            textBox5 = new TextBox();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            tabPage3 = new TabPage();
            label9 = new Label();
            label8 = new Label();
            dateTimePicker3 = new DateTimePicker();
            button4 = new Button();
            dateTimePicker4 = new DateTimePicker();
            tabPage2 = new TabPage();
            dateTimePicker2 = new DateTimePicker();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            radioButton1 = new RadioButton();
            label6 = new Label();
            radioButton2 = new RadioButton();
            label5 = new Label();
            button2 = new Button();
            radioButton3 = new RadioButton();
            tabPage1 = new TabPage();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(144, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(680, 201);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(383, 12);
            label1.Name = "label1";
            label1.Size = new Size(227, 38);
            label1.TabIndex = 1;
            label1.Text = "Üye Aidat Listesi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 409);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(47, 398);
            label2.Name = "label2";
            label2.Size = new Size(92, 38);
            label2.TabIndex = 1;
            label2.Text = "Sorgu";
            // 
            // isim_btn
            // 
            isim_btn.AutoSize = true;
            isim_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            isim_btn.Location = new Point(58, 466);
            isim_btn.Name = "isim_btn";
            isim_btn.Size = new Size(156, 24);
            isim_btn.TabIndex = 3;
            isim_btn.TabStop = true;
            isim_btn.Text = "İsme Göre Arama: ";
            isim_btn.UseVisualStyleBackColor = true;
            // 
            // miktar_btn
            // 
            miktar_btn.AutoSize = true;
            miktar_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            miktar_btn.Location = new Point(216, 466);
            miktar_btn.Name = "miktar_btn";
            miktar_btn.Size = new Size(169, 24);
            miktar_btn.TabIndex = 3;
            miktar_btn.TabStop = true;
            miktar_btn.Text = "Miktara Göre Arama";
            miktar_btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(miktar_btn);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(isim_btn);
            panel1.Location = new Point(12, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 779);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(aidat_btn);
            panel2.Controls.Add(yrdm_btn);
            panel2.Location = new Point(58, 512);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 54);
            panel2.TabIndex = 5;
            // 
            // aidat_btn
            // 
            aidat_btn.AutoSize = true;
            aidat_btn.Checked = true;
            aidat_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            aidat_btn.Location = new Point(158, 16);
            aidat_btn.Name = "aidat_btn";
            aidat_btn.Size = new Size(108, 24);
            aidat_btn.TabIndex = 0;
            aidat_btn.TabStop = true;
            aidat_btn.Text = "Aidat Sırala";
            aidat_btn.UseVisualStyleBackColor = true;
            aidat_btn.CheckedChanged += aidat_btn_CheckedChanged;
            // 
            // yrdm_btn
            // 
            yrdm_btn.AutoSize = true;
            yrdm_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            yrdm_btn.Location = new Point(0, 16);
            yrdm_btn.Name = "yrdm_btn";
            yrdm_btn.Size = new Size(120, 24);
            yrdm_btn.TabIndex = 0;
            yrdm_btn.Text = "Yardım Sırala";
            yrdm_btn.UseVisualStyleBackColor = true;
            yrdm_btn.CheckedChanged += yrdm_btn_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(798, 701);
            button1.Name = "button1";
            button1.Size = new Size(165, 75);
            button1.TabIndex = 4;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FloralWhite;
            tabPage4.Controls.Add(radioButton5);
            tabPage4.Controls.Add(radioButton4);
            tabPage4.Controls.Add(textBox5);
            tabPage4.Controls.Add(button5);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(501, 226);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Kayıt Silme";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(310, 148);
            button5.Name = "button5";
            button5.Size = new Size(165, 75);
            button5.TabIndex = 17;
            button5.Text = "Kayıt Sil";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(40, 26);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(126, 27);
            textBox5.TabIndex = 18;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(40, 79);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(200, 24);
            radioButton4.TabIndex = 19;
            radioButton4.TabStop = true;
            radioButton4.Text = "İsim Soyisime Göre Silme";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(288, 79);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(144, 24);
            radioButton5.TabIndex = 20;
            radioButton5.TabStop = true;
            radioButton5.Text = "İD'ye Göre Silme";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FloralWhite;
            tabPage3.Controls.Add(dateTimePicker4);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(dateTimePicker3);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(501, 226);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tarihe Göre Sıralama";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label9.Location = new Point(31, 48);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 20;
            label9.Text = "Başlangıç";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label8.Location = new Point(31, 96);
            label8.Name = "label8";
            label8.Size = new Size(48, 25);
            label8.TabIndex = 19;
            label8.Text = "Bitiş";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(210, 96);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(143, 27);
            dateTimePicker3.TabIndex = 17;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(251, 144);
            button4.Name = "button4";
            button4.Size = new Size(102, 26);
            button4.TabIndex = 21;
            button4.Text = "Sırala";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(210, 50);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(143, 27);
            dateTimePicker4.TabIndex = 18;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FloralWhite;
            tabPage2.Controls.Add(radioButton3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(radioButton2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(radioButton1);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(501, 226);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tarihe Göre Hesaplama";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(111, 90);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(137, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox4.Location = new Point(111, 143);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(137, 45);
            textBox4.TabIndex = 12;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(111, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(137, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            radioButton1.Location = new Point(293, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Yardım";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(16, 90);
            label6.Name = "label6";
            label6.Size = new Size(47, 23);
            label6.TabIndex = 9;
            label6.Text = "Bitiş:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            radioButton2.Location = new Point(293, 60);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 24);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Aidat";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(16, 32);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 9;
            label5.Text = "Başlangıç:";
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(296, 182);
            button2.Name = "button2";
            button2.Size = new Size(101, 44);
            button2.TabIndex = 15;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(293, 93);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 24);
            radioButton3.TabIndex = 16;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tümü";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FloralWhite;
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(501, 226);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Genel Hesap";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(227, 21);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(150, 38);
            textBox2.TabIndex = 7;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(22, 92);
            label4.Name = "label4";
            label4.Size = new Size(158, 31);
            label4.TabIndex = 6;
            label4.Text = "Toplam Aidat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(22, 28);
            label3.Name = "label3";
            label3.Size = new Size(176, 31);
            label3.TabIndex = 6;
            label3.Text = "Toplam Yardım:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(227, 91);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 38);
            textBox3.TabIndex = 8;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(259, 171);
            button3.Name = "button3";
            button3.Size = new Size(118, 49);
            button3.TabIndex = 9;
            button3.Text = "Hesapla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tabControl1.Location = new Point(412, 354);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(509, 259);
            tabControl1.TabIndex = 16;
            // 
            // Üye_Aidat_Takip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1023, 835);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Üye_Aidat_Takip";
            Text = "Üye Aidat Takip";
            Load += Üye_Aidat_Takip_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private RadioButton isim_btn;
        private RadioButton miktar_btn;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private RadioButton aidat_btn;
        private RadioButton yrdm_btn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TabPage tabPage2;
        private RadioButton radioButton3;
        private Button button2;
        private Label label5;
        private RadioButton radioButton2;
        private Label label6;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker2;
        private TabPage tabPage3;
        private DateTimePicker dateTimePicker4;
        private Button button4;
        private DateTimePicker dateTimePicker3;
        private Label label8;
        private Label label9;
        private TabPage tabPage4;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private TextBox textBox5;
        private Button button5;
    }
}