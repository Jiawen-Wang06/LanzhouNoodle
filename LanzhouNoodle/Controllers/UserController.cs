using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LanzhouNoodle.controllers
{
    [Route("admin/[controller]/[action]")]
    public class UserController : Controller
    {
        public IList<String> Index()
        {
            return new List<string> { "Lala", "Kiki"};
        }
    }
}
