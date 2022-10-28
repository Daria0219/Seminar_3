/*void PrintArray (int[] arr)
{   int count = arr.Length;
    int pos=0;
    while (pos<count)
    {Console.WriteLine(arr[pos]);
     pos++;}
}*/

// 1. программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

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

