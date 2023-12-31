﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Planety3D
{
    public class Mapa
    {
        public Mapa() {
            this.maxpx = -1;
            this.maxpxR = -1;
            this.maxpxG = -1;
            this.maxpxB = -1;
            this.minpx = 1000000;
            this.minpxR = 1000000;
            this.minpxG = 1000000;
            this.minpxB = 1000000;
        }
        public Mapa(Bitmap bmap)
        {
            this.w = bmap.Width;
            this.h = bmap.Height;
            this.maxpx = -1;
            this.maxpxR = -1;
            this.maxpxG = -1;
            this.maxpxB = -1;
            this.minpx = 1000000;
            this.minpxR = 1000000;
            this.minpxG = 1000000;
            this.minpxB = 1000000;
            this.tabpx = new int[w,h];

        }

        public int w; 
        public int h;
        public int maxpx;
        public int minpx;
        public int maxpxR;
        public int minpxR;
        public int maxpxB;
        public int minpxB;
        public int maxpxG;
        public int minpxG;
        public int[,] tabpx;

        private void TabCheck(Bitmap image)
        {
            int x = image.Width;
            int y = image.Height;
            if (tabpx == null)
            {
                w = x;
                h = y;
                tabpx = new int[w, h];
            }
            else if (tabpx.GetLength(1) != x || tabpx.GetLength(2) != y)
            {
                w = x;
                h = y;
                tabpx = null;
                tabpx = new int[w, h];
            }
        }

        public void BitmapToIntArray(Bitmap image)
        {
           
            TabCheck(image);
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    tabpx[x, y] = pixelColor.R;
                }
            }
        }
        public void BitmapMaxMin(Bitmap bitmap)
        {
            int w2 = bitmap.Width;
            int h2 = bitmap.Height;
            for (int x = 0; x < w2; x++)
            {
                for (int y = 0; y < h2; y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    if (pixelColor.R > maxpxR)
                    {
                        maxpxR = pixelColor.R;
                    }
                    if (pixelColor.R < minpxR)
                    {
                        minpxR = pixelColor.R;
                    }

                    if (pixelColor.G > maxpxR)
                    {
                        maxpxG = pixelColor.G;
                    }
                    if (pixelColor.G < minpxG)
                    {
                        minpxG = pixelColor.G;
                    }

                    if (pixelColor.B > maxpxB)
                    {
                        maxpxB = pixelColor.B;
                    }
                    if (pixelColor.B < minpxB)
                    {
                        minpxB = pixelColor.B;
                    }

                    maxpx = maxpxB;
                    if (maxpx < maxpxG) maxpx = maxpxG;
                    if (maxpx < maxpxR) maxpx = maxpxR;
                    minpx = minpxB;
                    if (minpx > minpxG) minpx = minpxG;
                    if (minpx > minpxR) minpx = minpxR;


                }
            }
        }
    }
}
