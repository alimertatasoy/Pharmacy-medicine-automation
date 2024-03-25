namespace ders2503
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(71, 102);
            label2.Name = "label2";
            label2.Size = new Size(117, 38);
            label2.TabIndex = 1;
            label2.Text = "İlaç Adı:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Roboto Condensed", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(26, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 848);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "İlaç Ekleme";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Roboto Condensed Light", 13.875F, FontStyle.Italic, GraphicsUnit.Point);
            textBox4.Location = new Point(48, 528);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(496, 52);
            textBox4.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleTurquoise;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(257, 605);
            panel3.Name = "panel3";
            panel3.Size = new Size(347, 226);
            panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 192);
            button4.Font = new Font("Roboto Condensed", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(15, 743);
            button4.Name = "button4";
            button4.Size = new Size(236, 75);
            button4.TabIndex = 10;
            button4.Text = "Satış Yap";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Font = new Font("Roboto Condensed", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(15, 626);
            button3.Name = "button3";
            button3.Size = new Size(236, 75);
            button3.TabIndex = 9;
            button3.Text = "İlaç Ekle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Roboto Condensed", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(308, 438);
            button2.Name = "button2";
            button2.Size = new Size(236, 75);
            button2.TabIndex = 8;
            button2.Text = "Klasörden Resim Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Roboto Condensed", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(48, 438);
            button1.Name = "button1";
            button1.Size = new Size(236, 75);
            button1.TabIndex = 7;
            button1.Text = "Url' den resim Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Roboto Condensed Light", 13.875F, FontStyle.Italic, GraphicsUnit.Point);
            textBox3.Location = new Point(194, 311);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(380, 52);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Roboto Condensed Light", 13.875F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(194, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(380, 52);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Roboto Condensed Light", 13.875F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(194, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(380, 52);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(26, 319);
            label4.Name = "label4";
            label4.Size = new Size(162, 38);
            label4.TabIndex = 3;
            label4.Text = "İlaç Miktarı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(48, 206);
            label3.Name = "label3";
            label3.Size = new Size(140, 38);
            label3.TabIndex = 2;
            label3.Text = "İlaç Kodu:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(665, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1070, 848);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(559, 9);
            label1.Name = "label1";
            label1.Size = new Size(646, 77);
            label1.TabIndex = 0;
            label1.Text = "İlaç Eczane Otomasyonu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1760, 988);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Eczane İlaç Takip Otomasyonu";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label1;
        private TextBox textBox4;
    }
}