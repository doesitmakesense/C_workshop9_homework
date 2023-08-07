// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanRecursion (int m, int n)
{
    if (m == 0) {
            return n + 1;
        } 
        else if (n == 0 && m > 0) {
            return AckermanRecursion(m - 1, 1);
        } 
        else {
            return AckermanRecursion(m - 1,AckermanRecursion(m, n - 1));
        }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите число m: ");
int n = GetInput("Введите число n: ");
if (m < 0 & n < 0) Console.WriteLine("Это не натуральные числа, введите числа больше нуля");
if (m < 0 || n < 0) Console.WriteLine("Одно из чисел не натуральное, введите числа больше нуля");
else Console.WriteLine($"m = {m}, n = {n} -> A (m,n) = {AckermanRecursion(m, n)}");