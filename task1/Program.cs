//  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int InputInt(string message)
{
    System.Console.WriteLine(message);
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);

    /// или  if (int.TryParse(Console.ReadLine(), out value))
    if (isCorrect)
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

bool ValidateCoord(int x, int y)
{
    if (x == 9 || y == 0)
    {
        System.Console.WriteLine("Одна из координат находится на оси");
        return false;
    }
    return true;
}


int Getquorter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }

    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;

}

int x = InputInt("Введите X");
int y = InputInt("Введите Y");

if (ValidateCoord(x, y))
{
    System.Console.WriteLine($"Координаты {x},{y} находятся в четверти {Getquorter(x, y)}");
}