/* System.Console.Write("--> ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= a; i++)
{
    sum = sum + i; // sum += i;
}

//string str = "Sum = " + sum;
Console.WriteLine(str);
Console.WriteLine("sum = " + sum); */

/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

/* Console.WriteLine("Input number");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0; /// int a = rnd.Next(1, 100000);

    while (a > 0)
    {
        a = a / 10;
        count++;
    }
   
    Console.WriteLine($"Количество цифр = " + count); */


/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

/* System.Console.Write("--> ");
int N = Convert.ToInt32(Console.ReadLine());


int proiz = 1;
for (int i = 1; i <= N; i++)
{
    proiz = proiz * i; 
}

Console.WriteLine("proiz = " + proiz); */ 


/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

int [] Array8 = new int [8];

Random rand = new Random();
    for (int x = 0; x < Array8.Length; x++)
    {
        Array8[x] = rand.Next(2); //Next [0,1]
        Console.Write(Array8[x]);
        
    }