void PrintPossibleCoordinateOfPoint(int possibleCoordinateOfPoint)
{
    if(possibleCoordinateOfPoint == 1)
        Console.WriteLine("x > 0 and y > 0");
    if(possibleCoordinateOfPoint == 2)
        Console.WriteLine("x < 0 and y > 0");
    if(possibleCoordinateOfPoint == 3)
        Console.WriteLine("x < 0 and y < 0");
    if(possibleCoordinateOfPoint == 4)
        Console.WriteLine("x > 0 and y < 0");
}
int possibleCoordinateOfPoint = int.Parse(Console.ReadLine()!);
PrintPossibleCoordinateOfPoint(possibleCoordinateOfPoint);