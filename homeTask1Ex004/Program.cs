﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите число, а я найду все четные от 1 до него.");
Console.Write("Введите число: ");
int numN = int.Parse(Console.ReadLine());
int count = 2;
while (count <= numN){
    Console.Write(count + ",");
    count = count + 2;
}
