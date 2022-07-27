// Заполняем массив случайными числами
void FillArray(int[] collection)
{
    // Задаём длину массива
    int length = collection.Length;
    // Задаём позицию старта
    int index = 0;
    // Задаём условие
    while (index < length)
    {
        // Обращаемся к аргументу collection на позицию index и положим новое случайное число из диапазона
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

// Задаём вывод массива с новым именем
void PrintArray(int[] col)
{
    // Задаём длину массива
    int count = col.Length;
    // Задаём позицию старта
    int position = 0;
    // Задаём условие
    while (position < count)
    {
        // Выводим значение текущего элемента
        Console.WriteLine(col[position]);
        position++;
    }
}

// Добавляем в решение метод return
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    // Если элемента нет, возвращаем позицию -1 - универсальный ответ в C#
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    // Возвращаем итоговую позицию элемента
    return position;
}

// new int[x] - создание нового массива с количеством х-элементов
int[] array = new int[10];

FillArray(array);
PrintArray(array);
// Добавим пустую строчку для визуального отделения ответов
Console.WriteLine();

// Определим новую переменную и в неё положим результат работы метода IndexOf
int pos = IndexOf(array, 4);
Console.WriteLine(pos);

