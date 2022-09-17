void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// collect, count, position - показывает, что это те же аргументы, но можем называть их по-разному.
void PrintArray(int[] collect)
{
    int count = collect.Length;
    int position = -1; // искуственно делаем -1, чтобы интерпретировать, что данного элемента не найдено
    while (position < count)
    {
        Console.WriteLine(collect[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10]; 
// определили массив из 10 элементов, заполненных нулями

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.Write(pos);