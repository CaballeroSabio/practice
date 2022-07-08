Console.Write("Write a number N: ");
int n = int.Parse(Console.ReadLine());

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
    Console.Write($"{i}");
    i++;
}
