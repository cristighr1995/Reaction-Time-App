using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactionTimeApp
{
    public partial class FormDemoFigurePlay : Form
    {
        private static string imagePath = "\\images\\img_";
        private static Random r = new Random();
        private static int photoNumber = 1;
        private static string hintRectangle = "You should press key 'A'";
        private static string hintCircle = "You should press key 'S'";
        private static string hintTriangle = "You should press key 'D'";
        private static int countTries = 0;
        public FormDemoFigurePlay()
        {
            InitializeComponent();
            this.CenterToScreen();
            label_startTest.Visible = false;
            pictureBox_startTest.Visible = false;
            timer.Start();
            initDemo();
        }

        private int getRandomNumber()
        {
            int nextNumber = r.Next(1, 9);
            while (nextNumber == photoNumber)
                nextNumber = r.Next(1, 9);

            photoNumber = nextNumber;
            return photoNumber;
        }

        private void loadImage()
        {
            pictureBox_central.BackgroundImage = Image.FromFile(Application.StartupPath + imagePath + getRandomNumber() + ".png");
            pictureBox_central.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void initDemo()
        {
            loadImage();
            if (photoNumber == 1 || photoNumber == 2 || photoNumber == 3)
                label_hint.Text = hintRectangle;
            if (photoNumber == 4 || photoNumber == 5 || photoNumber == 6)
                label_hint.Text = hintCircle;
            if (photoNumber == 7 || photoNumber == 8 || photoNumber == 9)
                label_hint.Text = hintTriangle;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            initDemo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            label_hint.Text = "";
            initDemo();
        }

        private void FormDemoFigurePlay_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkKeyPressed(e.KeyChar);
            countTries++;
            if (countTries == 20)
            {
                label_startTest.Visible = true;
                pictureBox_startTest.Visible = true;
                pictureBox_central.Visible = false;
                label_hint.Visible = false;
                label_try.Visible = false;
                pictureBox_try.Visible = false;
            }
        }

        private void checkKeyPressed(char key)
        {
            if (((key == 'A' || key == 'a') && (photoNumber == 1 || photoNumber == 2 || photoNumber == 3)) ||
                ((key == 'S' || key == 's') && (photoNumber == 4 || photoNumber == 5 || photoNumber == 6)) ||
                ((key == 'D' || key == 'd') && (photoNumber == 7 || photoNumber == 8 || photoNumber == 9)))
            {
                label_hint.Text = "Well done!";
            }
            else
            {
                label_hint.Text = "Wrong!";
            }

            loadImage();
        }

        private void pictureBox_startTest_Click(object sender, EventArgs e)
        {
            FormGame mFormGame = new FormGame();
            mFormGame.Show();
            this.Dispose();
        }
    }
}
