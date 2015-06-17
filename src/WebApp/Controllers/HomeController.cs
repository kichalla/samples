using System;
using Microsoft.AspNet.Mvc;

namespace SampleWebApp
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("From Home.Index");
        }
    }
}