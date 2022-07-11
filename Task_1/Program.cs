// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = num2*num2;
if (num1 == res)
{
    Console.Write("Первое число является квадратом второго");
}
else
{
    Console.Write("Первое число не является квадратом второго");
}
Console.WriteLine();