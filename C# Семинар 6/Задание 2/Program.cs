float[] CountPoint (float k1, float b1, float k2, float b2)
{
float[] result = new float[2];
result[0] = (b1-b2) / (k2 - k1);
result[1] = result[0] * k1 + b1;
return result;
}

Random rnd = new Random();

Console.Write("k1 = ");
float k1 = Convert.ToSingle(Console.ReadLine());

Console.Write("b1 = ");
float b1 = Convert.ToSingle(Console.ReadLine());

Console.Write("k2 = ");
float k2 = Convert.ToSingle(Console.ReadLine());

Console.Write("b2 = ");
float b2 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"y = {k1} * x + {b1} | y = {k2} * x + {b2}");

Console.WriteLine();

float[] f = CountPoint(k1,b1,k2,b2);

Console.WriteLine($"( {f[0]} | {f[1]} )");

Console.WriteLine();