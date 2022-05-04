using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plot_cost_1
{
    internal class Program
    {
        static void Main(string[] args)
        {   // STEP 1. Determine plot cost
            double userPlotLength, userPlotWidth, CalculatedPlotCost;
            Console.WriteLine("Please enter plot length in meters");
            userPlotLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter plot width in meters");
            userPlotWidth = Convert.ToDouble(Console.ReadLine());

            CalculatePlotCost(userPlotLength, userPlotWidth, out CalculatedPlotCost);
            Console.WriteLine("The plot cost is " + CalculatedPlotCost.ToString());

        }

        static void CalculatePlotCost(double PlotLength, double PlotWidth, out double PlotCost)
        {
            PlotCost = 0;
            double PlotSize = PlotLength * PlotWidth;
            if (PlotSize < 500)
            {
                PlotCost = PlotSize * 600;
            }
            else if (PlotSize >= 500 && PlotSize <= 1000)
            {
                PlotCost = PlotSize * 700;
            }
            else if (PlotSize > 1000)
            {
                PlotCost = PlotSize * 1000;
            }

            // STEP 2. Determine house building cost
           
            int houseCategory;
            double housesize, houseCost;

            Console.WriteLine("Please enter house size in square meters");
            housesize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter house category");
            houseCategory = Convert.ToInt32(Console.ReadLine());

            double[] houseCategoryArray = { 0.7, 0.9, 1.0, 1.2, 1.4 };
            houseCost = housesize * 1000 * houseCategoryArray[houseCategory - 1];
            Console.WriteLine("The house cost is" + houseCost.ToString());
            Console.ReadLine();

            // STEP 3. Get the top four special building requirements
            string[] buildingRequirements = new string[4];
            int requirementCounter = 1;
            for (int i = 0; i < buildingRequirements.Length; i++) 
            {
                Console.WriteLine("Please enter requirement " + requirementCounter.ToString() + " of 4");
                buildingRequirements[i] = Console.ReadLine();
                requirementCounter++;
            }
            Console.ReadLine();

            // STEP 4. Get garden requirements
            string[] gardenRequirements = new string[100];
            for (int i = 0; i < gardenRequirements.Length; i++)
            {
                gardenRequirements[i] = "";
            }

            for (int i = 0; i < gardenRequirements.Length; i++)
            {
                Console.WriteLine("Please enter garden requirements or 'stop' to end ");
                string userInput;
                userInput = Console.ReadLine();
                if (userInput== "stop")
                {
                    i = gardenRequirements.Length;
                    Console.WriteLine("We have received all the requirements");
                }
                else
                {
                    gardenRequirements[i] = Console.ReadLine();
                }
            }

            // STEP 5. Display Summary
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("----------------------------Summary report---------------------------");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("The plot cost is 350000");
            Console.WriteLine("The house size is 1000, the building factor is 1 and the cost is 1000000");
            Console.WriteLine("Special requirements are:" +

                "Pool" +

                "Extra room" +

                "Extra Garage" +

                "Garden room");
            Console.WriteLine("Garden requirements are:" +

                "Low water use" +

                "Indigenous tree");

            Console.ReadLine();
        }
      
  
    }
}
