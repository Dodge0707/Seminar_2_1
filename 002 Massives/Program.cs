int[] numbers = new int [5];

FillArray(numbers);
int sum = Sum(4, 6);


void FillArray(int[] array)
{
    int index = 0;
    while(index < array.Length)
    {
        array[index] = new Random().Next(0, 100);
        index++;
    }
} 


ТипвозвращаемогоЗнач Название(аргументы)
{
    тело
}

int Sum(int a, int b)
{
    return a + b;
}