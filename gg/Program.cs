Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());


while (num / 1000 != 0)
{
    System.Console.WriteLine($"{num} - Третьей цифры нет!");
}
num = num / 100;
Console.WriteLine($"{num}");