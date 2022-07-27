// Опишем функцию
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

// Задаём массив с помощью <системаЧисел [] имяМассива = {элементыМассива};>
// Индексы      0   1   2   3   4   5   6   7   8
int[] array = { 11, 25, 68, 47, 46, 14, 78, 98, 31 };
// Добавляем обращение к конкретному элементу, плюс присвоение 0-му элементу нового значения
// array[0] = 12;
// Console.WriteLine(array[2]);

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );

Console.WriteLine(result);


// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
// Console.WriteLine(max);






