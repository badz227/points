using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingViaPoints
{
    public partial class Form1 : Form
    {
        Graphics g; Pen p; Pen p1; Point pt;
        int k = 0; Point[] points = new Point[200]; int[] pY = new int[200]; int[] pX = new int[200]; 
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            p = new Pen(Color.Black, 3);
            p1 = new Pen(Color.Red, 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            pt = this.PointToClient(Cursor.Position);
           
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
            if (k == 0)
            {
                
                pX[0] = pt.X;
                pY[0] = pt.Y;
                pX[1] = pt.X;
                pY[1] = pt.Y;
            }

            g.DrawEllipse(p1, pt.X - 10, pt.Y - 10, 20, 20);
            
            ++k;
            pX[++k] = pt.X;
            pY[k] = pt.Y;
            if (pX.Length == 2) {
            g.DrawLine(p, pt.X, pt.Y, pt.X, pt.Y); 
            }
            else {
            g.DrawLine(p, pX[--k], pY[k], pt.X, pt.Y);
            }
            
        }
    }
}
