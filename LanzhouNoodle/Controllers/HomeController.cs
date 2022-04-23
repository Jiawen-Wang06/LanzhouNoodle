using LanzhouNoodle.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using LanzhouNoodle.ViewModels;
using System.Linq;

namespace LanzhouNoodle.controllers
{
    //[Route("Home")] //Attribute routing
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;
        private IFeedbackRepo _feedbackRepo;

        public HomeController(INoodleRepository noodlerepo, IFeedbackRepo feedbackRepo)
        {
            _noodleRepository = noodlerepo;
            _feedbackRepo = feedbackRepo;
        }

        public IActionResult Index() {
            //var noodles =  _noodleRepository.GetAllNoodles();
            var viewModel = new HomeViewModel()
            {
                Feedbacks = _feedbackRepo.GetAllFeedbacks().ToList(),
                Noodles = _noodleRepository.GetAllNoodles().ToList()
            };
                
            return View(viewModel);
        }
        
       

        //[Route("AboutUs")]
        public String AboutUs()
        {
            return "About us";
        }

        public IActionResult Detail(int id)
        {
            
            return View(_noodleRepository.GetNoodleById(id));
        }
    }
}
