Console.Clear();

int xa=51, ya=1, xb=2, yb=42, xc=102, yc=42;
int x=xa, y=ya;
int r=0;

Console.SetCursorPosition(xa, ya);
Console.Write("*");
Console.SetCursorPosition(xb, yb-1);
Console.Write("*");
Console.SetCursorPosition(xc, yc-1);
Console.Write("*");

for (int i=1; i<10000; i++)
{
    r = new Random().Next(0, 3);
    switch (r)
    {
        case 0:
            x = (x + xa) / 2;
            y = (y + ya) / 2; break;
        case 1:
            x = (x + xb) / 2;
            y = (y + yb) / 2; break;           
        case 2:
            x = (x + xc) / 2;
            y = (y + yc) / 2; break;
    }
    Console.SetCursorPosition(x, y);
    Console.Write("*");
}
Console.SetCursorPosition(0, 43);
Console.ReadLine();