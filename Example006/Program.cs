// Задача 6:
// Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
Console.Write("Введите целое число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0)
{
    Console.WriteLine("Число " + Number + " четное");
}
else
{
    Console.WriteLine("Число " + Number + " нечетное");
}