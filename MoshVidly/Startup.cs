using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoshVidly.Startup))]
namespace MoshVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
