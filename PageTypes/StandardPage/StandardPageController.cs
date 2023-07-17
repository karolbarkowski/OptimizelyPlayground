using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Optimizely.PageTypes.StandardPage
{
    public class StandardPageController : PageController<StandardPage>
    {
        [HttpGet]
        public IActionResult Index(StandardPage currentPage)
        {
            return View(currentPage);
        }
    }
}