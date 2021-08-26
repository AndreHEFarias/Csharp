using System;

namespace nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            double a = x ?? 5;//?? Se o valor for nulo sera substituido pelo valor apos as ??
            double b = y ?? 5;

            Console.WriteLine(a+", "+b);

            /*double x = null; -> não pode ser usado null nessa variavel dese jeito;
            Nullable<double> x; -> usando com o nullable
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());//pega o valor e se for nulo pega o valor padrão(no exemplo é o 0)
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);//verifica se ha valor e retorna true ou false;
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);//verifica o valor e se for nulo retorna erro
            }else
            {
                Console.WriteLine("x é nulo");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y é nulo");
            }
            */
        }
    }
}
