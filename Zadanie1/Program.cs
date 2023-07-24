Console.Write("Введите число: ");
var n = Convert.ToInt32(Console.ReadLine());
if (n > 0 && n < 100)
{
    for (int i = 1; i <= n; i++)
    {
        if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
        else if (i % 5 == 0) Console.WriteLine("Buzz");
        else if (i % 3 == 0) Console.WriteLine("Fizz");
        else Console.WriteLine(i);
    }
}
else Console.WriteLine("Error!");