//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


System.Console.WriteLine("Введите Ваше пятизначное число : ");
int[] array = { 0, 0, 0, 0, 0 };
System.Console.WriteLine("Вводите число по одной цифре.Введите первую цифру пятизначного числа : ");
int elem1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Вводите число по одной цифре.Введите вторую цифру пятизначного числа : ");
int elem2 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Вводите число по одной цифре.Введите третью цифру пятизначного числа : ");
int elem3 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Вводите число по одной цифре.Введите четвертую цифру пятизначного числа : ");
int elem4 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Вводите число по одной цифре.Введите пятую цифру пятизначного числа : ");
int elem5 = Convert.ToInt32(System.Console.ReadLine());
array[0] = elem1;
array[1] = elem2;
array[2] = elem3;
array[3] = elem4;
array[4] = elem5;

if (array[0] == array[4] && array[1] == array[3])   // Не знаю как решить иначе, можно через строки(гораздо меньше кода), но Вы запретили решать через строки.
{
    System.Console.WriteLine("Это палиндром");
}
else
{
    System.Console.WriteLine("Это не палиндром");
}




//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


System.Console.WriteLine("Введите координаты первой точки в 3D пространстве : ");
int x1 = Convert.ToInt32(System.Console.ReadLine());
int y1 = Convert.ToInt32(System.Console.ReadLine());
int z1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки в 3D пространстве : ");
int x2 = Convert.ToInt32(System.Console.ReadLine());
int y2 = Convert.ToInt32(System.Console.ReadLine());
int z2 = Convert.ToInt32(System.Console.ReadLine());

double L = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
double result = Math.Round(L, 2);
System.Console.WriteLine($"Расстояние между точками = {result}");



//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


System.Console.WriteLine("Введите Ваше число: ");
int N = Convert.ToInt32(Console.ReadLine());
double count = 1;
double result1 = 1;
while (count <= N)
{
    result1 = Math.Pow(count,3);
    System.Console.WriteLine($" Число -> {result1}");
    count++;
}
