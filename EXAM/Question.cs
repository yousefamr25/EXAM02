using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Question
    {
       
        public Question(string? header, string? body, int mark, Answer[] ansArr, int correctAns)
        {
            Header = header;
            Body = body;
            Mark = mark;
            this.ansArr = ansArr;
            this.correctAns = correctAns;
        }

        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answer[] ansArr { get; set; }
        public int correctAns { get; set; }
        public bool IsCorrectAnswer(int answerIndex)
        {
            return answerIndex == correctAns;
        }

    }
}
