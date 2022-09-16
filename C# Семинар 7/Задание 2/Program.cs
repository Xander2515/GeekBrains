int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();

    for (int i=0; i<m; i++)
        for (int j=0; j<n; j++)
            result[i, j] = rnd.Next(10, 100);
    
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

string FindNumber(int[,] a, int b)
{
    for (int i=0; i<a.GetLength(0); i++)
        for (int j=0; j<a.GetLength(1); j++)
            if(a[i, j] == b)
                return $"{i} | {j}";
    
    return "Такого числа нет";
}

Console.WriteLine("Введите искомое число");

int x = Convert.ToInt32(Console.ReadLine());

Console. WriteLine(FindNumber(arr, x));