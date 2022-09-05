int digitsum (int a)
{
int result = 0;
while (a > 0)
{
    result = result + a % 10;
    a = a / 10;
}
return result;
}

Console.WriteLine(digitsum(Convert.ToInt32(Console.ReadLine())));