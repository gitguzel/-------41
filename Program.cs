﻿//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите числа");

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count = arr.Count(x => x > 0);

Console.WriteLine($"Кол-во элементов > 0: {count}");