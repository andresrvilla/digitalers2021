using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeguridadAplicacionWeb.Startup))]
namespace SeguridadAplicacionWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
