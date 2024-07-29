using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
     abstract class Exam
    {
        public string time;
        public int numQustoin;
        public int CountQuestion;
        public Question[] questions;
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }

        public Exam(string time, int numQustoin)
        {
            this.time = time;
            this.numQustoin = numQustoin;
            CountQuestion = 0;
            questions = new Question[numQustoin];
        }

        public void AddQuestion(Question question)
        {
            if (CountQuestion < questions.Length)
            {
                questions[CountQuestion++] = question;
            }
            else
                Console.WriteLine("quuestion is full");
        }
        public void StartExam()
        {
            StartTime = DateTime.Now;
            Console.WriteLine($"Exam started at: {StartTime}");
        }

        public void EndExam()
        {
            EndTime = DateTime.Now;
            Console.WriteLine($"Exam ended at: {EndTime}");
            DisplayTimeTaken();
        }

        private void DisplayTimeTaken()
        {
            TimeSpan timeTaken = EndTime - StartTime;
            Console.WriteLine($"Time to the exam: {timeTaken.TotalMinutes}");
        }
        public abstract void display();
        public int ConductExam()
        {
            Console.WriteLine("start exam (y OR n)");
            string? x = Console.ReadLine();
            if (x=="y")
            {
                Console.Clear();

                int totalScore = 0;
                foreach (var q in questions)
                {
                    if (q != null)
                    {
                        Console.WriteLine($"{q.Header}: {q.Body}");
                        if (q is TrueFalse)
                        {
                            Console.WriteLine("1. True");
                            Console.WriteLine("2. False");
                        }
                        else if (q is MCQ mCQ)
                        {
                            for (int i = 0; i < mCQ.ansArr.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {mCQ.ansArr[i].ansText}");
                            }
                        }

                        Console.WriteLine("Enter your answer (number): ");
                        int.TryParse(Console.ReadLine(), out int answer);
                        if (q.IsCorrectAnswer(answer - 1))
                        {
                            Console.WriteLine("Correct!");
                            totalScore += q.Mark;
                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                        }
                        Console.Clear();

                    }
                }
                Console.WriteLine($"Total Score: {totalScore}");
                return totalScore;
            }
            else
            { return 0; }
            
        }
    }

}

