//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Task13()
{
   string? number = Console.ReadLine();
   char[] charArray = number.ToCharArray();
   if (charArray.Length < 3)
   {
      Console.WriteLine("Третьей цифры нет");
   }
   else
   {
      Console.WriteLine(charArray[2]);
   }
}
Task13();