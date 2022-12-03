// Напишите программу которая принимает на вход координаты двух точек и находит расстояние междуними в 3д пространстве
//A (3,6,8)   B (2,1,-7) -> 15.84
// A (7,-5,0) B (1,-1,9) -> 11.53

Console.Clear();

int DataEntryXY(string str)             ///функция ввода данных
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double CalcDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
    return result;
}


int x1 = DataEntryXY("введите координаты x1 = ");
int y1 = DataEntryXY("введите координаты y1 = ");
int z1 = DataEntryXY("введите координаты z1 = ");

int x2 = DataEntryXY("введите координаты x2 = ");
int y2 = DataEntryXY("введите координаты y2 = ");
int z2 = DataEntryXY("введите координаты z2 = ");

double result = CalcDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine("расстояние между точками: " + result);