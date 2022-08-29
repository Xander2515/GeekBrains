int Max (int[] numbers)
{
    int result = numbers[0];
    for (int count=1; count < numbers.Length; count++)
    {
        if (numbers[count] > result) {result = numbers[count];}
    }
    return result;
}

int GetArray (int[] result)
{
    Console.WriteLine("Введите чисело, для завершения введите max или min");
    string str = "";
    int count=0;
    while ((str != "max") && (str != "min"))
    {
        str = Console.ReadLine();
        if (!int.TryParse(str, out result [count]))
        {
            Console.WriteLine("Это не число");
        }
    }
    return result.Length;
}

int[] a = {};

GetArray (a);

Max(a);