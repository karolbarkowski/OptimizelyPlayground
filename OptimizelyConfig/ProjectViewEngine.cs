using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace Optimizely.OptimizelyConfig
{
    public class ProjectViewEngine : RazorViewEngine
    {
        public ProjectViewEngine(IRazorPageFactoryProvider pageFactory, IRazorPageActivator pageActivator, HtmlEncoder htmlEncoder, IOptions<RazorViewEngineOptions> optionsAccessor, ILoggerFactory loggerFactory, DiagnosticListener diagnosticListener) : base(pageFactory, pageActivator, htmlEncoder, optionsAccessor, loggerFactory, diagnosticListener)
        {
        }
    }
}
