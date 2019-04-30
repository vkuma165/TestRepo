using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleDotnetApp.Startup))]
namespace SampleDotnetApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
