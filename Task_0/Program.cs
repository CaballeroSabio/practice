// 0. Демонстрация решения
// Напишите программу,
// 1. которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Clear();
string str = "Hi!";
Console.Write("Enter an integer: ");
int num=Convert.ToInt32(Console.ReadLine()); // int num=4; // -2.147 млрд до 2.147 млрд
// double d=4.6;
int res=num*num;
Console.WriteLine($"Квадрат числа {num} = {res}");