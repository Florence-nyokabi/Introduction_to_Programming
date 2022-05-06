using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL1_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SCHOOL1Entities db = new SCHOOL1Entities();

            // Table CLASS
            CLASS newClass = db.CLASSes.FirstOrDefault(s => s.CLASS_ID == 2);
            newClass.CLASS_NAME = "new class";
            db.SaveChanges();

            // Table COURSE
            COURSE newCourse = db.COURSEs.FirstOrDefault(s => s.COURSE_ID == 3);
            newCourse.COURSE_NAME = "new course";
            db.SaveChanges();

            // Table PROFESSOR
            PROFESSOR newProfessor = db.PROFESSORs.FirstOrDefault(s => s.PROF_ID == 4);
            newProfessor.PROF_FNAME = "Fname";
            newProfessor.PROF_LNAME = "Lname";
            db.SaveChanges();

            // Table STUDENTS
            STUDENT_ newStudent = db.STUDENT_.FirstOrDefault(s => s.STUD_ID == 1);
            newStudent.STUD_FNAME = "Fname";
            newStudent.STUD_LNAME = "Lname";
            newStudent.STUD_CITY = "city";
            newStudent.STUD_ZIP = "new zip";
            newStudent.STUD_STREET = "street1";
            db.SaveChanges();

            Console.WriteLine("bye");
            Console.ReadLine();

        }
    }
}
