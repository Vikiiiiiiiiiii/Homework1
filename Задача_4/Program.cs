/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("number_a");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("number_b");
int number_b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("number_с");
int number_с = Convert.ToInt32(Console.ReadLine());

int max = number_a;

if (number_b > max)
{
    max = number_b;
}
if (number_с > max)
{
    max = number_с;
}
Console.WriteLine("наибольшее число" + max);


