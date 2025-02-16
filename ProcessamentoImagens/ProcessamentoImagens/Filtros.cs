using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.ConstrainedExecution;

namespace ProcessamentoImagens
{
    class Filtros
    {
        public static void convert_to_gray(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;
            Int32 gs;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;
                    gs = (Int32)(r * 0.2990 + g * 0.5870 + b * 0.1140);

                    Color newcolor = Color.FromArgb(gs, gs, gs);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        public static void convert_to_move(Bitmap imageBitmapSrc, MouseEventArgs e, TextBox tbR, TextBox tbG, TextBox tbB,TextBox tbMatiz, TextBox tbLum, TextBox tbSat)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int x = e.X;
            int y = e.Y;

            if (x >= 0 && x < width && y >= 0 && y < height)
            {
                Color cor = imageBitmapSrc.GetPixel(x, y);
                tbR.Text = cor.R.ToString();
                tbG.Text = cor.G.ToString();
                tbB.Text = cor.B.ToString();



            }



        }

   

        public static void aumentar_reduzirBrilho(Bitmap imageBitmapSrc, Bitmap imageBitmapDest ,NumericUpDown numUD)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;
            Int32 gs;
            //double a = Math.Cos(Math.PI);
            float novoBrilho;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);


                    novoBrilho = cor.GetBrightness() + cor.GetBrightness() * ((float)numUD.Value) / 100;
                    if (novoBrilho > 1)
                        novoBrilho = 1;
                    Color newcolor = RGBtoHSI(cor.GetHue(), cor.GetSaturation() * 100, novoBrilho * 255);
                    //Color newcolor = RGBtoHSI(210, (float)33.3, (float)149.94);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        public static void aumentar_reduzirMatiz(Bitmap imageBitmapSrc, Bitmap imageBitmapDest, NumericUpDown numUD)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;
            Int32 gs;
            //double a = Math.Cos(Math.PI);
            float novaMatiz;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);


                    novaMatiz  =  (float)numUD.Value;
                    Color newcolor = RGBtoHSI(novaMatiz, cor.GetSaturation() * 100, cor.GetBrightness() * 255);
                    //Color newcolor = RGBtoHSI(210, (float)33.3, (float)149.94);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        private static Color RGBtoHSI(float H, float S, float I)
        {
            float h = H * ((float)Math.PI) / 180;
            float s = S / 100;
            float i = I / 255;

            float x, y, z;

            if(h < (2 *(float)Math.PI) / 3)
            {
                x = i * (1 - s);
                y = i * (1 + (s * ((float)Math.Cos(h)) / ((float)Math.Cos(((float)Math.PI / 3) - h))));
                z = 3 * i - (x + y);
                if(x>1)
                    x = 1;
                if(y>1)
                    y = 1;
                if(z>1) 
                    z = 1;
                return Color.FromArgb((int)(y * 255), (int)(z * 255), (int)(x * 255));
            }
            else if ((2 * (float)Math.PI) / 3 <= h  && h< (4 * (float)Math.PI) / 3)
            {
                h = h - (2 * (float)Math.PI) / 3;

                x = i * (1 - s);
                y = i * (1 + (s * ((float)Math.Cos(h)) / ((float)Math.Cos((((float)Math.PI) / 3) - h))));
                z = 3 * i - (x + y);
                if (x > 1)
                    x = 1;
                if (y > 1)
                    y = 1;
                if (z > 1)
                    z = 1;
                return Color.FromArgb((int)(x * 255), (int)(y * 255), (int)(z * 255));

            }else if ((4 * (float)Math.PI) / 3 <= h && h< 2 * (float)Math.PI)
            {
                h = h - (4 * (float)Math.PI) / 3;

                x = i * (1 - s);
                y = i * (1 + (s * ((float)Math.Cos(h)) / ((float)Math.Cos((((float)Math.PI) / 3) - h))));
                z = 3 * i - (x + y);
                if (x > 1)
                    x = 1;
                if (y > 1)
                    y = 1;
                if (z > 1)
                    z = 1;
                return Color.FromArgb((int)(z * 255), (int)(x * 255), (int)(y * 255));
            }
            return Color.FromArgb(255,255,255);

        }



    }
}
