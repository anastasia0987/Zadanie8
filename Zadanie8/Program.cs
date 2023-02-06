using System;

var array = new int[] { 0, -1, -2, 3, -4, 5, -6, 7, 8, -9 };
Console.WriteLine(array.Count(e => e > 0) <= 5 ? "Верно" : "Не верно");
