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

Console.WriteLine();

int[,] arr1 = GetArray(a, b);

PrintArray(arr1);

Console.WriteLine();

int[,] arr2 = GetArray(b, a);

PrintArray(arr2);

Console.WriteLine();

int[,] MultiplyMatrix(int[,] a, int[,] b)
{
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];

    for (int i=0; i < result.GetLength(0); i++)
        for (int j=0; j < result.GetLength(1); j++)
        {
            result[i,j] = 0;

            for (int l=0; l < a.GetLength(0); l++)
                    result[i,j] += a[i,l] * b[l,j];
        }

return result;
}

PrintArray(MultiplyMatrix(arr1, arr2));