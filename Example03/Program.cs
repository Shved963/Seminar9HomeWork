// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.Write("Введите число m ");
double m = IntoInt();
Console.Write("Введите число n ");
double n = IntoInt();
Console.WriteLine(GetAkkermanFunctiont(m, n));

double GetAkkermanFunctiont(double m, double n)
{
    if (m == 0) 
    return n + 1;

    if (n == 0 && m > 0) 
    return GetAkkermanFunctiont(m - 1, 1);

    if (n > 0 && m > 0) 
    return GetAkkermanFunctiont(m - 1, GetAkkermanFunctiont(m, n - 1));
    else
    return GetAkkermanFunctiont(n, m);
}



double IntoInt()
{
    bool isParsed = double.TryParse(Console.ReadLine(), out double num);
    if (isParsed && num >= 0)
    {
        return num;
    }
    else
    {
        throw new Exception("Ввели не корректные данные");
    }
}
