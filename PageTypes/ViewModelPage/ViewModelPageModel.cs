using Optimizely.PageTypes._BasePageConfig;

namespace Optimizely.PageTypes.ViewModelPage
{
    public class ViewModelPageModel : PageViewModel<ViewModelPage>
	{
		public string ViewModelString { get; set; } = "VIEW-MODEL-STRING";

        public ViewModelPageModel(ViewModelPage currentPage) : base(currentPage)
		{
		}
	}
}
