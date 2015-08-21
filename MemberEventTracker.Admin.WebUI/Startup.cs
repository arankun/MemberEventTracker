using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MemberEventTracker.Admin.WebUI.Startup))]
namespace MemberEventTracker.Admin.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
