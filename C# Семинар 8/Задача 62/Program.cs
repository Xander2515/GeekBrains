int[,] GetArray(int m, int s)
{
    int[,] res = new int[m, m];
    int n = (m+1)/2; //количество проходов по периметру
    for (int i=0; i<n; i++)
    {
        for (int a=i; a<m-i; a++)
        {res[i,a] = s; s++;}
        for (int a=i+1; a<m-i; a++)
        {res[a,m-i-1] = s; s++;}
        for (int a=m-i-2; a>=i; a--)
        {res[m-i-1,a] = s; s++;}
        for (int a=m-i-2; a>=i+1; a--)
        {res[a,i] = s; s++;}
    }
    return res;
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

Console.WriteLine("Введите начальное значение");

int b = Convert.ToInt32(Console.ReadLine());

int[,] arr = GetArray(a,b);

PrintArray(arr);