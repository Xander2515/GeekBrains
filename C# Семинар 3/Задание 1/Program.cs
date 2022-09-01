string Palindrom (string number)
{
    for (int i=0; i < number.Length/2; i++)
    {
        if (number[i] != number[number.Length-1-i])
        {
            return "не палиндром";
        }
    }
    return "палиндром";
}

Console.WriteLine("Введите число");

Console.WriteLine(Palindrom(Console.ReadLine()));