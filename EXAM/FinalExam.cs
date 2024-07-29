using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class FinalExam : Exam
    {
        public FinalExam(string time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void display()
        {
            Console.WriteLine("Final Exam:");
            Console.WriteLine($"Time: {time}");
            int totalGrade = 0;
            int correctAnswer = -1;
            foreach (var q in questions)
            {
                if (q != null)
                {
                    Console.WriteLine($"{q.Header} , the question is {q.Body} ,Mark= {q.Mark}");
                    if (q is TrueFalse)
                    {
                        Console.WriteLine("True or False");
                    }
                    else if (q is MCQ mCQ)
                    {
                        for (int i = 0; i < mCQ.ansArr.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {mCQ.ansArr[i].ansText}");
                        }
                    }
                    correctAnswer = q.correctAns;
                    totalGrade += q.Mark;
                }
            }
            if (correctAnswer != -1)
            {
                Console.WriteLine($"Correct answer index is: {correctAnswer + 1}");
            }
            Console.WriteLine($"Total Grade: {totalGrade}");
        }
    }
}
