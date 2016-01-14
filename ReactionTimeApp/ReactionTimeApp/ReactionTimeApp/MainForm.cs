using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactionTimeApp
{
    public partial class MainForm : Form
    {
        private static string backgroundImageSource = "\\images\\img_background.png";
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            InitializeBackgroundImages();
            rotateImageBack();
            pictureBox_back.Visible = false;
            clearAbout();
        }

        private void rotateImageBack()
        {
            Image pbImage = pictureBox_back.BackgroundImage;
            pbImage.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBox_back.BackgroundImage = pbImage;
            pictureBox_back.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void InitializeBackgroundImages()
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + backgroundImageSource);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox_startDemo_Click(object sender, EventArgs e)
        {
            FormDemoVisual mFormDemo = new FormDemoVisual();
            mFormDemo.Show();
        }

        private void pictureBox_startGame_Click(object sender, EventArgs e)
        {
            FormGame mFormGame = new FormGame();
            mFormGame.Show();
        }

        private void pictureBox_about_Click(object sender, EventArgs e)
        {
            printAbout();
        }

        private void printAbout()
        {
            pictureBox_startDemo.Visible = false;
            pictureBox_startGame.Visible = false;
            pictureBox_back.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            clearAbout();
        }

        private void clearAbout()
        {
            pictureBox_startDemo.Visible = true;
            pictureBox_startGame.Visible = true;
            pictureBox_back.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
    }
}
