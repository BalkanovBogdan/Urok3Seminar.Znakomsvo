// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.WriteLine("Введите кординаты точки A по x.");
double x1= double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кординаты точки A по y");
double y1= double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кординаты точки A по z.");
double z1= double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кординаты точки B по x");
double x2= double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кординаты точки B по y");
double y2= double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кординаты точки B по z");
double z2= double.Parse(Console.ReadLine()!);
double r=Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
Console.WriteLine($"{r:f2}");