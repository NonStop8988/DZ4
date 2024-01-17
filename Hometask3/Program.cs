// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

// Функция - создание массива случайных одномерных чисел
int[] CreateArray(int size)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, 10);
    }
    return arr;
}

// Функция - переворот массива
int[] FlipArray(int[] arr)
{
    int middleLength = arr.Length / 2;
    for (int i = 0; i < middleLength; i++)
    {
        int tempArr = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = tempArr;
    }
    return arr;
}

Console.WriteLine("Введите цифру от 1 до 9");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 10)
{
    int[] arr = CreateArray(number);
    Console.Write("Изначальный массив: ");
    foreach(int e in arr)
    {
        Console.Write(e + " ");
    }
    Console.Write("\nПеревернутый массив: ");
    foreach(int e in FlipArray(arr))
    {
        Console.Write(e + " ");
    }
}

else
{
    Console.WriteLine("Введены неверные данные, массив не создан");
}