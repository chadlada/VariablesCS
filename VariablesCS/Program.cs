using System;
using System.Collections.Generic;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many cups of coffee do I drink each day?");

            // Create a variable (use your best judgment for type) that stores the numberOfCupsOfCoffee that you drink every day.
            var numberOfCupsOfCoffee = 3;

            // Create a variable (use your best judgment for type) called fullName and set it equal to your full name.
            var fullname = "Chad Lada";

            // Create a variable (use your best judgment for type) called today and set it equal to today's date.
            var today = DateTime.Now;

            // Use Console.WriteLine and your variables, numberOfCupsOfCoffee, fullName, and today, to output all three on one line.
            Console.WriteLine(numberOfCupsOfCoffee + fullname + today);

            // Practice Getting Input From the User

            // Ask the user for their name and store it in a variable named userName.
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            if (userName == "alice")
            {
                Console.Write("Welcome to the twighlight zone alice !");
            }



            var message = $"Wow, {userName} is such a beautiful name!";
            Console.WriteLine(message);

            // Practice Getting Different Types of Input From the User

            // Ask the user to input two numbers.
            // Get the numbers as strings using Console.ReadLine, store them in variables named firstNumberAsString and secondNumberAsString

            // Convert each string above to a double using double.Parse. Save the first value in a variable named firstOperand and the second value in a variable named secondOperand.

            Console.Write("Enter a number: ");
            string firstNumberAsString = Console.ReadLine();
            double firstOperand = Convert.ToDouble(firstNumberAsString);

            Console.Write("Enter a second number: ");
            string secondNumberAsString = Console.ReadLine();
            double secondOperand = Convert.ToDouble(secondNumberAsString);

            // Doing Math
            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            Console.WriteLine($"Here are the answers to your numbers!: {sum} {difference} {product} {quotient} {remainder} ");






        }
    }
}
