// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
     int startNumber = 1;
while(startNumber <= number)
    {
        if(startNumber % 2 ==0)
        Console.Write(startNumber + " ");
        startNumber ++;
    }

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 8;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}