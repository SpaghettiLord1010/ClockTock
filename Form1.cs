using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClockTock.Properties;

namespace ClockTock
{


    public partial class Form1 : Form
    {
        int curSound = 0;
        int MyAngle = 6;
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;

        }

        public Image StartPic = null;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            
            pictureBox1.Refresh();

            if (MyAngle != 0 && pictureBox1.Image != null)
            {
                pictureBox1.Image = RotateImage(StartPic, MyAngle);
            }

            timer1.Enabled = true;
            if (listBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Properties.Resources.DarkThemeBig_01;
            }
            else if(listBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.LightTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Properties.Resources.RedTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 3)
            {
                pictureBox1.Image = Properties.Resources.GreenTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 4)
            {
                pictureBox1.Image = Properties.Resources.BlueTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 5)
            {
                pictureBox1.Image = Properties.Resources.OrangeTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 6)
            {
                pictureBox1.Image = Properties.Resources.YellowTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 7)
            {
                pictureBox1.Image = Properties.Resources.PinkTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 8)
            {
                pictureBox1.Image = Properties.Resources.TurkeseTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 9)
            {
                pictureBox1.Image = Properties.Resources.VioletTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 10)
            {
                pictureBox1.Image = Properties.Resources.DarkTheme;
            }
            else if (listBox1.SelectedIndex == 11)
            {
                pictureBox1.Image = Properties.Resources.LightTheme;
            }
            else if (listBox1.SelectedIndex == 12)
            {
                pictureBox1.Image = Properties.Resources.RedTheme;
            }
            else if (listBox1.SelectedIndex == 13)
            {
                pictureBox1.Image = Properties.Resources.GreenTheme;
            }
            else if (listBox1.SelectedIndex == 14)
            {
                pictureBox1.Image = Properties.Resources.BlueTheme;
            }
            else if (listBox1.SelectedIndex == 15)
            {
                pictureBox1.Image = Properties.Resources.OrangeTheme;
            }
            else if (listBox1.SelectedIndex == 16)
            {
                pictureBox1.Image = Properties.Resources.YellowTheme;
            }
            else if (listBox1.SelectedIndex == 17)
            {
                pictureBox1.Image = Properties.Resources.PinkTheme;
            }
            else if (listBox1.SelectedIndex == 18)
            {
                pictureBox1.Image = Properties.Resources.TurkeseTheme;
            }
            else if (listBox1.SelectedIndex == 19)
            {
                pictureBox1.Image = Properties.Resources.VioletTheme;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (curSound % 2 == 0)
            {
                System.IO.Stream str = Properties.Resources.Tick1;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                curSound++;
            }
            else
            {
                curSound++;
                System.IO.Stream str = Properties.Resources.Tock1;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            if (curSound >= 2) { curSound = 0; }

            pictureBox1.Refresh();
            if (listBox1.SelectedIndex == 0)
            {
                StartPic = Properties.Resources.DarkThemeBig_01;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                StartPic = Properties.Resources.LightTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                StartPic = Properties.Resources.RedTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 3)
            {
                StartPic = Properties.Resources.GreenTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 4)
            {
                StartPic = Properties.Resources.BlueTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 5)
            {
                StartPic = Properties.Resources.OrangeTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 6)
            {
                StartPic = Properties.Resources.YellowTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 7)
            {
                StartPic = Properties.Resources.PinkTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 8)
            {
                StartPic = Properties.Resources.TurkeseTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 9)
            {
                StartPic = Properties.Resources.VioletTheme_Big_01;
            }
            else if (listBox1.SelectedIndex == 10)
            {
                StartPic = Properties.Resources.DarkTheme;
            }
            else if (listBox1.SelectedIndex == 11)
            {
                StartPic = Properties.Resources.LightTheme;
            }
            else if (listBox1.SelectedIndex == 12)
            {
                StartPic = Properties.Resources.RedTheme;
            }
            else if (listBox1.SelectedIndex == 13)
            {
                StartPic = Properties.Resources.GreenTheme;
            }
            else if (listBox1.SelectedIndex == 14)
            {
                StartPic = Properties.Resources.BlueTheme;
            }
            else if (listBox1.SelectedIndex == 15)
            {
                StartPic = Properties.Resources.OrangeTheme;
            }
            else if (listBox1.SelectedIndex == 16)
            {
                StartPic = Properties.Resources.YellowTheme;
            }
            else if (listBox1.SelectedIndex == 17)
            {
                StartPic = Properties.Resources.PinkTheme;
            }
            else if (listBox1.SelectedIndex == 18)
            {
                StartPic = Properties.Resources.TurkeseTheme;
            }
            else if (listBox1.SelectedIndex == 19)
            {
                StartPic = Properties.Resources.VioletTheme;
            }

            if (MyAngle >=354)
            {
                MyAngle = 0;
            }
            else
            {
                MyAngle = MyAngle + 6;
            }
            
            pictureBox1.Image = RotateImage(StartPic, MyAngle);
        }

        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            //gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }
    }
}
