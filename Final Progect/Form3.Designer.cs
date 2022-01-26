
namespace Final_Progect
{
    partial class gameEasy
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
            this.tmShut = new System.Windows.Forms.Timer(this.components);
            this.lblLife = new System.Windows.Forms.Label();
            this.tmRock = new System.Windows.Forms.Timer(this.components);
            this.picBulet = new System.Windows.Forms.PictureBox();
            this.picNrock1 = new System.Windows.Forms.PictureBox();
            this.picShutle = new System.Windows.Forms.PictureBox();
            this.tmShoot = new System.Windows.Forms.Timer(this.components);
            this.picBase = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBulet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNrock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShutle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tmShut
            // 
            this.tmShut.Enabled = true;
            this.tmShut.Interval = 10;
            this.tmShut.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLife.ForeColor = System.Drawing.Color.White;
            this.lblLife.Location = new System.Drawing.Point(12, 9);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(58, 20);
            this.lblLife.TabIndex = 2;
            this.lblLife.Text = "lifes: ";
            this.lblLife.Visible = false;
            // 
            // tmRock
            // 
            this.tmRock.Enabled = true;
            this.tmRock.Interval = 20;
            this.tmRock.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picBulet
            // 
            this.picBulet.Image = global::Final_Progect.Properties.Resources.download__3_;
            this.picBulet.Location = new System.Drawing.Point(655, 644);
            this.picBulet.Name = "picBulet";
            this.picBulet.Size = new System.Drawing.Size(10, 50);
            this.picBulet.TabIndex = 3;
            this.picBulet.TabStop = false;
            this.picBulet.Visible = false;
            // 
            // picNrock1
            // 
            this.picNrock1.Image = global::Final_Progect.Properties.Resources.download__1_;
            this.picNrock1.Location = new System.Drawing.Point(599, 9);
            this.picNrock1.Name = "picNrock1";
            this.picNrock1.Size = new System.Drawing.Size(81, 110);
            this.picNrock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNrock1.TabIndex = 1;
            this.picNrock1.TabStop = false;
            // 
            // picShutle
            // 
            this.picShutle.Image = global::Final_Progect.Properties.Resources.download;
            this.picShutle.Location = new System.Drawing.Point(614, 700);
            this.picShutle.Name = "picShutle";
            this.picShutle.Size = new System.Drawing.Size(90, 119);
            this.picShutle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShutle.TabIndex = 0;
            this.picShutle.TabStop = false;
            // 
            // tmShoot
            // 
            this.tmShoot.Interval = 30;
            this.tmShoot.Tick += new System.EventHandler(this.tmShoot_Tick);
            // 
            // picBase
            // 
            this.picBase.BackColor = System.Drawing.Color.DimGray;
            this.picBase.Location = new System.Drawing.Point(-3, 825);
            this.picBase.Name = "picBase";
            this.picBase.Size = new System.Drawing.Size(1497, 50);
            this.picBase.TabIndex = 4;
            this.picBase.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox2.Location = new System.Drawing.Point(529, 825);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 17);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox3.Location = new System.Drawing.Point(972, 825);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(262, 17);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox4.Location = new System.Drawing.Point(116, 825);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(262, 17);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // gameEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1494, 854);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picBase);
            this.Controls.Add(this.picBulet);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.picNrock1);
            this.Controls.Add(this.picShutle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gameEasy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBulet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNrock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShutle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmShut;
        private System.Windows.Forms.PictureBox picShutle;
        private System.Windows.Forms.PictureBox picNrock1;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Timer tmRock;
        private System.Windows.Forms.PictureBox picBulet;
        private System.Windows.Forms.Timer tmShoot;
        private System.Windows.Forms.PictureBox picBase;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}