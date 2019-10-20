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
            string image = "cat.jpg";

            if (!System.IO.File.Exists(image))
                MessageBox.Show("Oops");
            else
            {
                Image cat = Image.FromFile(image);

                Bitmap bmp = new Bitmap(cat);
                originalIMG.Image = cat;
            }

             
        }

        private void btnRGB_Click(object sender, EventArgs e)
        {

            string image = "cat.jpg";

            Image cat = Image.FromFile(image);

            originalIMG1.Image = cat;

            int height = cat.Height;
            int width = cat.Width;

            Bitmap red = new Bitmap(cat);
            Bitmap green = new Bitmap(cat);
            Bitmap blue = new Bitmap(cat);

            Bitmap bmap = new Bitmap(cat);

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
            string image = "cat.jpg";

            Image cat = Image.FromFile(image);

            Bitmap grey = new Bitmap(cat);
            Bitmap kitty = new Bitmap(cat);

            int width = cat.Width;
            int height = cat.Height;

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
;
        }

        private void btnDFT_Click(object sender, EventArgs e)
        {
            string image = "cat.jpg";

            Bitmap grey = new Bitmap(image);
            Bitmap kitty = new Bitmap(image);

           
        }
    }
}
