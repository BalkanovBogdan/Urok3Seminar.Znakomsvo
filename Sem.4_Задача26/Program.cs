// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
Console.Clear();
Console.WriteLine("Введите число.");
int s=int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр = {CountNumbers(s)}");

int CountNumbers(int n)
{
    int count =0;
    if(n<0)
        n*=(-1); //n=n*(-1)
    while (n>0)
    {
        n/=10; //n=n/10 n=0
        count++;
    }  
    return count; 
}
