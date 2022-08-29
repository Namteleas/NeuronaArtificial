using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuronaArtificial
{
    public partial class Form1 : Form
    {
        Bitmap bmpFondo;
        Bitmap bmpAnimacion;
        Pen planoPen;
        Brush ceroBrush;
        Brush unoBrush;
        Brush baseBrush;
        List<PointF> entradas;
        public Form1()
        {
            InitializeComponent(); 
            bmpFondo = new Bitmap(1000, 1000);
            bmpAnimacion = new Bitmap(1000, 1000);
            entradas = new List<PointF>();
            pictureBoxCanvas.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCanvas.BackgroundImage = bmpFondo;
            pictureBoxCanvas.Image = bmpAnimacion;
            planoPen = new Pen(Color.Black, 4);
            ceroBrush = new SolidBrush(Color.Red); //False
            unoBrush = new SolidBrush(Color.Blue);  //True
            baseBrush = new SolidBrush(Color.Black);
            listBoxEntradas.DataSource = null;
            dibujarCanvas();
        }

        void dibujarCanvas()
        {
            Graphics g = Graphics.FromImage(bmpFondo);
            g.Clear(Color.White);

            for (int i = 1; i < 10; i++)
            {
                g.DrawLine(planoPen, i * 100, 0, i * 100, 999);
                g.DrawLine(planoPen, 0, i * 100, 999, i * 100);
            }
            pictureBoxCanvas.Refresh();
        }

        private void pictureBoxCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(bmpFondo);

            float x, y;

            x = (e.X * 2f - 500f) / 100f;
            y = (e.Y * 2f - 500f) / 100f;

            entradas.Add(new PointF(x, y));
            g.FillEllipse(baseBrush, e.X * 2 - 10, e.Y * 2 - 10, 20, 20);

            listBoxEntradas.DataSource = null;
            listBoxEntradas.DataSource = entradas;
            pictureBoxCanvas.Refresh();
        }

        void dibujarPlano()
        {
            float y1, y2, x1, x2;
            float bias, w1, w2;

            bias = (float)numericUpDownBias.Value;
            w1 = (float)numericUpDownW1.Value;
            w2 = (float)numericUpDownW2.Value;

            Graphics g = Graphics.FromImage(bmpAnimacion);

            g.Clear(Color.Transparent);

            y1 = (bias - w1 * -5) / w2;
            y2 = (bias - w1 * 5) / w2;

            x1 = (bias - w2 * -5) / w1;
            x2 = (bias - w2 * 5) / w1;

            if (Math.Abs(y1) <= 5 && Math.Abs(y2) <= 5)
                g.DrawLine(planoPen, -5 * 100 + 500, y1 * 100 + 500, 5 * 100 + 500, y2 * 100 + 500);
            else
                g.DrawLine(planoPen, x1 * 100 + 500, -5 * 100 + 500, x2 * 100 + 500, 5 * 100 + 500);

            pictureBoxCanvas.Refresh();
        }

        private void buttonAnalizar_Click(object sender, EventArgs e)
        {
            dibujarPlano();
            dibujarCirculos();
        }

        private void dibujarCirculos()
        {
            Graphics g = Graphics.FromImage(bmpFondo);
            float bias, w1, w2;

            bias = (float)numericUpDownBias.Value;
            w1 = (float)numericUpDownW1.Value;
            w2 = (float)numericUpDownW2.Value;

            foreach (PointF ent in entradas)
            {
                if (ent.X * w1 + ent.Y * w2 - bias >= 0)
                    g.FillEllipse(unoBrush, ent.X * 100 + 490, ent.Y * 100 + 490, 20, 20);
                else
                    g.FillEllipse(ceroBrush, ent.X * 100 + 490, ent.Y * 100 + 490, 20, 20);
            }

            pictureBoxCanvas.Refresh();
        }
    }
}
