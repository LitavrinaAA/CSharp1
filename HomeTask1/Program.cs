// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Я принимаю два числа и выдю, какое число большее, а какое меньшее.");
Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine());
if (firstNum > secondNum){
    Console.WriteLine("Самое большое первое число " + firstNum 
                + ", а самое маленькое второе " + secondNum);
}
else {
    Console.WriteLine("Самое большоес второе число " + secondNum 
                + ", а самое маленькое первое " + firstNum);  
}
