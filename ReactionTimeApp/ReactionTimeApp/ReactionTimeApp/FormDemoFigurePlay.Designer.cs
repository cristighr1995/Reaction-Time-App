namespace ReactionTimeApp
{
    partial class FormDemoFigurePlay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemoFigurePlay));
            this.pictureBox_central = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_hint = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_try = new System.Windows.Forms.PictureBox();
            this.label_try = new System.Windows.Forms.Label();
            this.label_startTest = new System.Windows.Forms.Label();
            this.pictureBox_startTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_central)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_try)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_startTest)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 1;
            // 
            // label_hint
            // 
            this.label_hint.AutoSize = true;
            this.label_hint.BackColor = System.Drawing.Color.Transparent;
            this.label_hint.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hint.ForeColor = System.Drawing.Color.Transparent;
            this.label_hint.Location = new System.Drawing.Point(19, 455);
            this.label_hint.Name = "label_hint";
            this.label_hint.Size = new System.Drawing.Size(57, 32);
            this.label_hint.TabIndex = 2;
            this.label_hint.Text = "hint";
            // 
            // timer
            // 
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox_try
            // 
            this.pictureBox_try.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_try.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_try.BackgroundImage")));
            this.pictureBox_try.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_try.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_try.Location = new System.Drawing.Point(670, 485);
            this.pictureBox_try.Name = "pictureBox_try";
            this.pictureBox_try.Size = new System.Drawing.Size(70, 58);
            this.pictureBox_try.TabIndex = 3;
            this.pictureBox_try.TabStop = false;
            this.pictureBox_try.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_try
            // 
            this.label_try.AutoSize = true;
            this.label_try.BackColor = System.Drawing.Color.Transparent;
            this.label_try.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_try.ForeColor = System.Drawing.Color.White;
            this.label_try.Location = new System.Drawing.Point(505, 498);
            this.label_try.Name = "label_try";
            this.label_try.Size = new System.Drawing.Size(159, 32);
            this.label_try.TabIndex = 4;
            this.label_try.Text = "Try it yourself";
            // 
            // label_startTest
            // 
            this.label_startTest.AutoSize = true;
            this.label_startTest.BackColor = System.Drawing.Color.Transparent;
            this.label_startTest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startTest.ForeColor = System.Drawing.Color.White;
            this.label_startTest.Location = new System.Drawing.Point(70, 124);
            this.label_startTest.Name = "label_startTest";
            this.label_startTest.Size = new System.Drawing.Size(594, 32);
            this.label_startTest.TabIndex = 5;
            this.label_startTest.Text = "I think you are prepared now! Let\'s try some real stuff!";
            // 
            // pictureBox_startTest
            // 
            this.pictureBox_startTest.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_startTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_startTest.BackgroundImage")));
            this.pictureBox_startTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_startTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_startTest.Location = new System.Drawing.Point(334, 159);
            this.pictureBox_startTest.Name = "pictureBox_startTest";
            this.pictureBox_startTest.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_startTest.TabIndex = 6;
            this.pictureBox_startTest.TabStop = false;
            this.pictureBox_startTest.Click += new System.EventHandler(this.pictureBox_startTest_Click);
            // 
            // FormDemoFigurePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 555);
            this.Controls.Add(this.pictureBox_startTest);
            this.Controls.Add(this.label_startTest);
            this.Controls.Add(this.label_try);
            this.Controls.Add(this.pictureBox_try);
            this.Controls.Add(this.label_hint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_central);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDemoFigurePlay";
            this.Text = "FormDemoFigurePlay";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDemoFigurePlay_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_central)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_try)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_startTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_central;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_hint;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox_try;
        private System.Windows.Forms.Label label_try;
        private System.Windows.Forms.Label label_startTest;
        private System.Windows.Forms.PictureBox pictureBox_startTest;
    }
}