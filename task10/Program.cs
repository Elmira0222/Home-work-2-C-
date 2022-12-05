/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1   */

Console.Write("Enter three digit number: ");
int A = int.Parse(Console.ReadLine()!);

if (A > 99 & A < 1000)
{
    int B = A%100;
    int C = B/10;
    Console.WriteLine("Second digit in the number --> " + C);
}
else
{
    Console.WriteLine("It is not a three digit number");
}
