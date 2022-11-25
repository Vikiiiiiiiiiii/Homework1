/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/



Console.WriteLine("number_a");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("number_b");
int number_b = Convert.ToInt32(Console.ReadLine());

if (number_a > number_b) 
{
    Console.WriteLine("min число");
}
else
{
    Console.WriteLine("max число");
}

