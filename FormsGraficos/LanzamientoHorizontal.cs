using System;
using System.Drawing;
using System.Windows.Forms;
namespace FormsGraficos
{
    public partial class LanzamientoHorizontal : Form
    {
        private const int CircleDiameter = 30;
        private const int XInicial = 0;
        private const double GravedadEscalada = 9.8 * 5; // Gravedad con factor de escala
        private Graphics graphics;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        // Parámetros de la simulación
        private double alturaInicial = 450;
        private double velocidadInicial = 77.7;
        private double tiempoActual = 0;
        // Posición actual
        private int x, y;
        //Pausar / Reanudar ???
        private bool estaPausado = false;
        public LanzamientoHorizontal()
        {
            InitializeComponent();
            timer.Interval = 30;
            timer.Tick += timer_Tick;
            ResetAnimation();
            // Iniciar animación automáticamente
            //timer.Start();
        }
        private void ResetAnimation()
        {
            tiempoActual = 0;
            x = XInicial;
            y = ptbDibujo.Height - (int)alturaInicial - CircleDiameter;
            ptbDibujo.Invalidate();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            // Incrementar tiempo (ms a segundos)
            tiempoActual += timer.Interval / 1000.0;
            // Actualizar posición horizontal
            x = XInicial + (int)(velocidadInicial * tiempoActual);
            // Calcular altura actual y convertir a coordenadas de pantalla
            int alturaActual = (int)(alturaInicial - 0.5 * GravedadEscalada * tiempoActual * tiempoActual);
            y = ptbDibujo.Height - alturaActual - CircleDiameter;
            // Verificar si llegó al piso
            if (y >= ptbDibujo.Height - CircleDiameter)
            {
                timer.Stop();
                y = ptbDibujo.Height - CircleDiameter;
            }
            ptbDibujo.Invalidate();
        }
        private void ptbDibujo_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.DrawEllipse(new Pen(Color.Red, 3f), x, y, CircleDiameter, CircleDiameter);
            DibujarTrayectoria();
            MostrarInformacion();
            DibujarPared_Suelo();
        }

        private void DibujarPared_Suelo()
        {
            graphics.DrawLine(new Pen(Color.DarkGreen, 5f), 0, 0, 0, ptbDibujo.Height);
            graphics.DrawLine(new Pen(Color.DarkBlue, 5f), 0, ptbDibujo.Height - 1, ptbDibujo.Width, ptbDibujo.Height - 1);

            using var marcadorFont = new Font("Arial", 8);
            using var marcadorBrush = new SolidBrush(Color.Black);
            using var marcadorPen = new Pen(Color.Black, 1f);

            for (int y = 0; y <= ptbDibujo.Height; y += 10)
            {
                graphics.DrawLine(marcadorPen, 0, y, 5, y);
                if (y % 50 == 0)
                    graphics.DrawString((ptbDibujo.Height - y).ToString(), marcadorFont, marcadorBrush, 6, y - 6);
            }

            for (int x = 0; x <= ptbDibujo.Width; x += 10)
            {
                graphics.DrawLine(marcadorPen, x, ptbDibujo.Height - 1, x, ptbDibujo.Height - 6);
                if (x % 50 == 0)
                    graphics.DrawString(x.ToString(), marcadorFont, marcadorBrush, x - 10, ptbDibujo.Height - 20);
            }
        }

        private void DibujarTrayectoria()
        {
            const int steps = 1000;
            Point[] puntosTrayectoria = new Point[steps];
            for (int i = 0; i < steps; i++)
            {
                double t = (tiempoActual + 0.1) * (i + 1) / steps;
                int tx = XInicial + (int)(velocidadInicial * t);
                int alturaT = (int)(alturaInicial - 0.5 * GravedadEscalada * t * t);
                int ty = ptbDibujo.Height - alturaT - CircleDiameter;
                puntosTrayectoria[i] = new Point(tx, ty);
            }
            if (puntosTrayectoria.Length > 1)
                graphics.DrawLines(new Pen(Color.LightGray, 1f), puntosTrayectoria);
        }
        private void MostrarInformacion()
        {
            Font font = new Font("Arial", 10);
            Brush textBrush = new SolidBrush(Color.Black);
            graphics.DrawString($"Altura inicial: {alturaInicial}px", font, textBrush, 10, 10);
            graphics.DrawString($"Velocidad inicial: {velocidadInicial} px/s", font, textBrush, 10, 30);
            graphics.DrawString($"Altura: {ptbDibujo.Height - y - CircleDiameter} px", font, textBrush, 180, 10);
            graphics.DrawString($"Tiempo y Coords: {tiempoActual:F2}s, (X:{x}, Y:{ptbDibujo.Height - y - CircleDiameter})", font, textBrush, 290, 10);
            graphics.DrawString($"Distancia recorrida: {x - XInicial}px", font, textBrush, 290, 30);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnPausarReanudar.Enabled = true;
            if (!timer.Enabled)
            {
                timer.Start();
                btnIniciar.Enabled = false;
            }
        }

        private void btnPausarReanudar_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                estaPausado = true;
                btnPausarReanudar.Text = "Reanudar";
            }
            else if (estaPausado)
            {
                timer.Start();
                estaPausado = false;
                btnPausarReanudar.Text = "Pausar";
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timer.Stop();
            estaPausado = false;
            btnPausarReanudar.Enabled = false;
            btnPausarReanudar.Text = "Pausar";
            btnIniciar.Enabled = true;
            ResetAnimation();
            ptbDibujo.Invalidate();
        }
    }
}