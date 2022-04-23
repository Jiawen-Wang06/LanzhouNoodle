using System;
using System.Collections.Generic;
using LanzhouNoodle.Models;

namespace LanzhouNoodle.ViewModels
{
    public class HomeViewModel
    {

        public IList<Noodle> Noodles { get; set; }
        public IList<Feedback> Feedbacks { get; set; }
    }
}
