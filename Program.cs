﻿using System;

class Program
{
    static void Main()
    {
        // Asking the user to input a real number
        Console.Write("Please enter a real number: ");
        double x = double.Parse(Console.ReadLine());

        // Defining the intervals
        double interval1 = 2;
        double interval1End = 3;
        double interval2 = 0;
        double interval2End = 1;
        double interval3 = -10;
        double interval3End = -2;

        // Testing the membership using only < and ==
        bool condition1 = (x >= interval1) && (x < interval1End);
        bool condition2 = (x > interval2) && (x <= interval2End);
        bool condition3 = (x >= interval3) && (x <= interval3End);

        // Displaying the result based on logical operators
        if (((condition1 || condition2) || (condition3)))
        {
            Console.WriteLine("x belongs to I");
        }
        else
        {
            Console.WriteLine("x does not belong to I");
        }
    }
}