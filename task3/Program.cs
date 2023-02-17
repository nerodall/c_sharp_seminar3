// Задача 3: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

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

double Distance(int x1, int y1, int x2, int y2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;

    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
}

int x1 = InputInt ("Введите х1");
int y1 = InputInt("Введите y1");
int x2 = InputInt("Введите х2");
int y2 = InputInt ("Введите y2");

double distance = Distance(x1,y1,x2,y2);
System.Console.WriteLine($"Дистанция равна {distance:F2}");