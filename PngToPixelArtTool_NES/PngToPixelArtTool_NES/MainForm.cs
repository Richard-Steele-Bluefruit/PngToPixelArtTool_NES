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

        static Color[] NESColours =
        {
            Color.FromArgb(84, 84, 84),
            Color.FromArgb(0, 30, 116),
            Color.FromArgb(8, 16, 144),
            Color.FromArgb(48, 0, 136),
            Color.FromArgb(68, 0, 100),
            Color.FromArgb(92, 0, 48),
            Color.FromArgb(84, 4, 0),
            Color.FromArgb(60, 24, 0),
            Color.FromArgb(32, 42, 0),
            Color.FromArgb(8, 58, 0),
            Color.FromArgb(0, 64, 0),
            Color.FromArgb(0, 60, 0),
            Color.FromArgb(0, 50, 60),
            Color.FromArgb(0, 0, 0),
            
            Color.FromArgb(152, 150, 152),
            Color.FromArgb(8, 76, 196),
            Color.FromArgb(48, 50, 236),
            Color.FromArgb(92, 30, 228),
            Color.FromArgb(136, 20, 176),
            Color.FromArgb(160, 20, 100),
            Color.FromArgb(152, 34, 32),
            Color.FromArgb(120, 60, 0),
            Color.FromArgb(84, 90, 0),
            Color.FromArgb(40, 114, 0),
            Color.FromArgb(8, 124, 0),
            Color.FromArgb(0, 118, 40),
            Color.FromArgb(0, 102, 120),
            Color.FromArgb(0, 0, 0),
            
            Color.FromArgb(236, 238, 236),
            Color.FromArgb(76, 154, 236),
            Color.FromArgb(120, 124, 236),
            Color.FromArgb(176, 98, 236),
            Color.FromArgb(228, 84, 236),
            Color.FromArgb(236, 88, 180),
            Color.FromArgb(236, 106, 100),
            Color.FromArgb(212, 136, 32),
            Color.FromArgb(160, 170, 0),
            Color.FromArgb(116, 196, 0),
            Color.FromArgb(76, 208, 32),
            Color.FromArgb(56, 204, 108),
            Color.FromArgb(56, 180, 204),
            Color.FromArgb(60, 60, 60),
            
            Color.FromArgb(236, 238, 236),
            Color.FromArgb(168, 204, 236),
            Color.FromArgb(188, 188, 236),
            Color.FromArgb(212, 178, 236),
            Color.FromArgb(236, 174, 236),
            Color.FromArgb(236, 174, 212),
            Color.FromArgb(236, 180, 176),
            Color.FromArgb(228, 196, 144),
            Color.FromArgb(204, 210, 120),
            Color.FromArgb(180, 222, 120),
            Color.FromArgb(168, 226, 144),
            Color.FromArgb(152, 226, 180),
            Color.FromArgb(160, 214, 228),
            Color.FromArgb(160, 162, 160),
        };

    public MainForm()
        {
            InitializeComponent();

            ChooseImageFileAndProcess();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseImageFileAndProcess();
        }

        void ChooseImageFileAndProcess()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG files|*.png";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select image.png file";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int numberOfPixelsWidth = 32;
                int numberOfPixelsHeight = 32;

                int maxPaletteSize = 4;

                Bitmap originalBmp = new Bitmap(openFileDialog.FileName);
                Bitmap pixelatedBmp = new Bitmap(numberOfPixelsWidth, numberOfPixelsHeight);
                Bitmap ClosestMatchBmp = new Bitmap(numberOfPixelsWidth, numberOfPixelsHeight);
                Bitmap ClosestMatchFourBmp = new Bitmap(numberOfPixelsWidth, numberOfPixelsHeight);

                pictureBox_Original.Image = originalBmp;

                Dictionary<Color, int> colourCount = new Dictionary<Color, int>();

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

                        Color averageColour = Color.FromArgb(r, g, b);

                        pixelatedBmp.SetPixel(x, y, averageColour);

                        Color nearestColour = GetClosestColourFromArray(averageColour, NESColours);

                        ClosestMatchBmp.SetPixel(x, y, nearestColour);

                        if (colourCount.ContainsKey(nearestColour))
                        {
                            colourCount[nearestColour] += 1;
                        }
                        else
                        {
                            colourCount.Add(nearestColour, 1);
                        }
                    }
                }

                pictureBox_Pixelated.Image = ResizeImage(pixelatedBmp, pictureBox_Pixelated.Width, pictureBox_Pixelated.Height);// originalBmp.Width, originalBmp.Height);
                pixelatedBmp.Dispose();

                var colourCountList = colourCount.ToList();

                colourCountList.Sort((a, b) => b.Value.CompareTo(a.Value));

                int finalNumberOfColours = colourCountList.Count > maxPaletteSize ? maxPaletteSize : colourCountList.Count;

                Color[] finalColours = new Color[finalNumberOfColours];

                for (int i = 0; i < finalNumberOfColours; i++)
                {
                    finalColours[i] = colourCountList[i].Key;
                }

                for (int x = 0; x < numberOfPixelsWidth; x++)
                {
                    for (int y = 0; y < numberOfPixelsHeight; y++)
                    {
                        Color NESPaletteColour = ClosestMatchBmp.GetPixel(x, y); ;
                        ClosestMatchFourBmp.SetPixel(x, y, GetClosestColourFromArray(NESPaletteColour, finalColours));
                    }
                }

                pictureBox_ClosestMatch.Image = ResizeImage(ClosestMatchBmp, pictureBox_Pixelated.Width, pictureBox_Pixelated.Height);// originalBmp.Width, originalBmp.Height);
                ClosestMatchBmp.Dispose();

                pictureBox_ClosestMatchFour.Image = ResizeImage(ClosestMatchFourBmp, pictureBox_Pixelated.Width, pictureBox_Pixelated.Height);// originalBmp.Width, originalBmp.Height);
                ClosestMatchFourBmp.Dispose();


                pictureBox_Original.Image = ResizeImage(originalBmp, pictureBox_Pixelated.Width, pictureBox_Pixelated.Height);// originalBmp.Width, originalBmp.Height);
                originalBmp.Dispose();
                
                //MessageBox.Show($"Success {openFileDialog.FileName}", "Title", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        Bitmap ResizeImage(Image image, int width, int height)
        {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (ImageAttributes wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        double GetColourDistance(Color a, Color b)
        {
            double dR = a.R - b.R;
            double dG = a.G - b.G;
            double dB = a.B - b.B;

            return Math.Sqrt(dR*dR + dG*dG + dB*dB);
        }

        Color GetClosestColourFromArray(Color inputColor, Color[] choices)
        {
            Color returnValue = Color.Empty;
            double tempBestDistance = 500;

            foreach (Color c in choices)
            {
                double thisDistance = GetColourDistance(inputColor, c);

                if (thisDistance < tempBestDistance)
                {
                    tempBestDistance = thisDistance;
                    returnValue = c;
                }
            }

            return returnValue;
        }
    }
}
