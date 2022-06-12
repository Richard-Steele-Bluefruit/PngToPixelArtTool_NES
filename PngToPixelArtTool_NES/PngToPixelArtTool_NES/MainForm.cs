using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                Bitmap imageBmp = new Bitmap(openFileDialog.FileName);

                for (int x = 0; x < imageBmp.Width; x++)
                {
                    for (int y = 0; y < imageBmp.Height; y++)
                    {
                    }
                }

                MessageBox.Show($"Success {openFileDialog.FileName}", "Title", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
