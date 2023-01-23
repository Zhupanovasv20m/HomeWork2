// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 100 != 0)
{
    int numLast = num % 10;
    System.Console.WriteLine($"{num} -> {numLast}");
}
else
{
    System.Console.WriteLine($"{num} - Третьей цифры нет!");
}