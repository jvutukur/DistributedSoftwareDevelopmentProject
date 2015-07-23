using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryItWebPages.Startup))]
namespace TryItWebPages
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
