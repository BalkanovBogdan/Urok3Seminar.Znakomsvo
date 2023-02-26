// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
Console.Clear();
Console.WriteLine("Введите два числа.");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int sum=a;
int i=2;
for(;i<=b;i++)
 {sum*=a;}
 
Console.WriteLine($"Вывод={sum}");