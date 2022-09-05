double Exp(double x, int n)
{
    double result=1;

    for (int i=0; i < n; i++)
    {
        result = result * x;
    }

    return result;
}

Console.WriteLine( Exp( Convert.ToDouble(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) ) );