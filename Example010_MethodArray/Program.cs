int[] array = { 13, 28, 143, 18, 84, 53, 602, 78, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        // Для случаев когда моэет быть несколько ответов. а нужен всего один, можно
        // воспользоваться прерыванием, как только будет найден первый
        break;
    }
    // index = index + 1;
    index++;
}


