// Напишите программу, которая принимает на вход число N,
// и выдает произведение чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число.");
int s=int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение = {Proizvedenie(s)}");

int Proizvedenie(int n)
{
   int sum=1;
   int i=2;
   if(n<0){i=n;n=-1;}
   for(;i<=n;i++)
    {sum*=i;}
    return sum;
}