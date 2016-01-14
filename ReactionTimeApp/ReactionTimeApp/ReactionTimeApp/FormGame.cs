using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactionTimeApp
{
    public partial class FormGame : Form
    {
        private static string imagePath = "\\images\\img_";
        private static Random r = new Random();
        private static int photoNumber = 1;
        private Stopwatch mStopWatch = new Stopwatch();
        private static ArrayList reactionTimeList = new ArrayList();
        private static double sumReactionTime = 0;
        private static bool isCorrect = true;
        private SoundPlayer simpleSound = new SoundPlayer();
        public FormGame()
        {
            InitializeComponent();
            this.CenterToScreen();
            rotateImageBack();

            int rand = getRandomNumber();
            if(rand <= 9)
                putNextPicture(rand);
            else
            {
                string path = "";
                if (rand >= 10 && rand <= 14)
                    path = @"music\\sound_high.wav";
                if (rand >= 15 && rand <= 18)
                    path = @"music\\sound_low.wav";

                playSound(path);
            }

            label_textAverageReaction.Visible = false;
            label_numberAverage.Visible = false;
            pictureBox_back.Visible = false;
        }

        private int getRandomNumber()
        {
            int nextNumber = r.Next(1, 18);
            while (nextNumber == photoNumber)
                nextNumber = r.Next(1, 18);

            photoNumber = nextNumber;
            return photoNumber;
        }

        private void loadImage(int number)
        {
            pictureBox_central.BackgroundImage = Image.FromFile(Application.StartupPath + imagePath + number + ".png");
            pictureBox_central.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void putNextPicture(int number)
        {
            pictureBox_central.Visible = true;
            loadImage(number);
            mStopWatch.Start();
        }

        private void FormGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            // opresc cronometrul si sunetul, daca era pornit
            mStopWatch.Stop();
            simpleSound.Stop();

            // timpul de reactie
            double reactionTime = ((float)mStopWatch.ElapsedMilliseconds) / 1000;
            sumReactionTime += reactionTime;
            reactionTimeList.Add(reactionTime);

            label_reactionTime.Text = reactionTime.ToString();
            // resetez cronometrul 
            mStopWatch.Reset();

            checkKeyPressed(e.KeyChar);

            if (isCorrect)
            {
                int rand = getRandomNumber();
                if (rand <= 9)
                    putNextPicture(rand);
                else
                {
                    string path = "";
                    if (rand >= 10 && rand <= 14)
                        path = @"music\\sound_high.wav";
                    if (rand >= 15 && rand <= 18)
                        path = @"music\\sound_low.wav";

                    playSound(path);
                }
            }
        }

        private void playSound(string path)
        {
            pictureBox_central.Visible = false;
            mStopWatch.Start();

            simpleSound.Stop();

            string rootLocation = Application.StartupPath;
            string fullPathToSound = Path.Combine(rootLocation, path);

            simpleSound.SoundLocation = fullPathToSound;
            simpleSound.Play();
        }

        private void checkKeyPressed(char key)
        {
            if (((key == 'A' || key == 'a') && (photoNumber == 1 || photoNumber == 2 || photoNumber == 3)) ||
                ((key == 'S' || key == 's') && (photoNumber == 4 || photoNumber == 5 || photoNumber == 6)) ||
                ((key == 'D' || key == 'd') && (photoNumber == 7 || photoNumber == 8 || photoNumber == 9)))
            {
                isCorrect = true;
            }
            else if (((key == 'O' || key == 'o') && (photoNumber >= 10 && photoNumber <= 14)) ||
                     ((key == 'P' || key == 'p') && (photoNumber >= 15 && photoNumber <= 18)))
            {
                isCorrect = true;
            }
            else
            {
                isCorrect = false;
                pictureBox_central.Visible = false;
                label_reactionTime.Visible = false;

                label_textAverageReaction.Visible = true;
                double average = sumReactionTime / reactionTimeList.Count;
                label_numberAverage.Text = average.ToString("#.000");
                centerLabelAverage();
                label_numberAverage.Visible = true;
                pictureBox_back.Visible = true;
            }
            
        }

        private void rotateImageBack()
        {
            Image pbImage = pictureBox_back.BackgroundImage;
            pbImage.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBox_back.BackgroundImage = pbImage;
            pictureBox_back.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void centerLabelAverage()
        {
            label_numberAverage.Left = this.Width / 2 - (label_numberAverage.Width / 2);
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
