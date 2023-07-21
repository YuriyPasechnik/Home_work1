//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summ(int number)
{
int result = 0;
while (number > 0)
{
result += number%10;
number = number/10;
}
return result;
}

int GetInput(string text)
{
Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число: ");
Console.WriteLine($"Сумма всех цифр числа {number} равна {Summ(number)}");
