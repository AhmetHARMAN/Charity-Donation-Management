namespace dernek
{
    partial class Üye_Aidat_Kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Üye_Aidat_Kayıt));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            aidat_text = new TextBox();
            panel1 = new Panel();
            button3 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(69, 27);
            label1.Name = "label1";
            label1.Size = new Size(120, 31);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(371, 27);
            label2.Name = "label2";
            label2.Size = new Size(144, 31);
            label2.TabIndex = 0;
            label2.Text = "Aidat Tarihi: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(69, 120);
            label3.Name = "label3";
            label3.Size = new Size(94, 31);
            label3.TabIndex = 0;
            label3.Text = "Miktar: ";
            // 
            // aidat_text
            // 
            aidat_text.Location = new Point(195, 120);
            aidat_text.Multiline = true;
            aidat_text.Name = "aidat_text";
            aidat_text.Size = new Size(153, 31);
            aidat_text.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(aidat_text);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 356);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            button3.Location = new Point(238, 278);
            button3.Name = "button3";
            button3.Size = new Size(190, 77);
            button3.TabIndex = 9;
            button3.Text = "Listeyi Aç";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold);
            radioButton2.Location = new Point(546, 119);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 27);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Aidat";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold);
            radioButton1.Location = new Point(402, 119);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 27);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Yardım";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(195, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 28);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(460, 278);
            button1.Name = "button1";
            button1.Size = new Size(190, 77);
            button1.TabIndex = 6;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            button2.Location = new Point(17, 278);
            button2.Name = "button2";
            button2.Size = new Size(190, 77);
            button2.TabIndex = 5;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(521, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(129, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // Üye_Aidat_Kayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(867, 511);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Üye_Aidat_Kayıt";
            Text = "Üye Aidat Kayıt";
            Load += Üye_Aidat_Kayıt_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox aidat_text;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button3;
    }
}