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
            buttonTest = new Button();
            tabControl1 = new TabControl();
            tabDanePoczatkowe = new TabPage();
            textBoxSkalerTop = new TextBox();
            labelSkalaTopNaSr = new Label();
            textBoxSrModNaWysTop = new TextBox();
            labelSrModNaWysTop = new Label();
            textBoxSkalaTop = new TextBox();
            labelSkalaTop = new Label();
            textBoxSkalaSr = new TextBox();
            labelSkalaSr = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            labelWybórTypuModelu = new Label();
            textBoxWysTopPlanety = new TextBox();
            labelWysTopPlanety = new Label();
            textBoxSrPlanety = new TextBox();
            textBoxWysTopMod = new TextBox();
            labelSrPlanety = new Label();
            labelWysTopModelu = new Label();
            textBoxSrModelu = new TextBox();
            labelSrednicaModelu = new Label();
            tabOpcje = new TabPage();
            tabWyjscie = new TabPage();
            ((System.ComponentModel.ISupportInitialize)mapa_box).BeginInit();
            tabControl1.SuspendLayout();
            tabDanePoczatkowe.SuspendLayout();
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
            label_szerokosc.Location = new Point(833, 108);
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
            label_wysokosc.Location = new Point(833, 135);
            label_wysokosc.Name = "label_wysokosc";
            label_wysokosc.Size = new Size(60, 15);
            label_wysokosc.TabIndex = 3;
            label_wysokosc.Text = "Wysokość";
            // 
            // label_bit
            // 
            label_bit.AutoSize = true;
            label_bit.BackColor = Color.Silver;
            label_bit.Location = new Point(833, 165);
            label_bit.Name = "label_bit";
            label_bit.Size = new Size(78, 15);
            label_bit.TabIndex = 4;
            label_bit.Text = "głębia bitowa";
            // 
            // label_bitpx
            // 
            label_bitpx.AutoSize = true;
            label_bitpx.BackColor = Color.Silver;
            label_bitpx.Location = new Point(833, 192);
            label_bitpx.Name = "label_bitpx";
            label_bitpx.Size = new Size(78, 15);
            label_bitpx.TabIndex = 5;
            label_bitpx.Text = "głębia bitowa";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(835, 232);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 115);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(332, 12);
            button1.Name = "button1";
            button1.Size = new Size(116, 22);
            button1.TabIndex = 7;
            button1.Text = "wczytaj do tablicy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(210, 12);
            button2.Name = "button2";
            button2.Size = new Size(116, 22);
            button2.TabIndex = 8;
            button2.Text = "czyść obraz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox_test
            // 
            textBox_test.Location = new Point(835, 396);
            textBox_test.Multiline = true;
            textBox_test.Name = "textBox_test";
            textBox_test.Size = new Size(116, 236);
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
            // buttonTest
            // 
            buttonTest.Location = new Point(835, 353);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(116, 37);
            buttonTest.TabIndex = 11;
            buttonTest.Text = "test";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDanePoczatkowe);
            tabControl1.Controls.Add(tabOpcje);
            tabControl1.Controls.Add(tabWyjscie);
            tabControl1.Location = new Point(17, 447);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(567, 222);
            tabControl1.TabIndex = 12;
            // 
            // tabDanePoczatkowe
            // 
            tabDanePoczatkowe.Controls.Add(textBoxSkalerTop);
            tabDanePoczatkowe.Controls.Add(labelSkalaTopNaSr);
            tabDanePoczatkowe.Controls.Add(textBoxSrModNaWysTop);
            tabDanePoczatkowe.Controls.Add(labelSrModNaWysTop);
            tabDanePoczatkowe.Controls.Add(textBoxSkalaTop);
            tabDanePoczatkowe.Controls.Add(labelSkalaTop);
            tabDanePoczatkowe.Controls.Add(textBoxSkalaSr);
            tabDanePoczatkowe.Controls.Add(labelSkalaSr);
            tabDanePoczatkowe.Controls.Add(radioButton3);
            tabDanePoczatkowe.Controls.Add(radioButton2);
            tabDanePoczatkowe.Controls.Add(radioButton1);
            tabDanePoczatkowe.Controls.Add(labelWybórTypuModelu);
            tabDanePoczatkowe.Controls.Add(textBoxWysTopPlanety);
            tabDanePoczatkowe.Controls.Add(labelWysTopPlanety);
            tabDanePoczatkowe.Controls.Add(textBoxSrPlanety);
            tabDanePoczatkowe.Controls.Add(textBoxWysTopMod);
            tabDanePoczatkowe.Controls.Add(labelSrPlanety);
            tabDanePoczatkowe.Controls.Add(labelWysTopModelu);
            tabDanePoczatkowe.Controls.Add(textBoxSrModelu);
            tabDanePoczatkowe.Controls.Add(labelSrednicaModelu);
            tabDanePoczatkowe.Location = new Point(4, 24);
            tabDanePoczatkowe.Name = "tabDanePoczatkowe";
            tabDanePoczatkowe.Padding = new Padding(3);
            tabDanePoczatkowe.Size = new Size(559, 194);
            tabDanePoczatkowe.TabIndex = 0;
            tabDanePoczatkowe.Text = "Dane wejściowe";
            tabDanePoczatkowe.UseVisualStyleBackColor = true;
            // 
            // textBoxSkalerTop
            // 
            textBoxSkalerTop.Location = new Point(266, 118);
            textBoxSkalerTop.Name = "textBoxSkalerTop";
            textBoxSkalerTop.Size = new Size(96, 23);
            textBoxSkalerTop.TabIndex = 27;
            textBoxSkalerTop.TextChanged += textBoxSkalerTop_TextChanged;
            textBoxSkalerTop.KeyPress += textBoxSkalerTop_KeyPress;
            // 
            // labelSkalaTopNaSr
            // 
            labelSkalaTopNaSr.AutoSize = true;
            labelSkalaTopNaSr.Location = new Point(266, 100);
            labelSkalaTopNaSr.Name = "labelSkalaTopNaSr";
            labelSkalaTopNaSr.Size = new Size(90, 15);
            labelSkalaTopNaSr.TabIndex = 26;
            labelSkalaTopNaSr.Text = "Skaler Topologii";
            // 
            // textBoxSrModNaWysTop
            // 
            textBoxSrModNaWysTop.Location = new Point(266, 28);
            textBoxSrModNaWysTop.Name = "textBoxSrModNaWysTop";
            textBoxSrModNaWysTop.Size = new Size(96, 23);
            textBoxSrModNaWysTop.TabIndex = 25;
            textBoxSrModNaWysTop.TextChanged += textBoxSrModNaWysTop_TextChanged;
            textBoxSrModNaWysTop.KeyPress += textBoxSrModNaWysTop_KeyPress;
            // 
            // labelSrModNaWysTop
            // 
            labelSrModNaWysTop.AutoSize = true;
            labelSrModNaWysTop.Location = new Point(266, 10);
            labelSrModNaWysTop.Name = "labelSrModNaWysTop";
            labelSrModNaWysTop.Size = new Size(119, 15);
            labelSrModNaWysTop.TabIndex = 24;
            labelSrModNaWysTop.Text = "Śr mod/wys top mod";
            // 
            // textBoxSkalaTop
            // 
            textBoxSkalaTop.Location = new Point(124, 118);
            textBoxSkalaTop.Name = "textBoxSkalaTop";
            textBoxSkalaTop.Size = new Size(96, 23);
            textBoxSkalaTop.TabIndex = 23;
            textBoxSkalaTop.TextChanged += textBoxSkalaTop_TextChanged;
            textBoxSkalaTop.KeyPress += textBoxSkalaTop_KeyPress;
            // 
            // labelSkalaTop
            // 
            labelSkalaTop.AutoSize = true;
            labelSkalaTop.Location = new Point(124, 100);
            labelSkalaTop.Name = "labelSkalaTop";
            labelSkalaTop.Size = new Size(85, 15);
            labelSkalaTop.TabIndex = 22;
            labelSkalaTop.Text = "Skala topologii";
            // 
            // textBoxSkalaSr
            // 
            textBoxSkalaSr.Location = new Point(7, 118);
            textBoxSkalaSr.Name = "textBoxSkalaSr";
            textBoxSkalaSr.Size = new Size(96, 23);
            textBoxSkalaSr.TabIndex = 21;
            textBoxSkalaSr.TextChanged += textBoxSkalaSr_TextChanged;
            textBoxSkalaSr.KeyPress += textBoxSkalaSr_KeyPress;
            // 
            // labelSkalaSr
            // 
            labelSkalaSr.AutoSize = true;
            labelSkalaSr.Location = new Point(7, 100);
            labelSkalaSr.Name = "labelSkalaSr";
            labelSkalaSr.Size = new Size(81, 15);
            labelSkalaSr.TabIndex = 20;
            labelSkalaSr.Text = "Skala średnicy";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(399, 122);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(156, 19);
            radioButton3.TabIndex = 19;
            radioButton3.TabStop = true;
            radioButton3.Text = "Przeskalowana topologia";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(399, 57);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(106, 19);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "wys top = śr / x";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(399, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(119, 19);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Wartości ustalone";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // labelWybórTypuModelu
            // 
            labelWybórTypuModelu.AutoSize = true;
            labelWybórTypuModelu.Location = new Point(399, 10);
            labelWybórTypuModelu.Name = "labelWybórTypuModelu";
            labelWybórTypuModelu.Size = new Size(72, 15);
            labelWybórTypuModelu.TabIndex = 17;
            labelWybórTypuModelu.Text = "Typ modelu ";
            // 
            // textBoxWysTopPlanety
            // 
            textBoxWysTopPlanety.Location = new Point(124, 72);
            textBoxWysTopPlanety.Name = "textBoxWysTopPlanety";
            textBoxWysTopPlanety.Size = new Size(96, 23);
            textBoxWysTopPlanety.TabIndex = 16;
            textBoxWysTopPlanety.TextChanged += textBoxWysTopPlanety_TextChanged;
            textBoxWysTopPlanety.KeyPress += textBoxWysTopPlanety_KeyPress;
            // 
            // labelWysTopPlanety
            // 
            labelWysTopPlanety.AutoSize = true;
            labelWysTopPlanety.Location = new Point(124, 54);
            labelWysTopPlanety.Name = "labelWysTopPlanety";
            labelWysTopPlanety.Size = new Size(157, 15);
            labelWysTopPlanety.TabIndex = 15;
            labelWysTopPlanety.Text = "Wysokość topografii planety";
            // 
            // textBoxSrPlanety
            // 
            textBoxSrPlanety.Location = new Point(7, 72);
            textBoxSrPlanety.Name = "textBoxSrPlanety";
            textBoxSrPlanety.Size = new Size(96, 23);
            textBoxSrPlanety.TabIndex = 14;
            textBoxSrPlanety.TextChanged += textBoxSrPlanety_TextChanged;
            textBoxSrPlanety.KeyPress += textBoxSrPlanety_KeyPress;
            // 
            // textBoxWysTopMod
            // 
            textBoxWysTopMod.Location = new Point(124, 28);
            textBoxWysTopMod.Name = "textBoxWysTopMod";
            textBoxWysTopMod.Size = new Size(96, 23);
            textBoxWysTopMod.TabIndex = 3;
            textBoxWysTopMod.TextChanged += textBoxWysTopMod_TextChanged;
            textBoxWysTopMod.KeyPress += textBoxWysTopMod_KeyPress;
            // 
            // labelSrPlanety
            // 
            labelSrPlanety.AutoSize = true;
            labelSrPlanety.Location = new Point(7, 54);
            labelSrPlanety.Name = "labelSrPlanety";
            labelSrPlanety.Size = new Size(94, 15);
            labelSrPlanety.TabIndex = 13;
            labelSrPlanety.Text = "Średnica Planety";
            // 
            // labelWysTopModelu
            // 
            labelWysTopModelu.AutoSize = true;
            labelWysTopModelu.Location = new Point(124, 10);
            labelWysTopModelu.Name = "labelWysTopModelu";
            labelWysTopModelu.Size = new Size(159, 15);
            labelWysTopModelu.TabIndex = 2;
            labelWysTopModelu.Text = "Wysokość topografii modelu";
            // 
            // textBoxSrModelu
            // 
            textBoxSrModelu.Location = new Point(7, 28);
            textBoxSrModelu.Name = "textBoxSrModelu";
            textBoxSrModelu.Size = new Size(96, 23);
            textBoxSrModelu.TabIndex = 1;
            textBoxSrModelu.TextChanged += textBoxSrModelu_TextChanged;
            textBoxSrModelu.KeyPress += textBoxSrModelu_KeyPress;
            // 
            // labelSrednicaModelu
            // 
            labelSrednicaModelu.AutoSize = true;
            labelSrednicaModelu.Location = new Point(7, 10);
            labelSrednicaModelu.Name = "labelSrednicaModelu";
            labelSrednicaModelu.Size = new Size(96, 15);
            labelSrednicaModelu.TabIndex = 0;
            labelSrednicaModelu.Text = "Średnica modelu";
            // 
            // tabOpcje
            // 
            tabOpcje.Location = new Point(4, 24);
            tabOpcje.Name = "tabOpcje";
            tabOpcje.Padding = new Padding(3);
            tabOpcje.Size = new Size(596, 194);
            tabOpcje.TabIndex = 1;
            tabOpcje.Text = "Przetwarzanie ";
            tabOpcje.UseVisualStyleBackColor = true;
            // 
            // tabWyjscie
            // 
            tabWyjscie.Location = new Point(4, 24);
            tabWyjscie.Name = "tabWyjscie";
            tabWyjscie.Padding = new Padding(3);
            tabWyjscie.Size = new Size(596, 194);
            tabWyjscie.TabIndex = 2;
            tabWyjscie.Text = "Ustawienia wyjściowe";
            tabWyjscie.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(984, 689);
            Controls.Add(tabControl1);
            Controls.Add(buttonTest);
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
            tabControl1.ResumeLayout(false);
            tabDanePoczatkowe.ResumeLayout(false);
            tabDanePoczatkowe.PerformLayout();
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
        private Button buttonTest;
        private TabControl tabControl1;
        private TabPage tabDanePoczatkowe;
        private TabPage tabOpcje;
        private TabPage tabWyjscie;
        private TextBox textBoxSrModelu;
        private Label labelSrednicaModelu;
        private TextBox textBoxSrPlanety;
        private TextBox textBoxWysTopMod;
        private Label labelSrPlanety;
        private Label labelWysTopModelu;
        private TextBox textBoxWysTopPlanety;
        private Label labelWysTopPlanety;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label labelWybórTypuModelu;
        private TextBox textBoxSkalerTop;
        private Label labelSkalaTopNaSr;
        private TextBox textBoxSrModNaWysTop;
        private Label labelSrModNaWysTop;
        private TextBox textBoxSkalaTop;
        private Label labelSkalaTop;
        private TextBox textBoxSkalaSr;
        private Label labelSkalaSr;
    }
}