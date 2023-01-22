int getNumberOfPlane(double x, double y)
{
    int numberOfPlane = -1;

    if (x > 0 && y > 0)
    numberOfPlane = 1;
    
    if (x < 0 && y > 0)
    numberOfPlane = 2;

    if (x < 0 && y < 0)
    numberOfPlane = 3;

    if (x > 0 && y < 0)
    numberOfPlane = 4;
    return numberOfPlane;
}
Console.WriteLine("X:");
double x = double.Parse(Console.ReadLine()!);
Console.WriteLine("Y:");
double y = double.Parse(Console.ReadLine()!);

int numberOfPlane = getNumberOfPlane(x, y);

if (numberOfPlane == -1)
    Console.WriteLine("Вы ввели некорректные координаты");
else
    Console.WriteLine($"Номер плоскости: {numberOfPlane}.");

