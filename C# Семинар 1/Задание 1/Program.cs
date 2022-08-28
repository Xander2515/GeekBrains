double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
if (a > b)
{
    Console.Write(a);
    Console.Write(" > ");
    Console.Write(b);
}
else
{
    if (a == b)
    {
        Console.WriteLine("Числа равны");
    }
    else
    {
        Console.Write(b);
        Console.Write(" > ");
        Console.Write(a);
    }
}