// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ShowSumOfNaturalElements(int m, int n)
{
    if (n == m) return m;
    return n + ShowSumOfNaturalElements(m, n - 1);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите число M: ");
int n = GetInput("Введите число N: ");
if (m < 0 & n < 0) Console.WriteLine("Это не натуральные числа, введите числа больше нуля");
if (m < 0 || n < 0) Console.WriteLine("Одно из чисел не натуральное, введите числа больше нуля");
if (m > n) Console.WriteLine("M больше N, введите M меньше N.");
else Console.WriteLine($"M = {m}; N = {n} -> {ShowSumOfNaturalElements(m, n)}");