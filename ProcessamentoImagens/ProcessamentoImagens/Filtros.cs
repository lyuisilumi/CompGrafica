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
        public static void aumentar_reduzirBrilho(Bitmap imageBitmap, Bitmap imageBitmapDest, TrackBar trackBar)
        {
            int width = imageBitmap.Width;
            int height = imageBitmap.Height;

            // Ajuste de brilho: mapeando 100 para sem alteração e valores abaixo de 100 para redução de brilho
            float ajusteBrilho = (float)(trackBar.Value - 100) / 100;  // Ajusta o brilho com base em 100 como base

            BitmapData srcData = imageBitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData destData = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;
            IntPtr srcPtr = srcData.Scan0;
            IntPtr destPtr = destData.Scan0;

            unsafe
            {
                byte* src = (byte*)srcPtr;
                byte* dest = (byte*)destPtr;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int index = (y * stride) + (x * 3);
                        byte b = src[index];
                        byte g = src[index + 1];
                        byte r = src[index + 2];

                        // Ajuste de brilho direto nos componentes RGB
                        int rNovo = (int)(r * (1 + ajusteBrilho));
                        int gNovo = (int)(g * (1 + ajusteBrilho));
                        int bNovo = (int)(b * (1 + ajusteBrilho));

                        // Garantir que os valores estejam dentro dos limites válidos (0-255)
                        rNovo = Math.Max(0, Math.Min(255, rNovo));
                        gNovo = Math.Max(0, Math.Min(255, gNovo));
                        bNovo = Math.Max(0, Math.Min(255, bNovo));

                        // Definir o novo valor da cor ajustada
                        dest[index] = (byte)bNovo;
                        dest[index + 1] = (byte)gNovo;
                        dest[index + 2] = (byte)rNovo;
                    }
                }
            }

            imageBitmap.UnlockBits(srcData);
            imageBitmapDest.UnlockBits(destData);
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


                    novaMatiz = (float)numUD.Value;
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

            if (h < (2 * (float)Math.PI) / 3)
            {
                x = i * (1 - s);
                y = i * (1 + (s * ((float)Math.Cos(h)) / ((float)Math.Cos(((float)Math.PI / 3) - h))));
                z = 3 * i - (x + y);
                if (x > 1)
                    x = 1;
                if (y > 1)
                    y = 1;
                if (z > 1)
                    z = 1;
                return Color.FromArgb((int)(y * 255), (int)(z * 255), (int)(x * 255));
            }
            else if ((2 * (float)Math.PI) / 3 <= h && h < (4 * (float)Math.PI) / 3)
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

            }
            else if ((4 * (float)Math.PI) / 3 <= h && h < 2 * (float)Math.PI)
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
            return Color.FromArgb(255, 255, 255);

        }



    }
}
