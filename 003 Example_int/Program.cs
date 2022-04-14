int number = new Random().Next(10, 100);
int first = number / 10;
int second = number % 10;
Console.WriteLine(number);

int max = MaxNumber(first, second);
Console.WriteLine(max);

 int RandomInt(int min, int max)
 {
     return new Random().Next(min, max);
 }

 
int MaxNumber(int number1, int number2)
{
   
    if(number1 > number2)
        return number1;
    
    return number2;
}