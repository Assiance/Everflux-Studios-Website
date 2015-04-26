using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EverFlux.Web.Startup))]
namespace EverFlux.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
