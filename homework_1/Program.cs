// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("Введите числа: ");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);

if (number1 != number2) 
{
    if (number1 < number2) 
    {
        Console.WriteLine($"Наибольшее число: {number2}, наименьшее число: {number1}");
    } 
    else
    {
        Console.WriteLine($"Наибольшее число: {number1}, наименьшее число: {number2}");
    }
}
else
{
    Console.WriteLine("Числа равны");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Введите числа: ");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
int number3 = int.Parse(Console.ReadLine()!);

int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine($"Наибольшее число: {max}");

*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число: ");
int n1 = int.Parse(Console.ReadLine()!);

if((n1%2 == 1) || (n1%2 == -1)) 
{
    Console.WriteLine("нечетное");
}
else 
    Console.WriteLine("четное");
    
*/
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int n1 = int.Parse(Console.ReadLine()!);
int i = 1;

while (i <= n1)
{
    if (i%2 == 0) Console.Write($"{i} ");
    i++;
}