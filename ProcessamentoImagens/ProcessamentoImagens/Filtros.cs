﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

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



        public static Bitmap aumentar_reduzirMatiz(Bitmap image, float hueShift)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            // Bloqueia os bits da imagem original e da nova imagem
            BitmapData dataSrc = image.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData dataDst = newImage.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int bytes = Math.Abs(dataSrc.Stride) * image.Height;
            byte[] pixelBuffer = new byte[bytes];
            byte[] resultBuffer = new byte[bytes];

            // Copia os bytes da imagem para o buffer
            Marshal.Copy(dataSrc.Scan0, pixelBuffer, 0, bytes);
            image.UnlockBits(dataSrc);

            for (int i = 0; i < bytes; i += 3)
            {
                // Extrai os valores RGB
                byte b = pixelBuffer[i];
                byte g = pixelBuffer[i + 1];
                byte r = pixelBuffer[i + 2];

                // Converte para HSL
                float h, s, l;
                RgbToHsl(Color.FromArgb(r, g, b), out h, out s, out l);

                // Ajusta a matiz
                h = (h + hueShift) % 360;
                if (h < 0) h += 360;

                // Converte de volta para RGB
                Color newColor = HslToRgb(h, s, l);

                // Armazena os novos valores no buffer de saída
                resultBuffer[i] = newColor.B;
                resultBuffer[i + 1] = newColor.G;
                resultBuffer[i + 2] = newColor.R;
            }

            // Copia os dados processados de volta para a nova imagem
            Marshal.Copy(resultBuffer, 0, dataDst.Scan0, bytes);
            newImage.UnlockBits(dataDst);

            return newImage;
        }

        private static void RgbToHsl(Color color, out float h, out float s, out float l)
        {
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            float max = Math.Max(r, Math.Max(g, b));
            float min = Math.Min(r, Math.Min(g, b));

            l = (max + min) / 2;
            float delta = max - min;

            if (delta == 0)
            {
                h = 0;
                s = 0;
            }
            else
            {
                s = (l > 0.5) ? delta / (2 - max - min) : delta / (max + min);

                if (max == r)
                    h = (g - b) / delta + (g < b ? 6 : 0);
                else if (max == g)
                    h = (b - r) / delta + 2;
                else
                    h = (r - g) / delta + 4;

                h *= 60;
            }
        }

        private static Color HslToRgb(float h, float s, float l)
        {
            float r, g, b;

            if (s == 0)
            {
                r = g = b = l;
            }
            else
            {
                float q = l < 0.5 ? l * (1 + s) : l + s - l * s;
                float p = 2 * l - q;

                r = HueToRgb(p, q, h + 120);
                g = HueToRgb(p, q, h);
                b = HueToRgb(p, q, h - 120);
            }

            return Color.FromArgb(
                (int)(r * 255),
                (int)(g * 255),
                (int)(b * 255)
            );
        }

        private static float HueToRgb(float p, float q, float t)
        {
            if (t < 0) t += 360;
            if (t > 360) t -= 360;
            if (t < 60) return p + (q - p) * t / 60;
            if (t < 180) return q;
            if (t < 240) return p + (q - p) * (240 - t) / 60;
            return p;
        }



    }
}
