using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs zxc)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics e = Graphics.FromImage(bmp);
            int h = Convert.ToInt32(textBox1.Text);
            int w = Convert.ToInt32(textBox2.Text);
            int q = Convert.ToInt32(textBox3.Text);
            PointF point1 = new PointF(275.0F, 137.5F);
            PointF point2 = new PointF(215.0F, 275.0F);
            PointF point3 = new PointF(275.0F, 412.5F);
            PointF point4 = new PointF(335.0F, 275.0F);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4
             };
            e.DrawPolygon(Pens.Black, curvePoints);
            pictureBox1.Image = bmp;
            int P = h + h + w + w;
            label4.Text = $"P = {P}";
            label5.Text = $"S = {w * q}";
        }

    }
}