﻿// Опишем функцию
int Max(int arg1, int arg2, int arg3) 
// Обозвали функцию Max, в скобках возвращаемый элемент
{
    int result = arg1;
    // Определяем внутренний result, где будет хранится значния максимального
    if(arg2 > result) result = arg2;
    // Добавляем условие замены максимального числа в result
    if(arg3 > result) result = arg3;
    // Повторяем для третьей строчки кода
    return result;
    // Возвращаем итоговый result
}

int a1 = 15;
int b1 = 21;
int c1 = 85;
int a2 = 12;
int b2 = 923;
int c2 = 13;
int a3 = 8;
int b3 = 85;
int c3 = 33;

// Вариант простого решения 
// int max = a1;

// if(b1 > max) max = b1;
// if(c1 > max) max = c1;

// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;

// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;

// Console.WriteLine(max);



// Вариант решения с функцией
// int max1 = Max(a1, b1, c1);
// // Создаём новую переменную max1 для определения трёх финалистов, т.е. результатом
// // работы функции Max будет являться максимальное из трёх чисел a1, b1 и c1
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// // Повторяем для остальных чисел
// int max = Max(max1, max2, max3);
// // Создаём ещё одну новую переменную, которая примет финалистов и найдёт max среди них
// Console.WriteLine(max);



// Всё можно упростить так
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);






