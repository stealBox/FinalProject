
namespace Final_Progect
{
    partial class Form10
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
            this.lblLife = new System.Windows.Forms.Label();
            this.tmShut = new System.Windows.Forms.Timer(this.components);
            this.picNrock1 = new System.Windows.Forms.PictureBox();
            this.picShutle = new System.Windows.Forms.PictureBox();
            this.tmRock = new System.Windows.Forms.Timer(this.components);
            this.tmShoot = new System.Windows.Forms.Timer(this.components);
            this.picBulet = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNrock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShutle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBulet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLife.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLife.Location = new System.Drawing.Point(12, 9);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(96, 20);
            this.lblLife.TabIndex = 4;
            this.lblLife.Text = "HARDCORE";
            // 
            // tmShut
            // 
            this.tmShut.Enabled = true;
            this.tmShut.Interval = 10;
            this.tmShut.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picNrock1
            // 
            this.picNrock1.Image = global::Final_Progect.Properties.Resources.download__1_;
            this.picNrock1.Location = new System.Drawing.Point(600, 37);
            this.picNrock1.Name = "picNrock1";
            this.picNrock1.Size = new System.Drawing.Size(81, 110);
            this.picNrock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNrock1.TabIndex = 3;
            this.picNrock1.TabStop = false;
            // 
            // picShutle
            // 
            this.picShutle.Image = global::Final_Progect.Properties.Resources.download;
            this.picShutle.Location = new System.Drawing.Point(677, 646);
            this.picShutle.Name = "picShutle";
            this.picShutle.Size = new System.Drawing.Size(90, 119);
            this.picShutle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShutle.TabIndex = 2;
            this.picShutle.TabStop = false;
            // 
            // tmRock
            // 
            this.tmRock.Tick += new System.EventHandler(this.tmRock_Tick);
            // 
            // tmShoot
            // 
            this.tmShoot.Tick += new System.EventHandler(this.tmShoot_Tick);
            // 
            // picBulet
            // 
            this.picBulet.Image = global::Final_Progect.Properties.Resources.download__3_;
            this.picBulet.Location = new System.Drawing.Point(717, 590);
            this.picBulet.Name = "picBulet";
            this.picBulet.Size = new System.Drawing.Size(10, 50);
            this.picBulet.TabIndex = 5;
            this.picBulet.TabStop = false;
            this.picBulet.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox4.Location = new System.Drawing.Point(106, 771);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(262, 17);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox3.Location = new System.Drawing.Point(1090, 771);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(262, 17);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox2.Location = new System.Drawing.Point(591, 771);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 17);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(-13, 771);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1497, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1478, 815);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBulet);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.picNrock1);
            this.Controls.Add(this.picShutle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form10_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form10_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picNrock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShutle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBulet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNrock1;
        private System.Windows.Forms.PictureBox picShutle;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Timer tmShut;
        private System.Windows.Forms.Timer tmRock;
        private System.Windows.Forms.Timer tmShoot;
        private System.Windows.Forms.PictureBox picBulet;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}