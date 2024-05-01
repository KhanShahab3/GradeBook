using System;
using System.Xml.Linq;
namespace GradeBook;
public class GradeBook
{
    private string courseName;
    public string CourseName
    {
        get
        {
            return courseName;
        }
        set
        {
            courseName = value;
        }
    }

   
    public void DiplayMessage()
    {
        Console.WriteLine("Wellcome To Grade  Book..........");
        //Declaration of class contian the 
        //a method name DisplayMessage the recall of this we
        //need the object of class and call its method 
    }
    public void ClassAvergae()
    {
        int total=0;
        int grade;
        int gradeCounter=1;
        double classAverage;
        while (gradeCounter<=10) {
            Console.WriteLine("Enter the Grade");
            grade = Convert.ToInt32(  Console.ReadLine());
            total=total+grade;
            gradeCounter++;
        }
        classAverage = total / 10;
        Console.WriteLine("total is " + total);
        Console.WriteLine("class Average is " + classAverage);

    }
}