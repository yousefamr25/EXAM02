using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Answer
    {
        public Answer(int ansId, string? ansText)
        {
            this.ansId = ansId;
            this.ansText = ansText;
        }

        public int ansId { get; set; }
        public string? ansText {  get; set; }

    }
}
