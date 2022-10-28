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

/* 2. программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

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
*/

/* 3. программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел

void Cube(int num){
int ind=1;
while  (ind<num) {
    Console.Write($"{Math.Pow(ind,3)}, ");
    ind++;
}
Console.WriteLine(Math.Pow(num,3));
}
Console.WriteLine("Введите целое число N");
int N = int.Parse(Console.ReadLine());
Cube(N);
*/

/* дополнительное задание №1

void FillArr (int[] array)
{   int length = array.Length;
    int index = 0;
    while (index<length){
        int elementmassiva = int.Parse(Console.ReadLine());
        array[index]=elementmassiva;
        index++;}
}
Console.WriteLine("Введите число элементов массива");
int len = int.Parse(Console.ReadLine());
int[] massiv = new int [len];
Console.WriteLine("Введите массив столбцом");
FillArr(massiv);
Console.WriteLine("Введите номер позиции на удаление");
int N = int.Parse(Console.ReadLine());

void PrintArray (int[] arr)
{   int count = arr.Length;
    int pos=0;
    while (pos<count)
        {if (pos == (N-1)) pos++;
        else {Console.Write($"{arr[pos]} ");
        pos++;}}
}
PrintArray(massiv);
*/
// дополнительное задание №2

void FillArr (int[] array)
{   int length = array.Length;
    int index = 0;
    while (index<length){
        int elementmassiva = int.Parse(Console.ReadLine());
        array[index]=elementmassiva;
        index++;}
}
Console.WriteLine("Введите число элементов массива 1");
int len1 = int.Parse(Console.ReadLine());
int[] massiv1 = new int [len1];
Console.WriteLine("Введите массив 1 столбцом");
FillArr(massiv1);

Console.WriteLine();

Console.WriteLine("Введите число элементов массива 2");
int len2 = int.Parse(Console.ReadLine());
int[] massiv2 = new int [len2];
Console.WriteLine("Введите массив 2 столбцом");
FillArr(massiv2);

int len3 = len1 + len2;
int[] massiv3 = new int [len3];
int ind = 0;
    while (ind<len1){
        massiv3[ind] = massiv1[ind];
        ind++;}
int ind2 = len1;  
    while (ind2<len3){
        massiv3[ind2] = massiv2[ind2-len1];
        ind2++;}
Console.WriteLine();
Console.WriteLine("массив из двух массивов:");

void PrintArray (int[] arr)
{   int count = arr.Length;
    int pos=0;
    while (pos<count)
    {Console.WriteLine(arr[pos]);
     pos++;}
}
PrintArray(massiv3);

