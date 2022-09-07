// программа, кот принимает на вход координаты 2х точек и находит расстояние между ними в 3D пространстве

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return d;
}

Console.WriteLine("Введите координату x для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z для первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для Второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z для второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками: {Math.Round(result, 2)}");
