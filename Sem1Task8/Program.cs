﻿//№8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

string? inputLine = Console.ReadLine(); //Ввод числа
if (inputLine != null) //Проверка чтобы поле было заполнено
{
   int inputNumber = int.Parse(inputLine); //перевод строки в число
   for (int i = 1; i < inputNumber; i++) //ставим счетчик начиная с единицы, а не с нуля
   {
      if (i % 2 == 0)
      { // если число счётчика делится на 2 без остатка, то выводим его
         Console.WriteLine(i);
      }
   }
}


