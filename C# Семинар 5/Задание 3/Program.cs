float[] GetArray(int a)
{
    Random rnd = new Random();

    float[] result = new float[a];

    for (int i=0;i<a;i++)
    {
        result[i] = rnd.NextSingle() * 200 - 100;
    }

    return result;
}

void PrintArray(float[] a)
{
    Console.Write("[ ");
    for (int i=0; i < a.Length-1; i++)
    {
        Console.Write($"{a[i]} , ");
    }
    Console.WriteLine($"{a[a.Length-1]} ]");
}

Console.WriteLine("Введите длину массива");

float[] a = GetArray(Convert.ToInt32(Console.ReadLine()));

PrintArray(a);

float GetDelta (float[] a)
{
    float max = a[0];
    float min = a[0];
    foreach (float i in a)
    {
        if (max < i)
        max = i;
        if (min > i)
        min = i;
    }
    return max-min;
}

Console.WriteLine(GetDelta(a));