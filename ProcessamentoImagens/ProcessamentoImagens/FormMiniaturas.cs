using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ProcessamentoImagens
{

    public partial class FormMiniaturas : Form
    {
        public FormMiniaturas(Bitmap image)
        {
            InitializeComponent();

            // Convertendo a imagem para canais RGB e HSI
            Bitmap rChannel = GetChannelImageRGB(image, 'R');
            Bitmap gChannel = GetChannelImageRGB(image, 'G');
            Bitmap bChannel = GetChannelImageRGB(image, 'B');
            Bitmap hChannel = GetChannelImageHSI(image, 'H');
            Bitmap sChannel = GetChannelImageHSI(image, 'S');
            Bitmap iChannel = GetChannelImageHSI(image, 'I');

            // Exibindo as miniaturas nas PictureBoxes
            pictBoxImgR.Image = rChannel;
            pictBoxImgG.Image = gChannel;
            pictBoxImgB.Image = bChannel;
            pictBoxImgH.Image = hChannel;
            pictBoxImgS.Image = sChannel;
            pictBoxImgI.Image = iChannel;

            // Ajustando o tamanho da imagem na PictureBox
            pictBoxImgR.SizeMode = PictureBoxSizeMode.Zoom;
            pictBoxImgG.SizeMode = PictureBoxSizeMode.Zoom;
            pictBoxImgB.SizeMode = PictureBoxSizeMode.Zoom;
            pictBoxImgH.SizeMode = PictureBoxSizeMode.Zoom;
            pictBoxImgS.SizeMode = PictureBoxSizeMode.Zoom;
            pictBoxImgI.SizeMode = PictureBoxSizeMode.Zoom;

            // Atualizando os labels
            labelR.Text = "Canal R";
            labelG.Text = "Canal G";
            labelB.Text = "Canal B";
            labelH.Text = "Canal H";
            labelS.Text = "Canal S";
            labelI.Text = "Canal I";
        }

        // Função para obter a imagem de um canal RGB específico
        private Bitmap GetChannelImageRGB(Bitmap image, char channel)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            // Usando acesso direto à memória
            BitmapData data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                            ImageLockMode.ReadOnly,
                                            PixelFormat.Format24bppRgb);
            int bytesPerPixel = 3;
            int heightInPixels = data.Height;
            int widthInBytes = data.Width * bytesPerPixel;
            byte[] pixelData = new byte[widthInBytes * heightInPixels];

            Marshal.Copy(data.Scan0, pixelData, 0, pixelData.Length);
            image.UnlockBits(data);

            for (int y = 0; y < heightInPixels; y++)
            {
                for (int x = 0; x < widthInBytes; x += bytesPerPixel)
                {
                    int pixelIndex = y * widthInBytes + x;

                    byte r = pixelData[pixelIndex + 2]; // Red
                    byte g = pixelData[pixelIndex + 1]; // Green
                    byte b = pixelData[pixelIndex];     // Blue

                    int grayValue = 0;
                    switch (channel)
                    {
                        case 'R':
                            grayValue = r;
                            break;
                        case 'G':
                            grayValue = g;
                            break;
                        case 'B':
                            grayValue = b;
                            break;
                    }

                    pixelData[pixelIndex] = (byte)grayValue;
                    pixelData[pixelIndex + 1] = (byte)grayValue;
                    pixelData[pixelIndex + 2] = (byte)grayValue;
                }
            }

            // Criando a nova imagem com os dados alterados
            Bitmap outputBitmap = new Bitmap(image.Width, image.Height);
            BitmapData outputData = outputBitmap.LockBits(new Rectangle(0, 0, outputBitmap.Width, outputBitmap.Height),
                                                          ImageLockMode.WriteOnly,
                                                          PixelFormat.Format24bppRgb);

            Marshal.Copy(pixelData, 0, outputData.Scan0, pixelData.Length);
            outputBitmap.UnlockBits(outputData);
            return outputBitmap;
        }

        
        private Bitmap GetChannelImageHSI(Bitmap image, char channel)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            BitmapData data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                            ImageLockMode.ReadOnly,
                                            PixelFormat.Format24bppRgb);

            int bytesPerPixel = 3;
            int heightInPixels = data.Height;
            int widthInBytes = data.Width * bytesPerPixel;
            byte[] pixelData = new byte[widthInBytes * heightInPixels];

            Marshal.Copy(data.Scan0, pixelData, 0, pixelData.Length);
            image.UnlockBits(data);

            for (int y = 0; y < heightInPixels; y++)
            {
                for (int x = 0; x < widthInBytes; x += bytesPerPixel)
                {
                    int pixelIndex = y * widthInBytes + x;

                    byte r = pixelData[pixelIndex + 2]; 
                    byte g = pixelData[pixelIndex + 1]; 
                    byte b = pixelData[pixelIndex];     

                    // conversão RGB para HSI
                    float hue, saturation, intensity;
                    RGBtoHSI(r, g, b, out hue, out saturation, out intensity);

                    int grayValue = 0;
                    switch (channel)
                    {
                        case 'H':
                            grayValue = (int)((hue * 255) / 360);  // Normalizando H (0-360 → 0-255)
                            break;
                        case 'S':
                            grayValue = (int)(saturation * 255);  // Normalizando S (0-1 → 0-255)
                            break;
                        case 'I':
                            grayValue = (int)(intensity * 255);  // Normalizando I (0-1 → 0-255)
                            break;
                    }

                    // Garantindo que o valor está dentro dos limites de 0 a 255
                    grayValue = Math.Max(0, Math.Min(255, grayValue));

                    pixelData[pixelIndex] = (byte)grayValue;
                    pixelData[pixelIndex + 1] = (byte)grayValue;
                    pixelData[pixelIndex + 2] = (byte)grayValue;
                }
            }

            Bitmap outputBitmap = new Bitmap(image.Width, image.Height);
            BitmapData outputData = outputBitmap.LockBits(new Rectangle(0, 0, outputBitmap.Width, outputBitmap.Height),
                                                          ImageLockMode.WriteOnly,
                                                          PixelFormat.Format24bppRgb);

            Marshal.Copy(pixelData, 0, outputData.Scan0, pixelData.Length);
            outputBitmap.UnlockBits(outputData);
            return outputBitmap;
        }


        // Função para conversão de RGB para HSI
        private void RGBtoHSI(int r, int g, int b, out float h, out float s, out float i)
        {
            // Conversão de RGB para HSI
            float R = r / 255f;
            float G = g / 255f;
            float B = b / 255f;

            float min = Math.Min(Math.Min(R, G), B);
            float max = Math.Max(Math.Max(R, G), B);
            float delta = max - min;

            // Intensity
            i = (max + min) / 2;

            // Saturation
            s = (max == 0) ? 0 : (1 - min / max);

            // Hue
            if (delta == 0)
                h = 0;
            else if (max == R)
                h = (G - B) / delta;
            else if (max == G)
                h = (B - R) / delta + 2;
            else
                h = (R - G) / delta + 4;

            h *= 60;
            if (h < 0) h += 360;
        }
    }

}
