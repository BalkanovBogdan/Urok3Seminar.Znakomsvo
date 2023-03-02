// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.Clear();
int [] stArray= RandomMas(10,100,1000);
PrintArray(stArray);
Console.WriteLine($"Колличество четных чисел ={Koll(stArray)}");

int [] RandomMas(int size, int minValue, int maxValue)
{
    int [] res= new int [size];
    for( int i=0;i<size;i++)
    {
        res[i]=new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int Koll(int [] array)
{
    int count=0;
    foreach(int el in array)
    {
       if(el%2==0)count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}