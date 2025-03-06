namespace dernek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            ihtiyat_lst_btn = new Button();
            label1 = new Label();
            aidat_kyt_btn = new Button();
            üye_aidat_btn = new Button();
            üye_kyt_bnt = new Button();
            birey_button = new Button();
            yardım_kayıt = new Button();
            ihtiyaç_kayıt = new Button();
            button1 = new Button();
            button2 = new Button();
            reis_button = new Button();
            yardım_lst_btn = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(ihtiyat_lst_btn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(aidat_kyt_btn);
            panel1.Controls.Add(üye_aidat_btn);
            panel1.Controls.Add(üye_kyt_bnt);
            panel1.Controls.Add(birey_button);
            panel1.Controls.Add(yardım_kayıt);
            panel1.Controls.Add(ihtiyaç_kayıt);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(reis_button);
            panel1.Controls.Add(yardım_lst_btn);
            panel1.Location = new Point(377, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 635);
            panel1.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(622, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 27);
            dateTimePicker1.TabIndex = 22;
            // 
            // ihtiyat_lst_btn
            // 
            ihtiyat_lst_btn.BackColor = SystemColors.Control;
            ihtiyat_lst_btn.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ihtiyat_lst_btn.Location = new Point(579, 146);
            ihtiyat_lst_btn.Name = "ihtiyat_lst_btn";
            ihtiyat_lst_btn.Size = new Size(230, 82);
            ihtiyat_lst_btn.TabIndex = 21;
            ihtiyat_lst_btn.Text = "İhtiyaç Sahibi Liste";
            ihtiyat_lst_btn.UseVisualStyleBackColor = false;
            ihtiyat_lst_btn.Click += ihtiyat_lst_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(357, 46);
            label1.Name = "label1";
            label1.Size = new Size(127, 54);
            label1.TabIndex = 20;
            label1.Text = "Menü";
            // 
            // aidat_kyt_btn
            // 
            aidat_kyt_btn.BackColor = SystemColors.Control;
            aidat_kyt_btn.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            aidat_kyt_btn.Location = new Point(21, 255);
            aidat_kyt_btn.Name = "aidat_kyt_btn";
            aidat_kyt_btn.Size = new Size(230, 82);
            aidat_kyt_btn.TabIndex = 13;
            aidat_kyt_btn.Text = "Üye Aidat Kaydı";
            aidat_kyt_btn.UseVisualStyleBackColor = false;
            aidat_kyt_btn.Click += aidat_kyt_btn_Click;
            // 
            // üye_aidat_btn
            // 
            üye_aidat_btn.BackColor = SystemColors.Control;
            üye_aidat_btn.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            üye_aidat_btn.Location = new Point(21, 471);
            üye_aidat_btn.Name = "üye_aidat_btn";
            üye_aidat_btn.Size = new Size(230, 82);
            üye_aidat_btn.TabIndex = 14;
            üye_aidat_btn.Text = "Üye Aidat Takip Listesi";
            üye_aidat_btn.UseVisualStyleBackColor = false;
            üye_aidat_btn.Click += üye_aidat_btn_Click_1;
            // 
            // üye_kyt_bnt
            // 
            üye_kyt_bnt.BackColor = SystemColors.Control;
            üye_kyt_bnt.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            üye_kyt_bnt.Location = new Point(21, 363);
            üye_kyt_bnt.Name = "üye_kyt_bnt";
            üye_kyt_bnt.Size = new Size(230, 82);
            üye_kyt_bnt.TabIndex = 9;
            üye_kyt_bnt.Text = "Üye Kayıt Listesi";
            üye_kyt_bnt.UseVisualStyleBackColor = false;
            üye_kyt_bnt.Click += üye_kyt_bnt_Click;
            // 
            // birey_button
            // 
            birey_button.BackColor = SystemColors.Control;
            birey_button.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            birey_button.Location = new Point(579, 363);
            birey_button.Name = "birey_button";
            birey_button.Size = new Size(230, 82);
            birey_button.TabIndex = 18;
            birey_button.Text = "Aile Birey Listesi";
            birey_button.UseVisualStyleBackColor = false;
            birey_button.Click += birey_button_Click;
            // 
            // yardım_kayıt
            // 
            yardım_kayıt.BackColor = SystemColors.Control;
            yardım_kayıt.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            yardım_kayıt.Location = new Point(300, 255);
            yardım_kayıt.Name = "yardım_kayıt";
            yardım_kayıt.Size = new Size(230, 82);
            yardım_kayıt.TabIndex = 8;
            yardım_kayıt.Text = "Yeni Yardım Kayıt";
            yardım_kayıt.UseVisualStyleBackColor = false;
            yardım_kayıt.Click += yardım_kayıt_Click;
            // 
            // ihtiyaç_kayıt
            // 
            ihtiyaç_kayıt.BackColor = SystemColors.Control;
            ihtiyaç_kayıt.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            ihtiyaç_kayıt.Location = new Point(300, 146);
            ihtiyaç_kayıt.Name = "ihtiyaç_kayıt";
            ihtiyaç_kayıt.Size = new Size(230, 82);
            ihtiyaç_kayıt.TabIndex = 3;
            ihtiyaç_kayıt.Text = "Yeni İhtiyaç Sahibi Kaydı";
            ihtiyaç_kayıt.UseVisualStyleBackColor = false;
            ihtiyaç_kayıt.Click += ihtiyaç_kayıt_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(579, 546);
            button1.Name = "button1";
            button1.Size = new Size(230, 82);
            button1.TabIndex = 16;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(21, 146);
            button2.Name = "button2";
            button2.Size = new Size(230, 82);
            button2.TabIndex = 17;
            button2.Text = "Üye Kaydı";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // reis_button
            // 
            reis_button.BackColor = SystemColors.Control;
            reis_button.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            reis_button.Location = new Point(579, 255);
            reis_button.Name = "reis_button";
            reis_button.Size = new Size(230, 82);
            reis_button.TabIndex = 19;
            reis_button.Text = "Aile Reisi Listesi";
            reis_button.UseVisualStyleBackColor = false;
            reis_button.Click += reis_button_Click;
            // 
            // yardım_lst_btn
            // 
            yardım_lst_btn.BackColor = SystemColors.Control;
            yardım_lst_btn.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            yardım_lst_btn.Location = new Point(300, 363);
            yardım_lst_btn.Name = "yardım_lst_btn";
            yardım_lst_btn.Size = new Size(230, 82);
            yardım_lst_btn.TabIndex = 10;
            yardım_lst_btn.Text = "Yardım Kayıt Listesi";
            yardım_lst_btn.UseVisualStyleBackColor = false;
            yardım_lst_btn.Click += yardım_lst_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(317, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1134, 212);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = ihtiyaç_kayıt;
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1368, 947);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private RichTextBox richTextBox1;
        private ProgressBar progressBar1;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button aidat_kyt_btn;
        private Button üye_aidat_btn;
        private Button ihtiyaç_liste_btn;
        private Button üye_kyt_bnt;
        private Button birey_button;
        private Button yardım_kayıt;
        private Button ihtiyaç_kayıt;
        private Button button2;
        private Button reis_button;
        private Button yardım_lst_btn;
        private Button ihtiyat_lst_btn;
        private DateTimePicker dateTimePicker1;
    }
}
