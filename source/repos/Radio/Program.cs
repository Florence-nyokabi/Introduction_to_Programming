using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable
            string stationNumber;
           

            // Display message
            Console.WriteLine("************************************************");
            Console.WriteLine("             Welcome to Sony          ");
            Console.WriteLine("************************************************");
            Console.WriteLine("Which station would you like to listen to");

            stationNumber = Console.ReadLine();
            
            if (stationNumber == "1")
            {
                Console.WriteLine("Welcome to stationNumber 1");
                stationNumber1();
            }
            else if ( stationNumber =="2")
            {
                Console.WriteLine("Welcome to stationNumber 2");
                StationNumber2();
            }
            else
            {
                Console.WriteLine("Play Amapiano");
            }
            Console.ReadLine();
        }
        
        static void stationNumber1()
        {
            Console.WriteLine("Listen to reggae");
        }

         static void StationNumber2()
         { 
            Console.WriteLine("Listen to soul");
         }
    }
}
