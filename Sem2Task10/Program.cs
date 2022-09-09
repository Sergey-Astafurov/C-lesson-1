//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Task10()
{
   System.Random numberGenerator = new System.Random();
   int number = numberGenerator.Next(100, 1000);
   Console.WriteLine(number);
   char[] charArray = number.ToString().ToCharArray();
   Console.WriteLine(charArray[1]);


}
Task10();