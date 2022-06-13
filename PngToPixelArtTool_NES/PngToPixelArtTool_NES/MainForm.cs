using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PngToPixelArtTool_NES
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG files|*.png";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select image.png file";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int numberOfPixelsWidth = 80;
                int numberOfPixelsHeight = 80;

                Bitmap originalBmp = new Bitmap(openFileDialog.FileName);
                Bitmap pixelatedBmp = new Bitmap(numberOfPixelsWidth, numberOfPixelsHeight);

                pictureBox_Original.Image = originalBmp;

                int xStep = originalBmp.Width / numberOfPixelsWidth;
                int yStep = originalBmp.Height / numberOfPixelsHeight;

                for (int x = 0; x < numberOfPixelsWidth; x++)
                {
                    for (int y = 0; y < numberOfPixelsHeight; y++)
                    {
                        int r = 0;
                        int g = 0;
                        int b = 0;

                        int numPixels = 0;

                        for (int xInc = 0; xInc < xStep; xInc++)
                        {
                            for (int yInc = 0; yInc < yStep; yInc++)
                            {
                                Color colour = originalBmp.GetPixel((x * xStep) + xInc, (y * yStep) + yInc);

                                r += colour.R;
                                g += colour.G;
                                b += colour.B;

                                numPixels++;
                            }
                        }

                        r /= numPixels;
                        g /= numPixels;
                        b /= numPixels;

                        pixelatedBmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }

                pictureBox_Pixelated.Image = ResizeImage(pixelatedBmp, originalBmp.Width, originalBmp.Height);

                MessageBox.Show($"Success {openFileDialog.FileName}", "Title", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
