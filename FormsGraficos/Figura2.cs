using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsGraficos
{
    public class Figura2D
    {
        public List<PointF> PuntosOriginales { get; private set; } = new List<PointF>();
        public List<PointF> PuntosTransformados { get; private set; }
        public Color ColorFigura { get; set; } = Color.Black;
        public string Nombre => "Figura " + Id;
        private static int _contador = 0;
        public int Id { get; }

        public Figura2D()
        {
            Id = ++_contador;
            PuntosTransformados = new List<PointF>(PuntosOriginales);
        }

        public void AñadirPunto(PointF p)
        {
            PuntosOriginales.Add(p);
            ResetTransformadas();
        }

        public void Finalizar()
        {
            // Cierra polilínea
            if (PuntosOriginales.Count > 1)
                PuntosOriginales.Add(PuntosOriginales[0]);
            ResetTransformadas();
        }

        public void ResetTransformadas()
        {
            PuntosTransformados = new List<PointF>(PuntosOriginales);
        }

        public void AplicarMatriz(float[,] m)
        {
            PuntosTransformados = PuntosTransformados.Select(p =>
            {
                float x = p.X * m[0, 0] + p.Y * m[1, 0] + m[2, 0];
                float y = p.X * m[0, 1] + p.Y * m[1, 1] + m[2, 1];
                return new PointF(x, y);
            }).ToList();
        }
    }
}
