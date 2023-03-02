// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

Console.Clear();
Console.Write("Ведите данные массива через пробел: ");
string elements=Console.ReadLine()!;
int[] baseArray=GetARRAYfromString(elements!);
Console.Write("Введите число: ");
int n=int.Parse(Console.ReadLine()!);
if(FindElements(baseArray, n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}



bool FindElements(int[]array, int el)
{
    foreach( var item in array)
    {
        if(el==item) return true;
    }
    return false;
}

 int [] GetARRAYfromString(string stringArray)//Новая фигня
 {
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);//!!!!!!!!!!!
    int[] res =new int [nums.Length];
    for( int i=0; i< nums.Length; i++)
    {
        res[i]=int.Parse(nums[i]);
    }
    return res;
 }