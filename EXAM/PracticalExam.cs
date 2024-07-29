using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(string time, int numQustoin) : base(time, numQustoin)
        {
        }

        public override void display()
        {
            Console.WriteLine("this is Practical Exam");
            Console.WriteLine($"time ={time}");
            foreach ( var q in questions )
            {
                if (q != null )
                {
                    Console.WriteLine($"{q.Header} ,the question is {q.Body} ,Mark = {q.Mark}");
                    if (q is MCQ mcq)
                    {
                        for(int i =0; i<mcq.ansArr.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {mcq.ansArr[i].ansText}");
                        }
                        Console.WriteLine($"Correct Answer: {q.ansArr[q.correctAns].ansText}");

                    }
                }
            }
        }
    }
}
