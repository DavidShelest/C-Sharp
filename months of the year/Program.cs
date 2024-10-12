namespace months_of_the_year
{
    internal partial class Program
    {

        static void Main(string[] args)
        {

            int[] AllowedNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine("Введите число, соответствующее номеру месяца: ");
            int num;

            bool result = Int32.TryParse(Console.ReadLine(), out num);

            if (result && AllowedNumbers.Contains(num))
            {
                Console.WriteLine($"Выбран месяц: {Enum.GetName(typeof(MonthsOfTheYear), num)}");
            }
            else
            {
                Console.WriteLine("Необходимо ввести число от 1 до 12 (соответствующее номеру месяца)!");
            }
        }

    }

}
