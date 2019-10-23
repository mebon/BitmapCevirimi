//MUHAMMED EMİN BERKAY KOCAOĞLU 201513171070

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapCeviri
{
    public partial class BitmapCeviri : Form
    {
        Bitmap bmp;
        private int threshold = 128;
        public BitmapCeviri()
        {
            InitializeComponent();
        }
        private void BitmapCeviri_Load(object sender, EventArgs e)
        {
            thresholdDegeri.Text = threshold.ToString();
            if (pictureBox != null)
            {
                try
                {       
                    bmp = (Bitmap)Bitmap.FromFile(@"sekiller.jpg");
                    openFileDialog1.FileName = @"sekiller.jpg";
                    pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                    pictureBox.Image = bmp;
                    labelGenislik.Text = pictureBox.Width.ToString();
                    labelYukseklik.Text = pictureBox.Height.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dosya bulunamadı.");
                }
                this.Refresh();

            }
        }
        private void button2GrayScale_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);
                        
                        int r = c.R;
                        int g = c.G;
                        int b = c.B;
                        int avg = (r + g + b) / 3;
                        bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                    }
                }
                xVeYHareketi();
                pictureBox.Image = bmp;
                this.Refresh();
            }
        }
        private void xVeYHareketi()
        {
            if (bmp != null)
            {
                if (!string.IsNullOrEmpty(xAyarla.Text) && !string.IsNullOrEmpty(yAyarla.Text))
                {
                    int x, y;
                    x = Convert.ToInt32(xAyarla.Text);
                    y = Convert.ToInt32(yAyarla.Text);
                    Color color = bmp.GetPixel(x, y);

                    RedAyarla.Text = Convert.ToString(color.R);
                    GreenAyarla.Text = Convert.ToString(color.G);
                    BlueAyarla.Text = Convert.ToString(color.B);

                    pBRenk.BackColor = color;
                    hexaDeger.Text = color.Name;
                }
            }
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.Refresh();
            if (bmp != null)
            {
                xAyarla.Text = Convert.ToString(e.X);
                yAyarla.Text = Convert.ToString(e.Y);

                xVeYHareketi();
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
       
                bmp = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                pictureBox.Image = bmp;
                xVeYHareketi();
                this.Refresh();
            }
        }
        private void buttonBitmap_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);

                        int r = c.R;
                        int g = c.G;
                        int b = c.B;
                        
                        if ((r + g + b) / 3 >  Convert.ToInt32(thresholdDegeri.Text))
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        } else
                            bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
                xVeYHareketi();
                pictureBox.Image = bmp;
                this.Refresh();
            }
        }
        private void buttonResimYukleme_Click(object sender, EventArgs e)
        {
            if (pictureBox != null)
            {
                try
                {
                    openFileDialog1.ShowDialog();
                    pictureBox.ImageLocation = openFileDialog1.FileName;
                    bmp = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    labelGenislik.Text = pictureBox.Width.ToString();
                    labelYukseklik.Text = pictureBox.Height.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dosya bulunamadı.");
                }
            }
        }
        private void buttonThresholdUygula_Click(object sender, EventArgs e)
        {
            threshold = Convert.ToInt32( thresholdDegeri.Text);
        }
        private void thresholdDegeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonSetPiksel_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                if (!string.IsNullOrEmpty(xAyarla.Text) && !string.IsNullOrEmpty(yAyarla.Text))
                {
                    if (!string.IsNullOrEmpty(RedAyarla.Text) && !string.IsNullOrEmpty(GreenAyarla.Text) && !string.IsNullOrEmpty(BlueAyarla.Text))
                    {
                        int r, g, b;
                        int x, y;

                        r = Convert.ToInt32(RedAyarla.Text);
                        g = Convert.ToInt32(GreenAyarla.Text);
                        b = Convert.ToInt32(BlueAyarla.Text);

                        x = Convert.ToInt32(xAyarla.Text);
                        y = Convert.ToInt32(yAyarla.Text);
                        
                        bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                        pBRenk.BackColor = Color.FromArgb(r, g, b);
                        hexaDeger.Text = Color.FromArgb(r, g, b).Name;
                        this.Refresh();  
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
//MUHAMMED EMİN BERKAY KOCAOĞLU 201513171070
