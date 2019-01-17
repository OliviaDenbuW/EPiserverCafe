using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiserverCafe.Models.Pages;
using EPiserverCafe.Models.ViewModels;

namespace EPiserverCafe.Controllers
{
    public class StartPageController : SitePageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            var model = BuildViewModel(currentPage);
            
            return View(model);
        }
    }
}