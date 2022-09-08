// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число");
string inputString = Console.ReadLine();
if (inputString.Length ! = 3)
{
    int Number = int.Parse(inputString);
    Console.WriteLine(("Второе число: ") + (Number/10)%10);
}
else 
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
