// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.Clear();
int [] result=Massiv(20,0,100);
PrintArray(result);
Console.WriteLine($"Разница max и min числа = {Raznica(result)}");

int Raznica(int[]array)
{
    int max=0;
    int min=0;
    foreach(int el in array)
    {
        if(max<el)
        {
            max=el;
        }
    }
    min=max;
    foreach(int el in array)
    {
        if(min>el)
        {
            min=el;
        }
    }
    int sum=max-min;
    Console.WriteLine($"min={min},max={max}");
    return sum;
}
int [] Massiv(int size, int minValue, int maxValue)
{
    int[] res= new int[size];
    for(int i=0; i<size;i++)
    {
        res[i]=new Random().Next(minValue, maxValue+1);
    }
    return res;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}