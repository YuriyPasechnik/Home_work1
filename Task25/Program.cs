// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power(int numberA, int numberB)
{
int power = 1;
for (int i=0; i < numberB; i++)
{
power *= numberA; 
}
return power;
}

int GetInput(string text)
{
Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int numberA = GetInput("Введите основание: ");
int numberB = GetInput("Введите показатель: ");
Console.WriteLine($"Число {numberA}  в степени {numberB} равно {Power(numberA, numberB)}");