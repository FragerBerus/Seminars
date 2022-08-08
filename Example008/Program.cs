// Задача 8: 
// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
int count = 1;
Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Ряд четных чисел в диапазоне от 1 до " + number);
while (count <= number)
    {       
        if (count % 2 == 0)
        {
            Console.WriteLine(count);
        }
        count ++;        
    }