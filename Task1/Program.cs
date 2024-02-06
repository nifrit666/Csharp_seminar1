// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

Console.Write("Введите первое число: "); // Просим пользователя ввести число
int number1 = Convert.ToInt32(Console.ReadLine()); // Принимаем число от пользователя и сохраняем в переменную number1

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2) // 25 == 5 * 5
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}