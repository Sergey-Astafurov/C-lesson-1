//№6 Напишите программу, которая на вход принимает число и выдаёт, является ли числочётным (делится ли оно на два без остатка).


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



