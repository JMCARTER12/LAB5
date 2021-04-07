// Grade ID: R8206
// Lab # 5
// Due date: March 1 ,2020
// Section # 01
// This program collects different temperatures from the user and shows the total and calculates the mean.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables
            int min = -20;
            int max = 130;
            int count = 0;
            double sum = 0;
            double mean =0;
            const int QUIT = 999;
            double Validtemp;
            string inputString;
            int total;
            
            Console.Write($"Enter Temperatures from {min} to {max}:  "); // Prompting user

            inputString = Console.ReadLine(); // converting user input
            Validtemp = Convert.ToDouble(inputString);

            while (Validtemp != QUIT) // Loop starts
            {
                if (Validtemp >= min && Validtemp <= max)
                {
                    sum += Validtemp;
                    ++count;
                    mean = sum / count;
                    Console.Write($"Enter another temperature from {min} to {max} or enter 999 to stop:  ");
                    inputString = Console.ReadLine();
                    Validtemp = Convert.ToDouble(inputString);
                }
                // Invalid Temp
                else
                {
                    Console.Write($"Valid temperatures range from {min} to {max}. Please reenter temperature.");
                    inputString = Console.ReadLine();
                    Validtemp = Convert.ToDouble(inputString);
                }
            }
            // Shows total and mean from user inputs
            total = count;
            Console.WriteLine($"You entered {total:F0} valid temperatures");
            Console.WriteLine($"The mean temperature is {mean:F1} degrees");
        }
    }
}
