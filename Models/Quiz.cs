using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionaire.Models
{
    public class Quiz
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public List<Question> Questions { get; set; }

        public List<Respose> Resposes { get; set; }

        public Status Status { get; set; }

        public DateTime CreatedOn { get; set; }

        public Results Results { get; set; }
    }
    public enum Status
    {
        Complete,
        Incomplete
    }
    public enum Results
    {
        Successful,
        UnSuccessful
    }
}
