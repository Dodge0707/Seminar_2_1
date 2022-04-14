int sum = Sum(15, 62);
Print(Convert.ToString(sum));
int[] numbers = {5, 7, 8};
int[] numbers2 = new int [5];
int[] numbers3 = {};
int[] numbers4;


int number = 0; // пустое инт
string str = ""; // пустой стринг - строка

int Sum(int numberOne, int numberTwo)
{
    int sum = numberOne + numberTwo;
    return sum;
}

void Print(string argument)
{
    Console.WriteLine(argument);
}