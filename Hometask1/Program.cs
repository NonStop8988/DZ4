// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.

// Функция определения четности суммы цифр заданного числа
bool IsEven(int n)
{
    int sum = 0;
    int digitNumber = 0;
    while (n > 0)
    {
        digitNumber = n % 10;
        n /= 10;
        sum += digitNumber;
    }
    // Console.WriteLine(sum);
    if (sum % 2 == 0)
    {
        return true;
    }
    return false;
}

bool workProgramm = true;
while (workProgramm)
{
    Console.WriteLine("Введите целое число или 'q' для завершения работы программы");
    string input = Console.ReadLine();

    if (input == Convert.ToString("q"))
    {
        Console.WriteLine("Введено q, завершение работы программы");
        workProgramm = false;
    }
    int number = Convert.ToInt32(input);
    bool even = IsEven(number);
    if (even == true)
    {
        Console.WriteLine($"Сумма цифр введенного числа {number} - четная, завершение работы программы");
        workProgramm = false;
    }
}