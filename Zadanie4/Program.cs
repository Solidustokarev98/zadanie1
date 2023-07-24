using System;

Console.Write("Введите шестизначное число: ");
var n = Convert.ToInt32(Console.ReadLine());
if(n>=1000000 && n< 10000000)
{
    int a1 = n / 100000;
    int a2 = (n / 10000) % 10;
    int a3 = (n / 1000) % 10;
    int a4 = (n / 100) % 10;
    int a5 = (n / 10) % 10;
    int a6 = n % 10;
    Console.Write("Ответ: ", a6+a2+a3+a4+a5+a1);
}
else Console.Write("Error!");