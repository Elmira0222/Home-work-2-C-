/* Напишите программу, которая принимает на вход 
число и проверяет, кратно ли оно одновременно 
7 и 23.
● 14 -> нет 
● 46 -> нет 
● 161 -> да */

Console.Write("Enter number  1: ");
int number1 = int.Parse(Console.ReadLine()!);
if (number1 % 7 == 0 & number1 % 23 == 0 )
{
    Console.WriteLine("yes");
}
else{
    Console.WriteLine("no");
}
    


