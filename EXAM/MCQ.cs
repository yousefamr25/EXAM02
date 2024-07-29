using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class MCQ : Question
    {
        public MCQ(string? header, string? body, int mark, Answer[] ansArr, int correctAns) : base(header, body, mark, ansArr, correctAns)
        {
        }
    }
}
