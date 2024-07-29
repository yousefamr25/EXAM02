using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }

        public void DisplayExam()
        {
            if (Exam != null)
            {

                Console.WriteLine($"Subject: {SubjectName} (ID: {SubjectId})");
                Exam.display();
            }
            else
            {
                Console.WriteLine("No exam created for this subject.");
            }
        }

        public void StartExam()
        {
            Exam.StartExam();
        }

        public void EndExam()
        {
            Exam.EndExam();
        }
        public void ConductExam()
        {
           
            {
                Console.WriteLine("No exam to conduct for this subject.");
            }
        }
    }
}
