using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspwithjenkins.Startup))]
namespace aspwithjenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
