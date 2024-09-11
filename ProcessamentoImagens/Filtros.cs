using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.NetworkInformation;

namespace ProcessamentoImagens
{
    class Filtros
    {
        //sem acesso direto a memoria
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
                    //obtendo a cor do pixel
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;
                    gs = (Int32)(r * 0.2990 + g * 0.5870 + b * 0.1140);

                    //nova cor
                    Color newcolor = Color.FromArgb(gs, gs, gs);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        //sem acesso direito a memoria
        public static void negativo(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //obtendo a cor do pixel
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;

                    //nova cor
                    Color newcolor = Color.FromArgb(255 - r, 255 - g, 255 - b);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        //com acesso direto a memória
        public static void convert_to_grayDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;
            Int32 gs;

            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //lock dados bitmap destino
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src++); //está armazenado dessa forma: b g r 
                        g = *(src++);
                        r = *(src++);
                        gs = (Int32)(r * 0.2990 + g * 0.5870 + b * 0.1140);
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                    }
                    src += padding;
                    dst += padding;
                }
            }
            //unlock imagem origem
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            //unlock imagem destino
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        //com acesso direito a memoria
        public static void negativoDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;

            //lock dados bitmap origem 
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //lock dados bitmap destino
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src1 = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src1++); //está armazenado dessa forma: b g r 
                        g = *(src1++);
                        r = *(src1++);

                        *(dst++) = (byte)(255 - b);
                        *(dst++) = (byte)(255 - g);
                        *(dst++) = (byte)(255 - r);
                    }
                    src1 += padding;
                    dst += padding;
                }
            }
            //unlock imagem origem 
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            //unlock imagem destino
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }


        //espelho horizontal sem acesso a memória
        public static void espelhoHorizontal(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int height = imageBitmapDest.Height;
            int width = imageBitmapDest.Width;
            int posFinal;

            for (int y = 0; y < height; y++)
            {
                posFinal = width - 1;
                for (int x = 0; x < width; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    imageBitmapDest.SetPixel(posFinal, y, cor);
                    posFinal--;
                    
                }
            }
        }

        public static void espelhoVerical(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int height = imageBitmapSrc.Height;
            int width = imageBitmapSrc.Width;

            int posFinal;

            for (int x = 0; x < width; x++)
            {
                posFinal = height - 1;
                for (int y = 0; y < height; y++)
                {
                   
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    imageBitmapDest.SetPixel(x, posFinal, cor);
                    posFinal--;
                }
            }
        }

        public static void inverterRB(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;

            for (int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    int r = cor.R;
                    int g = cor.G;
                    int b = cor.B;


                    Color newColor = Color.FromArgb(b, g, r);
                    imageBitmapDest.SetPixel(x, y, newColor);
                }
            }
        }

        public static void espelhoDiagonalPrincipal(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int height = imageBitmapSrc.Height;
            int width = imageBitmapSrc.Width;

            int auxHeight = height - 1;
            for (int y = 0; y < height; y++)
            {
                int auxWidth = width - 1;
                for (int x = 0; x < width; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);
                    imageBitmapDest.SetPixel(auxWidth, auxHeight, cor);
                    auxWidth--;
                }

                auxHeight--;
            }
        }

        public static void pretoEBranco(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int height = imageBitmapSrc.Height;
            int width = imageBitmapSrc.Width;

            for (int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y) ;

                    int r = cor.R;
                    int g = cor.G;
                    int b = cor.B;

                    int media = (r + g + b) / 3;

                    Color novaCor;

                    if (media >= 127)
                    {
                        novaCor = Color.White;   
                    }
                    else
                    {
                        novaCor = Color.Black;
                    }

                    imageBitmapDest.SetPixel(x, y, novaCor);
                }
            }
        }

        public static void separaCanalRBG(Bitmap imageBitmapSrc, Bitmap imageBitmapDest, char canal)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;

            for (int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    Color novaCor;

                    if (canal == 'R')
                    {
                        novaCor = Color.FromArgb(cor.R, 0, 0);
                    } else if(canal == 'G')
                    {
                       novaCor = Color.FromArgb(0, cor.G, 0);
                    } else
                    {
                        novaCor = Color.FromArgb(0, 0, cor.B);
                    }

                    imageBitmapDest.SetPixel(x, y, novaCor);
                }
            }
        }
    }
}
