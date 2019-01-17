using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiserverCafe.Models.Pages;
using EPiserverCafe.Models.ViewModels;

namespace EPiserverCafe.Controllers
{
    public class SitePageController<T>: PageController<T> where T : SitePageBase
    {
        protected PageViewModel<T> BuildViewModel(T currentPage)
        {
            var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = loader.Get<StartPage>(ContentReference.StartPage);

            var pages = new List<SitePageBase>();
            pages.Add(startPage);
            pages.AddRange(loader.GetChildren<SitePageBase>(ContentReference.StartPage));

            var model = new PageViewModel<T>(startPage)
            {
                TopMenuPages = pages
            };


            return model;
        }
    }
}