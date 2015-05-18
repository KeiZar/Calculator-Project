using System;
using System.IO;


class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the digits and operations:");
        string[] input = Console.ReadLine().Split(' ');
        int firstNumber = int.Parse(input[0]);
        int secondNumber = int.Parse(input[2]);
        int result = 0;

        while (input[0] != "End")
        {
            switch (input[1])
            {
                case "+":
                {
                    result = firstNumber + secondNumber;
                    break;
                }
                case "-":
                {
                    result = firstNumber - secondNumber;
                    break;
                }
                case "*":
                {
                    result = firstNumber*secondNumber;
                    break;
                }
                case "/":
                {
                    result = firstNumber/secondNumber;
                    break;
                }

            }
            Console.WriteLine(result);
            Console.Write("Please enter new digits or end program with 'End':");
            input = Console.ReadLine().Split(' ');
            firstNumber = int.Parse(input[0]);
            secondNumber = int.Parse(input[2]);
        }
    }
}

