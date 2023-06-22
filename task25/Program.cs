int inputNumber(string message) 
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;

}

void IntPow(int numA, int numB)
{
    double result = Math.Pow(numA, numB);
    Console.WriteLine($"{result:f0}");
}

int numA = inputNumber("Введите, пожалуйста, первое число");
int numB = inputNumber("Введите, пожалуйста, второе число");
IntPow(numA, numB);
