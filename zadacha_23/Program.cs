// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
// 3 -> 1,8,27
// 5 -> 1,8,27,25,64,125

Console.Clear();

void TablePOW2(string str)             ///функция ввода данных
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        int pow = count*count*count;
        Console.Write(pow + " ");
        count++;
    }
    Console.WriteLine();
}

TablePOW2("Введите число N: ");