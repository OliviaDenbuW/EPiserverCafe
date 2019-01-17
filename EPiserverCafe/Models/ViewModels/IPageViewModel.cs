using EPiserverCafe.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiserverCafe.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageBase
    {
        StartPage StartPage { get; }

        IList<SitePageBase> TopMenuPages { get; }
    }
}
