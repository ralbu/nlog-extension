using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NLogExtension.Startup))]
namespace NLogExtension
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
