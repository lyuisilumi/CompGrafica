using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ProcessamentoImagens
{
    public partial class frmPrincipal : Form
    {
        private Image image;
        private Bitmap imageBitmap;
        private int valorMatiz;

        public frmPrincipal()
        {
            InitializeComponent();
            this.Size = new Size(1250, 768);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            trackBarBrilho.Value = 100;
            nUDmatiz.Value = 0;
            valorMatiz = 0;
            tbBrilho.Text = "100";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(openFileDialog.FileName); // Garante que image não será null
                imageBitmap = new Bitmap(image); // Atualiza imageBitmap corretamente
                pictBoxImg1.Image = imageBitmap;
                pictBoxImg1.SizeMode = PictureBoxSizeMode.Zoom; // Mantém a proporção sem perda de qualidade
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictBoxImg1.Image = null;

        }

        private void btnLuminanciaSemDMA_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            imageBitmap = new Bitmap(image); // Atualiza para garantir que temos um bitmap válido
            Bitmap imgDest = new Bitmap(imageBitmap);

            Filtros.convert_to_gray(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
        }



        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictBoxImg1_MouseMove(object sender, MouseEventArgs e)
        {
            if (imageBitmap != null)
            {
                int imgWidth = imageBitmap.Width;
                int imgHeight = imageBitmap.Height;
                int boxWidth = pictBoxImg1.Width;
                int boxHeight = pictBoxImg1.Height;

                // Pegando os limites visíveis da imagem dentro do PictureBox
                float imageAspect = (float)imgWidth / imgHeight;
                float boxAspect = (float)boxWidth / boxHeight;

                int drawWidth, drawHeight, offsetX, offsetY;

                if (imageAspect > boxAspect)
                {
                    // A imagem se ajusta na largura do PictureBox
                    drawWidth = boxWidth;
                    drawHeight = (int)(boxWidth / imageAspect);
                    offsetX = 0;
                    offsetY = (boxHeight - drawHeight) / 2; // Centraliza verticalmente
                }
                else
                {
                    // A imagem se ajusta na altura do PictureBox
                    drawHeight = boxHeight;
                    drawWidth = (int)(boxHeight * imageAspect);
                    offsetY = 0;
                    offsetX = (boxWidth - drawWidth) / 2; // Centraliza horizontalmente
                }

                // Convertendo as coordenadas do mouse para a escala da imagem original
                if (e.X >= offsetX && e.X < offsetX + drawWidth && e.Y >= offsetY && e.Y < offsetY + drawHeight)
                {
                    int imgX = (int)((e.X - offsetX) * (float)imgWidth / drawWidth);
                    int imgY = (int)((e.Y - offsetY) * (float)imgHeight / drawHeight);

                    Color pixelColor = imageBitmap.GetPixel(imgX, imgY);
                    tbRed.Text = pixelColor.R.ToString();
                    tbGreen.Text = pixelColor.G.ToString();
                    tbBlue.Text = pixelColor.B.ToString();

                    // Conversão para CMY
                    int C = 255 - pixelColor.R;
                    int M = 255 - pixelColor.G;
                    int Y = 255 - pixelColor.B;

                    tbC.Text = C.ToString();
                    tbM.Text = M.ToString();
                    tbY.Text = Y.ToString();

                    // Conversão para HSI (caso precise)
                    tbMatiz.Text = ((int)pixelColor.GetHue()).ToString();
                    tbSat.Text = ((int)(pixelColor.GetSaturation() * 100)).ToString();
                    tbLum.Text = ((int)(pixelColor.GetBrightness() * 255)).ToString();
                }
            }
        }

        private void lbMatiz_Click(object sender, EventArgs e)
        {

        }

        private void trackBarBrilho_Scroll(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.aumentar_reduzirBrilho(imageBitmap, imgDest, trackBarBrilho);
            pictBoxImg1.Image = imgDest;
            imageBitmap = imgDest;
        }

        private void tbBrilho_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRed_TextChanged(object sender, EventArgs e)
        {

        }

        private void nUDmatiz_ValueChanged(object sender, EventArgs e)
        {
            int calculoMatiz = (int)nUDmatiz.Value - valorMatiz;
            valorMatiz = (int)nUDmatiz.Value;
            imageBitmap = Filtros.aumentar_reduzirMatiz(imageBitmap, calculoMatiz);
            pictBoxImg1.Image = imageBitmap;
        }
    }
}
