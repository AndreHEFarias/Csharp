using System;
using System.Globalization;

namespace entradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);

            Console.WriteLine(nome + "\n" + sexo + "\n" + idade);

            /* int intT = int.Parse(Console.ReadLine());
             char charT = char.Parse(Console.ReadLine());
             double doub = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             Console.WriteLine(intT+"\n"+charT+"\n"+doub.ToString(CultureInfo.InvariantCulture));


              string frase1 = Console.ReadLine();
              string frase2 = Console.ReadLine();
              string frase3 = Console.ReadLine();

              Console.WriteLine(frase1);
              Console.WriteLine(frase2);
              Console.WriteLine(frase3); 
             string frase4 = Console.ReadLine();
             string[] vet = frase4.Split(' ');
             Console.WriteLine(vet[2]);

             string[] vet2 = Console.ReadLine().Split(' ');
             string ar1 = vet2[0];
             string ar2 = vet2[1];
             string ar3 = vet2[2];
             Console.WriteLine(ar1+ar2+ar3);*/
        }
    }
}
