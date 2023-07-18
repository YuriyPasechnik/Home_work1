// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void ShowPolin(int ax, int ay, int az,int bx,int by,int bz)
{
double distance = Math.Pow((Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2) *1.0), 0.5);
Console.WriteLine($"Расстояние между точками A и B: {distance}");
}
int GetInput(string text)
{
Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int ax = GetInput("Введите координату x точки А:");
int ay = GetInput("Введите координату y точки А:");
int az = GetInput("Введите координату z точки А:");
int bx = GetInput("Введите координату X точки B:");
int by = GetInput("Введите координату y точки B:");
int bz = GetInput("Введите координату z точки B:");
ShowPolin(ax,ay,az,bx,by,bz);