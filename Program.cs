﻿// Задача 1

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
// Задача 2



class Program
{
    static void Main()
    {
        // Задаем размер массива
        int arraySize = 10; // Можете изменить размер массива по вашему усмотрению

        // Создаем массив случайных трехзначных чисел
        int[] randomArray = GenerateRandomArray(arraySize);

        // Выводим массив на консоль
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(randomArray);

        // Получаем количество четных чисел в массиве
        int evenCount = CountEvenNumbers(randomArray);

        // Выводим результат
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000); // Генерируем трехзначные числа
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }

    static int CountEvenNumbers(int[] array)
    {
        int evenCount = 0;

        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                //evenCount++;
            }
        }

        return evenCount;
    }
}

// Задача 3

using System;

class Program
{
    static void Main()
    {
        // Задаем массив
        int[] originalArray = { 1, 2, 3, 4, 5 };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);

        // Переворачиваем массив
        int[] reversedArray = ReverseArray(originalArray);

        // Выводим перевернутый массив
        Console.WriteLine("Перевернутый массив:");
        PrintArray(reversedArray);
    }

    static int[] ReverseArray(int[] array)
    {
        int length = array.Length;
        int[] reversedArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            reversedArray[i] = array[length - 1 - i];
        }

        return reversedArray;
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
}
