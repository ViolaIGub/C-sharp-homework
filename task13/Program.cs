// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет

Console.WriteLine("Введите любое число");
string inputString = Console.ReadLine();
string inputString = Convert.ToString(Number);

if (inputString.Length > 2)
{
    Console.WriteLine(inputString[2] + " - искомое значение");
}
else
{
    Console.WriteLine("третья цифра отсутствует");
}
