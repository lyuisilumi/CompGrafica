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

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            nUDbrilho.Value = 0;
            nUDmatiz.Value = 0;
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pictBoxImg1.Image = image;
                pictBoxImg1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictBoxImg1.Image = null;

        }

        private void btnLuminanciaSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_gray(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
        }



        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictBoxImg1_MouseMove(object sender, MouseEventArgs e)
        {
            imageBitmap = (Bitmap)image;
            if(imageBitmap != null)
            {
                int width = imageBitmap.Width;
                int height = imageBitmap.Height;
                int R, G, B,H,S,I;
                double h,s,i, r, g, b,min;
                if (e.X >= 0 && e.X < width && e.Y >= 0 && e.Y < height) {
                    R = imageBitmap.GetPixel(e.X, e.Y).R;
                    G = imageBitmap.GetPixel(e.X, e.Y).G;
                    B = imageBitmap.GetPixel(e.X, e.Y).B;
                    tbRed.Text = R.ToString();
                    tbGreen.Text = G.ToString();
                    tbBlue.Text = B.ToString();
                    tbC.Text = (255 - R).ToString();
                    tbM.Text = (255 - G).ToString();
                    tbY.Text = (255 - B).ToString();
                    tbMatiz.Text = ((int)imageBitmap.GetPixel(e.X, e.Y).GetHue()).ToString();
                    tbSat.Text = ((int)imageBitmap.GetPixel(e.X, e.Y).GetSaturation()).ToString();
                    tbLum.Text = ((int)imageBitmap.GetPixel(e.X, e.Y).GetBrightness()).ToString();



                    /*r = R / (R + G + B);
                    g = G / (R + G + B);
                    b = B / (R + G + B);
                    if(b <= g)
                        h = Math.Acos((0.5 * ((r - g) + (r - b))) / Math.Sqrt(Math.Pow((r - g), 2) + (r - b) * (g - b)));
                    else
                        h = 2*3.1415 - Math.Acos((0.5 * ((r - g) + (r - b))) / Math.Sqrt(Math.Pow((r - g), 2) + (r - b) * (g - b)));
                    if (r > g)
                        min = g;
                    else
                        min = r;
                    if (min < b)
                        min = b;
                    s = 1 - (3 * min);
                    i = (R+G+B) / (3*255);
               
                    H = (int)((int)(h * 180) / Math.PI);
                    S = (int)s * 100;
                    I = (int)i * 255;
                    tbMatiz.Text = H.ToString();
                    tbSat.Text = S.ToString();
                    tbLum.Text = I.ToString();*/
                }

            }
            
        }

        private void nUDbrilho_ValueChanged(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.aumentar_reduzirBrilho(imageBitmap, imgDest,nUDbrilho);
            pictBoxImg1.Image = imgDest;
        }

        private void nUDmatiz_ValueChanged(object sender, EventArgs e)
        {

            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.aumentar_reduzirMatiz(imageBitmap, imgDest, nUDmatiz);
            pictBoxImg1.Image = imgDest;
        }
    }
}
