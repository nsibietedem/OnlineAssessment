using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    public class Student:Human,IAskQuestion,IAnswerQuestion
    {
        public Programm Program { get; set; }
        //public enum DayOfTheWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //}
        public Student()
        {

        }
        public Student(string name,Programm Program)
        {
            base.Name= name;
            this.Program= Program;
            
        }
        public  void AskQuestion()
        {
            

        }
        public  void AnswerQuestion()
        {

        }
        public  override void AttendClasses(int dayoftheweek)

        {
            if (Program is BackEnd)
            {

                switch (dayoftheweek)
                {
                    case (int)DayOfTheWeek.Monday :
                        Console.WriteLine("The host would Let you in");
                        Thread.Sleep(5000);
                        Console.WriteLine("Your in");
                        break;

                    case (int)DayOfTheWeek.Tuesday:
                        Console.WriteLine("The host would Let you in");
                        Thread.Sleep(5000);
                        Console.WriteLine("Your in");
                        break;
                    case (int)DayOfTheWeek.Wednesday:
                        Console.WriteLine("No classes today");
                        break;
                    case (int)DayOfTheWeek.Thursday:
                        Console.WriteLine("The host would Let you in");
                        Thread.Sleep(5000);
                        Console.WriteLine("Your in");
                        break;
                    case (int)DayOfTheWeek.Friday:
                        Console.WriteLine("No classes today");
                        break;
                    default:
                        Console.WriteLine("Invalid Day of the week");
                        break;
                }

                
            }
            else if (Program is FrontEnd)
            {
                switch (dayoftheweek)
                {
                    case (int)DayOfTheWeek.Monday:
                        Console.WriteLine("No classes today");
                        break;
                    case (int)DayOfTheWeek.Tuesday:
                        Console.WriteLine("The host would Let you in");
                        Thread.Sleep(5000);
                        Console.WriteLine("Your in");
                        break;
                    case (int)DayOfTheWeek.Wednesday:
                        Console.WriteLine("The host would Let you in");
                        Thread.Sleep(5000);
                        Console.WriteLine("Your in");
                        break;
                    case (int) DayOfTheWeek.Thursday:
                        Console.WriteLine("The host would Let you in");
                        Thread.Sleep(5000);
                        Console.WriteLine("Your in");
                        break;
                    case (int)DayOfTheWeek.Friday:
                        Console.WriteLine("No class today");
                        break;
                    default:
                        Console.WriteLine("Invalid day of the week");
                        break;
                }

                
            }
            

        }
    }
}
