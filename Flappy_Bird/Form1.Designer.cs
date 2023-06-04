namespace Flappy_Bird
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.scoreTesxt = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            this.SuspendLayout();
            // 
            // BoruUst
            // 
            this.BoruUst.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst.Image")));
            this.BoruUst.Location = new System.Drawing.Point(470, 2);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(84, 126);
            this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst.TabIndex = 0;
            this.BoruUst.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(26, 238);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(95, 63);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.flappyBird_Click);
            // 
            // Zemin
            // 
            this.Zemin.Image = ((System.Drawing.Image)(resources.GetObject("Zemin.Image")));
            this.Zemin.Location = new System.Drawing.Point(-4, 545);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(619, 50);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 3;
            this.Zemin.TabStop = false;
            // 
            // BoruAlt
            // 
            this.BoruAlt.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt.Image")));
            this.BoruAlt.Location = new System.Drawing.Point(404, 391);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(88, 158);
            this.BoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt.TabIndex = 4;
            this.BoruAlt.TabStop = false;
            // 
            // scoreTesxt
            // 
            this.scoreTesxt.AutoSize = true;
            this.scoreTesxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreTesxt.Location = new System.Drawing.Point(57, 601);
            this.scoreTesxt.Name = "scoreTesxt";
            this.scoreTesxt.Size = new System.Drawing.Size(115, 31);
            this.scoreTesxt.TabIndex = 5;
            this.scoreTesxt.Text = "Score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(605, 642);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.scoreTesxt);
            this.Controls.Add(this.BoruAlt);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.BoruUst);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoruUst;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.PictureBox BoruAlt;
        private System.Windows.Forms.Label scoreTesxt;
        private System.Windows.Forms.Timer gameTimer;
    }
}

