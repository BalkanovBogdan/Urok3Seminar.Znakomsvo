// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.
Console.Clear();
Console.WriteLine("Введите координаты точки A по X ");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки A по Y");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки B по X");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки B по Y");
double y2 = double.Parse(Console.ReadLine()!);
double r = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
Console.WriteLine($"Растояние между ними ={r:f2}");