namespace EERI325
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnHighpass = new System.Windows.Forms.Button();
            this.btnIDFT = new System.Windows.Forms.Button();
            this.btnDFT = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btnRGB = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OriginalImage = new System.Windows.Forms.TabPage();
            this.originalIMG = new System.Windows.Forms.PictureBox();
            this.RGB = new System.Windows.Forms.TabPage();
            this.BLUE = new System.Windows.Forms.PictureBox();
            this.GREEN = new System.Windows.Forms.PictureBox();
            this.RED = new System.Windows.Forms.PictureBox();
            this.originalIMG1 = new System.Windows.Forms.PictureBox();
            this.Grayscale = new System.Windows.Forms.TabPage();
            this.GRAY = new System.Windows.Forms.PictureBox();
            this.originalIMG2 = new System.Windows.Forms.PictureBox();
            this.DFT = new System.Windows.Forms.TabPage();
            this.baseFourier = new System.Windows.Forms.PictureBox();
            this.phase = new System.Windows.Forms.PictureBox();
            this.magnitude = new System.Windows.Forms.PictureBox();
            this.originalIMG3 = new System.Windows.Forms.PictureBox();
            this.IDFT = new System.Windows.Forms.TabPage();
            this.inverse = new System.Windows.Forms.PictureBox();
            this.originalIMG4 = new System.Windows.Forms.PictureBox();
            this.Highpass = new System.Windows.Forms.TabPage();
            this.FilteredMagnitude = new System.Windows.Forms.PictureBox();
            this.OriginalMagnitude = new System.Windows.Forms.PictureBox();
            this.Filtered = new System.Windows.Forms.PictureBox();
            this.originalIMG5 = new System.Windows.Forms.PictureBox();
            this.Pencil = new System.Windows.Forms.TabPage();
            this.PencilSketch = new System.Windows.Forms.PictureBox();
            this.originalIMG6 = new System.Windows.Forms.PictureBox();
            this.phaseSketch = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.OriginalImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG)).BeginInit();
            this.RGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BLUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG1)).BeginInit();
            this.Grayscale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG2)).BeginInit();
            this.DFT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseFourier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG3)).BeginInit();
            this.IDFT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG4)).BeginInit();
            this.Highpass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilteredMagnitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalMagnitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filtered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG5)).BeginInit();
            this.Pencil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PencilSketch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseSketch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPencil);
            this.panel1.Controls.Add(this.btnHighpass);
            this.panel1.Controls.Add(this.btnIDFT);
            this.panel1.Controls.Add(this.btnDFT);
            this.panel1.Controls.Add(this.btnGrayscale);
            this.panel1.Controls.Add(this.btnRGB);
            this.panel1.Location = new System.Drawing.Point(24, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 456);
            this.panel1.TabIndex = 0;
            // 
            // btnPencil
            // 
            this.btnPencil.Location = new System.Drawing.Point(31, 393);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(117, 39);
            this.btnPencil.TabIndex = 5;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnHighpass
            // 
            this.btnHighpass.Location = new System.Drawing.Point(31, 322);
            this.btnHighpass.Name = "btnHighpass";
            this.btnHighpass.Size = new System.Drawing.Size(117, 39);
            this.btnHighpass.TabIndex = 4;
            this.btnHighpass.Text = "Highpass";
            this.btnHighpass.UseVisualStyleBackColor = true;
            this.btnHighpass.Click += new System.EventHandler(this.btnHighpass_Click);
            // 
            // btnIDFT
            // 
            this.btnIDFT.Location = new System.Drawing.Point(31, 248);
            this.btnIDFT.Name = "btnIDFT";
            this.btnIDFT.Size = new System.Drawing.Size(117, 39);
            this.btnIDFT.TabIndex = 3;
            this.btnIDFT.Text = "IDFT";
            this.btnIDFT.UseVisualStyleBackColor = true;
            this.btnIDFT.Click += new System.EventHandler(this.btnIDFT_Click);
            // 
            // btnDFT
            // 
            this.btnDFT.Location = new System.Drawing.Point(31, 175);
            this.btnDFT.Name = "btnDFT";
            this.btnDFT.Size = new System.Drawing.Size(117, 39);
            this.btnDFT.TabIndex = 2;
            this.btnDFT.Text = "DFT";
            this.btnDFT.UseVisualStyleBackColor = true;
            this.btnDFT.Click += new System.EventHandler(this.btnDFT_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(31, 105);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(117, 39);
            this.btnGrayscale.TabIndex = 1;
            this.btnGrayscale.Text = "Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnRGB
            // 
            this.btnRGB.Location = new System.Drawing.Point(31, 35);
            this.btnRGB.Name = "btnRGB";
            this.btnRGB.Size = new System.Drawing.Size(117, 39);
            this.btnRGB.TabIndex = 0;
            this.btnRGB.Text = "RGB";
            this.btnRGB.UseVisualStyleBackColor = true;
            this.btnRGB.Click += new System.EventHandler(this.btnRGB_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OriginalImage);
            this.tabControl1.Controls.Add(this.RGB);
            this.tabControl1.Controls.Add(this.Grayscale);
            this.tabControl1.Controls.Add(this.DFT);
            this.tabControl1.Controls.Add(this.IDFT);
            this.tabControl1.Controls.Add(this.Highpass);
            this.tabControl1.Controls.Add(this.Pencil);
            this.tabControl1.Location = new System.Drawing.Point(230, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 515);
            this.tabControl1.TabIndex = 1;
            // 
            // OriginalImage
            // 
            this.OriginalImage.Controls.Add(this.originalIMG);
            this.OriginalImage.Location = new System.Drawing.Point(4, 22);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Padding = new System.Windows.Forms.Padding(3);
            this.OriginalImage.Size = new System.Drawing.Size(691, 489);
            this.OriginalImage.TabIndex = 0;
            this.OriginalImage.Text = "Original Image";
            this.OriginalImage.UseVisualStyleBackColor = true;
            // 
            // originalIMG
            // 
            this.originalIMG.Location = new System.Drawing.Point(64, 70);
            this.originalIMG.Name = "originalIMG";
            this.originalIMG.Size = new System.Drawing.Size(546, 346);
            this.originalIMG.TabIndex = 0;
            this.originalIMG.TabStop = false;
            // 
            // RGB
            // 
            this.RGB.Controls.Add(this.BLUE);
            this.RGB.Controls.Add(this.GREEN);
            this.RGB.Controls.Add(this.RED);
            this.RGB.Controls.Add(this.originalIMG1);
            this.RGB.Location = new System.Drawing.Point(4, 22);
            this.RGB.Name = "RGB";
            this.RGB.Padding = new System.Windows.Forms.Padding(3);
            this.RGB.Size = new System.Drawing.Size(691, 489);
            this.RGB.TabIndex = 1;
            this.RGB.Text = "RGB";
            this.RGB.UseVisualStyleBackColor = true;
            // 
            // BLUE
            // 
            this.BLUE.Location = new System.Drawing.Point(354, 263);
            this.BLUE.Name = "BLUE";
            this.BLUE.Size = new System.Drawing.Size(267, 196);
            this.BLUE.TabIndex = 3;
            this.BLUE.TabStop = false;
            // 
            // GREEN
            // 
            this.GREEN.Location = new System.Drawing.Point(39, 263);
            this.GREEN.Name = "GREEN";
            this.GREEN.Size = new System.Drawing.Size(267, 196);
            this.GREEN.TabIndex = 2;
            this.GREEN.TabStop = false;
            // 
            // RED
            // 
            this.RED.Location = new System.Drawing.Point(354, 24);
            this.RED.Name = "RED";
            this.RED.Size = new System.Drawing.Size(267, 196);
            this.RED.TabIndex = 1;
            this.RED.TabStop = false;
            // 
            // originalIMG1
            // 
            this.originalIMG1.Location = new System.Drawing.Point(43, 24);
            this.originalIMG1.Name = "originalIMG1";
            this.originalIMG1.Size = new System.Drawing.Size(263, 196);
            this.originalIMG1.TabIndex = 0;
            this.originalIMG1.TabStop = false;
            // 
            // Grayscale
            // 
            this.Grayscale.Controls.Add(this.GRAY);
            this.Grayscale.Controls.Add(this.originalIMG2);
            this.Grayscale.Location = new System.Drawing.Point(4, 22);
            this.Grayscale.Name = "Grayscale";
            this.Grayscale.Size = new System.Drawing.Size(691, 489);
            this.Grayscale.TabIndex = 2;
            this.Grayscale.Text = "Grayscale";
            this.Grayscale.UseVisualStyleBackColor = true;
            // 
            // GRAY
            // 
            this.GRAY.Location = new System.Drawing.Point(373, 129);
            this.GRAY.Name = "GRAY";
            this.GRAY.Size = new System.Drawing.Size(284, 212);
            this.GRAY.TabIndex = 1;
            this.GRAY.TabStop = false;
            // 
            // originalIMG2
            // 
            this.originalIMG2.Location = new System.Drawing.Point(19, 129);
            this.originalIMG2.Name = "originalIMG2";
            this.originalIMG2.Size = new System.Drawing.Size(284, 212);
            this.originalIMG2.TabIndex = 0;
            this.originalIMG2.TabStop = false;
            // 
            // DFT
            // 
            this.DFT.Controls.Add(this.baseFourier);
            this.DFT.Controls.Add(this.phase);
            this.DFT.Controls.Add(this.magnitude);
            this.DFT.Controls.Add(this.originalIMG3);
            this.DFT.Location = new System.Drawing.Point(4, 22);
            this.DFT.Name = "DFT";
            this.DFT.Size = new System.Drawing.Size(691, 489);
            this.DFT.TabIndex = 3;
            this.DFT.Text = "DFT";
            this.DFT.UseVisualStyleBackColor = true;
            // 
            // baseFourier
            // 
            this.baseFourier.Location = new System.Drawing.Point(359, 260);
            this.baseFourier.Name = "baseFourier";
            this.baseFourier.Size = new System.Drawing.Size(282, 184);
            this.baseFourier.TabIndex = 3;
            this.baseFourier.TabStop = false;
            // 
            // phase
            // 
            this.phase.Location = new System.Drawing.Point(22, 260);
            this.phase.Name = "phase";
            this.phase.Size = new System.Drawing.Size(282, 184);
            this.phase.TabIndex = 2;
            this.phase.TabStop = false;
            // 
            // magnitude
            // 
            this.magnitude.Location = new System.Drawing.Point(359, 33);
            this.magnitude.Name = "magnitude";
            this.magnitude.Size = new System.Drawing.Size(282, 184);
            this.magnitude.TabIndex = 1;
            this.magnitude.TabStop = false;
            // 
            // originalIMG3
            // 
            this.originalIMG3.Location = new System.Drawing.Point(21, 33);
            this.originalIMG3.Name = "originalIMG3";
            this.originalIMG3.Size = new System.Drawing.Size(283, 184);
            this.originalIMG3.TabIndex = 0;
            this.originalIMG3.TabStop = false;
            // 
            // IDFT
            // 
            this.IDFT.Controls.Add(this.inverse);
            this.IDFT.Controls.Add(this.originalIMG4);
            this.IDFT.Location = new System.Drawing.Point(4, 22);
            this.IDFT.Name = "IDFT";
            this.IDFT.Size = new System.Drawing.Size(691, 489);
            this.IDFT.TabIndex = 4;
            this.IDFT.Text = "IDFT";
            this.IDFT.UseVisualStyleBackColor = true;
            // 
            // inverse
            // 
            this.inverse.Location = new System.Drawing.Point(373, 104);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(296, 200);
            this.inverse.TabIndex = 1;
            this.inverse.TabStop = false;
            // 
            // originalIMG4
            // 
            this.originalIMG4.Location = new System.Drawing.Point(27, 104);
            this.originalIMG4.Name = "originalIMG4";
            this.originalIMG4.Size = new System.Drawing.Size(296, 200);
            this.originalIMG4.TabIndex = 0;
            this.originalIMG4.TabStop = false;
            // 
            // Highpass
            // 
            this.Highpass.Controls.Add(this.FilteredMagnitude);
            this.Highpass.Controls.Add(this.OriginalMagnitude);
            this.Highpass.Controls.Add(this.Filtered);
            this.Highpass.Controls.Add(this.originalIMG5);
            this.Highpass.Location = new System.Drawing.Point(4, 22);
            this.Highpass.Name = "Highpass";
            this.Highpass.Size = new System.Drawing.Size(691, 489);
            this.Highpass.TabIndex = 6;
            this.Highpass.Text = "Highpass";
            this.Highpass.UseVisualStyleBackColor = true;
            // 
            // FilteredMagnitude
            // 
            this.FilteredMagnitude.Location = new System.Drawing.Point(351, 259);
            this.FilteredMagnitude.Name = "FilteredMagnitude";
            this.FilteredMagnitude.Size = new System.Drawing.Size(274, 190);
            this.FilteredMagnitude.TabIndex = 3;
            this.FilteredMagnitude.TabStop = false;
            // 
            // OriginalMagnitude
            // 
            this.OriginalMagnitude.Location = new System.Drawing.Point(20, 259);
            this.OriginalMagnitude.Name = "OriginalMagnitude";
            this.OriginalMagnitude.Size = new System.Drawing.Size(274, 190);
            this.OriginalMagnitude.TabIndex = 2;
            this.OriginalMagnitude.TabStop = false;
            // 
            // Filtered
            // 
            this.Filtered.Location = new System.Drawing.Point(351, 36);
            this.Filtered.Name = "Filtered";
            this.Filtered.Size = new System.Drawing.Size(279, 190);
            this.Filtered.TabIndex = 1;
            this.Filtered.TabStop = false;
            // 
            // originalIMG5
            // 
            this.originalIMG5.Location = new System.Drawing.Point(20, 36);
            this.originalIMG5.Name = "originalIMG5";
            this.originalIMG5.Size = new System.Drawing.Size(274, 190);
            this.originalIMG5.TabIndex = 0;
            this.originalIMG5.TabStop = false;
            // 
            // Pencil
            // 
            this.Pencil.Controls.Add(this.phaseSketch);
            this.Pencil.Controls.Add(this.PencilSketch);
            this.Pencil.Controls.Add(this.originalIMG6);
            this.Pencil.Location = new System.Drawing.Point(4, 22);
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(691, 489);
            this.Pencil.TabIndex = 5;
            this.Pencil.Text = "Pencil";
            this.Pencil.UseVisualStyleBackColor = true;
            // 
            // PencilSketch
            // 
            this.PencilSketch.Location = new System.Drawing.Point(368, 68);
            this.PencilSketch.Name = "PencilSketch";
            this.PencilSketch.Size = new System.Drawing.Size(278, 185);
            this.PencilSketch.TabIndex = 1;
            this.PencilSketch.TabStop = false;
            // 
            // originalIMG6
            // 
            this.originalIMG6.Location = new System.Drawing.Point(37, 68);
            this.originalIMG6.Name = "originalIMG6";
            this.originalIMG6.Size = new System.Drawing.Size(271, 185);
            this.originalIMG6.TabIndex = 0;
            this.originalIMG6.TabStop = false;
            // 
            // phaseSketch
            // 
            this.phaseSketch.Location = new System.Drawing.Point(368, 280);
            this.phaseSketch.Name = "phaseSketch";
            this.phaseSketch.Size = new System.Drawing.Size(278, 185);
            this.phaseSketch.TabIndex = 2;
            this.phaseSketch.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.OriginalImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG)).EndInit();
            this.RGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BLUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG1)).EndInit();
            this.Grayscale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG2)).EndInit();
            this.DFT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseFourier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG3)).EndInit();
            this.IDFT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inverse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG4)).EndInit();
            this.Highpass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilteredMagnitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalMagnitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filtered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG5)).EndInit();
            this.Pencil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PencilSketch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalIMG6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseSketch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRGB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OriginalImage;
        private System.Windows.Forms.PictureBox originalIMG;
        private System.Windows.Forms.TabPage RGB;
        private System.Windows.Forms.PictureBox BLUE;
        private System.Windows.Forms.PictureBox GREEN;
        private System.Windows.Forms.PictureBox RED;
        private System.Windows.Forms.PictureBox originalIMG1;
        private System.Windows.Forms.TabPage Grayscale;
        private System.Windows.Forms.PictureBox GRAY;
        private System.Windows.Forms.PictureBox originalIMG2;
        private System.Windows.Forms.TabPage DFT;
        private System.Windows.Forms.PictureBox phase;
        private System.Windows.Forms.PictureBox magnitude;
        private System.Windows.Forms.PictureBox originalIMG3;
        private System.Windows.Forms.TabPage IDFT;
        private System.Windows.Forms.PictureBox inverse;
        private System.Windows.Forms.PictureBox originalIMG4;
        private System.Windows.Forms.TabPage Highpass;
        private System.Windows.Forms.PictureBox Filtered;
        private System.Windows.Forms.PictureBox originalIMG5;
        private System.Windows.Forms.TabPage Pencil;
        private System.Windows.Forms.PictureBox PencilSketch;
        private System.Windows.Forms.PictureBox originalIMG6;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnHighpass;
        private System.Windows.Forms.Button btnIDFT;
        private System.Windows.Forms.Button btnDFT;
        private System.Windows.Forms.PictureBox baseFourier;
        private System.Windows.Forms.PictureBox FilteredMagnitude;
        private System.Windows.Forms.PictureBox OriginalMagnitude;
        private System.Windows.Forms.PictureBox phaseSketch;
    }
}

