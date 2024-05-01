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
        Console.WriteLine("Enter the Grade or Enter -1 for exit");
        grade = Convert.ToInt32(Console.ReadLine());
        while (grade!=-1) {
            total=total+grade;
            gradeCounter++;
            Console.WriteLine("Enter the Grade or -1 for exit");
            grade = Convert.ToInt32(Console.ReadLine());
        }
        if(grade != 0)
        {
            classAverage = total / gradeCounter;
            Console.WriteLine("Total is: " + total);
            Console.WriteLine("Class Avearge is :" + classAverage);
        }
        else
        {
            Console.WriteLine("No grade are Enter");
        }
        

    }
}