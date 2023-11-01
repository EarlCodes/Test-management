using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Management_Application
{
   public class Test 
    {
        private string testName;
        List<Question> questionList = new List<Question>();
        
        public Test()
        {
            
        }

        public String TestName {
            get
             {
                return testName;
             }
            set
             {
                testName = value;
             }
        }

        public void AddQuestion(Question q)
        {
            questionList.Add(q);
        }
         
        public void RemoveQuestion(int index)
        {
            questionList.RemoveAt(index + 1);
        }

        public int GetListSize()
        {
            int num = questionList.Count;
            return num;
            
        }

        public List<Question> getQuestions()
        {
            return questionList;
        }
    }
}
