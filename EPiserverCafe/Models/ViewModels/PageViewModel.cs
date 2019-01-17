using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiserverCafe.Models.Pages;

namespace EPiserverCafe.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageBase
    {
        public IList<SitePageBase> TopMenuPages { get; set; }
    }
}