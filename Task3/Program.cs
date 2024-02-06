// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// // Напишите программу, которая принимает на вход
// // трёхзначное целое число и на выходе показывает сумму
// // первой и последней цифры этого числа.
// // 456 => 10
// // 782 => 9
// // 918 => 17

System.Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    System.Console.WriteLine(leftDigit + rightDigit);
}
else
{
    System.Console.WriteLine("Вы ввели не трёхзначное число!");
}