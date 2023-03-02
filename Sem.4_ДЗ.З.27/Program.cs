// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
int number=Prompt("Введите:");
Console.WriteLine($"Сумма всех чисел в цифре{number}={Suma(number)}");//!!!

int Prompt (string message)
{
Console.Clear();
Console.WriteLine("Введите число.");
int r = int.Parse(Console.ReadLine()!);
return r;
}
int Suma(int number)
{
    int r=0;
    while(number>0)
    {
        r+=number%10;
        number=number/10;
    }
    return r;
}
