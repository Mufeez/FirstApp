using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Student student1=new Student("asif",1);
            
           
            float percentage=student1.Percentage(80,80,80);
            student1.grade="A";
            string grade=student1.grade;
            Console.WriteLine(grade);
        
          }
    }
    public class Student
    {
        private
        string  name ;
       private  int roll_number;

       private  int total_marks;
public string grade{get;set;}
        public Student(string name ,int roll_number)
        {
            this.name=name;
            this.roll_number=roll_number;
            this.total_marks=0;

  
        }
 
        public float Percentage (int maths ,int english ,int science)

            {

                 this.total_marks = maths+english+science;

                float percentage=((float)total_marks/300)*100;
                return percentage;
            }

    }
}



