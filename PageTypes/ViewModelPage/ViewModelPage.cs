using System.ComponentModel.DataAnnotations;
using Optimizely.PageTypes._BasePageConfig;

namespace Optimizely.PageTypes.ViewModelPage
{
    [ContentType(
               DisplayName = "ViewModel page",
               GUID = "AC96A854-9085-4792-BF92-530F314BFE0B",
               Description = "ViewModel page.",
               AvailableInEditMode = true)]
    //[ImageUrl("~/styles/images/page_type.png")]
    public class ViewModelPage : SitePageData
	{
        [CultureSpecific]
        [Display(
               Name = "Title",
               Description = "Title for the page",
               GroupName = SystemTabNames.Content,
               Order = 1)]
        public virtual string? Title { get; set; }

        [CultureSpecific]
        [Display(
               Name = "Main body",
               Description = "Main body",
               GroupName = SystemTabNames.Content,
               Order = 2)]
        public virtual XhtmlString? MainBody { get; set; }
    }
}