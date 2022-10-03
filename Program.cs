Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int i = 1;
while (i <= n)
{
    if (i%2!=1)
    {
        Console.Write(i);
    }
    else
    {    
        Console.Write(" ");
    }
    i++;
}