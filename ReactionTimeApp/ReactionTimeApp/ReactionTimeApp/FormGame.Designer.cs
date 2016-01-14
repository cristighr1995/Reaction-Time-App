namespace ReactionTimeApp
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.pictureBox_central = new System.Windows.Forms.PictureBox();
            this.label_reactionTime = new System.Windows.Forms.Label();
            this.label_textAverageReaction = new System.Windows.Forms.Label();
            this.label_numberAverage = new System.Windows.Forms.Label();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_central)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_central
            // 
            this.pictureBox_central.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_central.Location = new System.Drawing.Point(176, 12);
            this.pictureBox_central.Name = "pictureBox_central";
            this.pictureBox_central.Size = new System.Drawing.Size(400, 400);
            this.pictureBox_central.TabIndex = 0;
            this.pictureBox_central.TabStop = false;
            // 
            // label_reactionTime
            // 
            this.label_reactionTime.AutoSize = true;
            this.label_reactionTime.BackColor = System.Drawing.Color.Transparent;
            this.label_reactionTime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reactionTime.ForeColor = System.Drawing.Color.White;
            this.label_reactionTime.Location = new System.Drawing.Point(12, 514);
            this.label_reactionTime.Name = "label_reactionTime";
            this.label_reactionTime.Size = new System.Drawing.Size(0, 32);
            this.label_reactionTime.TabIndex = 1;
            // 
            // label_textAverageReaction
            // 
            this.label_textAverageReaction.AutoSize = true;
            this.label_textAverageReaction.BackColor = System.Drawing.Color.Transparent;
            this.label_textAverageReaction.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_textAverageReaction.ForeColor = System.Drawing.Color.White;
            this.label_textAverageReaction.Location = new System.Drawing.Point(204, 110);
            this.label_textAverageReaction.Name = "label_textAverageReaction";
            this.label_textAverageReaction.Size = new System.Drawing.Size(343, 32);
            this.label_textAverageReaction.TabIndex = 2;
            this.label_textAverageReaction.Text = "You\'re average reaction time is";
            // 
            // label_numberAverage
            // 
            this.label_numberAverage.AutoSize = true;
            this.label_numberAverage.BackColor = System.Drawing.Color.Transparent;
            this.label_numberAverage.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numberAverage.ForeColor = System.Drawing.Color.LawnGreen;
            this.label_numberAverage.Location = new System.Drawing.Point(270, 142);
            this.label_numberAverage.Name = "label_numberAverage";
            this.label_numberAverage.Size = new System.Drawing.Size(218, 86);
            this.label_numberAverage.TabIndex = 3;
            this.label_numberAverage.Text = "5.285s";
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_back.BackgroundImage")));
            this.pictureBox_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_back.Location = new System.Drawing.Point(345, 483);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_back.TabIndex = 4;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.pictureBox_back_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 555);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.label_numberAverage);
            this.Controls.Add(this.label_textAverageReaction);
            this.Controls.Add(this.label_reactionTime);
            this.Controls.Add(this.pictureBox_central);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormGame_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_central)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_central;
        private System.Windows.Forms.Label label_reactionTime;
        private System.Windows.Forms.Label label_textAverageReaction;
        private System.Windows.Forms.Label label_numberAverage;
        private System.Windows.Forms.PictureBox pictureBox_back;
    }
}