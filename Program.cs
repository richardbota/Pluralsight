using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight
{
    class Program
    {
        static int Sum(int[] values, selector)
        {
            int sum = 0;

            foreach (var value in selector.Pick(values))
            {
                sum += value;
            }
            return sum;
        }

        //static int Sum(int[] values, bool oddNumbersOnly)
        //{
        //    int sum = 0;

        //    for (int i = 0; i < values.Length; i++)
        //    {
        //        if (!oddNumbersOnly || values[i] % 2 != 0)
        //            sum += values[i];
        //    }
        //    return sum;
        //}

        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    internal class selector
    {
        public static int Pick(int[] values, bool oddNumbersOnly)
        {
            int sum = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (!oddNumbersOnly || values[i] % 2 != 0)
                    sum += values[i];
            }
            return sum;
        }
    }
}
