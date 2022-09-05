int[] GetArray(int a)
{
    Random rnd = new Random();
    int[] result = new int[a];

    for(int i=0;i<a;i++)
    {
        result[i] = rnd.Next(-100, 101);
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
    Console.Write($"{a[a.Length-1]} ]");
}

Console.WriteLine("Введите длину массива");

PrintArray(GetArray(Convert.ToInt32(Console.ReadLine())));