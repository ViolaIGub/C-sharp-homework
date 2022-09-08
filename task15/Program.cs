// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным

Console.WriteLine("Введите число, обозначающее день недели, от 1 до 7");
int weekDay = int.Parse(Console.ReadLine());
if (weekDay == 6 || weekDay == 7)
{
    Console.WriteLine("Ура! Выходной");
}
else
{
    Console.WriteLine("Будний день");
}
