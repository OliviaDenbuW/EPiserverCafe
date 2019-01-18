using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiserverCafe.Business;

namespace EPiserverCafe.Models.Pages
{
    [ContentType(DisplayName = "Start Page",
                 GUID = "0dafc953-c4d0-4a67-b057-fd949aba1899", Description = "")]
    public class StartPage : SitePageBase
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */

        #region SiteSettings

        [Display(GroupName = GroupNames.SiteSettings, Order = 100)]
        public virtual string SiteBrand { get; set; }

        [Display(GroupName = GroupNames.SiteSettings, Order = 1400)]
        public virtual string SiteFooter { get; set; }

        #endregion
    }
}