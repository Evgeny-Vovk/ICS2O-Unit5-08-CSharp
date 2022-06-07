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
        int number;
        var answer = 0;

        // input
        Console.Write("\nThis program multiplies two numbers using a loop system. ");
        Console.WriteLine("");
        Console.Write("\nInput the number: ");
        number = Convert.ToInt32(Console.ReadLine());

        // process
        Console.WriteLine("");
        for (int repeat = 0; repeat <= number; repeat++)
        {
            answer += repeat;
        }
        Console.WriteLine("The answer is " + answer + ".");
        Console.WriteLine("\nDone.");
    }
}