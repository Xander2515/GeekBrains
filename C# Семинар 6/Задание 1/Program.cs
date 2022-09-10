float[] GetNumbers()
{
    Console.WriteLine("Введите числа, разделённые знаком |");

    Console.WriteLine();

    string a = Console.ReadLine();

    string[] b = a.Split('|', StringSplitOptions.RemoveEmptyEntries);

    float[] result = new float[b.Length];

    for (int i=0; i<b.Length; i++)
        result[i] = Convert.ToSingle(b[i]);

    return result;
}

int CountDigitsAboveZero(float[] a)
{
    int result = 0;

    foreach(float i in a)
    if (i>0)
        result++;

    return result;
}

Console.WriteLine();

int b = CountDigitsAboveZero(GetNumbers());

Console.WriteLine();

Console.WriteLine($"Введено положительных чисел: {b}");

Console.WriteLine();