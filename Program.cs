/*void PrintArray (int[] arr)
{   int count = arr.Length;
    int pos=0;
    while (pos<count)
    {Console.WriteLine(arr[pos]);
     pos++;}
}*/

/* 1. программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

void Palindrom(int number){
int firstN = number/10000;
int SecondN = (number/1000)%10;
int forthN = (number/10)%10;
int fifthN = number%10;
if (firstN==fifthN && SecondN==forthN) Console.WriteLine("да, это палиндром");
else Console.WriteLine("это не палиндром");
}
Console.WriteLine("Введите пятизначное число");
int N = int.Parse(Console.ReadLine());
Palindrom(N);
*/

// 2. программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double Distance(int x1, int y1, int z1, int x2, int y2, int z2){
double dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
return dist;}
Console.WriteLine("Введите координаты точки А");
int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int Z = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
double otvet = Distance(X,Y,Z,A,B,C);
Console.WriteLine(otvet);

