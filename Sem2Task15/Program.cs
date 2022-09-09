// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string? inputLine = Console.ReadLine();
int number = int.Parse(inputLine);
if (number > 7 || number < 0)
{
   Console.WriteLine("такого дня недели не существует");
}
else if (number == 6 || number == 7)
{
   Console.WriteLine("Да");
}
else
{
   Console.WriteLine("Нет");
}
