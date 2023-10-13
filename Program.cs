Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber > secondNumber)
{
    Console.WriteLine($"Первое число {firstNumber} больше чем второе число {secondNumber}");
}
if(firstNumber < secondNumber)
{
    Console.WriteLine($"Первое число {firstNumber} меньше чем второе число {secondNumber}");
}
if(firstNumber == secondNumber)
{
    Console.WriteLine($"Первое и второе число равны {firstNumber}");
}