using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;

namespace Optimizely.Helpers.HtmlHelpers
{
    /// <summary>
    /// PartialView-related extensions for <see cref="IHtmlHelper"/>.
    /// </summary>
    public static class HtmlHelperPartialExtensions
    {
        /// <summary>
        /// Renders HTML markup for the specified partial view.
        /// </summary>
        /// <param name="htmlHelper">The <see cref="IHtmlHelper"/> instance this method extends.</param>
        /// <param name="partialViewName">
        /// The name or path of the partial view used to create the HTML markup. Must not be <c>null</c>.
        /// </param>
        /// <param name="model">A model to pass into the partial view.</param>
        /// <returns>A <see cref="Task"/> that renders the created HTML when it executes.</returns>
        /// <remarks>
        /// In this context, "renders" means the method writes its output using <see cref="ViewContext.Writer"/>.
        /// </remarks>
        public static Task ConditionalRenderPartialAsync(
            this IHtmlHelper htmlHelper,
            string partialViewName,
            bool condition,
            object model)
        {
            if (htmlHelper == null)
            {
                throw new ArgumentNullException(nameof(htmlHelper));
            }

            if (partialViewName == null)
            {
                throw new ArgumentNullException(nameof(partialViewName));
            }

            if (!condition)
            {
                return Task.CompletedTask;
            }

            return htmlHelper.RenderPartialAsync(partialViewName, model, viewData: null);
        }

        public static IHtmlContent RenderMetaTags(this IHtmlHelper helper, string description, IList<string> keywords)
        {
            var sbMeta = new StringBuilder();
            sbMeta.AppendLine("<meta charset='utf-8'>");
            sbMeta.AppendLine("<meta http-equiv='X-UA-Compatible' content='IE=edge'>");
            sbMeta.AppendLine("<meta name='viewport' content='width=device-width, initial-scale=1'>");

            if (!string.IsNullOrWhiteSpace(description)) 
                sbMeta.AppendLine($"<meta name='description' content='{description}'>");

            if (keywords != null && keywords.Any())
                sbMeta.AppendLine($"<meta name='keywords' content='{string.Join(", ", keywords)}'>");

            return helper.Raw(sbMeta.ToString());
        }
    }
}
