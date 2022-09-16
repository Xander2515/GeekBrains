int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();

    for (int i=0; i<m; i++)
        for (int j=0; j<n; j++)
            result[i, j] = rnd.Next(0, 10);
    
    return result;
}

void PrintArray(int[,] a)
{
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1); j++)
            Console.Write($"| {a[i, j]} ");
        
        Console.WriteLine("|");
    }
}

Console.WriteLine("Введите размерность массива");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int[,] arr = GetArray(a, b);

PrintArray(arr);

void FindAverage(int[,] a)
{
    float result = 0;

    for (int i=0; i<a.GetLength(1); i++)
    {
        result = 0;
        
        for (int j=0; j<a.GetLength(0); j++)
            result = result + a[j, i];
    
        result=result/a.GetLength(0);
        Console.Write($"| {result} ");
    }
    Console.WriteLine("|");
}

Console.WriteLine();

FindAverage(arr);