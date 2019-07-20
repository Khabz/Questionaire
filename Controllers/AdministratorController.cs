using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Questionaire.Data;
using Questionaire.Models;
using Questionaire.Models.AdminViewModels;

namespace Questionaire.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdministratorController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Questions()
        {
            var questions = _context.Questions.ToList();
            return View(questions);
        }

        [HttpGet]
        public IActionResult AddQuestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddQuestion(AddQuestionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var question = new Question
                {
                    QuestionName = model.QuestionName,
                    True = model.True,
                    False = model.False
                };
                _context.Add(question);
                _context.SaveChanges();

                return RedirectToAction("Questions", "Administrator");
            }
            return View(model);
        }
    }
}