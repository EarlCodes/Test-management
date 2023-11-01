using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Management_Application
{
    public class Question 
    {
        public Question(string question , string[] possibleAnswers , String correctAnswer ,int mark)
        {
            //Setting default values 
            GetQuestion = question;
            this.PossibleAnswers = possibleAnswers;
            CorrectAnswer = correctAnswer;
            Mark = mark;
        }

        public String GetQuestion{ get; set; }

        public String[] PossibleAnswers{ get; set;}

        public String CorrectAnswer{ get; set; }

        public int Mark { get; set; }
    }
}
