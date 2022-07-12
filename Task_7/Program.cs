// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.Write("Hello, User! Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine()); // при делении 456 на 10 = 45.6
int lastDigit = num % 10;
Console.WriteLine(lastDigit);
Console.WriteLine();