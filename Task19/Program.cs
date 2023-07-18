// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void ShowPolin(int number)
{
 int j;
 int sum = 0;
 int temp = number;
            while (number > 0)
            {
                j = number % 10;
                sum = (sum * 10) + j;
                number = number / 10; 
            }
 if (temp == sum)
            {
                Console.WriteLine($"Число {temp} является полиндромом");
            }
            else
            {
                Console.WriteLine($"Число {temp} не является полиндромом");
            }           
}

int GetInput(string text)
{
Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число:");
ShowPolin(number);