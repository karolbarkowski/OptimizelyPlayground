using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Optimizely.PageTypes._BasePageConfig;

namespace Optimizely.PageTypes.StandardPage
{
    public class StandardPageController : PageController<StandardPage>
    {
        [HttpGet]
        public IActionResult Index(StandardPage currentPage)
        {
            return View(PageViewModel.Create(currentPage));
        }
    }
}