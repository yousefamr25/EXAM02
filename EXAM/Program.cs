namespace EXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("to start the exam 'y' to end 'n'");
            char input = char.Parse(Console.ReadLine());
            if (input == 'y' || input == 'y')
            {
                Console.WriteLine("Please Enter type of Exam (1 for practical | 2 for final):");
                int.TryParse(Console.ReadLine(), out var x);
                if (x == 1)
                {
                    Console.WriteLine("please enter the time for FROM (30 to 180):");
                    int.TryParse(Console.ReadLine(), out x);
                    if (x >= 30 && x <= 180)
                    {
                        Console.WriteLine("please enter number of questions:");
                        int.TryParse(Console.ReadLine(), out var numques);
                        PracticalExam practical = new PracticalExam($"{x} minutes", numques);
                        for (int i = 0; i < numques; i++)
                        {
                            Console.Clear();

                            Console.WriteLine(" ou IN the MCQ question");
                            string header = $"Question {i + 1}";
                            Console.WriteLine("please enter question:");
                            string? body = Console.ReadLine();
                            Console.WriteLine("please enter question Mark:");
                            int QMark;
                            int.TryParse(Console.ReadLine(), out QMark);
                            Console.WriteLine("please enter choices:");
                            Answer[] QAnswers = new Answer[4];
                            string? answerText;
                            for (int j = 0; j < QAnswers.Length; j++)
                            {
                                Console.Write($"please enter choice number {j + 1}: ");
                                answerText = Console.ReadLine();
                                QAnswers[j] = new Answer(j + 1, answerText);
                            }
                            Console.WriteLine("please enter right answer id:");
                            int.TryParse(Console.ReadLine(), out var correctAns);
                            var MCQQuestion = new MCQ(header, body, QMark, QAnswers, correctAns - 1);
                            practical.AddQuestion(MCQQuestion);

                        }
                        var subject = new Subject(1, "Practical Subject");
                        Console.Clear();
                        subject.CreateExam(practical);
                        subject.StartExam();
                        subject.DisplayExam();
                        practical.ConductExam();
                        subject.EndExam();
                    }
                }
                else if (x == 2)
                {
                    Console.WriteLine("please enter the time for exam from 30 to 180:");
                    int.TryParse(Console.ReadLine(), out x);
                    if (x >= 30 && x <= 180)
                    {
                        Console.WriteLine("please enter number of questions:");
                        int.TryParse(Console.ReadLine(), out var numques);
                        FinalExam final = new FinalExam($"{x} minutes", numques);
                        for (int i = 0; i < numques; i++)
                        {
                            Console.WriteLine("please enter type of question (1 for MCQ | 2 for true and false):");
                            int.TryParse(Console.ReadLine(), out x);
                            Console.Clear();

                            if (x == 1)
                            {

                                Console.WriteLine("MCQ question");
                                string header = $"Question {i + 1}";
                                Console.WriteLine("please enter question body:");
                                string? body = Console.ReadLine();
                                Console.WriteLine("please enter question Mark:");
                                int QMark;
                                int.TryParse(Console.ReadLine(), out QMark);
                                Console.WriteLine("please enter choices:");
                                Answer[] QAnswers = new Answer[4];
                                string? answerText;
                                for (int j = 0; j < QAnswers.Length; j++)
                                {
                                    Console.Write($"please enter choice number {j + 1}: ");
                                    answerText = Console.ReadLine();
                                    QAnswers[j] = new Answer(j + 1, answerText);
                                }
                                Console.WriteLine("please enter right answer id:");
                                int.TryParse(Console.ReadLine(), out var correctAns);
                                var MCQQuestion = new MCQ(header, body, QMark, QAnswers, correctAns - 1);
                                final.AddQuestion(MCQQuestion);
                            }
                            else if (x == 2)
                            {
                                Console.WriteLine("True or False question");
                                string header = $"Question {i + 1}";
                                Console.WriteLine("please enter question body:");
                                string? body = Console.ReadLine();
                                Console.WriteLine("please enter question Mark:");
                                int QMark;
                                int.TryParse(Console.ReadLine(), out QMark);
                                Answer[] tfAnswers = new Answer[]
                                {
                                new Answer(1, "True"),
                                new Answer(2, "False")
                                };
                                Console.WriteLine("please enter right answer id (1 for True | 2 for False):");
                                int.TryParse(Console.ReadLine(), out var correctAns);
                                var tfQuestion = new TrueFalse(header, body, QMark, tfAnswers, correctAns - 1);
                                final.AddQuestion(tfQuestion);
                            }
                        }
                        var subject = new Subject(2, "Final Subject");
                        Console.Clear();
                        subject.CreateExam(final);
                        subject.StartExam();
                        subject.DisplayExam();
                        final.ConductExam();
                        subject.EndExam();
                    }
                }
            }
            else
            {
                Console.WriteLine("you choose to end the exam");
            }



        }



    }
}