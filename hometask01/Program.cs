// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = int.Parse(Console.ReadLine());


int result = number / 10 % 10;

Console.WriteLine(result);