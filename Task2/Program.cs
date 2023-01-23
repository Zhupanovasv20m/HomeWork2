// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
long num = Convert.ToInt64(Console.ReadLine());
long result = num;

if (num / 100 == 0)
{
    Console.WriteLine($"{num} - Третьей цифры нет!");
}
else
{
    while (result / 1000 != 0)
    {
        result = result / 10;
    }
    Console.WriteLine($"{num} -> {result % 10}");
}