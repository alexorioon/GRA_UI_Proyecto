using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsGraficos
{
    public partial class LanzamientoHorizontal : Form
    {

        public LanzamientoHorizontal()
        {
            InitializeComponent();
        }
        Graphics graphics;
        int x = 50, y = 50, xDiameter = 50, yDiameter = 50;

        private void ptbDibujo_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            Pen pen = new Pen(Color.Blue, 3);

            graphics.DrawEllipse(pen, x, y, xDiameter, yDiameter);
        }
    }
}