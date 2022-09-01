double Distance(double ax, double ay, double az, double bx, double by, double bz)
{
    return Math.Sqrt(Math.Pow(ax-bx, 2) + Math.Pow(ay-by, 2) + Math.Pow(az-bz, 2));
}

Console.WriteLine("Введите координаты первой точки");
double ax = Convert.ToDouble(Console.ReadLine());
double ay = Convert.ToDouble(Console.ReadLine());
double az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
double bx = Convert.ToDouble(Console.ReadLine());
double by = Convert.ToDouble(Console.ReadLine());
double bz = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние");
Console.WriteLine(Distance(ax, ay, az, bx, by, bz));