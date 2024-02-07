// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        if (firstNumber == secondNumber)
        {Console.Write ("Числа равны");}
        else
            {
                if (firstNumber > secondNumber)
                {Console.Write ("Первое число больше");}
                else
                {Console.Write ("второе число больше");}
            }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 3;
            secondNumber = 3;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}