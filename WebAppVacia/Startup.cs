using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppVacia.Startup))]
namespace WebAppVacia
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
