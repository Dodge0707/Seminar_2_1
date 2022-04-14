Console.Write("Введите первое число: ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberB = Convert.ToDouble(Console.ReadLine());
Proverka(numberA, numberB);


void Proverka(double numberA, double numberB)
{

if (numberB < numberA)
{
    Console.WriteLine("Ошибка! Второе число меньше первого!");
}
else
{
    double result = numberB % numberA;
if (result == 0)
{
    Console.WriteLine("Число " + numberB + " кратно числу " + numberA);
}
else 
{
    Console.WriteLine("Остаток от деление равно: " + result);
} 
}
}
