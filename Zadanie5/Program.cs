Console.Write("Введите дату: ");
DateTime date = new DateTime();
date = DateTime.Parse(Console.ReadLine());
Console.WriteLine(date.DayOfWeek);