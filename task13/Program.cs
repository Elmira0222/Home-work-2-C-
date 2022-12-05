/* Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Enter three digit number: ");
int A = int.Parse(Console.ReadLine()!);
if (A < 100 & A > -100)
{
    Console.WriteLine("No third digit");
}
else
{
    while (A > 1000 || A < -1000)
    {
        int N = A / 10;
        A = N;
    }
    int B = A % 10;
    if (B < 0)
    {
        B = B * -1;
    }
    Console.WriteLine("Third digit --> " + B);
}