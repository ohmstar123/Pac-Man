using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Pac_Man
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        
        {

        }
        
        private void Run_Button_Click(object sender, EventArgs e)
        {
            Run_Button.Visible = false;

            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            ///                 x   y   x    y
            g.DrawLine(drawPen, 0, 135, 250, 135);
            g.DrawLine(drawPen, 0, 45, 350, 45);

            /// change of direction in tunnel
            g.DrawLine(drawPen, 250, 130, 250, 300);
            g.DrawLine(drawPen, 350, 40, 350, 300);

            /// pac-man colors
            Pen PacPen = new Pen(Color.Red, 10);
            SolidBrush PacBrush = new SolidBrush(Color.Yellow);

            /// pac-man 
            g.FillPie(PacBrush, 0, 60, 60, 60, 55, 260);
            Thread.Sleep(500);
            
           
        }
    }
}
