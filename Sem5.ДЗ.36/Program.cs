// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Clear();
int [] aa= Massiv(20,-10,10);
PrintArray(aa);
SumElement(aa);
Console.WriteLine($"Сумма элументов нечетных индексов= {SumElement(aa)}");

int [] Massiv(int size, int minValue, int maxValue)
{
    int[] res= new int[size];
    for(int i=0; i<size;i++)
    {
        res[i]=new Random().Next(minValue, maxValue+1);
    }
    return res;
}
int SumElement (int[] array)
{
    int sum=0;
    for(int i=0;i<array.Length;i++)
    {
        if(i%2==1)
        {
            sum=sum+array[i];
        }
         
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}