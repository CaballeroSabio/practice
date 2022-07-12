// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Clear();
Console.Write("Введите номер дня недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 1)
{
    Console.Write("Monday");
}
else if (dayWeek == 2)
{
    Console.Write("Tuesday");
}
else if (dayWeek == 3)
{
    Console.Write("Wednesday");
}
else if (dayWeek == 4)
{
    Console.Write("Thursday");
}
else if (dayWeek == 5)
{
    Console.Write("Friday");
}
else if (dayWeek == 6)
{
    Console.Write("Saturday");
}
else if (dayWeek == 7)
{
    Console.Write("Sunday");
}

Console.WriteLine();