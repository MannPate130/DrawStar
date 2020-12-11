using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class Form1 : Form
    {
        float colour;
        int x;
        int y;
        int s;
        int r;
        int b;
        int gr;
        int fontColor;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            Random randGen = new Random();
          

            int i = 1;
            while (i <= 1000)
            {
                s = randGen.Next(1, 151);
                x = randGen.Next(this.Width);
                y = randGen.Next(this.Height);
                r = randGen.Next(1, 254);
                b = randGen.Next(1, 254);
                gr = randGen.Next(1, 254);
                fontColor = randGen.Next(1, 151);

                Graphics g = this.CreateGraphics();
                Pen starPen = new Pen(Color.Red);
                starPen.Color = Color.FromArgb(r, b, gr, fontColor);
                Font drawFont = new Font("Arial", s, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                drawBrush.Color = Color.FromArgb(r, b, gr, fontColor);
                g.DrawString("*", drawFont, drawBrush, x, y);
                i++;
            }
        }
    }
}
