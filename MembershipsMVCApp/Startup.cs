using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MembershipsMVCApp.Startup))]
namespace MembershipsMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
