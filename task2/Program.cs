//  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

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


bool ValidateQuorter(int Quorter)
{
    if (Quorter > 4 || Quorter < 0)
    {
        System.Console.WriteLine("Такой четверти на оси координат нет");
        return false;
    }
    return true;
}

(int, int) GetCoords(int Quorter)  //Вызов "кортеж"
{
    switch (Quorter)
    {
        case 1:
            return (1, 1);
            break;
        case 2:
            return (-1, 1);
            break;
        case 3:
            return (-1, -1);
            break;
        default:
            return (1, -1);
            break;
    }
}


int Quorter = InputInt ("Введите номер четверти");
if (ValidateQuorter(Quorter))
{
    (int x, int y)  = GetCoords(Quorter);
    System.Console.WriteLine($"Координаты {Quorter} равны {x},{y}");
}