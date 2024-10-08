namespace months_of_the_year
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] AllowedNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine("Введите число, соответствующее номеру месяца: ");
            int result = Convert.ToInt32(Console.ReadLine());
        }
    
            //if AllowedNumbers

       
    }

    enum MonthsOfTheYear
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
