using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace PngToPixelArtTool_NES
{
    public partial class MainForm : Form
    {
        static Dictionary<string, Color> NESColours = new Dictionary<string, Color>
        {
            { "00", Color.FromArgb(84, 84, 84) },
            { "01", Color.FromArgb(0, 30, 116) },
            { "02", Color.FromArgb(8, 16, 144) },
            { "03", Color.FromArgb(48, 0, 136) },
            { "04", Color.FromArgb(68, 0, 100) },
            { "05", Color.FromArgb(92, 0, 48) },
            { "06", Color.FromArgb(84, 4, 0) },
            { "07", Color.FromArgb(60, 24, 0) },
            { "08", Color.FromArgb(32, 42, 0) },
            { "09", Color.FromArgb(8, 58, 0) },
            { "0a", Color.FromArgb(0, 64, 0) },
            { "0b", Color.FromArgb(0, 60, 0) },
            { "0c", Color.FromArgb(0, 50, 60) },
            { "0d", Color.FromArgb(0, 0, 0) },

            { "10", Color.FromArgb(152, 150, 152) },
            { "11", Color.FromArgb(8, 76, 196) },
            { "12", Color.FromArgb(48, 50, 236) },
            { "13", Color.FromArgb(92, 30, 228) },
            { "14", Color.FromArgb(136, 20, 176) },
            { "15", Color.FromArgb(160, 20, 100) },
            { "16", Color.FromArgb(152, 34, 32) },
            { "17", Color.FromArgb(120, 60, 0) },
            { "18", Color.FromArgb(84, 90, 0) },
            { "19", Color.FromArgb(40, 114, 0) },
            { "1a", Color.FromArgb(8, 124, 0) },
            { "1b", Color.FromArgb(0, 118, 40) },
            { "1c", Color.FromArgb(0, 102, 120) },
            { "1d", Color.FromArgb(0, 0, 0) },

            { "20", Color.FromArgb(236, 238, 236) },
            { "21", Color.FromArgb(76, 154, 236) },
            { "22", Color.FromArgb(120, 124, 236) },
            { "23", Color.FromArgb(176, 98, 236) },
            { "24", Color.FromArgb(228, 84, 236) },
            { "25", Color.FromArgb(236, 88, 180) },
            { "26", Color.FromArgb(236, 106, 100) },
            { "27", Color.FromArgb(212, 136, 32) },
            { "28", Color.FromArgb(160, 170, 0) },
            { "29", Color.FromArgb(116, 196, 0) },
            { "2a", Color.FromArgb(76, 208, 32) },
            { "2b", Color.FromArgb(56, 204, 108) },
            { "2c", Color.FromArgb(56, 180, 204) },
            { "2d", Color.FromArgb(60, 60, 60) },

            { "30", Color.FromArgb(236, 238, 236) },
            { "31", Color.FromArgb(168, 204, 236) },
            { "32", Color.FromArgb(188, 188, 236) },
            { "33", Color.FromArgb(212, 178, 236) },
            { "34", Color.FromArgb(236, 174, 236) },
            { "35", Color.FromArgb(236, 174, 212) },
            { "36", Color.FromArgb(236, 180, 176) },
            { "37", Color.FromArgb(228, 196, 144) },
            { "38", Color.FromArgb(204, 210, 120) },
            { "39", Color.FromArgb(180, 222, 120) },
            { "3a", Color.FromArgb(168, 226, 144) },
            { "3b", Color.FromArgb(152, 226, 180) },
            { "3c", Color.FromArgb(160, 214, 228) },
            { "3d", Color.FromArgb(160, 162, 160) },
        };

        Bitmap originalBmp;
        string thisFileName;

    public MainForm()
        {
            InitializeComponent();

            LoadImageFile();

            // Have to bring to front first time
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImageFile();
        }

        void LoadImageFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.png;*jpg";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select image file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalBmp = new Bitmap(openFileDialog.FileName);

                string[] filePathArray = openFileDialog.FileName.Split('\\');
                string[] fileNameArray = filePathArray[filePathArray.Count()-1].Split('.');
                thisFileName = fileNameArray[0];

                pictureBox_Original.Image = ResizeImage(originalBmp, pictureBox_Original.Width, pictureBox_Original.Height);

                ProcessImage();
            }
        }

        void SaveImageFile(Image image, string appendString)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"PNG|*.png";
            saveFileDialog.FileName = thisFileName + appendString;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
        }

        void ProcessImage()
        {
            if (originalBmp != null)
            {
                int numberOfPixelsWidth = (int)numericUpDown_PixelWidth.Value;
                int numberOfPixelsHeight = (int)numericUpDown_PixelHeight.Value;

                int maxPaletteSize = (int)numericUpDown_NumPaletteValues.Value;

                Bitmap pixelatedBmp = new Bitmap(numberOfPixelsWidth, numberOfPixelsHeight);
                Bitmap ClosestMatchBmp = new Bitmap(numberOfPixelsWidth, numberOfPixelsHeight);
                Bitmap ClosestMatchFourBmp = new Bitmap(numberOfPixelsWidth, numberOfPixelsHeight);

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

                        if (numPixels == 0)
                        {
                            MessageBox.Show("Exceeds image dimensions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            if (checkBox_LinkWidthAndHeight.Enabled)
                            {
                                int lowestValue = originalBmp.Width < originalBmp.Height ? originalBmp.Width : originalBmp.Height;

                                numericUpDown_PixelWidth.Value = lowestValue;
                                numericUpDown_PixelHeight.Value = lowestValue;
                            }
                            else
                            {
                                numericUpDown_PixelWidth.Value = originalBmp.Width;
                                numericUpDown_PixelHeight.Value = originalBmp.Height;
                            }

                            return;
                        }

                        r /= numPixels;
                        g /= numPixels;
                        b /= numPixels;

                        Color averageColour = Color.FromArgb(r, g, b);

                        pixelatedBmp.SetPixel(x, y, averageColour);

                        Color nearestColour = GetClosestColourFromArray(averageColour, NESColours.Values.ToArray());

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

                pictureBox_Pixelated.Image = ResizeImage(pixelatedBmp, pictureBox_Pixelated.Width, pictureBox_Pixelated.Height);
                pixelatedBmp.Dispose();

                // Pick final colours

                textBox_FinalNESPaletteCodes.Text = "";

                var colourCountList = colourCount.ToList();
                colourCountList.Sort((a, b) => b.Value.CompareTo(a.Value));

                int finalNumberOfColours = colourCountList.Count > maxPaletteSize ? maxPaletteSize : colourCountList.Count;

                Color[] finalColours = new Color[finalNumberOfColours];

                for (int i = 0; i < finalNumberOfColours; i++)
                {
                    finalColours[i] = colourCountList[i].Key;

                    textBox_FinalNESPaletteCodes.Text += GetNESColourCodeFromPalette(finalColours[i]) + ", ";
                }

                for (int x = 0; x < numberOfPixelsWidth; x++)
                {
                    for (int y = 0; y < numberOfPixelsHeight; y++)
                    {
                        Color NESPaletteColour = ClosestMatchBmp.GetPixel(x, y);

                        ClosestMatchFourBmp.SetPixel(x, y, GetClosestColourFromArray(NESPaletteColour, finalColours));
                    }
                }

                pictureBox_ClosestMatch.Image = ResizeImage(ClosestMatchBmp, pictureBox_ClosestMatch.Width, pictureBox_ClosestMatch.Height);
                ClosestMatchBmp.Dispose();

                pictureBox_ClosestMatchFour.Image = ResizeImage(ClosestMatchFourBmp, pictureBox_ClosestMatchFour.Width, pictureBox_ClosestMatchFour.Height);
                ClosestMatchFourBmp.Dispose();
                
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

        string GetNESColourCodeFromPalette(Color colour)
        {
            foreach (var c in NESColours)
            {
                if (colour == c.Value)
                {
                    return c.Key;
                }
            }

            return "ERROR: " + colour.ToString();
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
            double tempBestDistance = double.MaxValue;

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

        private void numericUpDown_PixelHeight_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox_LinkWidthAndHeight.Checked)
            {
                numericUpDown_PixelWidth.Value = numericUpDown_PixelHeight.Value;
            }

            ProcessImage();
        }

        private void numericUpDown_PixelWidth_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox_LinkWidthAndHeight.Checked)
            {
                numericUpDown_PixelHeight.Value = numericUpDown_PixelWidth.Value;
            }

            ProcessImage();
        }

        private void checkBox_LinkWidthAndHeight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_LinkWidthAndHeight.Checked)
            {
                numericUpDown_PixelWidth.Value = numericUpDown_PixelHeight.Value;

                ProcessImage();
            }
        }

        private void numericUpDown_NumPaletteValues_ValueChanged(object sender, EventArgs e)
        {
            ProcessImage();
        }

        private void pixelatedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImageFile(pictureBox_Pixelated.Image, $"_pixelated_{numericUpDown_PixelWidth.Value}x{numericUpDown_PixelHeight.Value}");
        }

        private void nESPaletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImageFile(pictureBox_ClosestMatch.Image, $"_fullNESPalette_{numericUpDown_PixelWidth.Value}x{numericUpDown_PixelHeight.Value}");
        }

        private void finalNESPaletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImageFile(pictureBox_ClosestMatchFour.Image, $"_finalNESPalette_Size{numericUpDown_NumPaletteValues.Value}_{numericUpDown_PixelWidth.Value}x{numericUpDown_PixelHeight.Value}");
        }
    }
}
