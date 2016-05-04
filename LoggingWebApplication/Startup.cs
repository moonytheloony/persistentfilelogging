using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoggingWebApplication.Startup))]
namespace LoggingWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
