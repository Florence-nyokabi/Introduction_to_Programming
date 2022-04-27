using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimensional_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] studentMark = new int[5, 5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter the student mark for subject index " + i);
                studentMark[0, i] = Convert.ToInt32(Console.ReadLine());
            }
            int MarkMarks = 0;
            for (int i = 0; i < 5; i++)
            {
                MarkMarks += studentMark[0, i];
            }
            Console.WriteLine("The total marks are " + MarkMarks);
            Console.ReadLine();


            int JohnMarks = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter the student mark for subject index " + i);
                studentMark[1, i] = Convert.ToInt32(Console.ReadLine());
                JohnMarks += studentMark[1, i];
            }
            Console.WriteLine("The total marks are " + JohnMarks);
            Console.ReadLine();

            int MichaelMarks = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter the student mark for subject index " + i);
                studentMark[2, i] = Convert.ToInt32(Console.ReadLine());
                MichaelMarks += studentMark[2, i];
            }
            Console.WriteLine("The total marks are " + MichaelMarks);
            Console.ReadLine();


            int JaneMarks = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter the student mark for subject index " + i);
                studentMark[3, i] = Convert.ToInt32(Console.ReadLine());
                JaneMarks += studentMark[3, i];
            }
            Console.WriteLine("The total marks are " + JaneMarks);
            Console.ReadLine();


            int JanetMarks = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter the student mark for  subject index " + i);
                studentMark[4, i] = Convert.ToInt32(Console.ReadLine());
                JanetMarks += studentMark[4, i];
            }
            Console.WriteLine("The total marks are " + JanetMarks);
            Console.ReadLine();

            // Find the average mark per suject.
            int[,] SubjectMark = new int[5, 5];
            
            // Maths Average
            int MathsMarks = 0;
            for(int j = 0; j < 5; j++)
            {
                Console.WriteLine("Please enter the subject marks for student index " + j);
                SubjectMark[0, j] = Convert.ToInt32(Console.ReadLine());
                MathsMarks += SubjectMark[0, j];
            }
            Console.WriteLine("The average mark is " + MathsMarks / 5);
            Console.ReadLine();

            // Biology average
            int BiologyMarks = 0;
            for(int j = 0; j < 5; j++)
            {
                Console.WriteLine("Please enter the subject marks for student index " + j);
                SubjectMark[1, j] = Convert.ToInt32(Console.ReadLine());
                BiologyMarks += SubjectMark[1, j];
            }
            Console.WriteLine("The average mark is " + BiologyMarks / 5);
            Console.ReadLine();

            // Chemistry average
            int ChemistryMarks = 0;
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Please enter the subject marks for student index " + j);
                SubjectMark[2, j] = Convert.ToInt32(Console.ReadLine());
                ChemistryMarks += SubjectMark[2, j];
            }
            Console.WriteLine("The average mark is " + ChemistryMarks / 5);
            Console.ReadLine();

            // Physics average
            int PhysicsMarks = 0;
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Please enter the subject marks for  student index " + j);
                SubjectMark[3, j] = Convert.ToInt32(Console.ReadLine());
                PhysicsMarks += SubjectMark[3, j];
            }
            Console.WriteLine("The average mark is " + PhysicsMarks / 5);
            Console.ReadLine();

            // English average
            int EnglishMarks = 0; 
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Please enter the subject marks for student index " + j);
                SubjectMark[4, j] = Convert.ToInt32(Console.ReadLine());
                EnglishMarks += SubjectMark[4, j];
            }
            Console.WriteLine("The average mark is " + EnglishMarks / 5);
            Console.ReadLine();

        } 
    }
}
