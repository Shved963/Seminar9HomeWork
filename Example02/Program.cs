// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();


int numberBegin = IntoInt();
int numberEnd = IntoInt();

int sumInInterval = GetSumOfElementsInInterval(numberBegin, numberEnd);

Console.WriteLine(sumInInterval);

int GetSumOfElementsInInterval(int M, int N)
{
    int sum = 0;
    if (M > N)
    {
        return 0;
    }
    else
    {
        sum = M;
    }
    return sum + GetSumOfElementsInInterval(++M,N);
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
