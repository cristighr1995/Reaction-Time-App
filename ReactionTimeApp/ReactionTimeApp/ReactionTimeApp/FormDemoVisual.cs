using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactionTimeApp
{
    public partial class FormDemoVisual : Form
    {
        public FormDemoVisual()
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
            this.Dispose();
        }

        private void pictureBox_demo_next_Click(object sender, EventArgs e)
        {
            FormDemoSound mFormDemoSound = new FormDemoSound();
            mFormDemoSound.Show();
            this.Dispose();
        }
    }
}
