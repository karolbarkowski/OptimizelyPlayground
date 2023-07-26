using System.ComponentModel.DataAnnotations;
using Optimizely.PageTypes._BasePageConfig;

namespace Optimizely.PageTypes.StandardPage
{
    [ContentType(
               DisplayName = "Standard page",
               GUID = "934E7266-FB8C-4DEA-B033-3B4E6AE6CBCF",
               Description = "The standard page.",
               AvailableInEditMode = true)]
    //[ImageUrl("~/styles/images/page_type.png")]
    public class StandardPage : SitePageData
	{
        [CultureSpecific]
        [Display(
               Name = "Title",
               Description = "Title for the page",
               GroupName = SystemTabNames.Content,
               Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
               Name = "Main body",
               Description = "Main body",
               GroupName = SystemTabNames.Content,
               Order = 2)]
        public virtual XhtmlString? MainBody { get; set; }
    }
}