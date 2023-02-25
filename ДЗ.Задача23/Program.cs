// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//* при N < 0, нужно вывести от N до -1
Console.Clear();
Console.WriteLine("Введите число");
double N=double.Parse(Console.ReadLine()!);
double n=1;
double r=0;
double m=-1;
if(N>0){while(n<=N){r=Math.Pow(n,3);n++;Console.Write($"{r},");}}
else{while(N<=m){r=Math.Pow(N,3);N++;Console.Write($"{r},");}}