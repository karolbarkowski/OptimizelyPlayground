using Microsoft.AspNetCore.Mvc.Razor;

namespace Optimizely.OptimizelyConfig.MVC
{
    public class SiteViewEngineLocationExpander : IViewLocationExpander
    {
        public const string PageTypesFolder = "/PageTypes/";
        public const string BlockFolder = "/Blocks/";
        public const string PagePartialsFolder = "/PagePartials/";

        private static readonly string[] AdditionalPartialViewFormats = new[]
        {
            PageTypesFolder + "{1}/{1}{0}.cshtml",
            BlockFolder + "{1}.cshtml",
            PagePartialsFolder + "{1}.cshtml",
            PageTypesFolder + "_Layouts/Partials/{0}.cshtml",
        };

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            foreach (var location in viewLocations)
            {
                yield return location;
            }

            for (var i = 0; i < AdditionalPartialViewFormats.Length; i++)
            {
                yield return AdditionalPartialViewFormats[i];
            }
        }

        public void PopulateValues(ViewLocationExpanderContext context) { }
    }
}
