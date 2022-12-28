using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintArray
    {
        public static void ToPrint<T>(T [] inputArray)
        {
            foreach(T element in inputArray)
            {
                Console.Write(element+" "); //printing element in array
            }
            Console.WriteLine(" "); //new line
        }
    }
}
