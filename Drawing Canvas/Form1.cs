using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Canvas
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;

        public Form1()
        {
            InitializeComponent();
            g = panelCanvas.CreateGraphics();
        }
        
        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true;
            }
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                g.DrawLine(Pens.Black, startPoint, endPoint);
                startPoint = endPoint;
            }
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
    }

}
