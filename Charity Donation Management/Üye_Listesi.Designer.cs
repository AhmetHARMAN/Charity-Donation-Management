namespace dernek
{
    partial class Üye_Listesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Üye_Listesi));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            isim_btn = new RadioButton();
            kul_num_btn = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1149, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(478, 14);
            label1.Name = "label1";
            label1.Size = new Size(223, 38);
            label1.TabIndex = 1;
            label1.Text = "Üye Kayıt Listesi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold);
            label5.Location = new Point(211, 318);
            label5.Name = "label5";
            label5.Size = new Size(158, 38);
            label5.TabIndex = 1;
            label5.Text = "Üye Arama";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(375, 325);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // isim_btn
            // 
            isim_btn.AutoSize = true;
            isim_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            isim_btn.Location = new Point(375, 370);
            isim_btn.Name = "isim_btn";
            isim_btn.Size = new Size(209, 24);
            isim_btn.TabIndex = 4;
            isim_btn.TabStop = true;
            isim_btn.Text = "İsme Göre Arama ve Silme";
            isim_btn.UseVisualStyleBackColor = true;
            // 
            // kul_num_btn
            // 
            kul_num_btn.AutoSize = true;
            kul_num_btn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            kul_num_btn.Location = new Point(375, 417);
            kul_num_btn.Name = "kul_num_btn";
            kul_num_btn.Size = new Size(291, 24);
            kul_num_btn.TabIndex = 4;
            kul_num_btn.TabStop = true;
            kul_num_btn.Text = "Üye Numarasına Göre Arama ve Silme";
            kul_num_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            button1.Location = new Point(747, 417);
            button1.Name = "button1";
            button1.Size = new Size(163, 85);
            button1.TabIndex = 5;
            button1.Text = "Aidat Listesi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            button2.Location = new Point(945, 417);
            button2.Name = "button2";
            button2.Size = new Size(163, 85);
            button2.TabIndex = 6;
            button2.Text = "Çıkış";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(kul_num_btn);
            panel1.Controls.Add(isim_btn);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(8, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 521);
            panel1.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(375, 464);
            button3.Name = "button3";
            button3.Size = new Size(141, 38);
            button3.TabIndex = 7;
            button3.Text = "Kayıt Silme";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Üye_Listesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1212, 679);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Üye_Listesi";
            Text = "Üye_Listesi";
            Load += Üye_Listesi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label5;
        private TextBox textBox1;
        private RadioButton isim_btn;
        private RadioButton kul_num_btn;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button3;
    }
}