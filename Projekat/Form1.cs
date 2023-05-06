using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();


            Class1.Kanvas_Height = Convert.ToInt32(Math.Round(numericUpDown1.Value));
            Class1.Kanvas_Width = Convert.ToInt32(Math.Round(numericUpDown2.Value));

            Hide();
            Form2.TopMost = true;
            Form2.ShowDialog();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
