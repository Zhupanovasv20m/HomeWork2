//Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 457
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 100 != 0)
{
    int result1 = num % 100;
    int result2 = result1 / 10;
    System.Console.WriteLine($"{result2}");
}

else
{
    Console.WriteLine("Нужно ввести ТРЕХЗНАЧНОЕ число");
}
