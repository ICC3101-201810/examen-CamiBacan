namespace Examen
{
    partial class Partida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Partida));
            this.pinkGhost = new System.Windows.Forms.PictureBox();
            this.redGhost = new System.Windows.Forms.PictureBox();
            this.pacman = new System.Windows.Forms.PictureBox();
            this.uva = new System.Windows.Forms.PictureBox();
            this.cherry = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_timer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).BeginInit();
            this.SuspendLayout();
            // 
            // pinkGhost
            // 
            this.pinkGhost.Image = ((System.Drawing.Image)(resources.GetObject("pinkGhost.Image")));
            this.pinkGhost.Location = new System.Drawing.Point(93, 99);
            this.pinkGhost.Name = "pinkGhost";
            this.pinkGhost.Size = new System.Drawing.Size(26, 28);
            this.pinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkGhost.TabIndex = 0;
            this.pinkGhost.TabStop = false;
            this.pinkGhost.Tag = "ghost";
            // 
            // redGhost
            // 
            this.redGhost.Image = ((System.Drawing.Image)(resources.GetObject("redGhost.Image")));
            this.redGhost.Location = new System.Drawing.Point(93, 218);
            this.redGhost.Name = "redGhost";
            this.redGhost.Size = new System.Drawing.Size(26, 28);
            this.redGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redGhost.TabIndex = 1;
            this.redGhost.TabStop = false;
            this.redGhost.Tag = "ghost";
            // 
            // pacman
            // 
            this.pacman.Image = ((System.Drawing.Image)(resources.GetObject("pacman.Image")));
            this.pacman.Location = new System.Drawing.Point(357, 170);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(25, 25);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman.TabIndex = 2;
            this.pacman.TabStop = false;
            // 
            // uva
            // 
            this.uva.Image = ((System.Drawing.Image)(resources.GetObject("uva.Image")));
            this.uva.Location = new System.Drawing.Point(538, 313);
            this.uva.Name = "uva";
            this.uva.Size = new System.Drawing.Size(25, 25);
            this.uva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uva.TabIndex = 3;
            this.uva.TabStop = false;
            this.uva.Tag = "fruit";
            // 
            // cherry
            // 
            this.cherry.Cursor = System.Windows.Forms.Cursors.Default;
            this.cherry.Image = ((System.Drawing.Image)(resources.GetObject("cherry.Image")));
            this.cherry.Location = new System.Drawing.Point(207, 99);
            this.cherry.Name = "cherry";
            this.cherry.Size = new System.Drawing.Size(25, 25);
            this.cherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cherry.TabIndex = 4;
            this.cherry.TabStop = false;
            this.cherry.Tag = "fruit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.Location = new System.Drawing.Point(230, 9);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(65, 23);
            this.label_timer.TabIndex = 7;
            this.label_timer.Text = "timer\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cherry);
            this.Controls.Add(this.uva);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.redGhost);
            this.Controls.Add(this.pinkGhost);
            this.Name = "Partida";
            this.Text = "Partida";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pinkGhost;
        private System.Windows.Forms.PictureBox redGhost;
        private System.Windows.Forms.PictureBox pacman;
        private System.Windows.Forms.PictureBox uva;
        private System.Windows.Forms.PictureBox cherry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Label label3;
    }
}