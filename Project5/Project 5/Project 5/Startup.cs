using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_5.Startup))]
namespace Project_5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
