using EPiServer.Data;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Optimizely.PageTypes;

namespace Optimizely.OptimizelyConfig.MVC
{
	[ServiceConfiguration]
	public class PageViewContextFactory
	{
		private readonly IContentLoader _contentLoader;
		private readonly UrlResolver _urlResolver;
		private readonly IDatabaseMode _databaseMode;
		private readonly CookieAuthenticationOptions _cookieAuthenticationOptions;

		public PageViewContextFactory(
			IContentLoader contentLoader,
			UrlResolver urlResolver,
			IDatabaseMode databaseMode,
			IOptionsMonitor<CookieAuthenticationOptions> optionMonitor)
		{
			_contentLoader = contentLoader;
			_urlResolver = urlResolver;
			_databaseMode = databaseMode;
			_cookieAuthenticationOptions = optionMonitor.Get(IdentityConstants.ApplicationScheme);
		}

		public virtual LayoutModel CreateLayoutModel(ContentReference currentContentLink, HttpContext httpContext)
		{
			var startPageContentLink = SiteDefinition.Current.StartPage;

			// Use the content link with version information when editing the startpage,
			// otherwise the published version will be used when rendering the props below.
			if (currentContentLink.CompareToIgnoreWorkID(startPageContentLink))
			{
				startPageContentLink = currentContentLink;
			}

			//var startPage = _contentLoader.Get<StartPage>(startPageContentLink);

			return new LayoutModel
			{
				//Logotype = startPage.SiteLogotype,
				//LogotypeLinkUrl = new HtmlString(_urlResolver.GetUrl(SiteDefinition.Current.StartPage)),
				//ProductPages = startPage.ProductPageLinks,
				//CompanyInformationPages = startPage.CompanyInformationPageLinks,
				//NewsPages = startPage.NewsPageLinks,
				//CustomerZonePages = startPage.CustomerZonePageLinks,
			//	LoggedIn = httpContext.User.Identity.IsAuthenticated,
		//		LoginUrl = new HtmlString(GetLoginUrl(currentContentLink)),
			//	SearchActionUrl = new HtmlString(UrlResolver.Current.GetUrl(startPage.SearchPageLink)),
				IsInReadonlyMode = _databaseMode.DatabaseMode == DatabaseMode.ReadOnly
			};
		}
	}
}
