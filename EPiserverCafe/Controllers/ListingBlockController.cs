using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiserverCafe.Models.Blocks;
using EPiserverCafe.Models.ViewModels;

namespace EPiserverCafe.Controllers
{
    public class ListingBlockController : BlockController<ListingBlock>
    {
        private readonly IContentLoader Loader;

        public ListingBlockController(IContentLoader loader)
        {
            Loader = loader;
        }

        public override ActionResult Index(ListingBlock currentBlock)
        {
            var viewModel = new ListingBlockViewModel()
            {
                Heading = currentBlock.Heading
            };

            if (currentBlock.ShowChildrenOfThisPage != null)
            {
                IEnumerable<PageData> children = Loader.GetChildren<PageData>(currentBlock.ShowChildrenOfThisPage);

                // Remove pages:
                // 1. that are not published
                // 2. that the visitor does not have Read access to
                // 3. that do not have a page template
                IEnumerable<IContent> filteredChildren = FilterForVisitor.Filter(children);

                // 4. that do not have "Display in navigation" selected
                viewModel.Pages = filteredChildren.Cast<PageData>().Where(page => page.VisibleInMenu);
            }

            return PartialView(viewModel);
        }
    }
}
