using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneSignalPOC.Startup))]
namespace OneSignalPOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
