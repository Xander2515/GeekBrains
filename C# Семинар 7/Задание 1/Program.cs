float[,] GetArray(int m, int n)
{
    float[,] result = new float[m, n];
    Random rnd = new Random();

    for (int i=0; i<m; i++)
        for (int j=0; j<n; j++)
            result[i, j] = rnd.NextSingle()*20-10;
    
    return result;
}

void PrintArray(float[,] a)
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

PrintArray(GetArray(a, b));