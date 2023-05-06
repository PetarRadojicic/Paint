
namespace Projekat
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Kanvas = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pentagon = new System.Windows.Forms.PictureBox();
            this.trougao = new System.Windows.Forms.PictureBox();
            this.blok = new System.Windows.Forms.PictureBox();
            this.marker = new System.Windows.Forms.PictureBox();
            this.Gumica = new System.Windows.Forms.PictureBox();
            this.Hard = new System.Windows.Forms.PictureBox();
            this.Dot = new System.Windows.Forms.PictureBox();
            this.Sponge = new System.Windows.Forms.PictureBox();
            this.Soft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pentagon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trougao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gumica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sponge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soft)).BeginInit();
            this.SuspendLayout();
            // 
            // Kanvas
            // 
            this.Kanvas.BackColor = System.Drawing.Color.White;
            this.Kanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Kanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Kanvas.Location = new System.Drawing.Point(12, 135);
            this.Kanvas.Name = "Kanvas";
            this.Kanvas.Size = new System.Drawing.Size(568, 303);
            this.Kanvas.TabIndex = 0;
            this.Kanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Kanvas_Paint);
            this.Kanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kanvas_MouseDown);
            this.Kanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Kanvas_MouseMove);
            this.Kanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Kanvas_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(93, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 100);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(201, 59);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(199, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 64;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "64";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "Wipe";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 11;
            this.button4.Text = "Open";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pentagon);
            this.panel1.Controls.Add(this.trougao);
            this.panel1.Controls.Add(this.blok);
            this.panel1.Controls.Add(this.marker);
            this.panel1.Controls.Add(this.Gumica);
            this.panel1.Controls.Add(this.Hard);
            this.panel1.Controls.Add(this.Dot);
            this.panel1.Controls.Add(this.Sponge);
            this.panel1.Controls.Add(this.Soft);
            this.panel1.Location = new System.Drawing.Point(443, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 123);
            this.panel1.TabIndex = 13;
            // 
            // pentagon
            // 
            this.pentagon.BackgroundImage = global::Projekat.Properties.Resources.pentagon1;
            this.pentagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pentagon.Location = new System.Drawing.Point(986, 6);
            this.pentagon.Name = "pentagon";
            this.pentagon.Size = new System.Drawing.Size(117, 99);
            this.pentagon.TabIndex = 18;
            this.pentagon.TabStop = false;
            this.pentagon.Click += new System.EventHandler(this.pentagon_Click);
            // 
            // trougao
            // 
            this.trougao.BackgroundImage = global::Projekat.Properties.Resources.trougao1;
            this.trougao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trougao.Location = new System.Drawing.Point(864, 6);
            this.trougao.Name = "trougao";
            this.trougao.Size = new System.Drawing.Size(117, 99);
            this.trougao.TabIndex = 19;
            this.trougao.TabStop = false;
            this.trougao.Click += new System.EventHandler(this.trougao_Click);
            // 
            // blok
            // 
            this.blok.BackgroundImage = global::Projekat.Properties.Resources.blok1;
            this.blok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blok.Location = new System.Drawing.Point(741, 6);
            this.blok.Name = "blok";
            this.blok.Size = new System.Drawing.Size(117, 99);
            this.blok.TabIndex = 20;
            this.blok.TabStop = false;
            this.blok.Click += new System.EventHandler(this.blok_Click);
            // 
            // marker
            // 
            this.marker.BackgroundImage = global::Projekat.Properties.Resources.marker1;
            this.marker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.marker.Location = new System.Drawing.Point(618, 6);
            this.marker.Name = "marker";
            this.marker.Size = new System.Drawing.Size(117, 99);
            this.marker.TabIndex = 21;
            this.marker.TabStop = false;
            this.marker.Click += new System.EventHandler(this.marker_Click);
            // 
            // Gumica
            // 
            this.Gumica.BackColor = System.Drawing.Color.White;
            this.Gumica.BackgroundImage = global::Projekat.Properties.Resources.gumica;
            this.Gumica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gumica.Image = ((System.Drawing.Image)(resources.GetObject("Gumica.Image")));
            this.Gumica.Location = new System.Drawing.Point(3, 6);
            this.Gumica.Name = "Gumica";
            this.Gumica.Size = new System.Drawing.Size(117, 99);
            this.Gumica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gumica.TabIndex = 1;
            this.Gumica.TabStop = false;
            this.Gumica.Click += new System.EventHandler(this.Gumica_Click);
            // 
            // Hard
            // 
            this.Hard.Image = global::Projekat.Properties.Resources.pen;
            this.Hard.Location = new System.Drawing.Point(126, 6);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(117, 99);
            this.Hard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hard.TabIndex = 12;
            this.Hard.TabStop = false;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // Dot
            // 
            this.Dot.Image = global::Projekat.Properties.Resources.dot;
            this.Dot.Location = new System.Drawing.Point(495, 6);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(117, 99);
            this.Dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dot.TabIndex = 16;
            this.Dot.TabStop = false;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Sponge
            // 
            this.Sponge.Image = global::Projekat.Properties.Resources.sponge;
            this.Sponge.Location = new System.Drawing.Point(372, 6);
            this.Sponge.Name = "Sponge";
            this.Sponge.Size = new System.Drawing.Size(117, 99);
            this.Sponge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sponge.TabIndex = 17;
            this.Sponge.TabStop = false;
            this.Sponge.Click += new System.EventHandler(this.Sponge_Click);
            // 
            // Soft
            // 
            this.Soft.Image = global::Projekat.Properties.Resources.Untitled_1;
            this.Soft.Location = new System.Drawing.Point(249, 6);
            this.Soft.Name = "Soft";
            this.Soft.Size = new System.Drawing.Size(117, 99);
            this.Soft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Soft.TabIndex = 13;
            this.Soft.TabStop = false;
            this.Soft.Click += new System.EventHandler(this.Soft_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekat.Properties.Resources.paint;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Kanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pentagon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trougao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gumica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sponge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Kanvas;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Gumica;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox Hard;
        private System.Windows.Forms.PictureBox Soft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Sponge;
        private System.Windows.Forms.PictureBox Dot;
        private System.Windows.Forms.PictureBox pentagon;
        private System.Windows.Forms.PictureBox trougao;
        private System.Windows.Forms.PictureBox blok;
        private System.Windows.Forms.PictureBox marker;
    }
}

