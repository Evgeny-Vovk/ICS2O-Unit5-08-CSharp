// Created by: Evgeny Vovk
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program calculate which movie rate can you watch
        int firstInput;
        int secondInput;
        int repeat;
        int fullNumber = 0;

        // input
        Console.Write("\nThis program divides two numbers and shows the reminder using a loop system. ");
        Console.WriteLine("");
        Console.Write("\nInput the first number: ");
        firstInput = Convert.ToInt32(Console.ReadLine());
        repeat = firstInput;
        Console.Write("\nInput the number you want to divide it by: ");
        secondInput = Convert.ToInt32(Console.ReadLine());

        // process
        if ((firstInput > 0) && (secondInput > 0))
        {
            while (repeat >= secondInput)
            {
                repeat = repeat - secondInput;
                ++fullNumber;
            }
        }
        else if ((firstInput < 0) && (secondInput < 0))
        {
            while (Math.Abs(repeat) >= Math.Abs(secondInput))
            {
                repeat = Math.Abs(repeat) - Math.Abs(secondInput);
                ++fullNumber;
            }
            repeat = repeat * -1;
        }
        else if ((firstInput < 0) || (secondInput < 0))
        {
            while (Math.Abs(repeat) >= Math.Abs(secondInput))
            {
                repeat = Math.Abs(repeat) - Math.Abs(secondInput);
                ++fullNumber;
            }
            fullNumber = fullNumber * -1;
            repeat = repeat * -1;
        }
        Console.WriteLine("\n\nThe full number is " + fullNumber + " and the reminder is " + repeat + ".");
        Console.WriteLine("\nDone.");
    }
}