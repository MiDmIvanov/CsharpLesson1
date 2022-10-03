Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
int max =0;
if (a>b)
{
    max = a;
}
else
{
    max = b;
}
Console.Write("Максимальное число ");
Console.WriteLine(max);
