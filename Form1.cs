using Planety3D;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Planety3D
{
    public partial class Form1 : Form
    {
        Mapa mapa = new Mapa();
        Bitmap bmap;
        Model model = new Model();

        public Form1()
        {
            InitializeComponent();

            //if (textBoxSrModelu.Text.Length == 0)
            //{
            //    textBoxSrModelu.BackColor = Color.Red;
            //}
            //else
            //{
            //    textBoxSrModelu.BackColor = SystemColors.Window;
            //}
        }

        private void wczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nazwaPlikuGlobal = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    return;
                }

                bmap = new Bitmap(openFileDialog1.FileName);
                PixelFormat pixelFormat = bmap.PixelFormat;
                Color pixelColor = bmap.GetPixel(1, 1);
                if (pixelColor.R != pixelColor.G && pixelColor.B != pixelColor.G)
                {
                    DialogResult result = MessageBox.Show("Obraz nie jest w skali szaroœci czy chcesz kontyn³owaæ?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        bmap = null;
                        mapa_box.Image = null;
                        return;
                    }
                }

                mapa_box.Image = bmap;


                //mapa.Save("image.jpg", ImageFormat.Jpeg);
            }

        }
        private void szerokosc_Click(object sender, EventArgs e)
        {

        }

        //public static Bitmap RemoveRed(Bitmap image)
        //{
        //    Bitmap newImage = new Bitmap(image.Width, image.Height);
        //    for (int x = 0; x < image.Width; x++)
        //    {
        //        for (int y = 0; y < image.Height; y++)
        //        {
        //            Color pixel = image.GetPixel(x, y);
        //            Color newPixel = Color.FromArgb(pixel.A, 0, pixel.G, pixel.B);
        //            newImage.SetPixel(x, y, newPixel);
        //        }
        //    }
        //    return newImage;
        //}

        //public static int[,] BitmapToIntArray(Bitmap image)
        //{
        //    int[,] array = new int[image.Width, image.Height];
        //    for (int x = 0; x < image.Width; x++)
        //    {
        //        for (int y = 0; y < image.Height; y++)
        //        {
        //            Color pixel = image.GetPixel(x, y);
        //            array[x, y] = pixel.ToArgb();
        //        }
        //    }
        //    return array;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //mapa_box.Image = bmap;
            mapa.BitmapToIntArray(bmap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mapa_box.Image = null;
            bmap = null;
        }

        private void wlasciwosci_Click(object sender, EventArgs e)
        {
            mapa.BitmapMaxMin(bmap);
            PixelFormat pixelFormat = bmap.PixelFormat;
            Color pixelColor = bmap.GetPixel(1, 1);
            string text = "";
            //text += "Szerokoœæ: " + mapa_box.Image.Width + "\r\n";
            //text += "Wysokoœæ: " + mapa_box.Image.Height + "\r\n";
            //text += "g³êbia bitowa: " + Image.GetPixelFormatSize(mapa.PixelFormat) + "\r\n";
            text += "R = " + pixelColor.R.ToString() + "\r\n";
            text += "G = " + pixelColor.G.ToString() + "\r\n";
            text += "B = " + pixelColor.B.ToString() + "\r\n";
            text += "max " + mapa.maxpx.ToString() + "\r\n";
            text += "min " + mapa.minpx.ToString() + "\r\n";
            text += pixelFormat + "\r\n";

            textBox1.Text = text;

            label_szerokosc.Text = "Szerokoœæ:     " + mapa.w;
            label_wysokosc.Text = "Wysokoœæ:      " + mapa.h;
            label_bit.Text = "g³êbia bitowa: " + Bitmap.GetPixelFormatSize(bmap.PixelFormat);
            label_bitpx.Text = "";
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            string test = "";
            //for (int i = 0; i < 10; i++)
            //{
            //    test += mapa.tabpx[i, i].ToString() + " ";
            //}
            //textBox_test.Text = test;
            test += "\r\n" + model.srModelu.ToString();
            test += "\r\n" + model.wysTopModelu.ToString();
            test += "\r\n" + model.srModNaWysTopMod.ToString();
            test += "\r\n" + model.srPlanety.ToString();
            test += "\r\n" + model.wysTopPlanety.ToString();
            test += "\r\n" + model.skalaSr.ToString();
            test += "\r\n" + model.skalaTop.ToString();
            test += "\r\n" + model.skalerTop.ToString();
            textBox_test.Text = test;
        }


        private string checker(string input)
        {
            char last;
            if (input.Length > 1)
            {
                last = input.Substring(input.Length - 1)[0];
            }
            else if (input.Length == 1)
            {
                last = input[0];
            }
            else
            {
                return "";
            }
            textBox_test.Text = last.ToString();
            if ((!char.IsControl(last) && char.IsDigit(last) && last != '.') || last == '.' && input.IndexOf('.') > -1)
            {
                return input;
            }
            else
            {
                MessageBox.Show("Please enter only numbers.");
                if (input.Length > 1)
                {
                    return input.Remove(input.Length - 1);
                }
                else
                {
                    return "";
                }

            }

        }
        //=========================== SkalerTop //
        private void textBoxSkalerTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' || e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void textBoxSkalerTop_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxSkalerTop.Text, out float result) && result > 0)
            {
                model.skalerTop = result;
                textBox_test.Text = model.skalerTop.ToString();
            }
            else
            {
                textBoxSkalerTop.Text = "";
                MessageBox.Show("Please enter only numbers.");
            }
        }
        //=========================== wspólczynnik SrModNaWysTop //
        private void textBoxSrModNaWysTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' || e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void textBoxSrModNaWysTop_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxSrModNaWysTop.Text, out float result) && result > 0)
            {
                model.srModNaWysTopMod = result;
                if (radioButton2.Checked)
                {
                    model.wysTopModelu = model.srModelu / model.srModNaWysTopMod;
                    textBoxWysTopMod.Text = (model.wysTopModelu).ToString();
                }
            }
            else
            {
                textBoxSrModNaWysTop.Text = "";
            }
        }
        //=========================== SkalaTop //
        private void textBoxSkalaTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' || e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void textBoxSkalaTop_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxSkalaTop.Text, out float result) && result > 0)
            {
                model.skalaTop = result;
            }
            else
            {
                textBoxSkalaTop.Text = "";
            }
        }
        //=========================== SkalaSr //
        private void textBoxSkalaSr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' || e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void textBoxSkalaSr_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxSkalaSr.Text, out float result) && result > 0)
            {
                model.skalaSr = result;
            }
            else
            {
                textBoxSkalaSr.Text = "";
            }
        }
        //=========================== WysTopPlanety //
        private void textBoxWysTopPlanety_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' || e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void textBoxWysTopPlanety_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxWysTopPlanety.Text, out float result) && result > 0)
            {
                model.wysTopPlanety = result;
            }
            else
            {
                textBoxWysTopPlanety.Text = "";
            }
        }
        //=========================== SrPlanety //
        private void textBoxSrPlanety_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' || e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void textBoxSrPlanety_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxSrPlanety.Text, out float result) && result > 0)
            {
                model.srPlanety = result;
            }
            else
            {
                textBoxSrPlanety.Text = "";
            }
        }
        //=========================== WysTopMod //
        private void textBoxWysTopMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' || e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void textBoxWysTopMod_TextChanged(object sender, EventArgs e)
        {
            if (!radioButton2.Checked)
            {
                if (float.TryParse(textBoxWysTopMod.Text, out float result) && result > 0)
                {
                    model.wysTopModelu = result;
                    if (!radioButton2.Checked) textBoxSrModNaWysTop.Text = model.IlorazSrTop().ToString();
                    //if (radioButton2.Checked) textBoxWysTopMod.Text = (model.srModelu / model.wysTopModelu).ToString();
                }
                else
                {
                    textBoxWysTopMod.Text = "";
                }
            }
            else
            {

            }
        }
        //=========================== SrModelu //
        private void textBoxSrModelu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' || e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void textBoxSrModelu_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxSrModelu.Text, out float result) && result > 0)
            {
                model.srModelu = result;
                if (!radioButton2.Checked) textBoxSrModNaWysTop.Text = model.IlorazSrTop().ToString();
                if (radioButton2.Checked)
                {
                    model.wysTopModelu = model.srModelu / model.srModNaWysTopMod;
                    textBoxWysTopMod.Text = (model.wysTopModelu).ToString();
                }
            }
            else
            {
                textBoxSrModelu.Text = "";
            }
        }
        //===========================//
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSrModelu.BackColor = SystemColors.Window;
            textBoxWysTopMod.BackColor = SystemColors.Window;
            textBoxSkalaSr.BackColor = Color.LightGray;
            textBoxSkalaTop.BackColor = Color.LightGray;
            textBoxSkalerTop.BackColor = Color.LightGray;
            textBoxSrModNaWysTop.BackColor = Color.LightGray;
            textBoxSrPlanety.BackColor = Color.LightGray;
            textBoxWysTopPlanety.BackColor = Color.LightGray;

            textBoxSrModNaWysTop.Text = model.IlorazSrTop().ToString();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSrModelu.BackColor = SystemColors.Window;
            textBoxWysTopMod.BackColor = Color.LightGray;
            textBoxSkalaSr.BackColor = Color.LightGray;
            textBoxSkalaTop.BackColor = Color.LightGray;
            textBoxSkalerTop.BackColor = Color.LightGray;
            textBoxSrModNaWysTop.BackColor = SystemColors.Window;
            textBoxSrPlanety.BackColor = Color.LightGray;
            textBoxWysTopPlanety.BackColor = Color.LightGray;

            model.wysTopModelu = model.srModelu / model.srModNaWysTopMod;
            textBoxWysTopMod.Text = (model.wysTopModelu).ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSrModelu.BackColor = SystemColors.Window;
            textBoxWysTopMod.BackColor = Color.LightGray;
            textBoxSkalaSr.BackColor = SystemColors.Window;
            textBoxSkalaTop.BackColor = SystemColors.Window;
            textBoxSkalerTop.BackColor = SystemColors.Window;
            textBoxSrModNaWysTop.BackColor = Color.LightGray;
            textBoxSrPlanety.BackColor = SystemColors.Window;
            textBoxWysTopPlanety.BackColor = SystemColors.Window;
        }
        //===========================//




    }

}