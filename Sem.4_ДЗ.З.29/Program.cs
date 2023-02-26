// Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

int Prompt(string message)
{
    Console.Write("Привет");
    string ReadInput=Console.ReadLine()!;
    int result=int.Parse(ReadInput);
    return result;
}
int[] GenerateArray (int Length,int minValue,int maxValue)
{
    int[]array=new int[Length];
    Random random=new Random ();
    for(int i=0;i<Length; i++)
    {
        array[i]=random.Next(minValue,maxValue+1);
    }
}
void PrintArray(int[]array)
{
    Console.Write("[");
    for(int i=0;i<array.Length-1;i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}
int length=Prompt("Длина массива");
int min=Prompt("Начальное значание,для диапазона случайного числа:");
int max=Prompt("Конечное значание,для диапазона случайного числа:");
int []array=GenerateArray(length,min,max);
PrintArray(array);