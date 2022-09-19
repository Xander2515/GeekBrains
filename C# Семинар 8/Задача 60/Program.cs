int[,,] GetArray(int m, int n, int k)
{
    int[,,] result = new int[m, n, k];
    int a = 10;

    for (int i=0; i<m; i++)
        for (int j=0; j<n; j++)
            for (int l = 0; l < k; l++)
            {
                result[i, j, l] = a;
                a++;
            }
    
    return result;
}

void PrintArray(int[,,] a)
{
    for (int i=0; i<a.GetLength(0); i++)
        for (int j=0; j<a.GetLength(1); j++)
        {
            for (int l=0; l<a.GetLength(2); l++)
                Console.Write($"| {a[i, j, l]} ({i}, {j}, {l}) ");
        
            Console.WriteLine("|");
        }
}

Console.WriteLine("Введите размерность массива");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,,] arr1 = GetArray(a, b, c);

PrintArray(arr1);