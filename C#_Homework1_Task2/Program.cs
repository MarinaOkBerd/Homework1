// Программа на вход- 2 числа, на выходе выдает, какое число больше, а какое меньше

Console.WriteLine("Введите первое число");
string numberone = Console.ReadLine()??"";
int num1 = Convert.ToInt32(numberone);

Console.WriteLine("Введите второе число");
string numbertwo = Console.ReadLine()??"";
int num2 = Convert.ToInt32(numbertwo);

if (num1 > num2)
{
    Console.WriteLine($"max = {num1}");
}
else
{
    Console.WriteLine($"max = {num2}");
}