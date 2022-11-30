// на вход - число n, на выходе - все четные числа от 1 до n

Console.WriteLine("Введите число");
string number = Console.ReadLine()??"";
int n = Convert.ToInt32(number);

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
