using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoWebAPI.Startup))]
namespace DemoWebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
