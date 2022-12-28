namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics");
            //Int Array
            int[] intArray = { 42, 38, 76 };
            PrintArray.ToPrint(intArray);
            //Double array
            double[] doubleArray = { 32.4, 23.6, 12.9 };
            PrintArray.ToPrint(doubleArray);
            //Char Array
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            PrintArray.ToPrint(charArray);
        }
    }
}