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
            Console.Write($"|  {a[i, j]}  ");
        
        Console.WriteLine("|");
    }
}

Console.WriteLine("Введите размерность массива");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int[,] arr = GetArray(a, b);

PrintArray(arr);

int FindMinString(int[,] a)
{
    int result=0;

    int[] b = new int[a.GetLength(0)];

    for (int i=0; i<a.GetLength(0); i++)
    {
        b[i] = 0;
        for (int j=0; j<a.GetLength(1); j++)
        {
            b[i] = b[i] + a[i,j];
        }
    }

    for (int i=0; i<b.Length-1; i++)
        if (b[i] > b[i+1])
            result=i+1;

    return result;
}

Console.WriteLine();

Console.WriteLine(FindMinString(arr));