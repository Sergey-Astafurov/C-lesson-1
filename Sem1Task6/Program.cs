//№4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

string? inputLine = Console.ReadLine(); //Ввод числа
if (inputLine != null) //Проверка чтобы поле было заполнено
{
   int inputNumber = int.Parse(inputLine); //перевод строки в число
   if (inputNumber % 2 == 0)
   { // применяем остаток от деления
      Console.WriteLine("чётное");
   }
   else
   {
      Console.WriteLine("нечётное");
   }
}



