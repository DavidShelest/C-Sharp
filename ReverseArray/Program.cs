
namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива!");
            int num;
            bool result = Int32.TryParse(Console.ReadLine(), out num);

            if (result)
            {
                int[] numbers = GenerateNumbers(num);
                Reverse(numbers);
                PrintNumbers(numbers);
            }
            else
            {
                Console.WriteLine("Введены некорректные данные!");
            }
            
        }

        static int[] GenerateNumbers(int arraySize)
        {
            var rand = new Random();

            int[] numbers = new int[arraySize];
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i] = rand.Next(20);
            }

            Console.WriteLine($"Сгенерированный массив: {System.String.Join(", ", numbers)}");

            return numbers;
        }

        static void Reverse(int[] numbers)
        {
            Array.Reverse(numbers);
        }

        static void PrintNumbers(int[] numbers) 
        {
            Console.WriteLine($"Перевернутый массив: {System.String.Join(", ", numbers)}");
        }
    }
}
