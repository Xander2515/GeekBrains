float[] CountPoint (float k1, float b1, float k2, float b2)
{
float[] result = new float[2];
result[0] = (b1-b2) / (k2 - k1);
result[1] = result[0] * k1 + b1;
return result;
}

Random rnd = new Random();

float k1 = rnd.NextSingle()*10;
float b1 = rnd.NextSingle()*100;
float k2 = rnd.NextSingle()*10;
float b2 = rnd.NextSingle()*100;

Console.WriteLine();

Console.WriteLine($"y = {k1} * x + {b1} | y = {k2} * x + {b2}");

Console.WriteLine();

float[] f = CountPoint(k1,b1,k2,b2);

Console.WriteLine($"( {f[0]} | {f[1]} )");

Console.WriteLine();