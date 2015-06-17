using System;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.OptionsModel;

namespace SampleWebApp
{
    public class HomeController : Controller
    {
        private readonly AppSettings _appSettings;

        public HomeController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Options;
        }

        public IActionResult Index()
        {
            return Content("From Home.Index: " + _appSettings.Name);
        }
    }
}