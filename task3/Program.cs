/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно                */

Console.Write("Enter number 1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter number 2: ");
int number2 = int.Parse(Console.ReadLine()!);
if (number1 % number2 == 0)
{
    Console.WriteLine("kratno");
}
else
{
    int number3 = number1 % number2;
    Console.WriteLine("ne kratno: " + number3);
}


