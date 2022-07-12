// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Hello, User!");
Console.Write("Enter integer: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
	Console.WriteLine("This number is even");
}
else
{
	Console.WriteLine("This number isn't even");
	Console.WriteLine("Try again, please!");
}
Console.WriteLine("Goodbye!");
Console.WriteLine();