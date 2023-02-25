// Напишите программу, которая по заданному номеру четверти,
// показывает диапозон возможных координат точек в этой четверти (X и Y).
Console.Clear();
Console.WriteLine("Введите номер четверти");
int N=int.Parse(Console.ReadLine()!);
if(N==1){Console.WriteLine("x>0,y>0");}
else if(N==2){Console.WriteLine("x<0,y>0");}
else if(N==3){Console.WriteLine("x<0,y<0");}
else if(N==4){Console.WriteLine("x>0,y<0");}
else if(N>4 || N<1){Console.WriteLine("Введенно не верное значение");}