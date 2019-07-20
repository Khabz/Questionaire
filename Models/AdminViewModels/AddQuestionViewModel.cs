using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Questionaire.Models.AdminViewModels
{
    public class AddQuestionViewModel
    {
        [Required]
        [Display(Name = "Question Name")]
        public string QuestionName { get; set; }

        public bool True { get; set; }

        public bool False { get; set; }
    }
}
