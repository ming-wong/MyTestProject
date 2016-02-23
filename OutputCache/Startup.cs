using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OutputCache.Startup))]
namespace OutputCache
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
