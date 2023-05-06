using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class Form2 : Form
    {
        Graphics Grafika;/*Napravi grafiku*/
        static string[] path = new string[8] { "hard.png", "soft.png", "sponge.png", "dot.png", "marker.png", "blok.png", "trougao.png", "pentagon.png" };/*Napravi niz za tipove brusha*/
        Bitmap bitmap = new Bitmap(path[0]);/*Napravi bitmap za brush*/
        bool menjanje_pozicije = false;/*gleda da li se dugme na misu drzi kliknuto*/
        Color currentColor = Color.Black;/*dodeljuje pocetnu boju brushu, i menja je kasnije*/
        bool paste = false;/*prati da li je ctrl i v kliknuto za pastovanje slike*/
        bool Polovka = true;/*prati da li se koristi gumica*/
        int current_brush = 0;/*gleda koji brush je selectovan*/

        public Form2()
        {
            InitializeComponent();
            KeyPreview = true;/*da bi mogao kod da registruje kad se ctr i v kliknu*/
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            /*Uzima duzinu i visinu kanvasa iz Class1*/
            Kanvas.Width = Class1.Kanvas_Width;
            Kanvas.Height = Class1.Kanvas_Height;

            if (Kanvas.Width > 612)
            {
                /*resizuje Kanvas sa valuje koji je uzeo iz class 1*/
                Size = new Size(Kanvas.Width+45, Kanvas.Height+200);
                panel1.Size = new Size(Kanvas.Width-430, panel1.Size.Height);
            }

            Grafika = Kanvas.CreateGraphics();/*Kreira grafiku*/
        }
        #region tipovi brushevi
        private void Gumica_Click(object sender, EventArgs e)
        {
            Polovka = false;/*stavlja da ne moze da se menja boja*/
            bitmap = new Bitmap("gumica.png");
            bitmap = ResizeBitmap(bitmap, trackBar1.Value, trackBar1.Value);/*menja velicinu gumice*/
        }
        
        private void Hard_Click(object sender, EventArgs e)
        {
            Polovka = true;/*stavlja da moze da se menja boja*/
            Default(0);/*koristi brush koji je selectovan u nizu*/
            ChangeColor(bitmap, currentColor);
            bitmap = ResizeBitmap(bitmap, trackBar1.Value, trackBar1.Value);
            current_brush = 0;

        }
        private void Soft_Click(object sender, EventArgs e)
        {
            Polovka = true;
            Default(1);
            ChangeColor(bitmap, currentColor);
            bitmap = ResizeBitmap(bitmap, trackBar1.Value, trackBar1.Value);
            current_brush = 1;

        }
        private void Sponge_Click(object sender, EventArgs e)
        {
            Polovka = true;
            Default(2);
            ChangeColor(bitmap, currentColor);
            bitmap = ResizeBitmap(bitmap, trackBar1.Value, trackBar1.Value);
            current_brush = 2;

        }
        private void Dot_Click(object sender, EventArgs e)
        {
            Polovka = true;
            Default(3);
            ChangeColor(bitmap, currentColor);
            bitmap = ResizeBitmap(bitmap, trackBar1.Value, trackBar1.Value);
            current_brush = 3;

        }
        private void marker_Click(object sender, EventArgs e)
        {
            Polovka = true;
            Default(4);
            ChangeColor(bitmap, currentColor);
            bitmap = ResizeBitmap(bitmap, trackBar1.Value, trackBar1.Value);
            current_brush = 4;
        }

        private void blok_Click(object sender, EventArgs e)
        {
            Polovka = true;
            Default(5);
            ChangeColor(bitmap, currentColor);
            bitmap = ResizeBitmap(bitmap, trackBar1.Value, trackBar1.Value);
            current_brush = 5;
        }

        private void trougao_Click(object sender, EventArgs e)
        {
            Polovka = true;
            Default(6);
            ChangeColor(bitmap, currentColor);
            bitmap = ResizeBitmap(bitmap, trackBar1.Value, trackBar1.Value);
            current_brush = 6;
        }

        private void pentagon_Click(object sender, EventArgs e)
        {
            Polovka = true;
            Default(7);
            ChangeColor(bitmap, currentColor);
            bitmap = ResizeBitmap(bitmap, trackBar1.Value, trackBar1.Value);
            current_brush = 7;
        }
        #endregion

        #region Size of the brush
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (Polovka == true)
            {
                /*uzme brush koji se sad koristi i da mu color koji je vec imao i onda ge resizuje*/
                Default(current_brush);
                ChangeColor(bitmap, currentColor);
            }
            /*menja velicinu, i value za textbox*/
            bitmap = ResizeBitmap(bitmap, trackBar1.Value, trackBar1.Value);
            textBox1.Text = Convert.ToString(trackBar1.Value);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) <= 100 && Convert.ToInt32(textBox1.Text) > 2)
            {
                if (Polovka == true)
                {
                    Default(current_brush);
                    ChangeColor(bitmap, currentColor);
                }
                bitmap = ResizeBitmap(bitmap, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
                trackBar1.Value = Convert.ToInt32(textBox1.Text);
            }
            else if (Convert.ToInt32(textBox1.Text) > 100)
            {
                textBox1.Text = "100";
                /*ako se upise value veci od 100 samo ce staviti size na 100*/
                if (Polovka == true)
                {
                    Default(current_brush);
                    ChangeColor(bitmap, currentColor);
                }
                /*menja velicinu, i value za trackbar*/
                bitmap = ResizeBitmap(bitmap, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
                trackBar1.Value = Convert.ToInt32(textBox1.Text);
            }
            else if (Convert.ToInt32(textBox1.Text) < 2)
            {
                textBox1.Text = "2";
                /*ako se upise value manji od 2 samo ce staviti size na 2*/
                if (Polovka == true)
                {
                    Default(current_brush);
                    ChangeColor(bitmap, currentColor);
                }
                bitmap = ResizeBitmap(bitmap, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
                trackBar1.Value = Convert.ToInt32(textBox1.Text);
            }
        }
        #endregion

        #region pozicija misa
        private void Kanvas_MouseDown(object sender, MouseEventArgs e)
        {
            menjanje_pozicije = true;
            Grafika.DrawImage(bitmap, Kanvas.PointToClient(new Point(Cursor.Position.X - (bitmap.Width / 2), Cursor.Position.Y - (bitmap.Height / 2))));/*koristi postion cursora*/
        }
        private void Kanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (menjanje_pozicije == true)/*gleda da li mis kliknut*/
            {
                Grafika.DrawImage(bitmap, Kanvas.PointToClient(new Point(Cursor.Position.X - (bitmap.Width / 2), Cursor.Position.Y - (bitmap.Height / 2))));
            }

        }

        private void Kanvas_MouseUp(object sender, MouseEventArgs e)/*kada dignem mis ne crta se*/
        {
            menjanje_pozicije = false;
        }
        #endregion

        /*Color dialog button*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
                if (Polovka == true)
                {
                    Default(current_brush);
                    ChangeColor(bitmap, button1.BackColor);
                    bitmap = ResizeBitmap(bitmap, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
                }
                currentColor = button1.BackColor;
            }
        }
        /*Save*/
        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Kanvas.Width, Kanvas.Height, PixelFormat.Format32bppArgb);
            Graphics Grap = Graphics.FromImage(bmp);
            Grap.CopyFromScreen(PointToScreen(Kanvas.Location).X, PointToScreen(Kanvas.Location).Y, 0, 0, Kanvas.Size, CopyPixelOperation.SourceCopy);
            saveFileDialog1.Filter = "JPEG|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        /*Wipe*/
        private void button3_Click(object sender, EventArgs e)
        {
            Kanvas.BackgroundImage = null;
            Kanvas.Refresh();
        }
        /*Open*/
        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Kanvas.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }
        /*Copy paste*/
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.V)
            {
                paste = true;
                this.InvokePaint(Kanvas, new PaintEventArgs(Kanvas.CreateGraphics(), Kanvas.DisplayRectangle));
                paste = false;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                Kanvas.BackgroundImage = null;
                Kanvas.Refresh();
            }
        }
        private void Kanvas_Paint(object sender, PaintEventArgs e)
        {
             if (paste == true)
             {
                if (Clipboard.GetImage() != null)
                {
                    int X = Cursor.Position.X;
                    int Y = Cursor.Position.Y;
                    int imgX = Clipboard.GetImage().Size.Width;
                    int imgY = Clipboard.GetImage().Size.Height;
                    e.Graphics.DrawImage(Clipboard.GetImage(), Kanvas.PointToClient(new Point(X - (imgX / 2), Y - (imgY / 2))));
                }
             }
        }

        /*selektovanje brusha*/
        public void Default(int number)
        {
            bitmap = new Bitmap(path[number]);
        }

        /*Promenjivanje velicine brusha*/
        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }
    /**/
        public void ChangeColor(Bitmap bitmap, Color color)
        {
            for (int Xcount = 0; Xcount < bitmap.Width; Xcount++)
            {
                for (int Ycount = 0; Ycount < bitmap.Height; Ycount++)
                {
                    Color pixelColor = bitmap.GetPixel(Xcount, Ycount);

                    byte alpha = pixelColor.A;
                    byte red = pixelColor.R;
                    byte green = pixelColor.G;
                    byte blue = pixelColor.B;

                    if (red == 0 && green == 0 && blue == 0)
                    {
                        red = color.R;
                        green = color.G;
                        blue = color.B;
                    }

                    bitmap.SetPixel(Xcount, Ycount, Color.FromArgb(alpha, red, green, blue));
                }
            }
        }
    }
}
