// на вход 3 числа, выводит максимальное из этих чисел

Console.WriteLine("Введите первое число");
string numberone = Console.ReadLine()??"";
int num1 = Convert.ToInt32(numberone);

Console.WriteLine("Введите второе число");
string numbertwo = Console.ReadLine()??"";
int num2 = Convert.ToInt32(numbertwo);

Console.WriteLine("Введите третье число");
string numberthree = Console.ReadLine()??"";
int num3 = Convert.ToInt32(numberthree);

int max = 0;
if (num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}

if (max > num3)
    Console.WriteLine(max);
else
    Console.WriteLine(num3);    