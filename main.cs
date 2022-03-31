// Created by: Marshall Demars
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double heightRhombus;
        double baseRhombus;
        double area;

        // input
        Console.WriteLine("This program finds the area of a rhombus.");
        Console.WriteLine("");
        Console.WriteLine("the formula is: b x h");
        Console.WriteLine("");
        Console.WriteLine("please enter the measurements (cm)");
        Console.WriteLine("");

        Console.Write("Input the measurement for the base : ");
        baseRhombus = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the measurement for the height: ");
        heightRhombus = Convert.ToDouble(Console.ReadLine());

        // process
        area = baseRhombus * heightRhombus;

        // output
        Console.WriteLine("");
        Console.WriteLine("The area of the rhombus is, " + area.ToString("0.00") + " cm²");
        Console.WriteLine("\nDone.");
    }
}
