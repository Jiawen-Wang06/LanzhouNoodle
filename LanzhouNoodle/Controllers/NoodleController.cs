using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LanzhouNoodle.controllers
{
    public class NoodleController : Controller
    {
        public IList<string> Index()
        {
            return new List<String> { "Beef noodle", "Pork noodle", "Egg noodle" };
        }
    }
}
