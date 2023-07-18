// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void ShowPolin(int number)
{
Console.WriteLine($"Таблица кубов числа {number}: ");
for (int i=1;i<=number;i++)
{
int k = i*i*i;
Console.Write($"{k}, ");
}
}


int GetInput(string text)
{
Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число:");
ShowPolin(number);