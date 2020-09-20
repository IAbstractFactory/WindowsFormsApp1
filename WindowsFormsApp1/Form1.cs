using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            g = this.CreateGraphics();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            var args = e as MouseEventArgs;
            
          
            g.DrawEllipse(new Pen(Color.Red, 3),args.X, args.Y, 10, 10);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Pen pen = new Pen(Color.Blue,3);
            g.DrawLine(pen, 10, this.Height - 100, this.Width - 40, this.Height - 100);// нижняя 
            g.DrawLine(pen, 10, 10, 10, this.Height - 100);//левая

            g.DrawLine(pen, 10, 10, this.Width - 40, 10);//верхняя
                       
            g.DrawLine(pen, this.Width - 40, 10, this.Width - 40, this.Height - 100);//правая
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
        
        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            g.DrawEllipse(new Pen(Color.Red, 3), e.X, e.Y, 10, 10);
        }
    }
}
