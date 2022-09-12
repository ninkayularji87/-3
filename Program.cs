//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
while(num<9999 || num>100000)
{
    Console.WriteLine("Введите пятизначное число");
    num = int.Parse(Console.ReadLine());
}
int a1 = num/1000;
int a2 = num%10;
int b1 = (num/100)%10;
int b2 = (num%100)/10;
if (a1==a2 && b1==b2)
{
    Console.WriteLine(num+ "-> да");
}
else 
{
    Console.WriteLine(num+"-> нет");
}