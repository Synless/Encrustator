using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synless_Encrustor
{
    public partial class Form1 : Form
    {
        #region Variables
        Bitmap originalBmp = new Bitmap(128, 128);
        Bitmap modifiedBmp = new Bitmap(128, 128);
        Bitmap demoBmp = new Bitmap(32, 32);

        Color c = Color.White;

        bool black = true;
        bool leftArrow = true;
        bool rightArrow = true;
        #endregion

        public Form1()
        {
            InitializeComponent();
            for (int n = 0; n < 128; n++)
            {
                for (int m = 0; m < 128; m++)
                {
                    if (n == 0 || n == 127 || m == 0 || m == 127)
                    {
                        originalBmp.SetPixel(n, m, Color.Black);
                        modifiedBmp.SetPixel(n, m, Color.Black);
                    }
                }
            }
            for (int y = 0; y < demoBmp.Height; y++)
            {
                for (int x = 0; x < demoBmp.Width; x++)
                {
                    if (x == 0 || y == 0 || x == demoBmp.Width - 1 || y == demoBmp.Height - 1)
                    {
                        demoBmp.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        demoBmp.SetPixel(x, y, c);
                    }
                }
            }
            pictureBox1.Image = originalBmp;
            pictureBox2.Image = modifiedBmp;
        }

        private void enableControls()
        {
            tittleTxtBox.Enabled = true;
            opacityUpDown.Enabled = true;
            saveBtn.Enabled = true;
            blackRbt.Enabled = true;
            whiteRbt.Enabled = true;
            rightArrowCheck.Enabled = true;
            leftArrowCheck.Enabled = true;
            trackBarRed.Enabled = true;
            trackBarGreen.Enabled = true;
            trackBarBlue.Enabled = true;
        }

        #region Actual mod
        private void doMod()
        {
            modifiedBmp = new Bitmap(originalBmp);
            // STRIPS
            for (int y = 85; y < 115; y++)
            {
                for (int x = 0; x < originalBmp.Width; x++)
                {
                    if ((y > 84 && y < 87) || y > 112 && y < 115)
                    {
                        modifiedBmp.SetPixel(x, y, c);
                    }
                    else
                    {
                        int red = (int)(originalBmp.GetPixel(x, y).R * opacityUpDown.Value / 100) + (int)((c.R * (100 - opacityUpDown.Value) / 100));
                        int green = (int)(originalBmp.GetPixel(x, y).G * opacityUpDown.Value / 100) + (int)((c.G * (100 - opacityUpDown.Value) / 100));
                        int blue = (int)(originalBmp.GetPixel(x, y).B * opacityUpDown.Value / 100) + (int)((c.B * (100 - opacityUpDown.Value) / 100));
                        Color custom = Color.FromArgb(red, green, blue);
                        modifiedBmp.SetPixel(x, y, custom);
                    }
                }
            }
            //TITTLE
            Graphics tmp = System.Drawing.Graphics.FromImage(new Bitmap(1, 1));
            int offset = (int)tmp.MeasureString(tittleTxtBox.Text, new Font("Arial", 12, FontStyle.Bold)).Width;
            offset = 64 - (offset / 2);
            RectangleF rectf = new RectangleF(/*(float)offsetUpDown.Value*/offset, 90, 100, 100);
            Graphics g = Graphics.FromImage(modifiedBmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            if (black) { g.DrawString(tittleTxtBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, rectf); }
            else { g.DrawString(tittleTxtBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.White, rectf); }
            g.Flush();
            // ARROW
            if (leftArrow)
            {
                left();
            }
            if (rightArrow)
            {
                rigth();
            }
            updatePB();
        }
        private void left()
        {

            for (int x = 10; x < 23; x++)
            {
                for (int y = 20; y < 33; y++)
                {

                    if ((y - 20) + (x - 10) > 10 && (y - 20) + (x - 10) < 15)
                    {
                        modifiedBmp.SetPixel(x, y, c);
                    }
                    else if ((y - 20) + (x - 10) > 10)
                    {
                        int red = (int)(originalBmp.GetPixel(x, y).R * opacityUpDown.Value / 100) + (int)((c.R * (100 - opacityUpDown.Value) / 100));
                        int green = (int)(originalBmp.GetPixel(x, y).G * opacityUpDown.Value / 100) + (int)((c.G * (100 - opacityUpDown.Value) / 100));
                        int blue = (int)(originalBmp.GetPixel(x, y).B * opacityUpDown.Value / 100) + (int)((c.B * (100 - opacityUpDown.Value) / 100));
                        Color custom = Color.FromArgb(red, green, blue);
                        modifiedBmp.SetPixel(x, y, custom);
                    }
                }
            }
            for (int x = 10; x < 23; x++)
            {
                for (int y = 32; y < 45; y++)
                {
                    int d = ((x - 9) - (y - 32)) * ((x - 10) - (y - 32));
                    double tmp = Math.Sqrt(d);

                    if (tmp <= 2.0)
                    {
                        modifiedBmp.SetPixel(x, y, c);
                    }
                    else if ((x - 10) > (y - 32))
                    {
                        int red = (int)(originalBmp.GetPixel(x, y).R * opacityUpDown.Value / 100) + (int)((c.R * (100 - opacityUpDown.Value) / 100));
                        int green = (int)(originalBmp.GetPixel(x, y).G * opacityUpDown.Value / 100) + (int)((c.G * (100 - opacityUpDown.Value) / 100));
                        int blue = (int)(originalBmp.GetPixel(x, y).B * opacityUpDown.Value / 100) + (int)((c.B * (100 - opacityUpDown.Value) / 100));
                        Color custom = Color.FromArgb(red, green, blue);
                        modifiedBmp.SetPixel(x, y, custom);
                    }
                }
            }
            for (int x = 20; x < 23; x++)
            {
                for (int y = 20; y < 45; y++)
                {
                    if ((x - 20) + (y - 20) > 4)
                    {
                        modifiedBmp.SetPixel(x, y, c);
                    }
                }
            }
            //SHARPING            
            modifiedBmp.SetPixel(12, 32, c);
            modifiedBmp.SetPixel(9, 32, c);
            modifiedBmp.SetPixel(9, 33, c);
            modifiedBmp.SetPixel(22, 19, c);
            modifiedBmp.SetPixel(21, 45, c);
            modifiedBmp.SetPixel(22, 45, c);
            modifiedBmp.SetPixel(22, 46, c);
            //modifiedBmp.SetPixel(22, 46, c);
        }
        private void rigth()
        {
            for (int x = 105; x < 118; x++)
            {
                for (int y = 31; y < 44; y++)
                {
                    if ((y - 20) + (x - 105) > 9 && (y - 20) + (x - 105) > 22 && (y - 20) + (x - 105) > 9 && (y - 20) + (x - 105) < 27)
                    {
                        modifiedBmp.SetPixel(x, y, c);
                    }
                    else if ((y - 20) + (x - 105) > 10 && (y - 20) + (x - 105) < 25)
                    {
                        int red = (int)(originalBmp.GetPixel(x, y).R * opacityUpDown.Value / 100) + (int)((c.R * (100 - opacityUpDown.Value) / 100));
                        int green = (int)(originalBmp.GetPixel(x, y).G * opacityUpDown.Value / 100) + (int)((c.G * (100 - opacityUpDown.Value) / 100));
                        int blue = (int)(originalBmp.GetPixel(x, y).B * opacityUpDown.Value / 100) + (int)((c.B * (100 - opacityUpDown.Value) / 100));
                        Color custom = Color.FromArgb(red, green, blue);
                        modifiedBmp.SetPixel(x, y, custom);
                    }
                }
            }
            for (int x = 105; x < 118; x++)
            {
                for (int y = 20; y < 33; y++)
                {
                    int d = ((x - 104) - (y - 20)) * ((x - 105) - (y - 20));
                    double tmp = Math.Sqrt(d);
                    if (tmp <= 2.0)
                    {
                        modifiedBmp.SetPixel(x, y, c);
                    }
                    else if ((x - 105) < (y - 20))
                    {
                        int red = (int)(originalBmp.GetPixel(x, y).R * opacityUpDown.Value / 100) + (int)((c.R * (100 - opacityUpDown.Value) / 100));
                        int green = (int)(originalBmp.GetPixel(x, y).G * opacityUpDown.Value / 100) + (int)((c.G * (100 - opacityUpDown.Value) / 100));
                        int blue = (int)(originalBmp.GetPixel(x, y).B * opacityUpDown.Value / 100) + (int)((c.B * (100 - opacityUpDown.Value) / 100));
                        Color custom = Color.FromArgb(red, green, blue);
                        modifiedBmp.SetPixel(x, y, custom);
                    }
                }
            }
            for (int x = 105; x < 108; x++)
            {
                for (int y = 20; y < 45; y++)
                {
                    if ((y - 20) > (x - 105))
                    {
                        modifiedBmp.SetPixel(x, y, c);
                    }
                }
            }
            //SHARPING            
            modifiedBmp.SetPixel(105, 19, c);
            modifiedBmp.SetPixel(105, 45, c);
            modifiedBmp.SetPixel(106, 45, c);
            modifiedBmp.SetPixel(105, 46, c);
            modifiedBmp.SetPixel(118, 32, c);
            modifiedBmp.SetPixel(118, 33, c);
        }
        private void updatePB()
        {
            pictureBox1.Image = originalBmp;
            pictureBox2.Image = modifiedBmp;
            demoPictureBox.Image = demoBmp;
            Application.DoEvents();
        }
        #endregion

        #region Form Action
        private void loadBtn_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Bitmap files |*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            originalBmp = new Bitmap(myStream);
                            modifiedBmp = new Bitmap(myStream);
                            if (originalBmp.Width == 128 && originalBmp.Height == 128 && modifiedBmp.Width >= 128 && modifiedBmp.Height == 128)
                            {
                                enableControls();
                                doMod();
                            }
                            else
                            {
                                MessageBox.Show("Error: Image smaller than 128 x 128, edition disabled");
                            }
                            updatePB();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }
        private void opacityUpDown_ValueChanged(object sender, EventArgs e)
        {
            doMod();
        }
        private void tittleTxtBox_TextChanged(object sender, EventArgs e)
        {
            doMod();
        }
        private void offsetUpDown_ValueChanged(object sender, EventArgs e)
        {
            doMod();
        }
        private void blackRbt_CheckedChanged(object sender, EventArgs e)
        {
            black = true;
            doMod();
        }
        private void whiteRbt_CheckedChanged(object sender, EventArgs e)
        {
            black = false;
            doMod();
        }
        private void leftArrowCheck_CheckedChanged(object sender, EventArgs e)
        {
            leftArrow = leftArrowCheck.Checked;
            doMod();
        }
        private void rightArrowCheck_CheckedChanged(object sender, EventArgs e)
        {
            rightArrow = rightArrowCheck.Checked;
            doMod();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Bitmap files |*.bmp";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    modifiedBmp.Save(myStream, System.Drawing.Imaging.ImageFormat.Bmp);
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }

        }
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            Color tmp = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            for (int y = 0; y < demoBmp.Height; y++)
            {
                for (int x = 0; x < demoBmp.Width; x++)
                {
                    if (x == 0 || y == 0 || x == demoBmp.Width - 1 || y == demoBmp.Height - 1)
                    {
                        demoBmp.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        demoBmp.SetPixel(x, y, tmp);
                    }
                }
            }
            c = tmp;
            doMod();
        }
        #endregion

    }
}
