namespace Planety3D
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
            mapa_box = new PictureBox();
            wczytaj = new Button();
            label_szerokosc = new Label();
            label_wysokosc = new Label();
            label_bit = new Label();
            label_bitpx = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox_test = new TextBox();
            wlasciwosci = new Button();
            ((System.ComponentModel.ISupportInitialize)mapa_box).BeginInit();
            SuspendLayout();
            // 
            // mapa_box
            // 
            mapa_box.BackColor = SystemColors.ControlDark;
            mapa_box.Location = new Point(17, 41);
            mapa_box.Name = "mapa_box";
            mapa_box.Size = new Size(800, 400);
            mapa_box.SizeMode = PictureBoxSizeMode.Zoom;
            mapa_box.TabIndex = 0;
            mapa_box.TabStop = false;
            // 
            // wczytaj
            // 
            wczytaj.Location = new Point(17, 12);
            wczytaj.Name = "wczytaj";
            wczytaj.Size = new Size(187, 22);
            wczytaj.TabIndex = 1;
            wczytaj.Text = "Wczyaj mapę terenu";
            wczytaj.UseVisualStyleBackColor = true;
            wczytaj.Click += wczytaj_Click;
            // 
            // label_szerokosc
            // 
            label_szerokosc.AutoSize = true;
            label_szerokosc.BackColor = Color.Silver;
            label_szerokosc.Location = new Point(833, 137);
            label_szerokosc.Name = "label_szerokosc";
            label_szerokosc.Size = new Size(62, 15);
            label_szerokosc.TabIndex = 2;
            label_szerokosc.Text = "Szerokość ";
            label_szerokosc.Click += szerokosc_Click;
            // 
            // label_wysokosc
            // 
            label_wysokosc.AutoSize = true;
            label_wysokosc.BackColor = Color.Silver;
            label_wysokosc.Location = new Point(833, 164);
            label_wysokosc.Name = "label_wysokosc";
            label_wysokosc.Size = new Size(60, 15);
            label_wysokosc.TabIndex = 3;
            label_wysokosc.Text = "Wysokość";
            // 
            // label_bit
            // 
            label_bit.AutoSize = true;
            label_bit.BackColor = Color.Silver;
            label_bit.Location = new Point(833, 194);
            label_bit.Name = "label_bit";
            label_bit.Size = new Size(78, 15);
            label_bit.TabIndex = 4;
            label_bit.Text = "głębia bitowa";
            // 
            // label_bitpx
            // 
            label_bitpx.AutoSize = true;
            label_bitpx.BackColor = Color.Silver;
            label_bitpx.Location = new Point(833, 221);
            label_bitpx.Name = "label_bitpx";
            label_bitpx.Size = new Size(78, 15);
            label_bitpx.TabIndex = 5;
            label_bitpx.Text = "głębia bitowa";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(835, 261);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 115);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(17, 460);
            button1.Name = "button1";
            button1.Size = new Size(116, 35);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(157, 460);
            button2.Name = "button2";
            button2.Size = new Size(85, 35);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox_test
            // 
            textBox_test.Location = new Point(17, 514);
            textBox_test.Multiline = true;
            textBox_test.Name = "textBox_test";
            textBox_test.Size = new Size(432, 81);
            textBox_test.TabIndex = 9;
            // 
            // wlasciwosci
            // 
            wlasciwosci.Location = new Point(835, 41);
            wlasciwosci.Name = "wlasciwosci";
            wlasciwosci.Size = new Size(116, 49);
            wlasciwosci.TabIndex = 10;
            wlasciwosci.Text = "Właściwości obrazu";
            wlasciwosci.UseVisualStyleBackColor = true;
            wlasciwosci.Click += wlasciwosci_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(wlasciwosci);
            Controls.Add(textBox_test);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label_bitpx);
            Controls.Add(label_bit);
            Controls.Add(label_wysokosc);
            Controls.Add(label_szerokosc);
            Controls.Add(wczytaj);
            Controls.Add(mapa_box);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)mapa_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mapa_box;
        private Button wczytaj;
        private Label label_szerokosc;
        private Label label_wysokosc;
        private Label label_bit;
        private Label label_bitpx;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox_test;
        private Button wlasciwosci;
    }
}