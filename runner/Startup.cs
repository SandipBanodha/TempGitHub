using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(runner.Startup))]
namespace runner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
