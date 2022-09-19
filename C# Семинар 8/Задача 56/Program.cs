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

int[,] OrderArray(int[,] a)
{
    int b;
    int[,] result = a;

    for (int i=0; i<result.GetLength(0); i++)
    {
        for (int j=0; j<result.GetLength(1)-1; j++)
        {
            if (result[i,j] < result[i,j+1])
            {
                b = result[i,j];
                result[i,j] = result[i,j+1];
                result[i,j+1] = b;
                j = -1;
            }
        }
    }

    return result;
}

Console.WriteLine();

PrintArray(OrderArray(arr));