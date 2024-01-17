// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Функция - создание массива случайных трехзначных чисел
int[] CreateArray(int size)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

// Функция - подсчет количества четных чисел в массиве
int GetCountEven(int[] arr)
{
    int countEven = 0;
    foreach (int e in arr)
    {
        if (e % 2 == 0)
        {
            countEven++;
        }
    }
    return countEven;
}

Console.WriteLine("Введите целое натуральное число");
int number = Int32.Parse(Console.ReadLine());

if (number > 0)
{
    int[] array = CreateArray(number);
    foreach(int e in array)
    {
        Console.Write(e + " ");
    }

    int countEven = GetCountEven(array);
    Console.WriteLine($"\nКоличество чётных чисел в массиве - {countEven}");
}

else
{
    Console.WriteLine($"Введено ненатуральное число");
}