//Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и еденицами в случайном порядке.
int[]array = randomnumber(8);
//Console.WriteLine($"[{String.Join(",",array)}]");

for (int i=0;i<array.Length-1;i++)
{
    Console.Write($"{array[i]},");
}
int[]randomnumber(int size)
{
    int[]result=new int[size];
    for(int i=0;i<size;i++)
    {
        result[i]= new Random().Next(2);
    }
    return result;
}    