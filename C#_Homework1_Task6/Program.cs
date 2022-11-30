// на вход принимается чмсло, выдает четное ли оно 

Console.WriteLine("Введите число");
string number = Console.ReadLine()??"";
int num = Convert.ToInt32(number);
num = Math.Abs(num);

if (num % 2 == 0)
{
    Console.WriteLine("да");
}
else if (num % 2 ==1)
{
    Console.WriteLine("нет");
}