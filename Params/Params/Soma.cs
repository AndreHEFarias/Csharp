using System;
using System.Collections.Generic;
using System.Text;

namespace Params
{
    class Soma
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        
    }
    public class Calculator
    {
        public static void Triple(ref int x)
        {
            x *= 3;
        }
        public static void TripleOut(int origem, out int resultado) 
        {
            resultado = origem * 3;
        }
    }
}
