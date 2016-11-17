using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectW.Startup))]
namespace ProjectW
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
