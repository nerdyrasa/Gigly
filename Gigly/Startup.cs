using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gigly.Startup))]
namespace Gigly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
