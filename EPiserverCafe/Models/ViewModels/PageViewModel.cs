using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiserverCafe.Models.Pages;

namespace EPiserverCafe.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageBase
    {
        public PageViewModel(StartPage startPage)
        {
            StartPage = startPage;
        }

        public StartPage StartPage { get; set; }

        public IList<SitePageBase> TopMenuPages { get; set; }
    }
}