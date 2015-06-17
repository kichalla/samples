using Microsoft.AspNet.Builder;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;
using Microsoft.Framework.Runtime;

namespace SampleWebApp
{
    public class Startup
    {
        public Startup(IApplicationEnvironment env, IRuntimeEnvironment runtimeEnvironment)
        {
            var path = env.ApplicationBasePath;

            var configBuilder = new ConfigurationBuilder(basePath: path)
                                .AddJsonFile("config.json")
                                .AddUserSecrets()
                                .AddEnvironmentVariables();

            Configuration = configBuilder.Build();
        }

        public IConfiguration Configuration { get; private set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<AppSettings>(Configuration.GetConfigurationSection("AppSettings"));

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Verbose);

            app.UseMvc((routes) =>
            {
                routes.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
