namespace Final
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
            this.lblWins = new System.Windows.Forms.Label();
            this.lbllosses = new System.Windows.Forms.Label();
            this.btnCards = new System.Windows.Forms.Button();
            this.lblwinCount = new System.Windows.Forms.Label();
            this.lbllossCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(13, 13);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(48, 24);
            this.lblWins.TabIndex = 0;
            this.lblWins.Text = "wins";
            // 
            // lbllosses
            // 
            this.lbllosses.AutoSize = true;
            this.lbllosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllosses.Location = new System.Drawing.Point(13, 55);
            this.lbllosses.Name = "lbllosses";
            this.lbllosses.Size = new System.Drawing.Size(63, 24);
            this.lbllosses.TabIndex = 1;
            this.lbllosses.Text = "losses";
            // 
            // btnCards
            // 
            this.btnCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCards.Location = new System.Drawing.Point(17, 99);
            this.btnCards.Name = "btnCards";
            this.btnCards.Size = new System.Drawing.Size(75, 31);
            this.btnCards.TabIndex = 2;
            this.btnCards.Text = "Cards";
            this.btnCards.UseVisualStyleBackColor = true;
            this.btnCards.Click += new System.EventHandler(this.btnCards_Click);
            // 
            // lblwinCount
            // 
            this.lblwinCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblwinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinCount.Location = new System.Drawing.Point(86, 14);
            this.lblwinCount.Name = "lblwinCount";
            this.lblwinCount.Size = new System.Drawing.Size(100, 23);
            this.lblwinCount.TabIndex = 3;

            // 
            // lbllossCount
            // 
            this.lbllossCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbllossCount.Location = new System.Drawing.Point(86, 56);
            this.lbllossCount.Name = "lbllossCount";
            this.lbllossCount.Size = new System.Drawing.Size(100, 23);
            this.lbllossCount.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(664, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(664, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbllossCount);
            this.Controls.Add(this.lblwinCount);
            this.Controls.Add(this.btnCards);
            this.Controls.Add(this.lbllosses);
            this.Controls.Add(this.lblWins);
            this.Name = "Form1";
            this.Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lbllosses;
        private System.Windows.Forms.Button btnCards;
        private System.Windows.Forms.Label lblwinCount;
        private System.Windows.Forms.Label lbllossCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

