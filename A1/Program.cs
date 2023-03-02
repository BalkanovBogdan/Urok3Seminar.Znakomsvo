// Дана последовательность натуральных чисел 1, 2, 3, ..., N. 
/*Необходимо сначала расположить в обратном порядке часть
 этой последовательности от элемента с номером A до элемента с номером B,
  а затем от C до D.*/

Console.WriteLine("Ведите число N:");
int N = int.Parse(Console.ReadLine());
int[] mas = Nmass(N);
PrintArray(mas);
ReversAB(mas, 2, 4);
PrintArray(mas);
ReversAB(mas, 6, 8);
PrintArray(mas);
int[] Nmass(int a)
{
    int[] result = new int[a];
    for (int i = 0; i < a; i++)
    {
        result[i] = i + 1;
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ReversAB(int[] array, int a, int b)
{
    for (int i = 0; i <= (b - a)/2; i++)
    {
        Console.WriteLine(i);
        int S = array[a + i];//1 +0 
        array[a + i] = array[b - i];//4 - 0
        array[b - i] = S;
    }
}