namespace FrmFractal01
{
    public partial class FrmFractal01 : Form
    {
        public FrmFractal01()
        {
            InitializeComponent();
        }

        private void FrmFractal01_Load(object sender, EventArgs e)
        {
            MandelbrotSet();
        }

        private void MandelbrotSet()
        {
            int width = pictureBoxMandelbrot.Width;
            int height = pictureBoxMandelbrot.Height;

            Bitmap bmp = new Bitmap(width, height);

            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    double c_re = (col - width / 2) * 4.0 / width;
                    double c_im = (row - height / 2) * 4.0 / width;

                    int iterations = 0;
                    double x = 0, y = 0;

                    while (iterations < 1000 && ((x * x) + (y * y)) <= 4)
                    {
                        double x_temp = (x * x) - (y * y) + c_re;
                        y = 2 * x * y + c_im;
                        x = x_temp;
                        iterations++;
                    }

                    if (iterations < 1000)
                    {
                        bmp.SetPixel(col, row, Color.FromArgb((col*iterations) % 85, iterations % 170, (row * iterations) % 255));
                        //bmp.SetPixel(col, row, Color.White);
                    }
                    else
                    {
                        bmp.SetPixel(col, row, Color.FromArgb(( iterations) % 85, iterations % 170, ( iterations) % 255));
                        //bmp.SetPixel(col, row, Color.Black);
                    }
                }
            }
            pictureBoxMandelbrot.Image = bmp;
        }
    }
}
