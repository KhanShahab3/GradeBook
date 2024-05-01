using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeBookTest
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("\"please Enter the Course Name\"");
            
            GradeBook myGradeBook =new GradeBook();
            //Console.WriteLine("intial courese name is '{0}'/n", myGradeBook.CourseName = "english");
           
            //Console.WriteLine("Enter the Course Name ");
          
        //myGradeBook.CourseName= Console.ReadLine();
            myGradeBook.DiplayMessage();
            myGradeBook.ClassAvergae(); 
        }
    }
}
