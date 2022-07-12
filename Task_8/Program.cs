// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Hello, User!");
Console.Write("Enter an integer: ");
int a = int.Parse(Console.ReadLine());
int i = 2;
while (i <= a) 
{ 
    if (i % 2 == 0) 
    { 
    	Console.Write($"{i} "); 
    } 
    i++; 
}
Console.WriteLine("Goodbye!");
Console.WriteLine();
