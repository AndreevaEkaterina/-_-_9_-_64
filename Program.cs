// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
string Counter(int end, int start)
{
    if (start > end)
    {
        return start + " " + Counter(start - 1, end);
    }
    if (end == start)
    {
        return end.ToString();
    }
    return end + " " + Counter(end - 1, start);
}
Console.Clear();
Console.Write("Введите первое число:");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(Counter(m, n));