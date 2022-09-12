//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/* Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
while(num<9999 || num>100000)
{
    Console.WriteLine("Вы ввели не пятизначное число, введите пятизначное число");
    num = int.Parse(Console.ReadLine());
}
int a1 = num/10000;
int a2 = num%10;
int b1 = (num/1000)%10;
int b2 = (num%100)/10;
if (a1==a2 && b1==b2)
{
    Console.WriteLine(num+ "-> да");
}
else 
{
    Console.WriteLine(num+"-> нет");
} */


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/* Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z1");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z2");
int z2 = int.Parse(Console.ReadLine());
Console.WriteLine(Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)));
  */


  //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

  Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
Console.Write(n+"-> ");
n = Math.Abs(n);

for (int i=1; i<=n; i++)
{
Console.Write(Math.Pow(i,3)+" ");
}