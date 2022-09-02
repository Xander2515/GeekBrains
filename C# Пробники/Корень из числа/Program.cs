double Root(double a, int n)
{
    //Отдельно метод вычисления степени
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
    //Перебираем до нужной точности
    for (int i=0; i < 15; i++)
    {
        double b = 0;
        //Сравниваем текущий результат в степени корня с аргументом корня по модулю
        while(b*b <= a*a)
        {
            result=result + 1/Exp(10, i);
            b=1;
            b=Exp(result, n);
        }
        //Если цикл завершён, то текущий результат в степени корня больше аргумента корня и нужно его уменьшить
        result=result-1/Exp(10, i);
    }
    //Если аргумент корня отрицательный и степень нечётная, то результат должен быть отрицательным
    if (a < 0 && n % 2 != 0)
        return -result;
    else
        return result;
}

double a = Convert.ToDouble(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

double x = Root(a, n);

if (a < 0 && n % 2 == 0)
    a = -a;

Console.Write($"Корень степени {n} из {a} равен {x}");