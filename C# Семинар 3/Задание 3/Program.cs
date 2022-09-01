void Numbers(string number)
{
    Console.WriteLine("Таблица");
    for (int i=1; i <= Convert.ToInt32(number); i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}

Console.WriteLine("Введите число");
Numbers(Console.ReadLine());