// формат - число и буква в конце
Console.WriteLine("Введите температуру:");
string input = Console.ReadLine();

// удаляем пробелы,получаем число и последний символ в конце
string noSpaces = input.Replace(" ", "");
noSpaces = noSpaces.ToLower();
string str = noSpaces.Remove(noSpaces.Length - 1); // число-строка без буквы
double degrees = Convert.ToDouble(str);

if (noSpaces.EndsWith("c") || noSpaces.EndsWith("ц"))
{
    double f = degrees * 9 / 5 + 32;
    Console.WriteLine($"{degrees}C = {f}F");
}
else if (noSpaces.EndsWith("f") || noSpaces.EndsWith("ф"))
{
    double c = (degrees - 32) / 1.8;
    Console.WriteLine($"{degrees}F = {c}C");
}

Console.ReadLine();