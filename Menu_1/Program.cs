using System;
using System.Diagnostics;
using System.Security;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.SetCursorPosition(10, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menú:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Menú 1. Programas de introducción.");
            Console.WriteLine("2. Menú 2. Programas de localización.");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Menu1();
                    break;
                case "2":
                    Menu2();
                    break;
                case "3":
                    return;
                default:
                    Console.Write("Opción no válida. Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private static void Menu1()
    {
        while (true)
        {
            Console.Clear();
            Console.SetCursorPosition(10, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menú 1. Programas de introducción:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Generar rectángulos con asteriscos.");
            Console.WriteLine("2. Generar barras con asteriscos.");
            Console.WriteLine("3. Generar espiral con asteriscos.");
            Console.WriteLine("4. Menú anterior");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    GenerarRectangulos();
                    break;
                case "2":
                    GenerarBarras();
                    break;
                case "3":
                    GenerarEspiral();
                    break;
                case "4":
                    return;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("Opción no válida. Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private static void Menu2()
    {
        while (true)
        {
            Console.Clear();
            Console.SetCursorPosition(10, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menú 2. Programas de localización:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Mostrar la tabla de senos del 0 al 90.");
            Console.WriteLine("2. Mostrar la tabla de cosenos del 0 al 90.");
            Console.WriteLine("3. Calcular hipotenusa y ángulos de un triángulo rectángulo.");
            Console.WriteLine("4. Calcular pendiente, ángulo de inclinación y punto medio de una recta.");
            Console.WriteLine("5. Calcular trayectoria de un proyectil.");
            Console.WriteLine("6. Menú anterior");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    MostrarTablaSenos();
                    break;
                case "2":
                    MostrarTablaCosenos();
                    break;
                case "3":
                    CalcularHipotenusa();
                    break;
                case "4":
                    CalcularPendiente();
                    break;
                case "5":
                    CalcularTrayectoriaProyectil();
                    break;
                case "6":
                    return;
                case "7":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("Opción no válida. Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private static void GenerarRectangulos()
    {
        Console.Clear();
        Console.WriteLine("Generar rectángulos con asteriscos.");
        // Código específico para generar rectángulos con asteriscos
        Console.WindowWidth = 85;
        Console.WindowHeight = 30;
        ConsoleColor[] colores =
        {
            ConsoleColor.Cyan,
            ConsoleColor.Blue,
            ConsoleColor.Red,
            ConsoleColor.Yellow
        };

        // Definimos el área del primer rectángulo
        int left = 18;               // columna izquierda
        int top = 5;                // fila superior
        int right = 62;             // columna derecha (45 asteriscos)
        int bottom = 21;            // fila inferior (17 asteriscos)
        int delay = 1;
        
        for (int i = 0; i < colores.Length; i++)
        {
            Console.ForegroundColor = colores[i];

            // DIBUJAR LÍNEA SUPERIOR (top) del rectángulo
            for (int col = left; col <= right; col++)
            {
                Console.SetCursorPosition(col, top);
                Console.Write("*");
                Thread.Sleep(delay);
            }

            // DIBUJAR LÍNEA INFERIOR (bottom)
            for (int col = left; col <= right; col++)
            {
                Console.SetCursorPosition(col, bottom);
                Console.Write("*");
                Thread.Sleep(delay);
            }

            // DIBUJAR LÍNEA IZQUIERDA
            for (int row = top; row <= bottom; row++)
            {
                Console.SetCursorPosition(left, row);
                Console.Write("*");
                Thread.Sleep(delay + delay);
            }

            // DIBUJAR LÍNEA DERECHA
            for (int row = top; row <= bottom; row++)
            {
                Console.SetCursorPosition(right, row);
                Console.Write("*");
                Thread.Sleep(delay + delay);
            }

            // Luego de dibujar un rectángulo, reduce el área para el siguiente
            left += 5;
            top += 2;
            right -= 5;
            bottom -= 2;
        }

        // DIBUJAR LOS ÚLTIMOS 3 ASTERISCOS
        Console.SetCursorPosition(left, top);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("* * *");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(11, 27);
        Console.Write("Finalizado. Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    private static void GenerarBarras()
    {
        Console.Clear();
        Console.WriteLine("Generar barras con asteriscos.");
        // Código específico para generar barras con asteriscos
        Console.WindowWidth = 85;
        Console.WindowHeight = 30;
        int x = 1, y = 19, countR = 0, sleep = 10;
        Console.SetCursorPosition(x, y);
        WriteCyan();
        for (int i = 7 - 1; i >= 0; i--)
        {
            MoveRight();
            if (countR >= 13)
            {
                Console.Write("*");
                break;
            }
            MoveUp();
            MoveRight();
            MoveDown();
        }
        void MoveRight(int steps = 5)
        {
            countR++;
            for (int i = 0; i < steps; i++)
            {
                WriteCyan();
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            }
        }
        void MoveUp(int steps = 13)
        {
            WriteBlue();
            for (int i = 0; i < steps; i++)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                WriteBlue();
            }
        }
        void MoveDown(int steps = 13)
        {
            WriteBlue();
            for (int i = 0; i < steps; i++)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop + 1);
                WriteBlue();
            }
        }
        void WriteCyan()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("*");
            Thread.Sleep(sleep);
        }
        void WriteBlue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("*");
            Thread.Sleep(sleep);
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(11, 21);
        Console.Write("Finalizado. Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    private static void GenerarEspiral()
    {
        Console.Clear();
        Console.WriteLine("Generar espiral con asteriscos.");
        // Código específico para generar espiral con asteriscos
        Console.WindowWidth = 85;
        Console.WindowHeight = 30;
        int x = Console.WindowWidth / 2, y = Console.WindowHeight / 2, l = 4, u = 2, r = 9, d = 4, colorIndex = 0, sleep = 10;
        Console.SetCursorPosition(x, y);
        ConsoleColor[] colores = { ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.Cyan };
        Console.ForegroundColor = colores[colorIndex];
        Console.Write("*");
        colorIndex = (colorIndex + 1) % colores.Length;
        for (int i = 0; i < 6; i++)
        {
            MoveLeft(l);
            MoveUp(u);
            if (u >= 21)
                break;
            MoveRight(r);
            MoveDown(d);
            l += 10;
            u += 4;
            r += 10;
            d += 4;
            if (u >= 22)
                u -= 1;
        }
        void MoveLeft(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                Console.ForegroundColor = colores[colorIndex];
                Console.Write("*");
                colorIndex = (colorIndex + 1) % colores.Length;
                Thread.Sleep(sleep);
            }
        }
        void MoveUp(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                Console.ForegroundColor = colores[colorIndex];
                Console.Write("*");
                colorIndex = (colorIndex + 1) % colores.Length;
                Thread.Sleep(sleep);
            }
        }
        void MoveRight(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                Console.ForegroundColor = colores[colorIndex];
                Console.Write("*");
                colorIndex = (colorIndex + 1) % colores.Length;
                Thread.Sleep(sleep);
            }
        }
        void MoveDown(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop + 1);
                Console.ForegroundColor = colores[colorIndex];
                Console.Write("*");
                colorIndex = (colorIndex + 1) % colores.Length;
                Thread.Sleep(sleep);
            }
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(11, 28);
        Console.Write("Finalizado. Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    private static void MostrarTablaSenos()
    {
        Console.Clear();
        Console.WriteLine("Mostrar la tabla de senos del 0 al 90.");
        // Lógica para mostrar la tabla de senos

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(11, 28);
        Console.Write("Finalizado. Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    private static void MostrarTablaCosenos()
    {
        Console.Clear();
        Console.WriteLine("Mostrar la tabla de cosenos del 0 al 90.");
        // Lógica para mostrar la tabla de cosenos

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(11, 28);
        Console.Write("Finalizado. Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    private static void CalcularHipotenusa()
    {
        Console.Clear();
        Console.WriteLine("Calcular hipotenusa y ángulos de un triángulo rectángulo.");
        // Lógica para calcular hipotenusa y ángulos

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(11, 28);
        Console.Write("Finalizado. Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    private static void CalcularPendiente()
    {
        Console.Clear();
        Console.WriteLine("Calcular pendiente, ángulo de inclinación y punto medio de una recta.");
        // Lógica para calcular pendiente, ángulo de inclinación y punto medio

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(11, 28);
        Console.Write("Finalizado. Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    private static void CalcularTrayectoriaProyectil()
    {
        Console.Clear();
        Console.WriteLine("Calcular trayectoria de un proyectil.");
        // Lógica para calcular trayectoria de un proyectil

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(11, 28);
        Console.Write("Finalizado. Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }
}