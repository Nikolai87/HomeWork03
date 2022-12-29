// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.

Console.Write("введите число: ");
int n = int.Parse(Console.ReadLine());
int count = 1;

while (count <= n)
{
    Console.WriteLine(Math.Pow(count, 3));   
    count ++;
}
