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
    
    public partial class FrmGraphics2D : Form
    {
        private List<Figura2D> figuras = new List<Figura2D>();
        private Figura2D figuraActual;
        private bool dibujando = false;

        public FrmGraphics2D()
        {
            InitializeComponent();
            SetupControls();
        }

        private void SetupControls()
        {
            // Configura selector de color
            btnColor.Click += (s, e) =>
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK && figuraActual != null)
                {
                    figuraActual.ColorFigura = colorDialog1.Color;
                    RefrescarPlano();
                }
            };

            // Evento click sobre panel de dibujo
            panelDibujo.MouseClick += PanelDibujo_MouseClick;
            panelDibujo.MouseDoubleClick += PanelDibujo_MouseDoubleClick;

            // Historial
            listBoxFiguras.SelectedIndexChanged += (s, e) =>
            {
                var idx = listBoxFiguras.SelectedIndex;
                if (idx >= 0) figuraActual = figuras[idx];
                MostrarCoordenadas();
            };

            // Botón limpiar
            btnLimpiar.Click += (s, e) =>
            {
                figuras.Clear(); figuraActual = null; listBoxFiguras.Items.Clear();
                RefrescarPlano();
            };

            // Botones de transformación
            btnTrasladar.Click += (s, e) => AplicarTraslacion();
            btnEscalar.Click += (s, e) => AplicarEscalacion();
            btnRotar.Click += (s, e) => AplicarRotacion();
            btnReflejar.Click += (s, e) => AplicarReflexion();
        }

        private void PanelDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            var coord = PantallaAPunto(e.Location);
            if (!dibujando)
            {
                figuraActual = new Figura2D();
                figuraActual.ColorFigura = Color.Black;
                figuras.Add(figuraActual);
                listBoxFiguras.Items.Add(figuraActual.Nombre);
                dibujando = true;
            }
            figuraActual.AñadirPunto(coord);
            RefrescarPlano();
            MostrarCoordenadas();
        }

        private void PanelDibujo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dibujando && figuraActual != null)
            {
                figuraActual.Finalizar();
                dibujando = false;
                RefrescarPlano();
            }
        }

        private void RefrescarPlano()
        {
            panelDibujo.Invalidate();
        }

        private PointF PantallaAPunto(Point p)
        {
            // Convierte coordenadas de pixel a cartelescas (origen al centro)
            float cx = panelDibujo.Width / 2f;
            float cy = panelDibujo.Height / 2f;
            return new PointF(p.X - cx, cy - p.Y);
        }

        private Point PuntoAPantalla(PointF p)
        {
            float cx = panelDibujo.Width / 2f;
            float cy = panelDibujo.Height / 2f;
            return new Point((int)(p.X + cx), (int)(cy - p.Y));
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // Dibuja ejes
            var penAxis = new Pen(Color.Gray, 1);
            g.DrawLine(penAxis, 0, panelDibujo.Height / 2, panelDibujo.Width, panelDibujo.Height / 2);
            g.DrawLine(penAxis, panelDibujo.Width / 2, 0, panelDibujo.Width / 2, panelDibujo.Height);

            // Dibuja figuras
            foreach (var fig in figuras)
            {
                if (fig.PuntosTransformados.Count > 1)
                {
                    var pts = fig.PuntosTransformados.Select(PuntoAPantalla).ToArray();
                    using (var pen = new Pen(fig.ColorFigura, 2))
                        g.DrawLines(pen, pts);
                }
            }
        }

        private void MostrarCoordenadas()
        {
            dataGridViewCoord.Rows.Clear();
            if (figuraActual == null) return;

            for (int i = 0; i < figuraActual.PuntosOriginales.Count; i++)
            {
                var o = figuraActual.PuntosOriginales[i];
                var t = figuraActual.PuntosTransformados[i];
                dataGridViewCoord.Rows.Add(i, o.X, o.Y, t.X, t.Y);
            }
        }

        // Métodos de transformación
        private void AplicarTraslacion()
        {
            if (figuraActual == null) return;
            float dx = (float)numericDx.Value;
            float dy = (float)numericDy.Value;
            float[,] m = { { 1, 0, 0 }, { 0, 1, 0 }, { dx, dy, 1 } }; // Matriz 3x3
            figuraActual.AplicarMatriz(m);
            RefrescarPlano();
            MostrarCoordenadas();
        }

        private void AplicarEscalacion()
        {
            if (figuraActual == null) return;
            float sx = (float)numericSx.Value;
            float sy = (float)numericSy.Value;
            PointF fix = new PointF(0, 0);
            if (checkBoxFijo.Checked)
                fix = new PointF((float)numericFx.Value, (float)numericFy.Value);
            // Trasladar al origen, escalar, trasladar de vuelta
            float[,] t1 = { { 1, 0, 0 }, { 0, 1, 0 }, { -fix.X, -fix.Y, 1 } };
            float[,] s = { { sx, 0, 0 }, { 0, sy, 0 }, { 0, 0, 1 } };
            float[,] t2 = { { 1, 0, 0 }, { 0, 1, 0 }, { fix.X, fix.Y, 1 } };
            figuraActual.AplicarMatriz(Multiplicar(t1, Multiplicar(s, t2)));
            RefrescarPlano(); MostrarCoordenadas();
        }

        private void AplicarRotacion()
        {
            if (figuraActual == null) return;
            float ang = (float)numericAng.Value * (float)Math.PI / 180f;
            PointF fix = new PointF(0, 0);
            if (checkBoxFijo.Checked)
                fix = new PointF((float)numericFx.Value, (float)numericFy.Value);
            float cos = (float)Math.Cos(ang), sin = (float)Math.Sin(ang);
            float[,] t1 = { { 1, 0, 0 }, { 0, 1, 0 }, { -fix.X, -fix.Y, 1 } };
            float[,] r = { { cos, -sin, 0 }, { sin, cos, 0 }, { 0, 0, 1 } };
            float[,] t2 = { { 1, 0, 0 }, { 0, 1, 0 }, { fix.X, fix.Y, 1 } };
            figuraActual.AplicarMatriz(Multiplicar(t1, Multiplicar(r, t2)));
            RefrescarPlano(); MostrarCoordenadas();
        }

        private void AplicarReflexion()
        {
            if (figuraActual == null) return;
            float[,] r;
            if (radioX.Checked) r = new float[,] { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };
            else if (radioY.Checked) r = new float[,] { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            else r = new float[,] { { -1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };
            figuraActual.AplicarMatriz(r);
            RefrescarPlano(); MostrarCoordenadas();
        }

        private float[,] Multiplicar(float[,] A, float[,] B)
        {
            float[,] R = new float[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                        R[i, j] += A[i, k] * B[k, j];
            return R;
        }
    }
}
