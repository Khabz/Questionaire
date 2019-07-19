using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionaire.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string QuestionName { get; set; }

        public int ResponseId { get; set; }
    }
}
