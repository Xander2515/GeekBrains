int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();

    for (int i=0; i<m; i++)
        for (int j=0; j<n; j++)
            result[i, j] = rnd.Next(0, 10);
    
    return result;
}

void PrintArrayFloatSingle(float[] a)
{
    for (int i=0; i<a.GetLength(0); i++)
        Console.Write($"| {a[i]} ");
        
        Console.WriteLine("|");
}

void PrintArrayDouble(int[,] a)
{
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1); j++)
            Console.Write($"|  {a[i, j]}  ");
        
        Console.WriteLine("|");
    }
}

Console.WriteLine("Введите размерность массива");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int[,] arr = GetArray(a, b);

PrintArrayDouble(arr);

float[] FindAverage(int[,] a)
{
    float[] result = new float[a.GetLength(1)];

    for (int i=0; i<a.GetLength(1); i++)
    {
        for (int j=0; j<a.GetLength(0); j++)
            result[i] += a[j, i];
    
        result[i]=result[i]/a.GetLength(0);
    }

    return result;
}

Console.WriteLine();

PrintArrayFloatSingle(FindAverage(arr));