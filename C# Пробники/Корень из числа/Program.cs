double Root(double a, int n)
{
    double Exp(double x, int n)
    {
        double result=1;

        for (int i=0; i < n; i++)
        {
            result = result * x;
        }

        return result;
    }

    double result = 0;
    
    for (int i=0; i < 16; i++)
    {
        double b = 0;
        while(b <= a)
        {
            result=result + 1/Exp(10, i);
            b=1;
            for (int j=0; j < n; j++)
            {
                b=b*result;
            }
        }
        result=result-1/Exp(10, i);
    }
    return result;
}

Console.Write(Root(Convert.ToDouble(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));