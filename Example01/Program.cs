// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int number = IntoInt();
PrintInterval(number);

void PrintInterval(int N, int i = 0)
{
    if (i < N)
    {
      //  N = N - i;
        Console.Write($"{N - i} ");
        PrintInterval(N, ++i);
    }
    return;

}


int IntoInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (isParsed && num > 0)
    {
        return num;
    }
    else
    {
        throw new Exception("Ввели не корректные данные");
    }
}
