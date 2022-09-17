int[] array = {1, 2, 4, 33, 53, 67, 4, 99};

int n = array.Length; // длина массива
int findNumber = 4;

int index = 0;

while (index < n)
{  
    if (array[index] == findNumber)
    {
        Console.WriteLine(index);
        break; // найдем только первое вхождение элемента
    }
    index += 1;
}