// Задача 4:
// Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
    {
        if (firstNumber > thirdNumber)
        {
            Console.WriteLine("Максимальное число " + firstNumber);
        }
        else
        {
            Console.WriteLine("Максимальное число " + thirdNumber);
        }
    }
    else
    {
        if (secondNumber > thirdNumber)
        {
            Console.WriteLine("Максимальное число " + secondNumber);
        }
        else
        {
            Console.WriteLine("Максимальное число " + thirdNumber);
        }
    }