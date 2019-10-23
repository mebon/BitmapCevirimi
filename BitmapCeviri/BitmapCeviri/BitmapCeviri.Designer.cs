namespace BitmapCeviri
{
    partial class BitmapCeviri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGenislik = new System.Windows.Forms.Label();
            this.labelYukseklik = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonResimYukleme = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSetPiksel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonBitmap = new System.Windows.Forms.Button();
            this.button2GrayScale = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pBRenk = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.thresholdDegeri = new System.Windows.Forms.NumericUpDown();
            this.BlueAyarla = new System.Windows.Forms.NumericUpDown();
            this.RedAyarla = new System.Windows.Forms.NumericUpDown();
            this.GreenAyarla = new System.Windows.Forms.NumericUpDown();
            this.hexaDeger = new System.Windows.Forms.Label();
            this.yAyarla = new System.Windows.Forms.NumericUpDown();
            this.xAyarla = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBRenk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdDegeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueAyarla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedAyarla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenAyarla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yAyarla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xAyarla)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 537);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Genişlik : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yükseklik : ";
            // 
            // labelGenislik
            // 
            this.labelGenislik.AutoSize = true;
            this.labelGenislik.Location = new System.Drawing.Point(57, 20);
            this.labelGenislik.Name = "labelGenislik";
            this.labelGenislik.Size = new System.Drawing.Size(13, 13);
            this.labelGenislik.TabIndex = 2;
            this.labelGenislik.Text = "0";
            // 
            // labelYukseklik
            // 
            this.labelYukseklik.AutoSize = true;
            this.labelYukseklik.Location = new System.Drawing.Point(163, 20);
            this.labelYukseklik.Name = "labelYukseklik";
            this.labelYukseklik.Size = new System.Drawing.Size(13, 13);
            this.labelYukseklik.TabIndex = 1;
            this.labelYukseklik.Text = "0";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Silver;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(17, 16);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(450, 450);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonResimYukleme);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(506, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 79);
            this.panel2.TabIndex = 1;
            // 
            // buttonResimYukleme
            // 
            this.buttonResimYukleme.Location = new System.Drawing.Point(56, 29);
            this.buttonResimYukleme.Name = "buttonResimYukleme";
            this.buttonResimYukleme.Size = new System.Drawing.Size(117, 23);
            this.buttonResimYukleme.TabIndex = 6;
            this.buttonResimYukleme.Text = "Resim Yükleme";
            this.buttonResimYukleme.UseVisualStyleBackColor = true;
            this.buttonResimYukleme.Click += new System.EventHandler(this.buttonResimYukleme_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(73, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resim Yükleme";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.xAyarla);
            this.panel3.Controls.Add(this.yAyarla);
            this.panel3.Controls.Add(this.hexaDeger);
            this.panel3.Controls.Add(this.GreenAyarla);
            this.panel3.Controls.Add(this.RedAyarla);
            this.panel3.Controls.Add(this.BlueAyarla);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.pBRenk);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.buttonSetPiksel);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(506, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 181);
            this.panel3.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Blue : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Green : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Red : ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // buttonSetPiksel
            // 
            this.buttonSetPiksel.Location = new System.Drawing.Point(3, 132);
            this.buttonSetPiksel.Name = "buttonSetPiksel";
            this.buttonSetPiksel.Size = new System.Drawing.Size(120, 25);
            this.buttonSetPiksel.TabIndex = 7;
            this.buttonSetPiksel.Text = "Set Piksel";
            this.buttonSetPiksel.UseVisualStyleBackColor = true;
            this.buttonSetPiksel.Click += new System.EventHandler(this.buttonSetPiksel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hexadecimal : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(83, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Piksel Bilgileri";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.buttonReset);
            this.panel4.Controls.Add(this.buttonBitmap);
            this.panel4.Controls.Add(this.button2GrayScale);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.thresholdDegeri);
            this.panel4.Location = new System.Drawing.Point(506, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 130);
            this.panel4.TabIndex = 2;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(60, 100);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(117, 23);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonBitmap
            // 
            this.buttonBitmap.Location = new System.Drawing.Point(150, 59);
            this.buttonBitmap.Name = "buttonBitmap";
            this.buttonBitmap.Size = new System.Drawing.Size(79, 23);
            this.buttonBitmap.TabIndex = 14;
            this.buttonBitmap.Text = "Bitmap";
            this.buttonBitmap.UseVisualStyleBackColor = true;
            this.buttonBitmap.Click += new System.EventHandler(this.buttonBitmap_Click);
            // 
            // button2GrayScale
            // 
            this.button2GrayScale.Location = new System.Drawing.Point(76, 20);
            this.button2GrayScale.Name = "button2GrayScale";
            this.button2GrayScale.Size = new System.Drawing.Size(82, 23);
            this.button2GrayScale.TabIndex = 13;
            this.button2GrayScale.Text = "GrayScale";
            this.button2GrayScale.UseVisualStyleBackColor = true;
            this.button2GrayScale.Click += new System.EventHandler(this.button2GrayScale_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(100, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Çeviri";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(506, 419);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 130);
            this.panel5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(99, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Yapan";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pBRenk
            // 
            this.pBRenk.Location = new System.Drawing.Point(129, 132);
            this.pBRenk.Name = "pBRenk";
            this.pBRenk.Size = new System.Drawing.Size(100, 24);
            this.pBRenk.TabIndex = 16;
            this.pBRenk.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "X : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Y : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Threshold : ";
            // 
            // thresholdDegeri
            // 
            this.thresholdDegeri.Location = new System.Drawing.Point(86, 61);
            this.thresholdDegeri.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdDegeri.Name = "thresholdDegeri";
            this.thresholdDegeri.Size = new System.Drawing.Size(58, 20);
            this.thresholdDegeri.TabIndex = 5;
            // 
            // BlueAyarla
            // 
            this.BlueAyarla.Location = new System.Drawing.Point(47, 78);
            this.BlueAyarla.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueAyarla.Name = "BlueAyarla";
            this.BlueAyarla.Size = new System.Drawing.Size(55, 20);
            this.BlueAyarla.TabIndex = 24;
            // 
            // RedAyarla
            // 
            this.RedAyarla.Location = new System.Drawing.Point(47, 39);
            this.RedAyarla.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedAyarla.Name = "RedAyarla";
            this.RedAyarla.Size = new System.Drawing.Size(55, 20);
            this.RedAyarla.TabIndex = 25;
            // 
            // GreenAyarla
            // 
            this.GreenAyarla.Location = new System.Drawing.Point(47, 58);
            this.GreenAyarla.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenAyarla.Name = "GreenAyarla";
            this.GreenAyarla.Size = new System.Drawing.Size(55, 20);
            this.GreenAyarla.TabIndex = 26;
            // 
            // hexaDeger
            // 
            this.hexaDeger.AutoSize = true;
            this.hexaDeger.Location = new System.Drawing.Point(80, 21);
            this.hexaDeger.Name = "hexaDeger";
            this.hexaDeger.Size = new System.Drawing.Size(13, 13);
            this.hexaDeger.TabIndex = 28;
            this.hexaDeger.Text = "0";
            // 
            // yAyarla
            // 
            this.yAyarla.Location = new System.Drawing.Point(156, 76);
            this.yAyarla.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.yAyarla.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yAyarla.Name = "yAyarla";
            this.yAyarla.Size = new System.Drawing.Size(55, 20);
            this.yAyarla.TabIndex = 29;
            this.yAyarla.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xAyarla
            // 
            this.xAyarla.Location = new System.Drawing.Point(156, 37);
            this.xAyarla.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.xAyarla.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xAyarla.Name = "xAyarla";
            this.xAyarla.Size = new System.Drawing.Size(55, 20);
            this.xAyarla.TabIndex = 30;
            this.xAyarla.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(-2, 104);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(237, 10);
            this.panel6.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(0, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Muhammed Emin Berkay KOCAOĞLU";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(74, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "201513171070";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Location = new System.Drawing.Point(-2, 46);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(237, 10);
            this.panel8.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Location = new System.Drawing.Point(-2, 88);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(237, 10);
            this.panel9.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.labelYukseklik);
            this.panel7.Controls.Add(this.labelGenislik);
            this.panel7.Location = new System.Drawing.Point(143, 472);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 57);
            this.panel7.TabIndex = 24;
            // 
            // BitmapCeviri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(749, 561);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BitmapCeviri";
            this.Text = "Bitmap Ceviri";
            this.Load += new System.EventHandler(this.BitmapCeviri_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBRenk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdDegeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueAyarla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedAyarla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenAyarla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yAyarla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xAyarla)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGenislik;
        private System.Windows.Forms.Label labelYukseklik;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonResimYukleme;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSetPiksel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonBitmap;
        private System.Windows.Forms.Button button2GrayScale;
        private System.Windows.Forms.PictureBox pBRenk;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown thresholdDegeri;
        private System.Windows.Forms.NumericUpDown GreenAyarla;
        private System.Windows.Forms.NumericUpDown RedAyarla;
        private System.Windows.Forms.NumericUpDown BlueAyarla;
        private System.Windows.Forms.Label hexaDeger;
        private System.Windows.Forms.NumericUpDown xAyarla;
        private System.Windows.Forms.NumericUpDown yAyarla;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
    }
}

