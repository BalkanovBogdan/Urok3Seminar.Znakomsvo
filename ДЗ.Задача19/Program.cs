// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите число.");
int N=int.Parse(Console.ReadLine()!);
if(N/10000==N%10)
{
    if((N%10000-N%1000)/1000==(N%100-N%10)/10)
    {
        if((N%1000-N%100)/100==(N%1000-N%100)/100){Console.WriteLine("Является палиндромом.");}
        else{Console.WriteLine("Не является палиндромом.c");}
    }
    else{Console.WriteLine("Не является палиндромом.b");}
}
else{Console.WriteLine("Не является палиндромом.a");}