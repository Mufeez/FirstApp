using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Student student1=new Student("asif",1);
            student1.english_score=80;
            student1.urdu_score=90;
            student1.kannada_score=70;
            student1.social_science_score=90;
            student1.science_score=80;
            student1.mathematics_score=70;
           
            float percentage=student1.Percentage();
           
            Console.WriteLine(percentage);
        
          }
    }
    public class Student
    {
        private
        string  name ;
       private  int roll_number;

       public int english_score{get;set;}
       public  int urdu_score{get;set;}
       public  int kannada_score{get;set;}
       public  int mathematics_score{get;set;}
       public  int social_science_score{get;set;}
       public  int science_score{get;set;}
       private string grade;
        public Student(string name ,int roll_number)
        {
            this.name=name;
            this.roll_number=roll_number;
            
  
        }
 
        public float Percentage ()

            {

                int total_marks = this.mathematics_score+this.kannada_score+this.science_score+this.social_science_score+this.urdu_score+this.english_score;

                float percentage=((float)total_marks/600)*100;
                return percentage;
            }

    }
}



