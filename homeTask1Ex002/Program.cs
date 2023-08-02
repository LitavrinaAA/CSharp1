//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите три числа, а я найду самое большое.");
Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondtNum = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNum = int.Parse(Console.ReadLine());
int max = firstNum;
if (secondtNum > max)
    max = secondtNum;
if (thirdNum > max)
    max = thirdNum;

 Console.WriteLine("Самое большое число:" + max);

