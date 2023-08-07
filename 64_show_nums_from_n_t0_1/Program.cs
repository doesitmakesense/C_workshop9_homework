// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string ShowNumbers(int n)
{
    if (n == 1) return n.ToString();
    return n + ", " + ShowNumbers(n - 1);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int n = GetInput("Введите число N: ");
if (n < 0) Console.WriteLine("Это не натуральное число, введите число больше нуля.");
else Console.WriteLine($"N = {n} -> {ShowNumbers(n)}");
