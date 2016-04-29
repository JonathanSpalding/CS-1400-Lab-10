// Author: Jonathan Spalding
// Assignment: Lab 10
// Instructor Roger deBry
// Clas: CS 1400
// Date Written: 2/9/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using static System.Console;

namespace Lab10
{
    class Program
    {
            // The static void Main Method
            // Purpose: ask the user to input the length of two sides of a triangle, then call back a method that finds the hypotenuse of 
            // Parameters: none
            // Returns: none
            static void Main()
            {
            //Ask the user to enter the length of one side of a right triangle.
            WriteLine("Please enter the length of one of one side of a right triangle: ");
            //Get the user's input and saves it in an appropriate variable.
            double side1 = double.Parse(ReadLine());
            //Ask the user to enter the length of the other side of the triangle.
            WriteLine("Please enter the length of the other side of the triangle: ");
            //Get the user's input and saves it in an appropriate variable.
            double side2 = double.Parse(ReadLine());
            //Call your CalcHypotenuse method and pass in the lengths of the two sides of the triangle as parameters and save the value returned by the method in an appropriate variable.
            double total = CalcHypotenuse(side1, side2);
            //Properly label and display the value returned by the method.
            WriteLine($"The hypotenuse of your triangle is: {total}");
            //wait for user to press a key before ending the program. (This allows the output to be displayed without executing the program early.
            ReadKey(true);

            }
        // The CalcHypotenuse Method
        // Purpose: multiply the square root of two sides to find the Hypotenuse
        // Parameters: side1, side2
        // Returns: hypotenuse
        static double CalcHypotenuse(double side1, double side2)
        {
            //find the hypotenuse by adding the square root of side one and side 2.
            double hypotenuse = Math.Sqrt(side1 * side1 + side2 * side2);
            //return the hypotenuse.
            return hypotenuse;
        }
    }
}
