using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Indicator.Text = "Mous Enter";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Indicator.Text = "Mous Move";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Indicator.Text = "Mous Leave";
        }

        bool mausClik;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Point point1 = new Point((int)numericUpDownPointAX.Value, (int)numericUpDownPointAY.Value);
            //Point point2 = new Point((int)numericUpDownPointBX.Value, (int)numericUpDownPointBY.Value);
            //Graphics graf = e.Graphics;
            //graf.DrawLine(Pens.Black, point1, point2);
        }

        private void numericUpDownPointAX_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        Point start;
        Point end;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mausClik = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mausClik = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mausClik)
            {
                if (start == null)
                {
                    start = new Point(e.X, e.Y);
                }

            }
        }
    }
}
