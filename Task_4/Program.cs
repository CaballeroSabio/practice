// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Hello, User!");
Console.Write("Enter first integer: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second integer: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third integer: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int Max(int num1, int num2, int num3)
{
    int result = num1;
    if (num2 > result) result = num2;
    if (num3 > result) result = num3;
    return result;
}
int max = Max(num1, num2, num3);
Console.WriteLine($"Maximum number is {max}");
Console.WriteLine("Goodbye!");
Console.WriteLine();