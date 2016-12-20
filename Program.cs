using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Student student1=new Student("asif",1,500);
            
            string student_name= student1.name;

            Console.WriteLine(student_name);
        }
    }

    public class Student
    {
        public
        string  name ;
        int roll_number;

        int total_marks;

        public Student(string name ,int roll_number,int total_marks)
        {
            this.name=name;
            this.roll_number=roll_number;
            this.total_marks=total_marks;

        }
 

    }
}
