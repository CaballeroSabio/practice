// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Hello, User!");
Console.Write("Do you want to know which number is the maximum and which in the minimum? Yes or No?: ");
string answer = Console.ReadLine();
if (answer.ToLower() == "yes")
{
	Console.Write("Enter first integer: ");
	int num1 = Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter second integer: ");
	int num2 = Convert.ToInt32(Console.ReadLine());
	if (num1 == num2)
	{
		Console.WriteLine("False");
		Console.WriteLine("Try again!");
	}
	else
	{	
		int Max(int num1, int num2)
		{
			int result1 = num1;
			if(num2 > result1) result1 = num2;
			return result1;
		}
 		int Min(int num1, int num2)
		{
			int result2 = num1;
			if(num2 < result2) result2 = num2;
			return result2;
		}
		int max = Max(num1, num2);
		int min = Min(num1, num2);
		Console.WriteLine($"Maximum number = {max}");
		Console.WriteLine($"Minimum number = {min}");
		Console.WriteLine("Great!");
	}
}
Console.WriteLine("Goodbye!");
Console.WriteLine();