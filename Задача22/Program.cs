// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int n=1;
int r=0;
while(n<=N){r=n*n;n++;
Console.Write($"{r},");}
