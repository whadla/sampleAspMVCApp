using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sampleAspMVC.Startup))]
namespace sampleAspMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
