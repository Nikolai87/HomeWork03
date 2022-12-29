// Напишите программу, которая на вход принимает пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("введите пятизначное число: ");
string number = Console.ReadLine();

if (number[0] == number[4] && number[1] == number[3]) 
{ 
    Console.WriteLine("это палиндром");
}
else
{
    Console.WriteLine("это не палиндром");
}
