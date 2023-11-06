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
        public Form1()
        {
            InitializeComponent();

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

        public static Bitmap RemoveRed(Bitmap image)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y);
                    Color newPixel = Color.FromArgb(pixel.A, 0, pixel.G, pixel.B);
                    newImage.SetPixel(x, y, newPixel);
                }
            }
            return newImage;
        }

        public static int[,] BitmapToIntArray(Bitmap image)
        {
            int[,] array = new int[image.Width, image.Height];
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y);
                    array[x, y] = pixel.ToArgb();
                }
            }
            return array;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mapa_box.Image = bmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mapa_box.Image = null;
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
    }
}