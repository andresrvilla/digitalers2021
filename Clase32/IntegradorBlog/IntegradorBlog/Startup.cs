using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntegradorBlog.Startup))]
namespace IntegradorBlog
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
