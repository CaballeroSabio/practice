// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();
Console.Write("Write a number N: ");
int n = int.Parse(Console.ReadLine()); //Convert.ToInt32 - более универсальный
int i = 0;
if (n < 0)
{
    i = n;
    n = -n;
}
else
{
   i = -n;
}
while (i <= n)
{
    Console.Write($"{i} ");
    i++;
}
Console.WriteLine();