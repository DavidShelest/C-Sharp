﻿namespace remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите делимое (целое число): ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите делитель (целое число): ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            if (divisor != 0)
                Console.WriteLine($"{dividend}/{divisor} = {quotient} остаток {remainder}");
            else
                Console.WriteLine("Ошибка! Деление на ноль!");
        }

    }

}