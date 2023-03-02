// Задайте одномерный массив из 123 случайных чисел.
// Найдите количеств элементов массива, значение которых лежат в отрезке от 10 до 150.
Console.Clear();
int[] stRandom123 = Random123(123,1,150);
endRandom123(stRandom123,10,20);
int[] Random123(int size, int minValue, int maxValue)
{
    int[] res= new int[size];
    for(int i=0;i<size;i++)
    {
        res[i]=new Random().Next(minValue,maxValue+1);
    }
    return res;
}

int endRandom123(int[]array,int min, int max)///!!!
{
    int Koll=0;
    foreach(int el in array )
    {
        if(el>=min && el<=max) Koll++; 
    }
    return Koll;
}
Console.WriteLine($"Подходящие количество чисел={endRandom123(stRandom123,10,20)}");////!!!