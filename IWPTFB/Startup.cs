using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IWPTFB.Startup))]
namespace IWPTFB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
