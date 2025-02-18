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

            // Bloquear os bits das imagens para acesso direto à memória
            BitmapData srcData = imageBitmapSrc.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            BitmapData destData = imageBitmapDest.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);

            int stride = srcData.Stride; // Largura real da linha de pixels (considera alinhamento de memória)
            int bytesPerPixel = 3; // Formato 24bpp (RGB)

            unsafe
            {
                byte* srcPtr = (byte*)srcData.Scan0;
                byte* destPtr = (byte*)destData.Scan0;

                for (int y = 0; y < height; y++)
                {
                    byte* srcRow = srcPtr + (y * stride);
                    byte* destRow = destPtr + (y * stride);

                    for (int x = 0; x < width; x++)
                    {
                        // Os valores são armazenados em BGR (ordem invertida)
                        byte b = srcRow[x * bytesPerPixel];
                        byte g = srcRow[x * bytesPerPixel + 1];
                        byte r = srcRow[x * bytesPerPixel + 2];

                        // Calcular o tom de cinza
                        byte gray = (byte)(r * 0.299 + g * 0.587 + b * 0.114);

                        // Substituir valores no destino
                        destRow[x * bytesPerPixel] = gray;      // Azul (B)
                        destRow[x * bytesPerPixel + 1] = gray;  // Verde (G)
                        destRow[x * bytesPerPixel + 2] = gray;  // Vermelho (R)
                    }
                }
            }

            // Desbloquear os bits após processamento
            imageBitmapSrc.UnlockBits(srcData);
            imageBitmapDest.UnlockBits(destData);
        }

        public static void aumentar_reduzirBrilho(Bitmap imageBitmap, Bitmap imageBitmapDest, TrackBar trackBar)
        {
            int width = imageBitmap.Width;
            int height = imageBitmap.Height;
            float ajusteBrilho = (float)(trackBar.Value-100) / 100;  // Convertendo o valor para um intervalo de 0 a 2

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

        public static void alterarMatiz(Bitmap imageBitmap, Bitmap imageBitmapDest, TrackBar trackBar)
        {
            int width = imageBitmap.Width;
            int height = imageBitmap.Height;

            // Ajuste da matiz baseado no valor do TrackBar.
            float ajusteMatiz = trackBar.Value; // 0 a 360 ou -180 a 180 dependendo da configuração do TrackBar.

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

                        // Converter a cor RGB para HSB
                        float hue = Color.FromArgb(r, g, b).GetHue();
                        float saturation = Color.FromArgb(r, g, b).GetSaturation();
                        float brightness = Color.FromArgb(r, g, b).GetBrightness();

                        // Ajustar a matiz (hue)
                        hue += ajusteMatiz;
                        if (hue > 360) hue -= 360;
                        if (hue < 0) hue += 360;

                        // Converter de volta para RGB
                        Color newColor = ColorFromHSV(hue, saturation, brightness);

                        dest[index] = newColor.B;
                        dest[index + 1] = newColor.G;
                        dest[index + 2] = newColor.R;
                    }
                }
            }

            imageBitmap.UnlockBits(srcData);
            imageBitmapDest.UnlockBits(destData);
        }

        public static Color ColorFromHSV(float hue, float saturation, float brightness)
        {
            // Limitar os valores de hue, saturation, brightness para garantir que não estejam fora dos limites
            hue = hue % 360;
            saturation = Math.Max(0, Math.Min(1, saturation));
            brightness = Math.Max(0, Math.Min(1, brightness));

            int hi = (int)(hue / 60) % 6;
            float f = hue / 60 - (int)(hue / 60);
            float p = brightness * (1 - saturation);
            float q = brightness * (1 - f * saturation);
            float t = brightness * (1 - (1 - f) * saturation);

            float r = 0, g = 0, b = 0;

            switch (hi)
            {
                case 0: r = brightness; g = t; b = p; break;
                case 1: r = q; g = brightness; b = p; break;
                case 2: r = p; g = brightness; b = t; break;
                case 3: r = p; g = q; b = brightness; break;
                case 4: r = t; g = p; b = brightness; break;
                case 5: r = brightness; g = p; b = q; break;
            }

            return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
        }



    }
}
