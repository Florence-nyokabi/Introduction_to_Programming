using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To calculate your BMI, multiply your height in inches times your height in inches.
            //Then, divide your weight by that number. Finally, multiply that result by 705.


            // Display:
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("****************************  BMI CALCULATOR  ********************************");
            Console.WriteLine("******************************************************************************");

            // Variables:
            int m;
            int kg;
            double BMI;
            string gender;
            // Input
            Console.WriteLine(" Enter your height: ");           
            m = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine(" Enter your weight in kilograms: ");           
            kg = Convert.ToInt32(Console.ReadLine());


            Console.Write("Gender (m/f):");
            gender = Console.ReadLine();

            BMI = kg / ((m / 100) * (m / 100));

            // Gender: f
            if (BMI < 19 & gender == "f")
            {
                Console.WriteLine("-> Underweight");
            }
            if (BMI >= 19 & BMI <= 24 & gender == "f")
            {
                Console.WriteLine("-> Normal");
            }
            if (BMI > 24 & gender == "f")
            {
                Console.WriteLine("-> Overweight");
            }
            
            // Gender: m
            if (BMI < 20 & gender == "m")
            {
                Console.WriteLine("-> Underweight");
            }
            if (BMI >= 20 & BMI <= 25 & gender == "m")
            {
                Console.WriteLine("-> Normal");
            }
            if (BMI > 25 & gender == "m")
            {
                Console.WriteLine("-> Overweight");
            }
            
            
            Console.ReadLine();


        }
    }
}
