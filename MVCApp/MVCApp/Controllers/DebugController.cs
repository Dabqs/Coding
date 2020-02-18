using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class DebugController : Controller
    {
        public string Index()
        {
            return "Hello world!";
        }
        
        public string SayBye()
        {
            return "Bye world...";
        }
        public string TestProps(int id, string name) 
        {
            return $"Testing data is {id}, name is {name}.";
        }
        [ActionName("Hello")]
        public ViewResult Hi()
        {
            return View();
        }

    }
}