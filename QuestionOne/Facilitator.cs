using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    public class Facilitator : Human, IAnswerQuestion, IAskQuestion
    {
        public Programm Program { get; set; }
        public enum DayOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
        }
        
        public Facilitator()
        {

        }
        public Facilitator(string name, Programm Program)
        {
            base.Name = name;
            this.Program = Program;

        }
        public void AnswerQuestion()
        {


        }
  
        
        public void AskQuestion()
        {
             throw new NotImplementedException();
        }
        public  override void AttendClasses(int dayoftheweek)

        {
            if (Program is BackEnd)
            {

                switch (dayoftheweek)
                {
                    case (int)DayOfTheWeek.Monday:
                        Console.WriteLine("The host would Let you in");
                        break;

                    case (int)DayOfTheWeek.Tuesday:
                        Console.WriteLine("The host would Let you in");
                        break;
                    case (int)DayOfTheWeek.Wednesday:
                        Console.WriteLine("The host would Let you in");
                        break;
                    case (int)DayOfTheWeek.Thursday:
                        Console.WriteLine("The host would Let you in");
                        break;
                    case (int)DayOfTheWeek.Friday:
                        Console.WriteLine("The host would Let you in");
                        break;
                    default:
                        Console.WriteLine("The host would Let you in");
                        break;
                }


            }
            else if (Program is FrontEnd)
            {
                switch (dayoftheweek)
                {
                    case (int)DayOfTheWeek.Monday:
                        Console.WriteLine("The host would Let you in");
                        break;
                    case (int)DayOfTheWeek.Tuesday:
                        Console.WriteLine("The host would Let you in");
                        break;
                    case (int)DayOfTheWeek.Wednesday:
                        Console.WriteLine("The host would Let you in");
                        break;
                    case (int)DayOfTheWeek.Thursday:
                        Console.WriteLine("The host would Let you in");
                        break;
                    case (int)DayOfTheWeek.Friday:
                        Console.WriteLine("The host would Let you in");
                        break;
                    default:
                        Console.WriteLine("The host would Let you in");
                        break;
                }


            }

        }


    }
}