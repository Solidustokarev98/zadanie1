Console.Write("Введите первое число: ");
var n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
var n2 = Convert.ToInt32(Console.ReadLine());
if (n1<n2)
{
    for(int i=n1;i<=n2;i++)
    {
        Console.WriteLine(i);
    }
}
else
{
    for (int i = n2; i <= n1; i++)
    {
        Console.WriteLine(i);
    }
}