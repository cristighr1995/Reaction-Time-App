using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactionTimeApp
{
    public partial class FormDemoSound : Form
    {
        private SoundPlayer simpleSound = new SoundPlayer();
        public FormDemoSound()
        {
            InitializeComponent();
            this.CenterToScreen();
            rotateImageBack();
        }

        private void rotateImageBack()
        {
            Image pbImage = pictureBox_demo_back.BackgroundImage;
            pbImage.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBox_demo_back.BackgroundImage = pbImage;
            pictureBox_demo_back.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox_demo_back_Click(object sender, EventArgs e)
        {
            FormDemoVisual mFormDemoVisual = new FormDemoVisual();
            mFormDemoVisual.Show();
            this.Dispose();
        }

        private void playSound(string path)
        {
            simpleSound.Stop();
            // getting root path
            string rootLocation = Application.StartupPath;
            // appending sound location
            string fullPathToSound = Path.Combine(rootLocation, path);
            simpleSound.SoundLocation = fullPathToSound;
            simpleSound.Play();
        }

        private void pictureBox_demo_playSoundHigh_Click(object sender, EventArgs e)
        {
            playSound(@"music\\sound_high.wav");
        }

        private void pictureBox_demo_playSoundLow_Click(object sender, EventArgs e)
        {
            playSound(@"music\\sound_low.wav");
        }

        private void pictureBox_demo_next_Click(object sender, EventArgs e)
        {
            FormDemoFigurePlay mFormDemoFigurePlay = new FormDemoFigurePlay();
            mFormDemoFigurePlay.Show();
            this.Dispose();
        }

    }
}
