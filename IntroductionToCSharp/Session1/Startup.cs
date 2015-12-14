using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Session1.Startup))]
namespace Session1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
