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
            pictBoxImg2.Image = null;
        }

        private void btnLuminanciaSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_gray(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnLuminanciaComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_grayDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnNegativoSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.negativo(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnNegativoComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.negativoDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnEspelhoHorizontal_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelhoHorizontal(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnEspelhoVertical_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelhoVerical(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
            
        }

        private void btnInverterRB_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.inverterRB(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnEspelhoDiagonalPrincipal(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelhoDiagonalPrincipal(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnPretoEBranco_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.pretoEBranco(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;

        }

        private void btnSeparaCanalR_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separaCanalRBG(imageBitmap, imgDest, 'R');
            pictBoxImg2.Image = imgDest;
        }

        private void btnSeparaCanalG_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separaCanalRBG(imageBitmap, imgDest, 'G');
            pictBoxImg2.Image = imgDest;
        }

        private void btnSeparaCanalB_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separaCanalRBG(imageBitmap, imgDest, 'B');
            pictBoxImg2.Image = imgDest;
        }

        private void btnInverterNoventa_Click(object sender, EventArgs e)
        {
            
            Bitmap imgDest = new Bitmap(image.Height, image.Width);
            imageBitmap = (Bitmap)image;
            Filtros.inverterNoventa(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnDivisaoCentro_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.divisaoCentro(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }
    }
}
