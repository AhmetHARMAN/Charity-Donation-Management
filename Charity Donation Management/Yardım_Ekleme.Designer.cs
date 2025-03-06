namespace dernek
{
    partial class Yardım_Ekleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yardım_Ekleme));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(8, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 0;
            label1.Text = "İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(8, 106);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 0;
            label2.Text = "Yardım Miktarı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(487, 26);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 0;
            label3.Text = "Yardım Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(485, 104);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 0;
            label4.Text = "Yardım Türü";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 105);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 27);
            textBox4.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(611, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(387, 340);
            button2.Name = "button2";
            button2.Size = new Size(186, 79);
            button2.TabIndex = 4;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            radioButton1.Location = new Point(602, 102);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 27);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nakdi";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold);
            radioButton2.Location = new Point(695, 102);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 27);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Gıda";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 420);
            panel1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(318, 31);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(128, 28);
            comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.DropDownHeight = 100;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(65, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(595, 340);
            button1.Name = "button1";
            button1.Size = new Size(186, 79);
            button1.TabIndex = 7;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(232, 33);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 0;
            label5.Text = "Soyisim:";
            // 
            // Yardım_Ekleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1407, 798);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Yardım_Ekleme";
            Text = "Yardım_Ekleme";
            Load += Yardım_Ekleme_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel1;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label5;
    }
}