int[] GetArray(int a)
{
    Random rnd = new Random();
    int[] result = new int[a];

    for (int i=0;i<a;i++)
    {
        result[i] = rnd.Next(-10, 11);
    }

    return result;
}

void PrintArray(int[] a)
{
    Console.Write("[ ");
    for (int i=0; i < a.Length-1; i++)
    {
        Console.Write($"{a[i]} , ");
    }
    Console.WriteLine($"{a[a.Length-1]} ]");
}

Console.WriteLine("Введите длину массива");

int[] a = GetArray(Convert.ToInt32(Console.ReadLine()));

PrintArray(a);

int CountArray(int[] a)
{
    int result = 0;

    for (int i=0; i*2+1 < a.Length; i++)
    {
        result = result + a[i*2+1];
    }

    return result;
}

Console.WriteLine(CountArray(a));