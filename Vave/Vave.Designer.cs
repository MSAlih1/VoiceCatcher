﻿namespace Vave
{
    partial class Vave
    {
        /// <summary>
        ///Gerekli designer değişkeni.
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
        ///Designer desteği için gerekli metottur; bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ResponseBox = new System.Windows.Forms.TextBox();
            this.MicrophoneLevel = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WaveViewer = new System.Windows.Forms.PictureBox();
            this.ProcessImage = new System.Windows.Forms.PictureBox();
            this.ProcessLogBox = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaveViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Kayıtları";
            // 
            // ResponseBox
            // 
            this.ResponseBox.Location = new System.Drawing.Point(15, 152);
            this.ResponseBox.Multiline = true;
            this.ResponseBox.Name = "ResponseBox";
            this.ResponseBox.Size = new System.Drawing.Size(396, 221);
            this.ResponseBox.TabIndex = 2;
            // 
            // MicrophoneLevel
            // 
            this.MicrophoneLevel.Location = new System.Drawing.Point(4, 19);
            this.MicrophoneLevel.Name = "MicrophoneLevel";
            this.MicrophoneLevel.Size = new System.Drawing.Size(274, 23);
            this.MicrophoneLevel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gelen Cevaplar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WaveViewer);
            this.groupBox1.Controls.Add(this.ProcessImage);
            this.groupBox1.Controls.Add(this.MicrophoneLevel);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mikrofon İstatistikleri";
            // 
            // WaveViewer
            // 
            this.WaveViewer.Location = new System.Drawing.Point(4, 48);
            this.WaveViewer.Name = "WaveViewer";
            this.WaveViewer.Size = new System.Drawing.Size(274, 60);
            this.WaveViewer.TabIndex = 4;
            this.WaveViewer.TabStop = false;
            // 
            // ProcessImage
            // 
            this.ProcessImage.ErrorImage = null;
            this.ProcessImage.Location = new System.Drawing.Point(281, 11);
            this.ProcessImage.Name = "ProcessImage";
            this.ProcessImage.Size = new System.Drawing.Size(100, 100);
            this.ProcessImage.TabIndex = 5;
            this.ProcessImage.TabStop = false;
            // 
            // ProcessLogBox
            // 
            this.ProcessLogBox.Location = new System.Drawing.Point(414, 36);
            this.ProcessLogBox.Margin = new System.Windows.Forms.Padding(0);
            this.ProcessLogBox.Name = "ProcessLogBox";
            this.ProcessLogBox.Size = new System.Drawing.Size(200, 337);
            this.ProcessLogBox.TabIndex = 7;
            this.ProcessLogBox.UseCompatibleStateImageBehavior = false;
            this.ProcessLogBox.View = System.Windows.Forms.View.Tile;
            this.ProcessLogBox.ItemActivate += new System.EventHandler(this.ProcessLogBox_ItemActivate);
            // 
            // Vave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 385);
            this.Controls.Add(this.ProcessLogBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResponseBox);
            this.Name = "Vave";
            this.Text = "Vave";
            this.Load += new System.EventHandler(this.Vave_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WaveViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResponseBox;
        private System.Windows.Forms.ProgressBar MicrophoneLevel;
        private System.Windows.Forms.PictureBox WaveViewer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ProcessImage;
        private System.Windows.Forms.ListView ProcessLogBox;
    }
}

