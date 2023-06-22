int inputNumber(string message) 
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void getSum(int number)
{
    int sum = 0;
    while (number != 0)
    {
        int result = number % 10;
        sum = sum + result;
        number = number / 10;
    }
    Console.WriteLine("Сумма цифр в числе: " + sum);
}

int number = inputNumber("Введите, пожалуйста, целое число");
getSum(number);
