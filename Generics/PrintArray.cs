using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintArray
    {
        public static void ToPrint(int[] inputtArray)
        {
            Console.WriteLine("Int Array : ");
            foreach(var intData in inputtArray)
            {
                Console.Write(intData+" ");
            }
        }
        public static void ToPrint(double[] inputtArray)
        {
            Console.WriteLine("\nDouble Array : ");
            foreach (var doubleData in inputtArray)
            {
                Console.Write(doubleData+" ");
            }
        }
        public static void ToPrint(char[] inputtArray)
        {
            Console.WriteLine("\nChar Array : ");
            foreach (var charData in inputtArray)
            {
                Console.Write(charData+" ");
            }
        }
    }
}
