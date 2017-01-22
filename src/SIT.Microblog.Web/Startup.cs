using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;

namespace SIT.Microblog.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
			services
				.AddMvc()
				.AddJsonOptions(config =>
				{
					config.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
				});
		}

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
			loggerFactory
				.AddConsole()
				.AddDebug();

	        app
		        .UseStaticFiles()
		        .UseStatusCodePages()
		        .UseMvc(MapRoutes);
 

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
		}

	    private static void MapRoutes(IRouteBuilder routes)
	    {
		    routes.MapRoute("api", "api/{controller}/{action}");
	    }
    }
}