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
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            var model = BuildViewModel(currentPage);
            

            return View(model);
        }
    }
}