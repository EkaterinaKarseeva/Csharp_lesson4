// Задача 1

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для завершения:");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (IsSumOfDigitsEven(Convert.ToInt32(input)))
            {
                Console.WriteLine($"Сумма цифр числа {input} чётная. Программа завершена.");
                break;
            }
        }
    }

    static bool IsSumOfDigitsEven(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum % 2 == 0;
    }
}
