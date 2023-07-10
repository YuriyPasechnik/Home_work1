//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите цисло: ");
int number = int.Parse(Console.ReadLine());
if (number<100)
{
Console.Write($" третьей цифры нет ");
}
else
{
while (number>999)
{
number = number / 10;
}
Console.Write($" третья цифра числа {number} является {number  % 10} ");
}