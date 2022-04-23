using Microsoft.AspNetCore.Mvc;
using LanzhouNoodle.Models;
using Microsoft.AspNetCore.Authorization;

namespace LanzhouNoodle.Controllers
{
    [Authorize]
    public class FeedbackController : Controller
    {
        private IFeedbackRepo _feedbackRepo;
        public FeedbackController(IFeedbackRepo feedbackRepo)
        {
            _feedbackRepo = feedbackRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _feedbackRepo.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");
            }
            return View();
            
        }
        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}
