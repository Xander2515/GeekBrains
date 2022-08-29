Console.WriteLine("Введите число");
string a = Console.ReadLine();
if (a.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(a[2]);
}