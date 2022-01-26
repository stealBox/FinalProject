
namespace Final_Progect
{
    partial class Form4
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
            this.lblShoot = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblLives = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShoot
            // 
            this.lblShoot.AutoSize = true;
            this.lblShoot.BackColor = System.Drawing.Color.CadetBlue;
            this.lblShoot.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoot.Location = new System.Drawing.Point(12, 9);
            this.lblShoot.Name = "lblShoot";
            this.lblShoot.Size = new System.Drawing.Size(334, 33);
            this.lblShoot.TabIndex = 0;
            this.lblShoot.Text = "(SPACEBAR) IS TO SHOOT";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.BackColor = System.Drawing.Color.CadetBlue;
            this.lblRight.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRight.Location = new System.Drawing.Point(12, 94);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(296, 33);
            this.lblRight.TabIndex = 1;
            this.lblRight.Text = "(D) IS TO MOVE RIGHT";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.BackColor = System.Drawing.Color.CadetBlue;
            this.lblLeft.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.Location = new System.Drawing.Point(12, 52);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(269, 33);
            this.lblLeft.TabIndex = 2;
            this.lblLeft.Text = "(A) IS TO MOVE LEFT";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.CadetBlue;
            this.lblClose.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(12, 182);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(370, 33);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "(ESC) IS TO CLOSE THE GAME";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkRed;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnReturn.Location = new System.Drawing.Point(12, 294);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(101, 34);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.Color.CadetBlue;
            this.lblLives.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(12, 138);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(365, 33);
            this.lblLives.TabIndex = 5;
            this.lblLives.Text = "(S) IS TO SHOW YOUR LIVES";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(752, 340);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblShoot);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShoot;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblLives;
    }
}