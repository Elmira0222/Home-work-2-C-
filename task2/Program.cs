﻿/* Напишите программу, которая выводит случайное трехзначное число
 и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98 */

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;
Console.WriteLine($"number:{a1 * 10 + a2}");
