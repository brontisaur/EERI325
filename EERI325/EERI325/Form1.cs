using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;

namespace EERI325
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //string image = "cat.jpg";
            string image = "benny.jpg";

                Image cat = Image.FromFile(image);

            //Bitmap bmp = new Bitmap(new Bitmap(cat), new Size(256,128));
            Bitmap bmp = new Bitmap(new Bitmap(cat), new Size(128, 256));
            originalIMG.Image = bmp;

             
        }

        private void btnRGB_Click(object sender, EventArgs e)
        {

            //string image = "cat.jpg";
            string image = "benny.jpg";

            Image cat = Image.FromFile(image);

            
            //Bitmap bmap = new Bitmap(new Bitmap(cat),new Size(256,128));
            Bitmap bmap = new Bitmap(new Bitmap(cat), new Size(128, 256));

            Bitmap red = new Bitmap(bmap);
            Bitmap green = new Bitmap(bmap);
            Bitmap blue = new Bitmap(bmap);

            originalIMG1.Image = bmap;

            int height = bmap.Height;
            int width = bmap.Width;



            for (int y = 0; y<height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bmap.GetPixel(x, y);

                    int alpha = pixel.A;
                    int rpix = pixel.R;
                    int gpix = pixel.G;
                    int bpix = pixel.B;

                    red.SetPixel(x, y, Color.FromArgb(alpha, rpix, 0, 0));
                    green.SetPixel(x, y, Color.FromArgb(alpha,0, gpix, 0));
                    blue.SetPixel(x, y, Color.FromArgb(alpha, 0, 0, bpix));
                }
            }


            RED.Image = red;
            GREEN.Image = green;
            BLUE.Image = blue;

        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            //string image = "cat.jpg";
            string image = "benny.jpg";

            Image cat = Image.FromFile(image);

            //Bitmap grey = new Bitmap(new Bitmap(cat),new Size(256,128));
            Bitmap grey = new Bitmap(new Bitmap(cat), new Size(128, 256));
            //Bitmap kitty = new Bitmap(new Bitmap(cat), new Size(256,128));
            Bitmap kitty = new Bitmap(new Bitmap(cat), new Size(128, 256));

            int width = kitty.Width;
            int height = kitty.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = kitty.GetPixel(x, y);

                    int alpha = pixel.A;
                    int rpix = pixel.R;
                    int gpix = pixel.G;
                    int bpix = pixel.B;

                    int gray = (rpix + gpix + bpix) / 3;

                    grey.SetPixel(x, y, Color.FromArgb(alpha, gray, gray, gray));
                    
                }
            }

            originalIMG2.Image = kitty;
            GRAY.Image = grey;
;
        }

        private void btnDFT_Click(object sender, EventArgs e)
        {
            //string image = "cat.jpg";
            string image = "benny.jpg";

            //Bitmap kitty = new Bitmap(new Bitmap(image), new Size(256, 128));
            Bitmap kitty = new Bitmap(new Bitmap(image), new Size(128, 256));

            Bitmap grey = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply(kitty);

            originalIMG3.Image = grey;

            AForge.Imaging.ComplexImage baseComplex = AForge.Imaging.ComplexImage.FromBitmap(grey);
            baseComplex.ForwardFourierTransform();
            Bitmap BaseFourier = baseComplex.ToBitmap();

            int width = kitty.Width;
            int height = kitty.Height;

            double Real = 0;
            double Imag = 0;
            double mag = 0;
            double ph = 0;


            //Bitmap phaseComp = new Bitmap(new Bitmap(kitty), new Size(256, 128));
            Bitmap phaseComp = new Bitmap(new Bitmap(kitty), new Size(128, 256));
            //Bitmap magComp = new Bitmap(new Bitmap(kitty), new Size(256, 128));
            Bitmap magComp = new Bitmap(new Bitmap(kitty), new Size(128, 256));


            int scaleconst = 100000;
            int phaseconst = 100;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Real = baseComplex.Data[y, x].Re;
                    Imag = baseComplex.Data[y, x].Im;

                    mag = Math.Sqrt(Real * Real + Imag * Imag);
                    ph = Math.Atan2(Imag, Real);

                    int phasecol = (int)Math.Abs(Math.Log(1 + ph) * phaseconst);

                    int color = (int)Math.Abs((Math.Log10(1 + mag) * scaleconst));
                    if (color > 255)
                    {
                        color = 255;
                    }
                    if (phasecol > 255)
                    {
                        phasecol = 255;
                    }
                    if (phasecol < 0)
                    {
                        phasecol = 0;
                    }
                    magComp.SetPixel(x, y, Color.FromArgb(255, color, color, color));
                    phaseComp.SetPixel(x,y, Color.FromArgb(255, phasecol, phasecol, phasecol));
                }
            }

            magnitude.Image = magComp;
            phase.Image = phaseComp;
            baseFourier.Image = BaseFourier;
        }

        private void btnIDFT_Click(object sender, EventArgs e)
        {
            //string image = "cat.jpg";
            string image = "benny.jpg";
            //Bitmap kitty = new Bitmap(new Bitmap(image), new Size(256, 128));
            Bitmap kitty = new Bitmap(new Bitmap(image), new Size(128, 256));
            Bitmap grey = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply(kitty);

            AForge.Imaging.ComplexImage baseComplex = AForge.Imaging.ComplexImage.FromBitmap(grey);
            baseComplex.ForwardFourierTransform();
            baseComplex.BackwardFourierTransform();
            Bitmap InverseFourier = baseComplex.ToBitmap();

            originalIMG4.Image = grey;
            inverse.Image = InverseFourier;

        }

        private void btnHighpass_Click(object sender, EventArgs e)
        {
            //string image = "cat.jpg";
            string image = "benny.jpg";
            //Bitmap kitty = new Bitmap(new Bitmap(image), new Size(256, 128));
            Bitmap kitty = new Bitmap(new Bitmap(image), new Size(128, 256));
            Bitmap grey = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply(kitty);

            AForge.Imaging.ComplexImage baseComplex = AForge.Imaging.ComplexImage.FromBitmap(grey);
            baseComplex.ForwardFourierTransform();

            double Real = 0;
            double Imag = 0;
            double mag = 0;
            int scaleconst = 100000;

            Bitmap MagnitudeOriginal = baseComplex.ToBitmap();
            Bitmap MagnitudeFiltered = new Bitmap(grey);

            int height = grey.Height;
            int width = grey.Width;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Real = baseComplex.Data[y, x].Re;
                    Imag = baseComplex.Data[y, x].Im;

                    mag = Math.Sqrt(Real * Real + Imag * Imag);
                    int color = (int)Math.Abs((Math.Log10(1 + mag) * scaleconst));
                    if (color > 255)
                    {
                        color = 255;
                    }
                   MagnitudeFiltered.SetPixel(x, y, Color.FromArgb(255, color, color, color));
                }
            }


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color Pixel = MagnitudeFiltered.GetPixel(x, y); //check to see mechanism of Fourier transform and magnitudes of lower frequencies
                    if (Pixel.B > 128)
                    {
                        MagnitudeFiltered.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                        baseComplex.Data[y, x].Im = 0;
                        baseComplex.Data[y, x].Re = 0;

                    }
                }
            }

            baseComplex.BackwardFourierTransform();
            Bitmap InverseFourierFiltered = baseComplex.ToBitmap();

            originalIMG5.Image = grey;
            Filtered.Image = InverseFourierFiltered;
            OriginalMagnitude.Image = MagnitudeOriginal;
            FilteredMagnitude.Image = MagnitudeFiltered;

        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            //string image = "cat.jpg";
            string image = "benny.jpg";
            //Bitmap kitty = new Bitmap(new Bitmap(image), new Size(256, 128));
            Bitmap kitty = new Bitmap(new Bitmap(image), new Size(128, 256));
            Bitmap grey = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply(kitty);

            AForge.Imaging.ComplexImage baseComplex = AForge.Imaging.ComplexImage.FromBitmap(grey);
            baseComplex.ForwardFourierTransform();

            double Real = 0;
            double Imag = 0;
            double mag = 0;
            int scaleconst = 100000;

            Bitmap MagnitudeOriginal = baseComplex.ToBitmap();
            Bitmap MagnitudeFiltered = new Bitmap(grey);

            int height = grey.Height;
            int width = grey.Width;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Real = baseComplex.Data[y, x].Re;
                    Imag = baseComplex.Data[y, x].Im;


                    mag = Math.Sqrt(Real * Real + Imag * Imag);
                    int color = (int)Math.Abs((Math.Log10(1 + mag) * scaleconst));
                    if (color > 255)
                    {
                        color = 255;
                    }


                    MagnitudeFiltered.SetPixel(x, y, Color.FromArgb(255, color, color, color));
                }

            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color Pixel = MagnitudeFiltered.GetPixel(x, y); 
                    if (Pixel.B > 250)
                    {
                        MagnitudeFiltered.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                        baseComplex.Data[y, x].Im = 0;
                        baseComplex.Data[y, x].Re = 0;

                    }
                }
            }

            baseComplex.BackwardFourierTransform();
            Bitmap InverseFourierFiltered = baseComplex.ToBitmap();
            Bitmap grey2 = new Bitmap(InverseFourierFiltered);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x< width; x++)
                {
             
                    Color Pixel2 = grey2.GetPixel(x, y);

                    int Red1 = 255;
                    int Red2 = Pixel2.R;

                    int sketch = Math.Abs(Red2 - Red1);

                    if (sketch > 220)
                    {
                        sketch = 255;
                    }
                    if (sketch < 220)
                    {
                        sketch = 150*(sketch/230);
                    }
                    

                    grey2.SetPixel(x, y, Color.FromArgb(255, sketch, sketch, sketch));

                }
            }



            originalIMG6.Image = grey;
            PencilSketch.Image = grey2;


        }
    }
}
