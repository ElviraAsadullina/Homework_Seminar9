void CheckIfMeetsConditions(double a, double b)
{
    if(a < 0 ^ a > 3)
    {
        Console.WriteLine("Введенное число - не удовлетворяет требованию!");
        Console.WriteLine("Введите любое неотрицательное число №1, меньшее либо равное 3: ");
        a = Convert.ToDouble(Console.ReadLine());
    }
    if(b < 0 ^ b > 3)
    {
        Console.WriteLine("Введенное число - не удовлетворяет требованию!");
        Console.WriteLine("Введите любое неотрицательное число №2, меньшее либо равное 3: ");
        b = Convert.ToDouble(Console.ReadLine());
    }
}
double GoAckermann(double a, double b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if (b == 0)
    {
        return GoAckermann(a - 1, 1);
    }
    else
    {
        return GoAckermann(a - 1, GoAckermann(a, b - 1));
    }
}
Console.WriteLine("Введите любое неотрицательное число №1, меньшее либо равное 3 :");
double m = Convert.ToDouble(Console.ReadLine());
CheckIfMeetsConditions(m, m);
Console.WriteLine("Введите любое нотрицательное число №2, меньшее либо равное 3: ");
double n = Convert.ToDouble(Console.ReadLine());
CheckIfMeetsConditions(m, n);
double result = GoAckermann(m, n);
Console.WriteLine(result);