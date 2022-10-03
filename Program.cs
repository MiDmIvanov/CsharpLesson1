
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число с");
int c = int.Parse(Console.ReadLine());
int max =0;
if (a>b)
{
    if (a>c)
    {
        max = a; 
    }
    else
    {
        max = c;
    }
}
else
{
    if (b>c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
}
Console.Write("Максимальное число ");
Console.WriteLine(max);
