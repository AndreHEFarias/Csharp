using System;
using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x= new Triangulo();
            y= new Triangulo();

            Console.WriteLine("Digite as medidas do Triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas do Triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de x é:"+areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y é:" + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Área x é maior");
            }
            else
            {
                Console.WriteLine("Área Y é maior");
            }
        }
    }

