// Напишите программу, которая на вход принимает пятизначное число и проеряет,является ли оно палиндромом
//14212 -> нет
//23432 -> да
//12821 -> да

Console.Clear();

void Polindrom(string str)             ///функция ввода данных
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int left = number;
    int reNumber = 0;                           //перевернутое значение
    while (left > 0)
    {
        int r = left % 10;
        reNumber = reNumber * 10 + r;
        left = left / 10;
    }
    if (number == reNumber)                  // условия для ответа
    {
        Console.WriteLine("-> да");
    }
    else
    {
        Console.WriteLine("-> нет");
    }
}

Polindrom("Введите число: ");




// Вариант № 1 без обращения к методу

// Console.Write("Введите число: ");            //просим ввести число
// int number = int.Parse(Console.ReadLine());

// int left = number;
// int reNumber = 0;                           //перевернутое значение
// while (left > 0)
// {
//     int r = left % 10;
//     reNumber = reNumber * 10 + r;
//     left = left / 10;
// }

// if (number == reNumber)                  // условия для ответа
// {
//     Console.WriteLine("-> да");
// }
// else
// {
//     Console.WriteLine("-> нет");
// }