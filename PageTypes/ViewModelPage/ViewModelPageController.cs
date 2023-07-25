using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Optimizely.PageTypes.ViewModelPage
{
	public class ViewModelPageController : PageController<ViewModelPage>
	{
		[HttpGet]
		public IActionResult Index(ViewModelPage currentPage)
		{
			var model = new ViewModelPageModel(currentPage);
			return View(model);
		}
	}
}
