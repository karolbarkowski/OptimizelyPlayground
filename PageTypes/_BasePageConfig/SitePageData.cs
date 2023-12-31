﻿using EPiServer.SpecializedProperties;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using static Optimizely.OptimizelyConfig.Globals;

namespace Optimizely.PageTypes._BasePageConfig
{
    /// <summary>
    /// Base class for all page types
    /// </summary>
    public abstract class SitePageData : PageData, ICustomCssInContentArea
    {
        [Display(GroupName = GroupNames.MetaData, Order = 100)]
        [CultureSpecific]
        public virtual string MetaTitle
        {
            get
            {
                var metaTitle = this.GetPropertyValue(p => p.MetaTitle);

                // Use explicitly set meta title, otherwise fall back to page name
                return !string.IsNullOrWhiteSpace(metaTitle)
                       ? metaTitle
                       : PageName;
            }
            set => this.SetPropertyValue(p => p.MetaTitle, value);
        }

        [Display(GroupName = GroupNames.MetaData, Order = 200)]
        [CultureSpecific]
        [BackingType(typeof(PropertyStringList))]
        public virtual IList<string> MetaKeywords { get; set; }

        [Display(GroupName = GroupNames.MetaData, Order = 300)]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string MetaDescription { get; set; }

        [Display(GroupName = GroupNames.MetaData, Order = 400)]
        [CultureSpecific]
        public virtual bool DisableIndexing { get; set; }


        [Display(GroupName = SystemTabNames.Settings, Order = 200)]
        [CultureSpecific]
        public virtual bool HideSiteHeader { get; set; }

        [Display(GroupName = SystemTabNames.Settings, Order = 300)]
        [CultureSpecific]
        public virtual bool HideSiteFooter { get; set; }


        public string ContentAreaCssClass => "teaserblock";
    }
}
