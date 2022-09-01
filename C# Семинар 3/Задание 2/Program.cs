double Distance(double[] dotA, double[] dotB)
{
    double result=0;

    for (int i=0; i < 3; i++)
    {
        result = result + Math.Pow(dotA[i]-dotB[i], 2);
    }

    return Math.Sqrt(result);
}

Console.WriteLine("Введите координаты первой точки");

double[] dotA = new double[3];
double[] dotB = new double[3];

for (int i=0; i < 3; i++)
{
    dotA[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Введите координаты второй точки");

for (int i=0; i < 3; i++)
{
    dotB[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Расстояние");
Console.WriteLine(Distance(dotA, dotB));