// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.WriteLine("Hello, User!");
Console.Write("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine()); // при делении 456 на 10 = 45.6

if (num >= 100 && num < 1000)
{
    int lastDigit = num % 10;
    Console.WriteLine(lastDigit);
}
else
{
    Console.WriteLine("wrong number");
}
Console.WriteLine("Goodbye!");
Console.WriteLine();