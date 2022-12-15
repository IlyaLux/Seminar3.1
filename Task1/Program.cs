using static System.Console;

WriteLine("Является ли число a квадратом числа b?");
WriteLine("Введите число a: ");
int a = int.Parse(ReadLine());

WriteLine("Введите число b: ");
int b = int.Parse(ReadLine());

if (a == b * b)
{
    WriteLine("да");
}
else {
    WriteLine("нет");        
}