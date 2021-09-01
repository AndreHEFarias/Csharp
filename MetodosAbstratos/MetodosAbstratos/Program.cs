using System;
using System.Collections.Generic;
using MetodosAbstratos.Entities;
using MetodosAbstratos.Entities.Enums;
using System.Globalization;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listfig = new List<Shape>();
            Console.WriteLine("Entre com a quandtidade de figuras:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Shape #{i} data: ");
                Console.Write("Retangulo ou circulo[r/c]: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor[Black/Blue/Red]: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listfig.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listfig.Add(new Circle(radius, color));
                }
                

            
            }
            Console.WriteLine("\nShape Areas: ");
            foreach (Shape shape in listfig)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
