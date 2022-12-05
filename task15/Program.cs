/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Write("Enter a number for the day of the week : ");
int A = int.Parse(Console.ReadLine()!);
if (A > 7 || A < 1)
{
    Console.WriteLine("There is no such day of the week");
}
else
{
    if (A == 6 || A == 7)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}