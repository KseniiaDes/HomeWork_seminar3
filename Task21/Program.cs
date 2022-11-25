// Задача 21. 
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек: ");
Console.Write("Введите координаты x точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z точки A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты x точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double Distance(int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az));
}

double result = Math.Round(Distance(xA, yA, zA, xB, yB, zB), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {result}");