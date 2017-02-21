using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TagHelpersDemo.Models;

namespace TagHelpersDemo.Controllers
{
    public class TagHelperController : Controller
    {
        private WebSiteInfoViewModel webSiteInfoModel = new WebSiteInfoViewModel()
        {
            DefaultUrl = "http://www.dotnetcode.it",
            Description = "DotNetCode Community WebSite",
            Email = "info@dotnetcode.it",
            IsPrivate = false,
            LanguageId = "it-IT",
            LatestUpdate = DateTime.Now,
            WebSiteId = 1
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Select()
        {
            return View();
        }

        public IActionResult TextArea()
        {
            return View();
        }
        public IActionResult Label()
        {
            return View();
        }
        public IActionResult Input()
        {

            return View(webSiteInfoModel);
        }

        public IActionResult Cache()
        {

            return View(webSiteInfoModel);
        }

        public IActionResult Image()
        {

            return View(webSiteInfoModel);
        }
    }
}
