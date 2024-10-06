using static System.Runtime.InteropServices.JavaScript.JSType;

namespace copying_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10]{7, 4, 3, 5, 3, 2, 2, 9, 5, 12};

            Console.WriteLine("Элементы массива Numbers: ");
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }

            int[] Numbers2 = new int[10];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers2[i] = Numbers[i];
            }

            Console.WriteLine("Элементы массива Numbers2: ");

            foreach (int i in Numbers2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
