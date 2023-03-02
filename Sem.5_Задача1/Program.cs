// Задайте массив из 12 элементов,заполнеными случайными числами из промежутка [-9,9].
//Найдите сумму отрицательных и положительных элементов массива.




int[]array = GetArray(12,-9,9);
Console.WriteLine(String.Join(", ",array));
int positiveSum=0;
int negativeSum=0;
foreach(int el in array)
{
    positiveSum+=el>0? el:0;
    negativeSum+=el<0? el:0;
}
int[] GetArray(int Length,int minValue,int maxValue)
{
    int[]array=new int[Length];
    //Random random=new Random ();
    for(int i=0;i<Length; i++)
    {
        array[i]=new Random().Next(minValue,maxValue+1);
    }
    return array;
}
Console.WriteLine($"Positive sum ={positiveSum}, negative sum = {negativeSum}");






/*void FillArray(int[]nnn)
{
    int length=nnn.Length;
    int index=0;
    while(index<length)
    {
        nnn[index]=new Random().Next(-9,9);
        index++;
    }

}

//void PrintArray(int[]nn)
{
    int cout=nn.Length;
    int i=0;
    while(i<cout)
    {
        Console.Write(nn[i]);
        i++;
    }
}

//int[] array =new int[12];
//FillArray(array);
//PrintArray(array);
*/