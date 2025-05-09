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

        // Factor de escala para hacer el plano cartesiano más pequeño (aproximadamente 13 veces)
        private float factorEscala = 13.0f;

        // Espaciado entre unidades en el plano
        private int unidadEspaciado = 2; // Cada 10 unidades

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

            // Configurar encabezados de columnas del DataGridView
            dataGridViewCoord.Columns[0].HeaderText = "Puntos";
            dataGridViewCoord.Columns[1].HeaderText = "X";
            dataGridViewCoord.Columns[2].HeaderText = "Y";
            dataGridViewCoord.Columns[3].HeaderText = "New X";
            dataGridViewCoord.Columns[4].HeaderText = "New Y";

            // Evento click sobre panel de dibujo
            panelDibujo.MouseClick += PanelDibujo_MouseClick;
            panelDibujo.MouseDoubleClick += PanelDibujo_MouseDoubleClick;
            // Evento para mostrar coordenadas del mouse
            panelDibujo.MouseMove += panelDibujo_MouseMove;

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

            // Habilitar/deshabilitar los campos de punto fijo
            checkBoxFijo.CheckedChanged += (s, e) =>
            {
                numericFx.Enabled = checkBoxFijo.Checked;
                numericFy.Enabled = checkBoxFijo.Checked;
            };
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
                MostrarCoordenadas();
            }
        }

        private void RefrescarPlano()
        {
            panelDibujo.Invalidate();
        }

        private PointF PantallaAPunto(Point p)
        {
            // Convierte coordenadas de pixel a cartesianas (origen al centro)
            float cx = panelDibujo.Width / 2f;
            float cy = panelDibujo.Height / 2f;

            // Aplicar el factor de escala al convertir de pantalla a coordenadas
            float x = (p.X - cx) / factorEscala;
            float y = (cy - p.Y) / factorEscala;

            // Aplicar redondeo para valores más limpios
            return new PointF((float)Math.Round(x, 1), (float)Math.Round(y, 1));
        }

        private Point PuntoAPantalla(PointF p)
        {
            float cx = panelDibujo.Width / 2f;
            float cy = panelDibujo.Height / 2f;

            // Aplicar el factor de escala al convertir coordenadas a pantalla
            return new Point(
                (int)(p.X * factorEscala + cx),
                (int)(cy - p.Y * factorEscala)
            );
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Centro del panel
            float cx = panelDibujo.Width / 2f;
            float cy = panelDibujo.Height / 2f;

            // Dibuja ejes principales
            var penAxis = new Pen(Color.Gray, 1);
            g.DrawLine(penAxis, 0, (int)cy, panelDibujo.Width, (int)cy); // Eje X
            g.DrawLine(penAxis, (int)cx, 0, (int)cx, panelDibujo.Height); // Eje Y

            // Dibujar unidades en el plano
            DibujarUnidades(g, cx, cy);

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

        private void DibujarUnidades(Graphics g, float cx, float cy)
        {
            // Calcular rango visible en unidades
            int rangoXMax = (int)Math.Ceiling((panelDibujo.Width / 2f) / factorEscala);
            int rangoYMax = (int)Math.Ceiling((panelDibujo.Height / 2f) / factorEscala);

            // Lapices para dibujar
            var penTick = new Pen(Color.Gray, 1);
            var brushText = new SolidBrush(Color.Black);
            var fontAxis = new Font("Arial", 8);

            // Dibujar marcas en eje X
            for (int x = -rangoXMax; x <= rangoXMax; x += unidadEspaciado)
            {
                if (x == 0) continue; // Omitir el origen

                Point p = PuntoAPantalla(new PointF(x, 0));
                g.DrawLine(penTick, p.X, p.Y - 5, p.X, p.Y + 5);

                // Etiqueta numérica (evitar el 0)
                string texto = x.ToString();
                SizeF tamTexto = g.MeasureString(texto, fontAxis);
                g.DrawString(texto, fontAxis, brushText,
                    p.X - tamTexto.Width / 2, p.Y + 5);
            }

            // Dibujar marcas en eje Y
            for (int y = -rangoYMax; y <= rangoYMax; y += unidadEspaciado)
            {
                if (y == 0) continue; // Omitir el origen

                Point p = PuntoAPantalla(new PointF(0, y));
                g.DrawLine(penTick, p.X - 5, p.Y, p.X + 5, p.Y);

                // Etiqueta numérica (evitar el 0)
                string texto = y.ToString();
                SizeF tamTexto = g.MeasureString(texto, fontAxis);
                g.DrawString(texto, fontAxis, brushText,
                    p.X - tamTexto.Width - 5, p.Y - tamTexto.Height / 2);
            }

            // Dibujar el origen (0,0)
            g.DrawString("0", fontAxis, brushText, cx + 5, cy + 5);
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

            // Crear nueva figura basada en la actual
            Figura2D nuevaFigura = figuraActual.CrearCopia();
            figuras.Add(nuevaFigura);
            listBoxFiguras.Items.Add(nuevaFigura.Nombre);

            // Hacer que la nueva figura sea la actual
            figuraActual = nuevaFigura;
            listBoxFiguras.SelectedIndex = listBoxFiguras.Items.Count - 1;

            // Aplicar transformación
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

            // Crear nueva figura basada en la actual
            Figura2D nuevaFigura = figuraActual.CrearCopia();
            figuras.Add(nuevaFigura);
            listBoxFiguras.Items.Add(nuevaFigura.Nombre);

            // Hacer que la nueva figura sea la actual
            figuraActual = nuevaFigura;
            listBoxFiguras.SelectedIndex = listBoxFiguras.Items.Count - 1;

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

            // Crear nueva figura basada en la actual
            Figura2D nuevaFigura = figuraActual.CrearCopia();
            figuras.Add(nuevaFigura);
            listBoxFiguras.Items.Add(nuevaFigura.Nombre);

            // Hacer que la nueva figura sea la actual
            figuraActual = nuevaFigura;
            listBoxFiguras.SelectedIndex = listBoxFiguras.Items.Count - 1;

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

            // Crear nueva figura basada en la actual
            Figura2D nuevaFigura = figuraActual.CrearCopia();
            figuras.Add(nuevaFigura);
            listBoxFiguras.Items.Add(nuevaFigura.Nombre);

            // Hacer que la nueva figura sea la actual
            figuraActual = nuevaFigura;
            listBoxFiguras.SelectedIndex = listBoxFiguras.Items.Count - 1;

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

        private void panelDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            PointF coordenadas = PantallaAPunto(e.Location);
            lblCoordenadas.Text = $"X:{coordenadas.X:F2} Y:{coordenadas.Y:F2}";
        }
    }
}