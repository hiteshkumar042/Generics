namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics");
            int[] intArray = { 42, 38, 76 };
            PrintArray.ToPrint(intArray);
            double[] doubleArray = { 32.4, 23.6, 12.9 };
            PrintArray.ToPrint(doubleArray);
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            PrintArray.ToPrint(charArray);
        }
    }
}