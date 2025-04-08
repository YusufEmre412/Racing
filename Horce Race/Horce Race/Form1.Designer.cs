namespace Horce_Race
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.sonic = new System.Windows.Forms.PictureBox();
            this.pikachu = new System.Windows.Forms.PictureBox();
            this.goku = new System.Windows.Forms.PictureBox();
            this.dog = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pikachu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Horce_Race.Properties.Resources.finish_line1;
            this.pictureBox5.Location = new System.Drawing.Point(1192, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(122, 574);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // sonic
            // 
            this.sonic.Image = global::Horce_Race.Properties.Resources.sonic;
            this.sonic.Location = new System.Drawing.Point(12, 449);
            this.sonic.Name = "sonic";
            this.sonic.Size = new System.Drawing.Size(138, 115);
            this.sonic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sonic.TabIndex = 3;
            this.sonic.TabStop = false;
            // 
            // pikachu
            // 
            this.pikachu.Image = global::Horce_Race.Properties.Resources.pikachu;
            this.pikachu.Location = new System.Drawing.Point(12, 303);
            this.pikachu.Name = "pikachu";
            this.pikachu.Size = new System.Drawing.Size(138, 115);
            this.pikachu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pikachu.TabIndex = 2;
            this.pikachu.TabStop = false;
            // 
            // goku
            // 
            this.goku.Image = global::Horce_Race.Properties.Resources.goku;
            this.goku.Location = new System.Drawing.Point(12, 155);
            this.goku.Name = "goku";
            this.goku.Size = new System.Drawing.Size(138, 115);
            this.goku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goku.TabIndex = 1;
            this.goku.TabStop = false;
            // 
            // dog
            // 
            this.dog.Image = global::Horce_Race.Properties.Resources.dog;
            this.dog.Location = new System.Drawing.Point(12, 12);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(138, 118);
            this.dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog.TabIndex = 0;
            this.dog.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox6.Location = new System.Drawing.Point(-3, 424);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1199, 20);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox7.Location = new System.Drawing.Point(-3, 276);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1199, 20);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox8.Location = new System.Drawing.Point(-3, 136);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1199, 20);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 570);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1317, 20);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1312, 570);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sonic);
            this.Controls.Add(this.pikachu);
            this.Controls.Add(this.goku);
            this.Controls.Add(this.dog);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pikachu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dog;
        private System.Windows.Forms.PictureBox goku;
        private System.Windows.Forms.PictureBox pikachu;
        private System.Windows.Forms.PictureBox sonic;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

