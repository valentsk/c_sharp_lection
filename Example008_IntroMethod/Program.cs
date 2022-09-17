int Max(int arg1, int arg2, int arg3) // поиск максимума из трех чисел
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int number1 = 1;
int number2 = 2;
int number3 = 3;
int number4 = 4;
int number5 = 5;
int number6 = 6;
int number7 = 7;
int number8 = 8;
int number9 = 9;

// int max1 = Max(number1, number2, number3);
// int max2 = Max(number4, number5, number6);
// int max3 = Max(number7, number8, number9);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(number1, number2, number3), 
    Max(number4, number5, number6), 
    Max(number7, number8, number9));

// if (number2 > max) max = number2;
// if (number3 > max) max = number3;
// if (number4 > max) max = number4;
// if (number5 > max) max = number5;
// if (number6 > max) max = number6;
// if (number7 > max) max = number7;
// if (number8 > max) max = number8;
// if (number9 > max) max = number9;

Console.Write(max);