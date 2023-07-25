﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Optimizely.OptimizelyConfig.MVC;

namespace Optimizely.OptimizelyConfig
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomViewLocations(this IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(options => options.ViewLocationExpanders.Add(new SiteViewEngineLocationExpander()));
            return services;
        }

		public static IServiceCollection AddCustomActionFilters(this IServiceCollection services)
		{
			services.Configure<MvcOptions>(options => options.Filters.Add<PageContextActionFilter>());
			return services;
		}
	}
}
